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
            //check if the ticket/product is still avaliable for this session before updating cart
            var sessionq = from s in _context.Ktixsession
                           where s.SessionId == dto.SessionId
                           select s;
            var thisKtixSession = await sessionq.FirstOrDefaultAsync();


            //get total of screen where session is showing minus the soldout limit - total seats already sold online or POS.
            int totalSessionSeats = thisKtixSession.Session.Screen.NumberOfSeats - thisKtixSession.Session.Screen.SoldOutLimit;
            // get total seats sold on POS and Online
            // function is in SessionController
            int totalSoldSeats = CountTicketsSoldForSession(thisKtixSession.KtixSessionId);
            // get total seats in cart which are not committed for session
            // function is in SessionController
            int reservredTicketsInPosCarts = GetNumberOfTicketsOnHoldInCartForPOS(thisKtixSession.KtixPriceGroup.KtixSettingId, thisKtixSession.SessionId);
            //get seats remaining
            int liveRemainingSeats = totalSessionSeats - totalSoldSeats - reservredTicketsInPosCarts;

            //check if there is an itemOuantityOverride
            int numberOfSaleItemsAvailable = GetQuantityOfAvailableSaleItemForSessionByItem(thisKtixSession.KtixSessionId, dto.KTixPriceGroupSaleItemId);

            //there are still seats avaliable for sale.
            if (liveRemainingSeats > 0 && numberOfSaleItemsAvailable > 0)
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

                    //update the seats remaining counter on the session
                    var sesstmp = from p in _context.Session
                             where p.SessionId == dto.SessionId
                             select p;

                    var thisSession = await sesstmp.FirstOrDefaultAsync();

                    thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining - 1);
                    _context.Update(thisSession);
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

                    //update the seats remaining counter on the session
                    var sesstmp = from p in _context.Session
                                  where p.SessionId == dto.SessionId
                                  select p;

                    var thisSession = await sesstmp.FirstOrDefaultAsync();

                    thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining - 1);
                    _context.Update(thisSession);
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
            else
            {
                return BadRequest("there are no tickets left for the session");
            }

        }

        [HttpPost("AddComboTicketToCart")]
        // [Authorize]
        public async Task<IActionResult> AddComboTicketToCart([FromBody]AddComboTicketToCartDTO dto)
        {

            var query = from p in _context.Ktixtransactioncart
                        where p.KtixTransactionCartId == dto.KTixTransactionCartId
                        && p.KtixTransactionCartId > 1
                        select p;

            var transactioncart = await query.FirstOrDefaultAsync();
            if (transactioncart != null)
            {
                //check if the ticket/product is still avaliable for this session
                int itemAvaliability = 0;

                //check if item exists for an incremetation of 1
                var q2 = from p in _context.Ktixtransactioncartitems
                         where p.KtixPriceGroupComboItemId == dto.KTixPriceGroupComboItemId
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
                        KtixPriceGroupComboItemId = dto.KTixPriceGroupComboItemId,
                        Quantity = 1,
                        KTixPriceGroupId = dto.KTixPriceGroupId,
                        SessionId = dto.SessionId
                    };

                    //have a cart already so add item
                    _context.Add(newdto);
                }
                _context.SaveChanges();

                //update the seats remaining counter on the session
                var sesstmp = from p in _context.Session
                              where p.SessionId == dto.SessionId
                              select p;

                var thisSession = await sesstmp.FirstOrDefaultAsync();

                thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining - 1);
                _context.Update(thisSession);
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
                    KtixPriceGroupComboItemId = dto.KTixPriceGroupComboItemId,
                    //KtixPriceGroupComboItemId = dto.KTixPriceGroupSaleItemId,
                    // KtixVoucherId = dto.KTixVoucherId,
                    Quantity = 1,
                    KTixPriceGroupId = dto.KTixPriceGroupId,
                    SessionId = dto.SessionId
                    // KtixKioskSaleItemId = dto.KTixKioskSaleItemId

                };
                _context.Add(newCartItem);

                _context.SaveChanges();

                //update the seats remaining counter on the session
                var sesstmp = from p in _context.Session
                              where p.SessionId == dto.SessionId
                              select p;

                var thisSession = await sesstmp.FirstOrDefaultAsync();

                thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining - 1);
                _context.Update(thisSession);
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

                    //update the seats remaining counter on the session
                    var sesstmp = from p in _context.Session
                                  where p.SessionId == dto.SessionId
                                  select p;

                    var thisSession = await sesstmp.FirstOrDefaultAsync();

                    thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining + 1);

                    _context.Update(thisSession);
                    _context.SaveChanges();


                }
                else
                {

                    //update the seats remaining counter on the session
                    var sesstmp = from p in _context.Session
                                  where p.SessionId == dto.SessionId
                                  select p;

                    var thisSession = await sesstmp.FirstOrDefaultAsync();

                    thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining - thisItem.Quantity);
                    _context.Update(thisSession);
                    _context.SaveChanges();


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
                //update the seats remaining counter on the session
                var sesstmp = from p in _context.Session
                              where p.SessionId == dto.SessionId
                              select p;

                var thisSession = await sesstmp.FirstOrDefaultAsync();

                thisSession.SeatsRemaining = (short)(thisSession.SeatsRemaining - thisItem.Quantity);
                _context.Update(thisSession);
                _context.SaveChanges();


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

                //calculate total ktixbooking cost for single items
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

                //calculate total ktixbooking cost for combo items
                var ci = from s in _context.Ktixtransactioncartitems
                        .Where(s => s.KtixTransactionCartId == dto.CartId
                           && s.KtixPriceGroupSaleItem != null
                         && s.SessionId != null && s.Quantity > 0)
                           .Include("KtixPriceGroupSaleItem")
                         select s;
                var ciResult = await ci.ToListAsync();
                if (ciResult != null && ciResult.Count() > 0)
                {
                    foreach (var item in ciResult)
                    {
                        totalKtixBookingCost += (item.KtixPriceGroupComboItem.Price * item.Quantity);
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

                    //add all single items.
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

                    //add all combo items.
                    foreach (var item in TPResult)
                    {
                        if (item.Quantity > 1)
                        {
                            for (int i = 0; i < item.Quantity; i++)
                            {
                                Ktixbookingcomboitems newbookingsaleitem = new Ktixbookingcomboitems()
                                {
                                    KtixBookingId = newBooking.KtixBookingId,
                                    KtixPriceGroupComboItemId = item.KtixPriceGroupComboItemId ?? default(int),


                                };
                                _context.Add(newbookingsaleitem);
                            }
                        }
                        else
                        {
                            Ktixbookingcomboitems newbookingsaleitem = new Ktixbookingcomboitems()
                            {
                                KtixBookingId = newBooking.KtixBookingId,
                                KtixPriceGroupComboItemId = item.KtixPriceGroupComboItemId ?? default(int),

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





        [HttpPost("GetListOfSessionsForBooking")]
        public async Task<IActionResult> GetListOfSessionsForBooking(String ReferenceNumber, Guid KtixSettingId)
        {
            var sessionList = new List<Ktixsession>();
            var result = new List<SessionsByCinemaDTO>();

            //get list of all avaliable sessions that is not cancelled , still active and is greater than now by 1 hour.
            var sessionQ = from s in _context.Ktixsession
                           .Where(s => s.KtixPriceGroup.KtixSettingId == KtixSettingId
                           && s.IsCancelled == false
                           && s.IsActive == true
                           && s.Session.DateTime > DateTime.Now.AddHours(1))
                           .Include("Session.Cinema")
                           .Include("Session.Screen")
                           .Include("Session.Sessionflags")
                           .Include("Session.Sessionflags.Flag")
                           .Include("Session.MovieInstance")
                           .Include("Session.MovieInstance.MovieDetail")
                           .Include("Session.MovieInstance.MovieDetail.Movie")
                           .Include("Session.MovieInstance.MovieDetail.Rating")
                           .Include("KtixPriceGroup")
                           orderby s.Session.CreateDateTime
                           select s;

            var sessionR = await sessionQ.ToListAsync();


            // Get the master transaction record based on the reference number which has a session(ktixbooking) linked to it. 
            // It will not get a record if the master transaction only contains kiosk items.
            var query = from p in _context.Ktixmastertransaction
                          .Where(p => p.ReferenceNumber == ReferenceNumber
                        && p.IsRefunded == false
                        && p.IsCommited == true
                        && p.KtixBookingId != null
                        && p.KtixTransactionCartId != null)
                            .Include("KtixTransactionCart")
                        select p.KtixBooking;
            var thisKtixBooking = await query.FirstOrDefaultAsync();

            if (thisKtixBooking != null)
            {
                // Get list of all session tickets/products associated with the master transaction.
                var saleitemlistQ = from s in _context.Ktixbookingsaleitems
                                    where s.KtixBookingId == thisKtixBooking.KtixBookingId
                                    select s;
                var saleItemlistR = await saleitemlistQ.Distinct().ToListAsync();


                // iliterate all session  tickets/products (adult ticket, beanbag etc)
                foreach (var thissaleitem in saleItemlistR)
                {
                    // get the total count of each ticket/product
                    var temp = from s in _context.Ktixbookingsaleitems
                               where s.KtixBookingId == thisKtixBooking.KtixBookingId
                               select s;
                    // this can return like 2 adult tickets
                    var numberOfItemsInBooking = await temp.CountAsync();


                    // go through each session in the session list to
                    foreach (var thisSession in sessionR)
                    {

                        //logic to make sure that this saleitem is avalbile for purchase in the new session.
                        //method to check how many is avaliable  of the ticket/product in the new sessions for sale
                        //get total amount of sale item per price group, applys an override for a session if applicable then minus amount of already sold.
                        int numberOfItemsAvailable = GetQuantityOfAvailableSaleItemForSessionByItem(thisSession.KtixSessionId, thissaleitem.KtixPriceGroupSaleItemId);

                        if (numberOfItemsAvailable < numberOfItemsInBooking)
                        {
                            sessionR.Remove(thisSession);
                        }

                        //if this session is the same session in the orignal booking or this session doesnt allow transfers, remove from list.
                        if (thisKtixBooking.KtixSessionId == thisSession.KtixSessionId || thisSession.KtixPriceGroup.IsAllowTransferDestination == false)
                        {
                            sessionR.Remove(thisSession);
                        }
                    }
                }

                // after removing sessions that are not needed or plausible, create a DTO object to return back to the API.
                foreach (var thisSession in sessionR)
                {
                    result.Add(new SessionsByCinemaDTO()
                    {
                        SessionId = thisSession.Session.SessionId,
                        CinemaId = thisSession.Session.CinemaId,
                        SessionDateTime = thisSession.Session.DateTime,
                        DayOfWeek = thisSession.Session.DateTime.DayOfWeek.ToString(),
                        CinemaName = thisSession.Session.Cinema.Name,
                        ScreenName = thisSession.Session.Screen.Name,
                        MovieTitle = thisSession.Session.MovieInstance.MovieDetail.Title,
                        KTixPriceGroupId = thisSession.KtixPriceGroupId,
                        PriceGroup = thisSession.KtixPriceGroup.Name,
                        PosterURL = "",
                        RunningTimeInMin = thisSession.Session.MovieInstance.MovieDetail.RunningTime.ToString(),
                        RatingName = thisSession.Session.MovieInstance.MovieDetail.Rating.Name,
                        IsCancelled = thisSession.IsCancelled,
                        IsSoldOut = false,
                        Codes = ""
                    });
                }

                return Ok(result);
            }
            else
            {
                return BadRequest("Booking not found.");
            }
        }


        [HttpPost("ChangeBooking")]
        public async Task<IActionResult> ChangeBooking(String ReferenceNumber, long newSessionId)
        {
            var query = from p in _context.Ktixmastertransaction
                          .Where(p => p.ReferenceNumber == ReferenceNumber
                        && p.IsRefunded == false
                        && p.IsCommited == true
                        && p.KtixBookingId != null
                        && p.KtixTransactionCartId != null)
                        select p;
            var ThisTransaction = await query.FirstOrDefaultAsync();

            if (ThisTransaction != null)
            {
                var newKtixsessionQ = from s in _context.Ktixsession
                      .Where(s => s.SessionId == newSessionId)
                      .Include("Session")
                      .Include("Session.MovieInstance")
                      .Include("Session.MovieInstance.MovieDetail")
                      .Include("Session.MovieInstance.MovieDetail.Movie")
                                      select s;
                var thisKtixSession = await newKtixsessionQ.FirstOrDefaultAsync();

                var bookingQ = from b in _context.Ktixbooking
                               where b.KtixBookingId == ThisTransaction.KtixBookingId
                               select b;
                var bookingR = await bookingQ.FirstOrDefaultAsync();
                if (bookingR != null)
                {
                    bookingR.KtixSessionId = thisKtixSession.KtixSessionId;
                    bookingR.SessionId = thisKtixSession.SessionId;
                    bookingR.SessionDateTime = thisKtixSession.Session.DateTime;
                    bookingR.MovieTitle = thisKtixSession.Session.MovieInstance.MovieDetail.Title;
                    bookingR.CinemaId = thisKtixSession.Session.CinemaId;
                    bookingR.IsReceiptSent = false;
                    _context.Update(bookingR);
                    _context.SaveChanges();



                }

                //update cart
                var temp = from t in _context.Ktixtransactioncartitems
                           where t.KtixTransactionCartId == ThisTransaction.KtixTransactionCartId
                           && t.KtixPriceGroupSaleItemId != null
                           && t.SessionId != null
                           select t;
                var cartItems = await temp.ToListAsync();
                foreach (var item in cartItems)
                {
                    item.SessionId = thisKtixSession.SessionId;
                    _context.Update(item);
                    _context.SaveChanges();
                }

                string SessionAsString = thisKtixSession.Session.MovieInstance.MovieDetail.Movie.Title + ", " + thisKtixSession.Session.DateTime.ToString("dd/mm/yyyy") + " " + thisKtixSession.Session.DateTime.ToShortTimeString();


                return Ok("Session has been changed to " + SessionAsString);
            }
            else
            {
                return BadRequest("Booking not found.");
            }

        }


        public int GetQuantityOfAvailableSaleItemForSessionByItem(long KtixSessionId, int priceGroupSaleItemId)
        {
            var tmpA = from a in _context.Ktixsession
                       where a.KtixSessionId == KtixSessionId
                       select a;

            var thisSession = tmpA.FirstOrDefault();

            var tmpB = from b in _context.Ktixpricegroupsaleitems
                       where b.KtixPriceGroupSaleItemId == priceGroupSaleItemId
                       select b;
            var thisPriceGroupSaleItem = tmpB.FirstOrDefault();

            if (thisSession != null && thisPriceGroupSaleItem != null)
            {
                int numberOfItemsForSession = thisPriceGroupSaleItem.NumberAvailablePerSession;

                //check if there is an override
                var q = from o in _context.Ktixsessionsaleitemoverride
                             where o.KtixSaleItemId == thisPriceGroupSaleItem.KtixSaleItemId
                             && o.KtixSessionId == KtixSessionId
                        select o;
                var thisKtixsessionsaleitemoverride = q.FirstOrDefault();

                if (thisKtixsessionsaleitemoverride != null)
                {
                    if (thisKtixsessionsaleitemoverride.NumberAvailablePerSession != null)
                    {
                        numberOfItemsForSession = thisKtixsessionsaleitemoverride.NumberAvailablePerSession.GetValueOrDefault();
                    }

                }


                int numberSold = 0;


                var bookingsq = from r in _context.Ktixbooking
                        where r.KtixSessionId == KtixSessionId
                        && r.IsCommitted == true
                        select r;

                var bookingList = bookingsq.ToList();

                

                foreach (var thisBooking in bookingList)
                {
                    int numberSoldThisBooking = 0;

                    //IList<ORM.Ktixbookingsaleitem> bookingSaleItemList = DAL.DataClasses.KTixBooking.GetBookingSaleItems(thisBooking.KTixBookingId);
                    IList<Ktixsaleitem> bookingSaleItemList = GetAllItems(thisBooking.KtixBookingId);

                    //foreach (ORM.Ktixbookingsaleitem thisBookingSaleItem in bookingSaleItemList)
                    foreach (var thisKTixSaleItem in bookingSaleItemList)
                    {

                            if (thisKTixSaleItem.KtixSaleItemId == thisPriceGroupSaleItem.KtixSaleItemId)
                            {
                                numberSoldThisBooking++;
                            }
                    }

                    numberSold += numberSoldThisBooking;
                }

                return numberOfItemsForSession - numberSold;
            }

            return 0;
        }

        public IList<Ktixsaleitem> GetAllItems(Guid kTixBookingId)
        {
            var saleitemq = from o in _context.Ktixbookingsaleitems
                             where o.KtixBookingId == kTixBookingId
                             select o;
            var bookingSaleItemList = saleitemq.ToList();

            var combosaleitemq = from o in _context.Ktixbookingcomboitems
                            where o.KtixBookingId == kTixBookingId
                            select o;
            var comboItemList = combosaleitemq.ToList();

            IList<Ktixsaleitem> saleItemList = new List<Ktixsaleitem>();

            foreach (var item in bookingSaleItemList)
            {
                saleItemList.Add(item.KtixPriceGroupSaleItem.KtixSaleItem);
            }

            foreach (var item in comboItemList)
            {
                var ci = from o in _context.Ktixcomboitemsaleitems
                             where o.KtixComboItemId == item.KtixPriceGroupComboItem.KtixComboItemId
                             select o;
                var combosaleitemslist = ci.ToList();

                foreach (var cbItem in combosaleitemslist)
                {
                    for (int i = 1; i <= cbItem.Quantity; i++)
                    {
                        var si = from o in _context.Ktixsaleitem
                                 where o.KtixSaleItemId == cbItem.KtixSaleItemId
                                 select o;
                        var thissaleitem = si.FirstOrDefault();


                        saleItemList.Add(thissaleitem);
                    }
                }
            }

            var result = from item in saleItemList
                         orderby item.IsTicket descending, item.Name
                         select item;

            return result.ToList();
        }
    }


}