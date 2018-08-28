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
                    Codes = outputcodes
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
    }
}
