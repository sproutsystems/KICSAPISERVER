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
    public class CinemaController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public CinemaController(KICSDEVContext context)
        {
            _context = context;
        }

        [HttpGet("GetActiveCinemasForCompany")]
        //[Authorize]
        public async Task<IActionResult> GetActiveCinemasForCompany(Guid companyId)
        {

            var query = from p in _context.Cinema
                        where p.CompanyId == companyId
                        && p.IsDeleted == false
                        select p;

            var cinemas = await query.Select(x => new CompanyCinemasDTO()
            {
                CinemaId = x.CinemaId,
                Name = x.Name
            }).ToListAsync();

            if (cinemas != null || cinemas.Count() > 0)
            {
                return Ok(cinemas);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetCinemaById")]
       // [Authorize]
        public async Task<IActionResult> GetCinemaById(Guid cinemaId)
        {
            var query = from p in _context.Cinema
                        where p.CinemaId == cinemaId
                        select p;

            var cinema = await query.Select(x => new CinemaNameDTO()
            {
                CinemaId = x.CompanyId,
                Name = x.Name,
                TimeZoneLocationID = x.TimeZoneLocationId,
                LogoUrl = x.WebsiteUrl + "/images/receiptLogo.png",
                Address = x.Address1 + " " + x.Address2 + " " + x.City + ", " + x.Postcode
            }).ToListAsync();

            if (cinema != null || cinema.Count() > 0)
            {
                return Ok(cinema);
            }
            else
            {
                return NotFound();
            }
        }
    

        [HttpGet("GetPaymentGatewayCredentials")]
       // [Authorize]
        public async Task<IActionResult> GetPaymentGatewayCredentials(Guid cinemaId)
        {
            var result = new List<CinemaPaymentGatewayDTO>();
            var query = from s in _context.Cinemapaymentgateway
               .Where(s => s.CinemaId == cinemaId)
                     .Include("PaymentGateway")
                        select s;

            var list = await query.ToListAsync();
            foreach (var item in list)
            {

                string URL = item.PaymentGateway.Address;
                if (item.IsTesting == true)
                {
                    URL = item.PaymentGateway.TestingAddress;
                }
                         
                result.Add(new CinemaPaymentGatewayDTO()
                {
                    CinemaId = item.CinemaId,
                    PaymentGatewayName = item.PaymentGateway.Name,
                    Credential1 = item.Credential1,
                    Credential2 = item.Credential2,
                    Credential3 = item.Credential3,
                    Credential4 = item.Credential4,
                    Credential5 = item.Credential5,
                    IsTesting = item.IsTesting,
                    GatewayURL = URL
                });
            }

            if (result != null || result.Count() > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetRecieptTemplate")]
       // [Authorize]
        public async Task<IActionResult> GetRecieptTemplate()
        {
            var q = from x in _context.Htmltemplate
                    orderby x.HtmltemplateId
                    select x;

            var r = await q.FirstOrDefaultAsync();

            string htmlcode = r.PosReceiptTemplate;

            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK,
                Content = htmlcode
            };
        }

        [HttpGet("GetTicketTemplate")]
       // [Authorize]
        public async Task<IActionResult> GetTicketTemplate()
        {
            var q = from x in _context.Htmltemplate
                    orderby x.HtmltemplateId
                    select x;

            var r = await q.FirstOrDefaultAsync();

            string htmlcode = r.PosTicketTemplate;

            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK,
                Content = htmlcode
            };

        }
    }
}
