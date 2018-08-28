using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KICSAPIServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace KICSAPIServer.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public CompaniesController(KICSDEVContext context)
        {
            _context = context;
        }


        [HttpGet("TestAPI")]
        [Authorize]
        public async Task<IActionResult> TestAPI()
        {
            return Ok("Hello world");

        }
        [HttpGet("GetActiveCompanies")]
       // [Authorize]
        //[HttpGet("GetActiveCompanies"), Authorize]
        public async Task<IActionResult> GetActiveCompanies()
        {
            var query = from p in _context.Company
                        where p.IsActive == true &&
                        p.IsDeleted == false &&
                        _context.Cinema.Any
                                        (bc => bc.CompanyId == p.CompanyId
                                         && bc.InternetTicketingTypeId == 9 && bc.PointOfSaleTypeId == 1)
                        select p;

            var companies = await query.Select(x => new CompanyDTO()
            {
                CompanyId = x.CompanyId,
                NameForDisplay = x.NameForDisplay,
                WebsiteURL = x.WebsiteUrl,
                City = x.City,
                Postcode = x.Postcode
            }).ToListAsync();

            if (companies != null)
            {
                return Ok(companies);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getCompanyNameById")]
       // [Authorize]
        public async Task<IActionResult> GetCompanyByName(Guid companyId)
        {
            var q2 = from h in _context.Ktixsetting
                     where h.CompanyId.Equals(companyId)
                     select h;

            var company = await q2.Select(x => new CompanyNameDTO()
            {
                CompanyId = x.CompanyId,
                NameForDisplay = x.Company.NameForDisplay,
                KTixSettingId = x.KtixSettingId

            }).ToListAsync();

            if (company != null)
            {
                return Ok(company);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
