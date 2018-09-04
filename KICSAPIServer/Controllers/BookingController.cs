using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using KICSAPIServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KICSAPIServer.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public BookingController(KICSDEVContext context)
        {
            _context = context;
        }

        [HttpPost("AddTicketProductToCart")]
        // [Authorize]
        public async Task<IActionResult> AddTicketProductToCart([FromBody]AddTicketProductToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncart
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixTransactionCartId > 1
                        select p;

            var transactioncart = await query.FirstOrDefaultAsync();
            if (transactioncart != null)
            {

                //check if item exists for an incremetation of 1
                var q2 = from p in _context.Ktixtransactioncartitems
                         where p.KtixPriceGroupSaleItemId == dto.KTixPriceGroupSaleItemId
                         && p.KtixTransactionCartId == transactioncart.KtixTransactionCartId
                         select p;

                var q2Result = await q2.FirstOrDefaultAsync();

                if (q2Result != null)
                {
                    q2Result.Quantity += 1;
                    _context.Update(q2Result);

                }
                //else add a new entry
                else
                {
                    Ktixtransactioncartitems newdto = new Ktixtransactioncartitems()
                    {
                        KtixTransactionCartId = dto.KTixTransactionCartId,
                        KtixPriceGroupSaleItemId = dto.KTixPriceGroupSaleItemId,
                        Quantity = 1,
                        KTixPriceGroupId = dto.KTixPriceGroupId,
                        SessionId = dto.SessionId
                    };

                    //have a cart already so add item
                    _context.Add(newdto);
                }
                _context.SaveChanges();

                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = dto.KTixTransactionCartId,
                    Status = true,
                    Message = "Ticket/Product added successfully to existing cart.",
                    CartCreateDateTime = transactioncart.CreateDateTime.ToString(),
                    CartExpiryDateTime = transactioncart.ExpiryDateTime.ToString()
                };

                return Ok(thisCart);

            }
            else
            {


                //add will be run this code block
                //dont have a cart so need to initialize mastertransaction record and create a cart
                Ktixtransactioncart newCart = new Ktixtransactioncart()
                {
                    CreateDateTime = DateTime.Now,
                    ExpiryDateTime = DateTime.Now.AddMinutes(10)

                };
                _context.Add(newCart);

                //initialize a booking
                Ktixmastertransaction newmastertransaction = new Ktixmastertransaction()
                {
                    KtixMasterTransactionId = Guid.NewGuid(),
                    IsPosSale = true,
                    KtixPosTerminalId = dto.KTixPosTerminalId,
                    CmsuserId = dto.CMSUserId,
                    IsCommited = false,
                    IsError = false,
                    IsRefunded = false,
                    KtixTransactionCartId = newCart.KtixTransactionCartId
                };
                _context.Add(newmastertransaction);

                //add items to new cart
                Ktixtransactioncartitems newCartItem = new Ktixtransactioncartitems()
                {
                    KtixTransactionCartId = newCart.KtixTransactionCartId,
                    KtixPriceGroupSaleItemId = dto.KTixPriceGroupSaleItemId,
                    //KtixPriceGroupComboItemId = dto.KTixPriceGroupSaleItemId,
                    // KtixVoucherId = dto.KTixVoucherId,
                    Quantity = 1,
                    KTixPriceGroupId = dto.KTixPriceGroupId,
                    SessionId = dto.SessionId
                    // KtixKioskSaleItemId = dto.KTixKioskSaleItemId

                };
                _context.Add(newCartItem);

                _context.SaveChanges();

                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = newCart.KtixTransactionCartId,
                    Status = true,
                    Message = "Ticket/Product added successfully to new cart.",
                    CartCreateDateTime = newCart.CreateDateTime.ToString(),
                    CartExpiryDateTime = newCart.ExpiryDateTime.ToString()
                };

                return Ok(thisCart);
            }
        }

        [HttpPost("RemoveTicketProductToCart")]
        // [Authorize]
        public async Task<IActionResult> RemoveTicketProductToCart([FromBody]RemoveTicketProductToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncartitems
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixPriceGroupSaleItemId == dto.KTixPriceGroupSaleItemId
                        select p;

            var thisItem = await query.FirstOrDefaultAsync();
            if (thisItem != null)
            {
                if (thisItem.Quantity > 1)
                {
                    thisItem.Quantity -= 1;
                    _context.Update(thisItem);
                }
                else
                {
                    _context.Remove(thisItem);
                }

                _context.SaveChanges();


            }
            if (thisItem != null)
            {
                //count number of items in cart.
                var counter = from c in _context.Ktixtransactioncartitems
                              where c.KtixTransactionCartId == dto.KTixTransactionCartId
                              select c;
                var counterR = await counter.ToListAsync();
                if (counterR.Count() == 0)
                {
                    var cartq = from a in _context.Ktixtransactioncart
                                where a.KtixTransactionCartId == dto.KTixTransactionCartId
                                select a;
                    var cartR = await cartq.FirstOrDefaultAsync();
                    _context.Remove(cartR);

                    var mt = from m in _context.Ktixmastertransaction
                             where m.KtixTransactionCartId == dto.KTixTransactionCartId
                             select m;
                    var mtR = await mt.FirstOrDefaultAsync();
                    _context.Remove(mtR);

                    _context.SaveChanges();
                    UpdatedCartDTO thisCart = new UpdatedCartDTO()
                    {
                        CartId = 1,
                        Status = true,
                        Message = "Successfully removed ticket/product from cart and removed cart.",
                        CartCreateDateTime = cartR.CreateDateTime.ToString(),
                        CartExpiryDateTime = cartR.ExpiryDateTime.ToString()
                    };

                    return Ok(thisCart);
                }
                else
                {
                    UpdatedCartDTO thisCart = new UpdatedCartDTO()
                    {
                        CartId = dto.KTixTransactionCartId,
                        Status = true,
                        Message = "Successfully removed ticket/product from cart.",
                    };

                    return Ok(thisCart);
                }
            }
            else
            {
                return BadRequest("Cart not found");

            }
        }



        [HttpPost("AddKioskProductToCart")]
        // [Authorize]
        public async Task<IActionResult> AddKioskProductToCart([FromBody]AddKioskProductToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncart
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixTransactionCartId > 1
                        select p;

            var transactioncart = await query.FirstOrDefaultAsync();
            if (transactioncart != null)
            {

                //check if item exists for an incremetation of 1
                var q2 = from p in _context.Ktixtransactioncartitems
                         where p.KtixKioskSaleItemId == dto.KTixKioskSaleItemId
                         && p.KtixTransactionCartId == transactioncart.KtixTransactionCartId
                         select p;

                var q2Result = await q2.FirstOrDefaultAsync();

                if (q2Result != null)
                {
                    q2Result.Quantity += 1;
                    _context.Update(q2Result);

                }
                //else add a new entry
                else
                {
                    Ktixtransactioncartitems newdto = new Ktixtransactioncartitems()
                    {
                        KtixTransactionCartId = dto.KTixTransactionCartId,
                        KtixKioskSaleItemId = dto.KTixKioskSaleItemId,
                        Quantity = 1,
                    };

                    //have a cart already so add item
                    _context.Add(newdto);
                }
                _context.SaveChanges();
                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = dto.KTixTransactionCartId,
                    Status = true,
                    Message = "Kiosk Product added successfully to existing cart.",
                    CartCreateDateTime = transactioncart.CreateDateTime.ToString(),
                    CartExpiryDateTime = transactioncart.ExpiryDateTime.ToString()
                };

                return Ok(thisCart);

            }
            else
            {
                //add will be run this code block
                //dont have a cart so need to initialize mastertransaction record and create a cart
                Ktixtransactioncart newCart = new Ktixtransactioncart()
                {
                    CreateDateTime = DateTime.Now,
                    ExpiryDateTime = DateTime.Now.AddMinutes(10)

                };
                _context.Add(newCart);

                //initialize a booking
                Ktixmastertransaction newmastertransaction = new Ktixmastertransaction()
                {
                    KtixMasterTransactionId = Guid.NewGuid(),
                    IsPosSale = true,
                    KtixPosTerminalId = dto.KTixPosTerminalId,
                    CmsuserId = dto.CMSUserId,
                    IsCommited = false,
                    IsError = false,
                    IsRefunded = false,
                    KtixTransactionCartId = newCart.KtixTransactionCartId
                };
                _context.Add(newmastertransaction);

                //add items to new cart
                Ktixtransactioncartitems newCartItem = new Ktixtransactioncartitems()
                {
                    KtixTransactionCartId = newCart.KtixTransactionCartId,
                    KtixKioskSaleItemId = dto.KTixKioskSaleItemId,
                    Quantity = 1
                };
                _context.Add(newCartItem);

                _context.SaveChanges();

                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = newCart.KtixTransactionCartId,
                    Status = true,
                    Message = "Kiosk Product added successfully to new cart.",
                    CartCreateDateTime = newCart.CreateDateTime.ToString(),
                    CartExpiryDateTime = newCart.ExpiryDateTime.ToString()
                };

                return Ok(thisCart);
            }
        }

        [HttpPost("RemoveKioskProductToCart")]
        // [Authorize]
        public async Task<IActionResult> RemoveKioskProductToCart([FromBody]RemoveKioskProductToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncartitems
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixKioskSaleItemId == dto.KTixKioskSaleItemId
                        select p;

            var thisItem = await query.FirstOrDefaultAsync();
            if (thisItem != null)
            {
                if (thisItem.Quantity > 1)
                {
                    thisItem.Quantity -= 1;
                    _context.Update(thisItem);
                }
                else
                {
                    _context.Remove(thisItem);
                }

                _context.SaveChanges();


            }

            //count number of items in cart.
            var counter = from c in _context.Ktixtransactioncartitems
                          where c.KtixTransactionCartId == dto.KTixTransactionCartId
                          select c;
            var counterR = await counter.ToListAsync();
            if (counterR.Count() == 0)
            {
                var cartq = from a in _context.Ktixtransactioncart
                            where a.KtixTransactionCartId == dto.KTixTransactionCartId
                            select a;
                var cartR = await cartq.FirstOrDefaultAsync();
                _context.Remove(cartR);

                var mt = from m in _context.Ktixmastertransaction
                         where m.KtixTransactionCartId == dto.KTixTransactionCartId
                         select m;
                var mtR = await mt.FirstOrDefaultAsync();
                _context.Remove(mtR);

                _context.SaveChanges();
                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = 1,
                    Status = true,
                    Message = "Successfully removed ticket/product from cart and removed cart.",
                    CartCreateDateTime = cartR.CreateDateTime.ToString(),
                    CartExpiryDateTime = cartR.ExpiryDateTime.ToString()
                };

                return Ok(thisCart);
            }
            else
            {
                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = dto.KTixTransactionCartId,
                    Status = true,
                    Message = "Successfully removed ticket/product from cart.",
                };

                return Ok(thisCart);
            }
        }

        [HttpGet("GetCartItemsByCartId")]
        // [Authorize]
        public async Task<IActionResult> GetCartItemsByCartId(long cartId)
        {
            var result = new List<ItemsInCartDTO>();

            var query = from s in _context.Ktixtransactioncartitems
                      .Where(s => s.KtixTransactionCartId == cartId)
                            .Include("KtixPriceGroupSaleItem")
                            .Include("KtixPriceGroupSaleItem.KtixSaleItem")
                            .Include("KtixKioskSaleItem")
                        select s;



            var list = await query.ToListAsync();
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    bool isTicket = false;
                    bool isProduct = false;
                    bool isKioskItem = false;
                    string sessiondatetimeAsString = "";
                    string fullItemDesc = "";
                    decimal price = 0;


                    if (item.KtixPriceGroupSaleItemId != null)
                    {
                        if (item.KtixPriceGroupSaleItem.KtixSaleItem.IsTicket == true)
                        {
                            isTicket = true;
                        }
                        else
                        {
                            isProduct = true;
                        }

                        price = item.KtixPriceGroupSaleItem.Price;
                        //get movie and session data
                        var sess = from s in _context.Session
                            .Where(s => s.SessionId == item.SessionId)
                               .Include("Cinema")
                               .Include("MovieInstance")
                               .Include("MovieInstance.MovieDetail")
                               .Include("MovieInstance.MovieDetail.Movie")
                                   select s;

                        var thisSession = await sess.FirstOrDefaultAsync();


                        sessiondatetimeAsString = thisSession.MovieInstance.MovieDetail.Movie.Title + ", " + thisSession.DateTime.ToString("dd/mm/yyyy") + " " + thisSession.DateTime.ToShortTimeString();
                        fullItemDesc = item.KtixPriceGroupSaleItem.KtixSaleItem.Name + " (" + sessiondatetimeAsString + ")";

                        result.Add(new ItemsInCartDTO()
                        {
                            KTixPriceGroupSaleItemId = item.KtixPriceGroupSaleItemId,
                            IsTicket = isTicket,
                            IsProduct = isProduct,
                            KTixKioskSaleItemId = null,
                            IsKioskItem = isKioskItem,
                            FullItemString = fullItemDesc,
                            Quantity = item.Quantity,
                            Price = price.ToString("0.00"),
                            Subtotal = (price * item.Quantity).ToString("0.00")
                        });


                    }
                    else if (item.KtixKioskSaleItemId != null)
                    {
                        isKioskItem = true;
                        fullItemDesc = item.KtixKioskSaleItem.Name;
                        price = item.KtixKioskSaleItem.DefaultPrice;

                        result.Add(new ItemsInCartDTO()
                        {
                            KTixPriceGroupSaleItemId = null,
                            IsTicket = isTicket,
                            IsProduct = isProduct,
                            KTixKioskSaleItemId = item.KtixKioskSaleItemId,
                            IsKioskItem = isKioskItem,
                            FullItemString = fullItemDesc,
                            Quantity = item.Quantity,
                            Price = price.ToString("0.00"),
                            Subtotal = (price * item.Quantity).ToString("0.00")
                        });

                    }
                } //foreach
            }

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Cart not found");

            }
        }

        [HttpPost("DeleteTicketProductFromCart")]
        // [Authorize]
        public async Task<IActionResult> DeleteTicketProductFromCart([FromBody]RemoveTicketProductToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncartitems
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixPriceGroupSaleItemId == dto.KTixPriceGroupSaleItemId
                        select p;

            var thisItem = await query.FirstOrDefaultAsync();
            if (thisItem != null)
            {
                _context.Remove(thisItem);
                _context.SaveChanges();
            }

            if (thisItem != null)
            {
                //count number of items in cart.
                var counter = from c in _context.Ktixtransactioncartitems
                              where c.KtixTransactionCartId == dto.KTixTransactionCartId
                              select c;
                var counterR = await counter.ToListAsync();
                if (counterR.Count() == 0)
                {
                    var cartq = from a in _context.Ktixtransactioncart
                                where a.KtixTransactionCartId == dto.KTixTransactionCartId
                                select a;
                    var cartR = await cartq.FirstOrDefaultAsync();
                    _context.Remove(cartR);

                    var mt = from m in _context.Ktixmastertransaction
                             where m.KtixTransactionCartId == dto.KTixTransactionCartId
                             select m;
                    var mtR = await mt.FirstOrDefaultAsync();
                    _context.Remove(mtR);

                    _context.SaveChanges();
                    UpdatedCartDTO thisCart = new UpdatedCartDTO()
                    {
                        CartId = 1,
                        Status = true,
                        Message = "Successfully deleted ticket/product from cart and deleted cart."
                        ,
                        CartCreateDateTime = cartR.CreateDateTime.ToString(),
                        CartExpiryDateTime = cartR.ExpiryDateTime.ToString()
                    };
                    return Ok(thisCart);
                }
                else
                {
                    UpdatedCartDTO thisCart = new UpdatedCartDTO()
                    {
                        CartId = dto.KTixTransactionCartId,
                        Status = true,
                        Message = "Successfully removed ticket/product from cart."
                    };
                    return Ok(thisCart);
                }
            }
            else
            {
                return BadRequest("Cart not found");

            }

        }

        [HttpPost("DeleteKioskProductFromCart")]
        // [Authorize]
        public async Task<IActionResult> DeleteKioskProductFromCart([FromBody]RemoveKioskProductToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncartitems
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixKioskSaleItemId == dto.KTixKioskSaleItemId
                        select p;

            var thisItem = await query.FirstOrDefaultAsync();
            if (thisItem != null)
            {
                _context.Remove(thisItem);
                _context.SaveChanges();
            }

            if (thisItem != null)
            {
                //count number of items in cart.
                var counter = from c in _context.Ktixtransactioncartitems
                              where c.KtixTransactionCartId == dto.KTixTransactionCartId
                              select c;
                var counterR = await counter.ToListAsync();
                if (counterR.Count() == 0)
                {
                    var cartq = from a in _context.Ktixtransactioncart
                                where a.KtixTransactionCartId == dto.KTixTransactionCartId
                                select a;
                    var cartR = await cartq.FirstOrDefaultAsync();
                    _context.Remove(cartR);

                    var mt = from m in _context.Ktixmastertransaction
                             where m.KtixTransactionCartId == dto.KTixTransactionCartId
                             select m;
                    var mtR = await mt.FirstOrDefaultAsync();
                    _context.Remove(mtR);

                    _context.SaveChanges();
                    UpdatedCartDTO thisCart = new UpdatedCartDTO()
                    {
                        CartId = 1,
                        Status = true,
                        Message = "Successfully deleted kiosk product from cart and deleted cart.",
                        CartCreateDateTime = cartR.CreateDateTime.ToString(),
                        CartExpiryDateTime = cartR.ExpiryDateTime.ToString()
                    };
                    return Ok(thisCart);
                }
                else
                {
                    UpdatedCartDTO thisCart = new UpdatedCartDTO()
                    {
                        CartId = dto.KTixTransactionCartId,
                        Status = true,
                        Message = "Successfully deleted kiosk product from cart"
                    };
                    return Ok(thisCart);
                }
            }
            else
            {
                return BadRequest("Cart not found");

            }


        }

        [HttpPost("ClearCart")]
        // [Authorize]
        public async Task<IActionResult> ClearCart(long cartId)
        {
            var result = new List<ItemsInCartDTO>();

            var query = from s in _context.Ktixtransactioncartitems
                      .Where(s => s.KtixTransactionCartId == cartId)
                            .Include("KtixPriceGroupSaleItem")
                            .Include("KtixPriceGroupSaleItem.KtixSaleItem")
                            .Include("KtixKioskSaleItem")
                        select s;
            var list = await query.ToListAsync();

            foreach (var item in list)
            {
                _context.Remove(item);
            }
            var cartq = from a in _context.Ktixtransactioncart
                        where a.KtixTransactionCartId == cartId
                        select a;
            var cartR = await cartq.FirstOrDefaultAsync();
            _context.Remove(cartR);

            var mt = from m in _context.Ktixmastertransaction
                     where m.KtixTransactionCartId == cartId
                     select m;
            var mtR = await mt.FirstOrDefaultAsync();
            _context.Remove(mtR);

            _context.SaveChanges();


            if (list != null)
            {

                UpdatedCartDTO thisCart = new UpdatedCartDTO()
                {
                    CartId = 1,
                    Status = true,
                    Message = "Successfully cleared all items in cart and deleted cart."
                };
                return Ok(thisCart);
            }
            else
            {

                return BadRequest("Cart not found");
            }
        }

        [HttpPost("ProcessBooking")]
        // [Authorize]
        public async Task<IActionResult> ProcessBooking([FromBody] ProcessDTO dto)
        {
            //check if mastertransaction has already been processed or commited?
            var q = from p in _context.Ktixmastertransaction
                    where p.KtixTransactionCartId == dto.CartId
                    && p.IsCommited == false
                    && p.KtixBookingId == null
                    && p.KtixKioskOrderId == null
                    && p.ReferenceNumber == null
                    select p;

            // make sure cart is valid
            var query = from p in _context.Ktixtransactioncart
                        where p.KtixTransactionCartId == dto.CartId
                        select p;

            var thisCart = await q.FirstOrDefaultAsync();


            //if cart is valid and cart is not expired
            if (thisCart != null)
            {
                //initialize total costs variables
                decimal totalKtixBookingCost = 0.00M;
                decimal totalKioskCost = 0.00M;
                decimal totalCost = 0.00M;
                Guid? newBookingId = null;
                Guid? newKioskOrderId = null;
                String bookingNumber = "";
                String OrderNumber = "";

                //calculate total ktixbooking cost
                var TP = from s in _context.Ktixtransactioncartitems
                        .Where(s => s.KtixTransactionCartId == dto.CartId
                           && s.KtixPriceGroupSaleItem != null
                         && s.SessionId != null && s.Quantity > 0)
                           .Include("KtixPriceGroupSaleItem")
                         select s;
                var TPResult = await TP.ToListAsync();
                if (TPResult != null && TPResult.Count() > 0)
                {
                    foreach (var item in TPResult)
                    {
                        totalKtixBookingCost += (item.KtixPriceGroupSaleItem.Price * item.Quantity);
                    }
                }

                //calculate total kioskorder cost
                var Kiosk = from s in _context.Ktixtransactioncartitems
                        .Where(s => s.KtixTransactionCartId == dto.CartId
                           && s.KtixKioskSaleItemId != null
                           && s.Quantity > 0)
                           .Include("KtixKioskSaleItem")
                            select s;
                var KioskResult = await Kiosk.ToListAsync();
                if (KioskResult != null && KioskResult.Count() > 0)
                {
                    foreach (var item in KioskResult)
                    {
                        totalKioskCost += (item.KtixKioskSaleItem.DefaultPrice * item.Quantity);
                    }
                }
                //calculate total transaction cost
                totalCost = (totalKtixBookingCost + totalKioskCost);

                //if cart contains tickets/products, add them to the Ktixbooking Table
                if (TPResult != null && TPResult.Count() > 0)
                {
                    //getKtixSessionObject
                    var firstItem = TPResult.FirstOrDefault();
                    long? sessionid = firstItem.SessionId;

                    var tmp = from s in _context.Ktixsession
                         .Where(s => s.SessionId == sessionid)
                            .Include("Session.Cinema")
                            .Include("Session.Sessionflags")
                            .Include("Session.Sessionflags.Flag")
                            .Include("Session.MovieInstance")
                            .Include("Session.MovieInstance.MovieDetail")
                            .Include("Session.MovieInstance.MovieDetail.Movie")
                            .Include("Session.MovieInstance.MovieDetail.Rating")
                            .Include("KtixPriceGroup")
                              select s;
                    var tmpresult = await tmp.FirstOrDefaultAsync();

                    bookingNumber = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);


                    //create a new record
                    Ktixbooking newBooking = new Ktixbooking()
                    {
                        KtixBookingId = Guid.NewGuid(),
                        KtixSettingId = dto.KTixSettingId,
                        ScreenId = tmpresult.Session.ScreenId,
                        SessionDateTime = tmpresult.Session.DateTime,
                        MovieTitle = tmpresult.Session.MovieInstance.MovieDetail.Title,
                        BookingDateTime = DateTime.Now,
                        SessionId = tmpresult.Session.SessionId,
                        CustomerIpaddress = null,
                        ReceiptHtml = "",
                        KtixPriceGroupId = tmpresult.KtixPriceGroupId,
                        KtixSessionId = tmpresult.KtixSessionId,
                        CinemaId = tmpresult.Session.CinemaId,
                        TotalCost = totalKtixBookingCost,
                        TotalCostOfBookingFees = 0,
                        TotalCostOfItems = totalKtixBookingCost,
                        BookingNumber = bookingNumber,
                        IsCommitted = true
                    };
                    _context.Add(newBooking);

                    newBookingId = newBooking.KtixBookingId;

                    foreach (var item in TPResult)
                    {
                        if (item.Quantity > 1)
                        {
                            for (int i = 0; i < item.Quantity; i++)
                            {
                                Ktixbookingsaleitems newbookingsaleitem = new Ktixbookingsaleitems()
                                {
                                    KtixBookingId = newBooking.KtixBookingId,
                                    KtixPriceGroupSaleItemId = item.KtixPriceGroupSaleItemId ?? default(int),
                                    KtixBookingVoucherId = null


                                };
                                _context.Add(newbookingsaleitem);
                            }
                        }
                        else
                        {
                            Ktixbookingsaleitems newbookingsaleitem = new Ktixbookingsaleitems()
                            {
                                KtixBookingId = newBooking.KtixBookingId,
                                KtixPriceGroupSaleItemId = item.KtixPriceGroupSaleItemId ?? default(int),
                                KtixBookingVoucherId = null

                            };
                            _context.Add(newbookingsaleitem);
                        }

                    }
                    _context.SaveChanges();
                    //return cart
                    // return Ok(newBooking.KtixBookingId);
                }

                //if cart contain kioskitems, add them to the kioskorder table

                if (KioskResult != null && KioskResult.Count() > 0)
                {
                    OrderNumber = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);


                    //create a new record
                    Ktixkioskorder newkioskorder = new Ktixkioskorder()
                    {
                        KtixKioskOrderId = Guid.NewGuid(),
                        KtixSettingId = dto.KTixSettingId,
                        CustomerEmail = "",
                        CustomerPhone = "",
                        TotalCostOfKioskItems = totalKioskCost,
                        OrderNumber = OrderNumber,
                        IsCommitted = true,
                        CinemaId = dto.CinemaId,
                    };
                    _context.Add(newkioskorder);

                    newKioskOrderId = newkioskorder.KtixKioskOrderId;
                    foreach (var item in KioskResult)
                    {
                        if (item.Quantity > 1)
                        {

                            Ktixkioskordersaleitem newkioskordersaleitem = new Ktixkioskordersaleitem()
                            {
                                KtixKioskOrderId = newkioskorder.KtixKioskOrderId,
                                KtixKioskSaleItemId = item.KtixKioskSaleItemId ?? default(Guid),
                                Quantity = item.Quantity

                            };
                            _context.Add(newkioskordersaleitem);
                        }
                    }
                    _context.SaveChanges();


                }

                //Update mastertransaction record with new ktixbookingid or/and ktixkioskorderid

                var mt = from p in _context.Ktixmastertransaction
                         where p.KtixTransactionCartId == dto.CartId
                         select p;

                var thismastertransaction = await mt.FirstOrDefaultAsync();
                if (TPResult != null && TPResult.Count() > 0)
                {
                    thismastertransaction.KtixBookingId = newBookingId;
                }
                if (Kiosk != null && Kiosk.Count() > 0)
                {
                    thismastertransaction.KtixKioskOrderId = newKioskOrderId;
                }
                thismastertransaction.TotalCostOfBooking = totalKtixBookingCost;
                thismastertransaction.TotalCostOfKioskOrder = totalKioskCost;
                thismastertransaction.TotalCostOfTransaction = totalCost;
                thismastertransaction.IsCommited = true;
                _context.Update(thismastertransaction);
                _context.SaveChanges();
                //return cart

                MyMasterTransactionDTO MyCart = new MyMasterTransactionDTO()
                {
                    KtixMasterTransactionId = thismastertransaction.KtixMasterTransactionId,
                    Status = true,
                    Message = "Successfully processed booking - waiting payment for commit.",
                    IsCommited = thismastertransaction.IsCommited,
                    KTixBookingId = thismastertransaction.KtixBookingId,
                    KTixBookingNumber = bookingNumber,
                    KTixKioskOrderId = thismastertransaction.KtixKioskOrderId,
                    KTixOrderNumber = OrderNumber
                };
                return Ok(MyCart);

            }
            else
            {
                return BadRequest("Unable to process booking.");
            }
        }

        [HttpPost("CommitBooking")]
        // [Authorize]
        public async Task<IActionResult> CommitBooking([FromBody] CommitDTO dto)
        {
            var query = from p in _context.Ktixmastertransaction
                        where p.KtixMasterTransactionId == dto.KtixMasterTransactionId
                        && p.IsCommited == true
                        select p;
            var thisTransaction = await query.FirstOrDefaultAsync();
            //if cart is valid and cart is not expired
            if (thisTransaction != null)
            {
                if (thisTransaction.ReferenceNumber != null && thisTransaction.ReferenceNumber.Length > 0)
                {
                    return BadRequest("Booking has already been commited with Payment.");
                }
                else
                {
                    if (dto.IsCash)
                    {
                        Ktixmasterpaymenttype newpayment = new Ktixmasterpaymenttype()
                        {
                            KtixMasterTransactionId = dto.KtixMasterTransactionId,
                            KtixPaymentTypeId = 3,
                            CreditCardCardPaidAmount = 0,
                            CreditCardGatewayTransactionNumber = null,
                            IsApproved = true,
                            BankAuthCode = null,
                            ResponseCode = null,
                            CreateDateTime = DateTime.Now,
                            MerchantDate = null,
                            CinemaPaymentGatewayId = null,
                            CashPaidAmount = dto.MoneyRecieved,
                            KtixGiftCardId = null,
                            GiftCardNumber = null,
                            GiftCardStartingBalance = null,
                            GiftCardClosingBalance = null,
                            GiftCardPaymentAmount = null,
                            GiftCardValid = false,
                            GiftCardCharged = false,
                            CashReturnedAmount = dto.MoneyReturned
                        };
                        _context.Add(newpayment);

                    }
                    else if (dto.IsEftpos)
                    {
                        Ktixmasterpaymenttype newpayment = new Ktixmasterpaymenttype()
                        {
                            KtixMasterTransactionId = dto.KtixMasterTransactionId,
                            KtixPaymentTypeId = 2,
                            CreditCardCardPaidAmount = dto.CreditCardAmount,
                            CreditCardGatewayTransactionNumber = null,
                            IsApproved = true,
                            BankAuthCode = null,
                            ResponseCode = null,
                            CreateDateTime = DateTime.Now,
                            MerchantDate = null,
                            CinemaPaymentGatewayId = null,
                            CashPaidAmount = 0,
                            KtixGiftCardId = null,
                            GiftCardNumber = null,
                            GiftCardStartingBalance = null,
                            GiftCardClosingBalance = null,
                            GiftCardPaymentAmount = null,
                            GiftCardValid = false,
                            GiftCardCharged = false,
                            CashReturnedAmount = null
                        };
                        _context.Add(newpayment);

                    }
                    else if (dto.IsGiftCard)
                    {
                        Ktixmasterpaymenttype newpayment = new Ktixmasterpaymenttype()
                        {
                            KtixMasterTransactionId = dto.KtixMasterTransactionId,
                            KtixPaymentTypeId = 4,
                            CreditCardCardPaidAmount = 0,
                            CreditCardGatewayTransactionNumber = null,
                            IsApproved = true,
                            BankAuthCode = null,
                            ResponseCode = null,
                            CreateDateTime = DateTime.Now,
                            MerchantDate = null,
                            CinemaPaymentGatewayId = null,
                            CashPaidAmount = null,
                            KtixGiftCardId = null,
                            GiftCardNumber = dto.GiftCardNumber,
                            GiftCardStartingBalance = null,
                            GiftCardClosingBalance = null,
                            GiftCardPaymentAmount = null,
                            GiftCardValid = false,
                            GiftCardCharged = false,
                            CashReturnedAmount = null
                        };
                        _context.Add(newpayment);

                    }

                    //generate a master transaction refernce number.
                    string ReferenceNumber = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);

                    thisTransaction.ReferenceNumber = ReferenceNumber;
                    _context.Update(thisTransaction);

                    _context.SaveChanges();
                    MyMasterTransactionDTO MyTransaction = new MyMasterTransactionDTO()
                    {
                        KtixMasterTransactionId = dto.KtixMasterTransactionId,
                        Status = true,
                        Message = "Successfully commited booking with Payment. Awaiting to get receipt and tickets.",
                        IsCommited = thisTransaction.IsCommited,
                        ReferenceNumber = ReferenceNumber,
                        CartId = thisTransaction.KtixTransactionCartId

                    };
                    return Ok(MyTransaction);
                }
            }
            else
            {
                MyMasterTransactionDTO MyTransaction = new MyMasterTransactionDTO()
                {
                    KtixMasterTransactionId = dto.KtixMasterTransactionId,
                    Status = false,
                    Message = "Unable to commit booking with Payment.",
                    IsCommited = false,
                    CartId = thisTransaction.KtixTransactionCartId

                };
                return Ok(MyTransaction);
            }
        }

        [HttpPost("CancelBooking")]
        // [Authorize]
        public async Task<IActionResult> CancelBooking(Guid KtixMasterTransactionId)
        {
            // make sure cart is valid
            var query = from p in _context.Ktixmastertransaction
                        where p.KtixMasterTransactionId == KtixMasterTransactionId
                        && p.IsCommited == true
                        select p;

            var thisTransaction = await query.FirstOrDefaultAsync();


            if (thisTransaction != null)
            {
                var cartitems = from t in _context.Ktixtransactioncartitems
                                where t.KtixTransactionCartId == thisTransaction.KtixTransactionCartId
                                select t;

                var itemlist = await cartitems.ToListAsync();
                //delete the associated cart and its items
                foreach (Ktixtransactioncartitems item in itemlist)
                {
                    _context.Remove(item);
                }

                var cart = from p in _context.Ktixtransactioncart
                           where p.KtixTransactionCartId == thisTransaction.KtixTransactionCartId
                           select p;

                var thisCart = await cart.FirstOrDefaultAsync();
                _context.Remove(thisCart);


                thisTransaction.KtixTransactionCartId = null;
                thisTransaction.KtixBookingId = null;
                thisTransaction.KtixKioskOrderId = null;
                _context.Update(thisTransaction);

                //delete the master transaction record.
                _context.Remove(thisTransaction);


                _context.SaveChanges();

                MyMasterTransactionDTO MyTransaction = new MyMasterTransactionDTO()
                {
                    KtixMasterTransactionId = new Guid("00000000-0000-0000-0000-000000000000"),
                    Status = true,
                    Message = "Successfully cancelled the booking.",
                    IsCommited = thisTransaction.IsCommited,
                    CartId = 1

                };
                return Ok(MyTransaction);
            }
            else
            {
                return BadRequest("Booking not found");
            }
        }

        [HttpGet("SearchBooking")]
        public async Task<IActionResult> SearchBooking(String ReferenceNumber)
        {
            // make sure cart is valid
            var query = from p in _context.Ktixmastertransaction
                          .Where(p => p.ReferenceNumber == ReferenceNumber
                        && p.IsRefunded == false
                        && p.IsCommited == true
                        && p.KtixTransactionCartId != null)
                            .Include("KtixTransactionCart")
                        select p;
            var thisTransaction = await query.FirstOrDefaultAsync();

            if (thisTransaction != null)
            {
                var result = new List<ItemsInCartDTO>();
                string PaymentTypeAsString = "";
                string SessionAsString = "";
                string ItemSummaryAsString = "";

                var payQ = from q in _context.Ktixmasterpaymenttype
                           .Where(q => q.KtixMasterTransactionId == thisTransaction.KtixMasterTransactionId)
                           .Include("KtixPaymentType")
                           select q;
                var payR = await payQ.FirstOrDefaultAsync();
                if (payR != null)
                {
                    PaymentTypeAsString = payR.KtixPaymentType.Name;
                }

                var cartQ = from p in _context.Ktixtransactioncartitems
                         .Where(p => p.KtixTransactionCartId == thisTransaction.KtixTransactionCartId)
                                .Include("KtixPriceGroupSaleItem")
                                .Include("KtixPriceGroupSaleItem.KtixSaleItem")
                                .Include("KtixKioskSaleItem")
                            select p;

                var list = await cartQ.ToListAsync();
                if (list.Count() > 0)
                {
                    foreach (var item in list)
                    {
                        bool isTicket = false;
                        bool isProduct = false;
                        bool isKioskItem = false;
                        string fullItemDesc = "";
                        decimal price = 0;


                        if (item.KtixPriceGroupSaleItemId != null)
                        {
                            if (item.KtixPriceGroupSaleItem.KtixSaleItem.IsTicket == true)
                            {
                                isTicket = true;
                            }
                            else
                            {
                                isProduct = true;
                            }

                            price = item.KtixPriceGroupSaleItem.Price;
                            //get movie and session data
                            var sess = from s in _context.Session
                                .Where(s => s.SessionId == item.SessionId)
                                   .Include("Cinema")
                                   .Include("MovieInstance")
                                   .Include("MovieInstance.MovieDetail")
                                   .Include("MovieInstance.MovieDetail.Movie")
                                       select s;

                            var thisSession = await sess.FirstOrDefaultAsync();


                            SessionAsString = thisSession.MovieInstance.MovieDetail.Movie.Title + ", " + thisSession.DateTime.ToString("dd/mm/yyyy") + " " + thisSession.DateTime.ToShortTimeString();
                            fullItemDesc = item.Quantity + " X " + item.KtixPriceGroupSaleItem.KtixSaleItem.Name;

                            result.Add(new ItemsInCartDTO()
                            {
                                KTixPriceGroupSaleItemId = item.KtixPriceGroupSaleItemId,
                                IsTicket = isTicket,
                                IsProduct = isProduct,
                                KTixKioskSaleItemId = null,
                                IsKioskItem = isKioskItem,
                                FullItemString = fullItemDesc,
                                Quantity = item.Quantity,
                                Price = price.ToString("0.00"),
                            });


                        }
                        else if (item.KtixKioskSaleItemId != null)
                        {
                            isKioskItem = true;
                            fullItemDesc = item.KtixKioskSaleItem.Name;
                            price = item.KtixKioskSaleItem.DefaultPrice;

                            result.Add(new ItemsInCartDTO()
                            {
                                KTixPriceGroupSaleItemId = null,
                                IsTicket = isTicket,
                                IsProduct = isProduct,
                                KTixKioskSaleItemId = item.KtixKioskSaleItemId,
                                IsKioskItem = isKioskItem,
                                FullItemString = fullItemDesc,
                                Quantity = item.Quantity,
                                Price = price.ToString("0.00"),
                            });

                        }
                    } //foreach

                }


                ThisMasterTransactionDTO Transaction = new ThisMasterTransactionDTO()
                {
                    KtixMasterTransactionId = thisTransaction.KtixMasterTransactionId,
                    Message = "Booking Found",
                    IsCommited = thisTransaction.IsCommited,
                    ReferenceNumber = thisTransaction.ReferenceNumber,
                    PaymentType = PaymentTypeAsString,
                    CartId = thisTransaction.KtixTransactionCartId.ToString(),
                    BookingDateTime = thisTransaction.KtixTransactionCart.CreateDateTime.ToString(),
                    TotalCost = thisTransaction.TotalCostOfTransaction.ToString(),
                    SessionDateTime = SessionAsString,
                    BookingItemsSummary = ItemSummaryAsString,
                    ItemsInCartDTO = result

                };
                return Ok(Transaction);
            }
            else
            {
                return BadRequest("Booking not found");
            }

        }

        [HttpPost("IssueRefund")]
        public async Task<IActionResult> IssueRefund(String ReferenceNumber, String Reason)
        {
            // make sure cart is valid
            var query = from p in _context.Ktixmastertransaction
                          .Where(p => p.ReferenceNumber == ReferenceNumber
                        && p.IsRefunded == false
                        && p.IsCommited == true
                        && p.KtixTransactionCartId != null)
                            .Include("KtixTransactionCart")
                        select p;
            var thisTransaction = await query.FirstOrDefaultAsync();

            if (thisTransaction != null)
            {
                thisTransaction.IsRefunded = true;
                thisTransaction.RefundedMessage = Reason;
                _context.Update(thisTransaction);
                _context.SaveChanges();

                return Ok("Booking has been marked as refunded.");
            }
            else
            {
                return BadRequest("Booking not found.");
            }
        }
    }
}