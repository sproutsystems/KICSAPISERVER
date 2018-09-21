using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KICSAPIServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KICSAPIServer.Controllers
{
    [Route("api/[controller]")]
    public class SessionsController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public SessionsController(KICSDEVContext context)
        {
            _context = context;
        }

        [HttpGet("GetSessionsByCinema")]
        // [Authorize]
        public async Task<IActionResult> GetSessionsByCinema(Guid cinemaId)
        {
            var result = new List<SessionsByCinemaDTO>();

            var query = from s in _context.Ktixsession
                         .Where(s => s.Session.CinemaId == cinemaId
                          && s.Session.DateTime.Date >= DateTime.Now.Date
                          && s.Session.MovieInstance.IsDeleted == false
                          && s.Session.MovieInstance.IsActive == true
                          && s.Session.DateTime.Date <= DateTime.Now.AddDays(6))
                            .Include("Session.Cinema")
                            .Include("Session.Sessionflags")
                            .Include("Session.Sessionflags.Flag")
                            .Include("Session.MovieInstance")
                            .Include("Session.MovieInstance.MovieDetail")
                            .Include("Session.MovieInstance.MovieDetail.Movie")
                            .Include("Session.MovieInstance.MovieDetail.Rating")
                            .Include("KtixPriceGroup")
                        orderby s.Session.DateTime ascending
                        select s;

            var list = await query.ToListAsync();

            foreach (var item in list)
            {
                var seatRemaining = item.Session.SeatsRemaining;
                var tmp = await _context.Session
                    .Include(x => x.Screen)
                    .Where(x => x.SessionId == item.SessionId)
                    .FirstOrDefaultAsync();
                var limit = tmp.Screen.SoldOutLimit;
                Boolean isSO = false;
                if (seatRemaining < limit)
                    isSO = true;

                string outputcodes = "";
                var codes = await _context.Sessionflags
                   .Include(x => x.Flag)
                    .Where(x => x.SessionId == item.SessionId)
                    .FirstOrDefaultAsync();
                var resultCodes = codes;
                if (resultCodes != null)
                    outputcodes = resultCodes.Flag.Code;


                string posterURL = item.Session.Cinema.WebsiteUrl + "/images/Placeholders/noPosterPlaceholder.jpg";
                var contentObject = await _context.Content
                      .Include(f => f.ContentFormat)
                    .Where(x => x.RelatedId == item.Session.MovieInstance.MovieDetail.Movie.MovieId.ToString() && x.ContentTypeId == 1 && x.IsNewLocation == true)
                    .FirstOrDefaultAsync();
                var ResultContentObject = contentObject;
                if (ResultContentObject != null)
                {
                    posterURL = item.Session.Cinema.WebsiteUrl + "/SharedContent/" + item.Session.MovieInstance.MovieDetail.Movie.MovieId.ToString() + "/" + ResultContentObject.ShortGuid + ResultContentObject.ContentFormat.FileExtension;
                }


                //get seats remaining for session when it was last checked online - not live accurate
                int sessionSeatsRemaining = item.Session.SeatsRemaining;

                //get total of screen where session is showing minus the soldout limit - total seats already sold online or POS.
                int totalSessionSeats = item.Session.Screen.NumberOfSeats - item.Session.Screen.SoldOutLimit;

                // get total seats sold on POS and Online
                int totalSoldSeats = CountTicketsSoldForSession(item.KtixSessionId);

                // get total seats in cart which are not committed for session
                int reservredTicketsInPosCarts = GetNumberOfTicketsOnHoldInCartForPOS(item.KtixPriceGroup.KtixSettingId, item.SessionId);

                int liveRemainingSeats = totalSessionSeats - totalSoldSeats - reservredTicketsInPosCarts;

                result.Add(new SessionsByCinemaDTO()
                {
                    SessionId = item.Session.SessionId,
                    CinemaId = item.Session.CinemaId,
                    SessionDateTime = item.Session.DateTime,
                    DayOfWeek = item.Session.DateTime.DayOfWeek.ToString(),
                    CinemaName = item.Session.Cinema.Name,
                    ScreenName = item.Session.Screen.Name,
                    MovieTitle = item.Session.MovieInstance.MovieDetail.Title,
                    KTixPriceGroupId = item.KtixPriceGroupId,
                    PriceGroup = item.KtixPriceGroup.Name,
                    PosterURL = posterURL,
                    RunningTimeInMin = item.Session.MovieInstance.MovieDetail.RunningTime.ToString(),
                    RatingName = item.Session.MovieInstance.MovieDetail.Rating.Name,
                    IsCancelled = item.IsCancelled,
                    IsSoldOut = isSO,
                    Codes = outputcodes,
                    ScreenTotalSeats = totalSessionSeats.ToString(),
                    SessionAvaliableSeats = liveRemainingSeats.ToString()
                });
            }

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();

            }

        }

        [HttpGet("GetComboTicketsBySession")]
        // [Authorize]
        public async Task<IActionResult> GetComboTicketsBySession(long sessionId)
        {

            var pgquery = from pg in _context.Ktixsession
                          where pg.SessionId == sessionId
                          select pg.KtixPriceGroupId;

            var pgresults = pgquery.FirstOrDefault();


            var comboQuery = from s in _context.Ktixpricegroupcomboitems
                             where s.KtixPriceGroupId == pgresults
                             select s;

            var tickets = await comboQuery.Select(x => new ComboTicketsBySessionDTO()
            {
                KTixPriceGroupComboItemId = x.KtixPriceGroupComboItemId,
                KTixComboItemId = x.KtixComboItemId,
                KTixComboItemName = x.KtixComboItem.Name,
                DisplayOrder = x.DisplayOrder,
                Price = x.Price,
                IsAvaliable = true,
                IsSoldout = false
            }).ToListAsync();

            if (tickets != null)
            {
                return Ok(tickets);
            }
            else
            {
                return NotFound();

            }
        }


        [HttpGet("GetTicketsBySession")]
        // [Authorize]
        public async Task<IActionResult> GetTicketsBySession(long sessionId)
        {

            var pgquery = from pg in _context.Ktixsession
                          where pg.SessionId == sessionId
                          select pg.KtixPriceGroupId;

            var pgresults = pgquery.FirstOrDefault();

            var query = from s in _context.Ktixpricegroupsaleitems
                        where s.KtixPriceGroupId == pgresults
                        && s.IsListed == true
                        && s.KtixSaleItem.IsTicket == true
                        orderby s.DisplayOrder, s.KtixSaleItem.Name
                        select s;
  
            var tickets = await query.Select(x => new TicketsBySessionDTO()
            {
                KTixPriceGroupSaleItemId = x.KtixPriceGroupSaleItemId,
                KTixSaleItemId = x.KtixSaleItemId,
                KTixSaleItemName = x.KtixSaleItem.Name,
                DisplayOrder = x.DisplayOrder,
                Price = x.Price,
                IsAvaliable = x.IsAvaliableForPOS,
                IsSoldout = false
            }).ToListAsync();

            if (tickets != null)
            {
                return Ok(tickets);
            }
            else
            {
                return NotFound();

            }
        }

        [HttpGet("GetProductsBySession")]
        // [Authorize]
        public async Task<IActionResult> GetProductsBySession(long sessionId)
        {
            var pgquery = from pg in _context.Ktixsession
                          where pg.SessionId == sessionId
                          select pg.KtixPriceGroupId;

            var pgresults = pgquery.FirstOrDefault();

            var query = from s in _context.Ktixpricegroupsaleitems
                        where s.KtixPriceGroupId == pgresults
                        && s.IsListed == true
                        && s.KtixSaleItem.IsTicket == false
                        && s.IsAvaliableForPOS == true
                        orderby s.KtixSaleItem.KtixItemGroup.Name, s.DisplayOrder, s.KtixSaleItem.Name
                        select s;

            var products = await query.Select(x => new ProductsBySessionDTO()
            {
                KTixPriceGroupSaleItemId = x.KtixPriceGroupSaleItemId,
                KTixSaleItemId = x.KtixSaleItemId,
                KTixSaleItemName = x.KtixSaleItem.Name,
                DisplayOrder = x.DisplayOrder,
                Price = x.Price,
                IsAvaliable = x.IsAvaliableForPOS,
                IsSoldout = false
            }).ToListAsync();

            if (products != null)
            {
                return Ok(products);
            }
            else
            {
                return NotFound();

            }
        }

        public int CountTicketsSoldForSession(long KtixSessionId)
        {
            int counter = 0;

            //get all bookings sold online or by POS
            var q = from r in _context.Ktixbooking
                    where r.KtixSessionId == KtixSessionId
                    && r.IsCommitted == true
                    select r;

            var bookingList = q.ToList();
            if (bookingList.Count() > 0)
            {
                //get numbers of tickets sold per booking
                foreach (var thisBooking in bookingList)
                {
                    counter += GetNumberOfTicketsInBooking(thisBooking.KtixBookingId);
                }
            }
            return counter;
        }

        public int GetNumberOfTicketsInBooking(Guid kTixBookingId)
        {
            int numberOfTickets = 0;

            //get number of individual tickets
            var result = from o in _context.Ktixbookingsaleitems
                         where o.KtixBookingId == kTixBookingId &&
                               o.KtixPriceGroupSaleItem.KtixSaleItem.IsTicket == true
                         select o;
            numberOfTickets = result.Count();

            // get number combo items that contain single items.
            var comboResult = from o in _context.Ktixbookingcomboitems
                              where o.KtixBookingId == kTixBookingId
                              select o;

            foreach (var cbi in comboResult.ToList())
            {
                numberOfTickets += CountNumberOfTicketsInComboItem(cbi.KtixPriceGroupComboItem.KtixComboItemId);
            }

            return numberOfTickets;
        }

        public int CountNumberOfTicketsInComboItem(Guid kTixComboItemId)
        {
            int numberOfTickets = 0;
            IList<Ktixcomboitemsaleitems> saleItemList = GetSaleItems(kTixComboItemId);

            foreach (var thisSaleItem in saleItemList)
            {
                var q = from r in _context.Ktixsaleitem
                        where r.KtixSaleItemId == thisSaleItem.KtixSaleItemId
                        select r;

                var item = q.FirstOrDefault();
                if (item.IsTicket == true)
                {
                    numberOfTickets += thisSaleItem.Quantity;
                }
            }

            return numberOfTickets;
        }

        public IList<Ktixcomboitemsaleitems> GetSaleItems(Guid kTixComboItemId)
        {
            var result = from o in _context.Ktixcomboitemsaleitems
                         where o.KtixComboItemId == kTixComboItemId
                         select o;
            return result.ToList();
        }


        public int GetNumberOfTicketsOnHoldInCartForPOS(Guid KtixSettingId, long sessionId)
        {
            int numberOfTickets = 0;

            var query = from r in _context.Ktixtransactioncartitems
                        where r.SessionId == sessionId
                        select r;

            var result = query.ToList();

            if (result.Count() > 0)
            {
                foreach (var thisCartItem in result)
                {
                    var q = from r in _context.Ktixmastertransaction
                            where r.KtixTransactionCartId == thisCartItem.KtixTransactionCart.KtixTransactionCartId
                            select r;

                    var thismastertransaction = q.FirstOrDefault();

                    if (thismastertransaction != null)
                    {
                        //check if the master transaction of the cart has already been paid
                        var tmp = from t in _context.Ktixmasterpaymenttype
                                  where t.KtixMasterTransactionId == thismastertransaction.KtixMasterTransactionId
                                  select t;
                        var HasPaymentType = tmp.FirstOrDefault();

                        //if item in cart is not commited/has payment then add item to counter
                        //cart can be processed but still waiting for payment.
                        if (HasPaymentType == null && thismastertransaction.IsRefunded == false)
                        {
                            numberOfTickets += thisCartItem.Quantity;
                        }


                    }


                }


            }
            return numberOfTickets;
        }
    }
}
