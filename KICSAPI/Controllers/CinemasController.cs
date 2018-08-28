using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KICSAPI.Models;

namespace KICSAPI.Controllers
{
    public class CinemasController : Controller
    {
        private readonly KICSDEVContext _context;

        public CinemasController(KICSDEVContext context)
        {
            _context = context;
        }

        // GET: Cinemas
        public async Task<IActionResult> Index()
        {
            var kICSDEVContext = _context.Cinema.Include(c => c.Company).Include(c => c.CountryState).Include(c => c.Crmtype).Include(c => c.InternetTicketingType).Include(c => c.MemberType).Include(c => c.NowShowingQueryMethod).Include(c => c.PointOfSaleType).Include(c => c.SessionRestrictUntilTime);
            return View(await kICSDEVContext.ToListAsync());
        }

        // GET: GetCinemasForCompany
        public IEnumerable<CompanyCinemasDTO> GetActiveCinemasForCompany(Guid companyId)
        {

            var query = from p in _context.Cinema
                        where p.CompanyId == companyId
                        && p.IsDeleted == false
                        select p;

            var cinemas = query.Select(x => new CompanyCinemasDTO()
            {
                CinemaId = x.CinemaId,
                Name = x.Name,
            }).ToList();

            return cinemas;
        }

        public IEnumerable<CinemaNameDTO> GetCinemaByName(Guid cinemaId)
        {
            //if (companyId == null)
            //{
            //    return NotFound();
            //}

            var query = from p in _context.Cinema
                        where p.CinemaId == cinemaId
                        select p;

            var company = query.Select(x => new CinemaNameDTO()
            {
                CinemaId = x.CompanyId,
                Name = x.Name,
            }).ToList();

            return company;
        }


        // GET: Cinemas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinema
                .Include(c => c.Company)
                .Include(c => c.CountryState)
                .Include(c => c.Crmtype)
                .Include(c => c.InternetTicketingType)
                .Include(c => c.MemberType)
                .Include(c => c.NowShowingQueryMethod)
                .Include(c => c.PointOfSaleType)
                .Include(c => c.SessionRestrictUntilTime)
                .SingleOrDefaultAsync(m => m.CinemaId == id);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinema);
        }

        // GET: Cinemas/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1");
            ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation");
            ViewData["CrmtypeId"] = new SelectList(_context.Crmtype, "CrmtypeId", "Name");
            ViewData["InternetTicketingTypeId"] = new SelectList(_context.Internetticketingtype, "InternetTicketingTypeId", "Name");
            ViewData["MemberTypeId"] = new SelectList(_context.Membertype, "MemberTypeId", "CreateAccountTitle");
            ViewData["NowShowingQueryMethodId"] = new SelectList(_context.Nowshowingquerymethod, "NowShowingQueryMethodId", "Description");
            ViewData["PointOfSaleTypeId"] = new SelectList(_context.Pointofsaletype, "PointOfSaleTypeId", "Name");
            ViewData["SessionRestrictUntilTimeId"] = new SelectList(_context.Time, "TimeId", "TimeId");
            return View();
        }

        // POST: Cinemas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CinemaId,CompanyId,Name,Address1,Address2,City,Postcode,Phone,BookingPhone,WebsiteUrl,PointOfSaleId,IsOnlineTicketing,SessionImportEmail,AdministrationEmail,TimeZoneLocationId,IsDeleted,PointOfSaleTypeId,InternetTicketingTypeId,CountryStateId,IsIgnoreScreenErrorsOnImport,LoyaltyPointOfSaleId,SessionNumberOfDaysLimit,SessionRestrictUntilTimeId,CrmtypeId,IsImportSessionsAutomatically,ShortName,NowShowingQueryMethodId,NowShowingCacheExpiryDateTime,FacebookPageUrl,TwitterPageUrl,AppStoreUrl,GooglePlayUrl,MovieTimesComAuUserName,MovieTimesComAuPassword,MovieTimesComAuCinemaName,MobileAppDescription,Latitude,Longitude,InstagramPageUrl,MemberTypeId,AllowMultipleSeatsPerTickets,AllowReDshieldFraudProtection")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                cinema.CinemaId = Guid.NewGuid();
                _context.Add(cinema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", cinema.CompanyId);
            ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation", cinema.CountryStateId);
            ViewData["CrmtypeId"] = new SelectList(_context.Crmtype, "CrmtypeId", "Name", cinema.CrmtypeId);
            ViewData["InternetTicketingTypeId"] = new SelectList(_context.Internetticketingtype, "InternetTicketingTypeId", "Name", cinema.InternetTicketingTypeId);
            ViewData["MemberTypeId"] = new SelectList(_context.Membertype, "MemberTypeId", "CreateAccountTitle", cinema.MemberTypeId);
            ViewData["NowShowingQueryMethodId"] = new SelectList(_context.Nowshowingquerymethod, "NowShowingQueryMethodId", "Description", cinema.NowShowingQueryMethodId);
            ViewData["PointOfSaleTypeId"] = new SelectList(_context.Pointofsaletype, "PointOfSaleTypeId", "Name", cinema.PointOfSaleTypeId);
            ViewData["SessionRestrictUntilTimeId"] = new SelectList(_context.Time, "TimeId", "TimeId", cinema.SessionRestrictUntilTimeId);
            return View(cinema);
        }

        // GET: Cinemas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinema.SingleOrDefaultAsync(m => m.CinemaId == id);
            if (cinema == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", cinema.CompanyId);
            ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation", cinema.CountryStateId);
            ViewData["CrmtypeId"] = new SelectList(_context.Crmtype, "CrmtypeId", "Name", cinema.CrmtypeId);
            ViewData["InternetTicketingTypeId"] = new SelectList(_context.Internetticketingtype, "InternetTicketingTypeId", "Name", cinema.InternetTicketingTypeId);
            ViewData["MemberTypeId"] = new SelectList(_context.Membertype, "MemberTypeId", "CreateAccountTitle", cinema.MemberTypeId);
            ViewData["NowShowingQueryMethodId"] = new SelectList(_context.Nowshowingquerymethod, "NowShowingQueryMethodId", "Description", cinema.NowShowingQueryMethodId);
            ViewData["PointOfSaleTypeId"] = new SelectList(_context.Pointofsaletype, "PointOfSaleTypeId", "Name", cinema.PointOfSaleTypeId);
            ViewData["SessionRestrictUntilTimeId"] = new SelectList(_context.Time, "TimeId", "TimeId", cinema.SessionRestrictUntilTimeId);
            return View(cinema);
        }

        // POST: Cinemas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CinemaId,CompanyId,Name,Address1,Address2,City,Postcode,Phone,BookingPhone,WebsiteUrl,PointOfSaleId,IsOnlineTicketing,SessionImportEmail,AdministrationEmail,TimeZoneLocationId,IsDeleted,PointOfSaleTypeId,InternetTicketingTypeId,CountryStateId,IsIgnoreScreenErrorsOnImport,LoyaltyPointOfSaleId,SessionNumberOfDaysLimit,SessionRestrictUntilTimeId,CrmtypeId,IsImportSessionsAutomatically,ShortName,NowShowingQueryMethodId,NowShowingCacheExpiryDateTime,FacebookPageUrl,TwitterPageUrl,AppStoreUrl,GooglePlayUrl,MovieTimesComAuUserName,MovieTimesComAuPassword,MovieTimesComAuCinemaName,MobileAppDescription,Latitude,Longitude,InstagramPageUrl,MemberTypeId,AllowMultipleSeatsPerTickets,AllowReDshieldFraudProtection")] Cinema cinema)
        {
            if (id != cinema.CinemaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cinema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinemaExists(cinema.CinemaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", cinema.CompanyId);
            ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation", cinema.CountryStateId);
            ViewData["CrmtypeId"] = new SelectList(_context.Crmtype, "CrmtypeId", "Name", cinema.CrmtypeId);
            ViewData["InternetTicketingTypeId"] = new SelectList(_context.Internetticketingtype, "InternetTicketingTypeId", "Name", cinema.InternetTicketingTypeId);
            ViewData["MemberTypeId"] = new SelectList(_context.Membertype, "MemberTypeId", "CreateAccountTitle", cinema.MemberTypeId);
            ViewData["NowShowingQueryMethodId"] = new SelectList(_context.Nowshowingquerymethod, "NowShowingQueryMethodId", "Description", cinema.NowShowingQueryMethodId);
            ViewData["PointOfSaleTypeId"] = new SelectList(_context.Pointofsaletype, "PointOfSaleTypeId", "Name", cinema.PointOfSaleTypeId);
            ViewData["SessionRestrictUntilTimeId"] = new SelectList(_context.Time, "TimeId", "TimeId", cinema.SessionRestrictUntilTimeId);
            return View(cinema);
        }

        // GET: Cinemas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinema
                .Include(c => c.Company)
                .Include(c => c.CountryState)
                .Include(c => c.Crmtype)
                .Include(c => c.InternetTicketingType)
                .Include(c => c.MemberType)
                .Include(c => c.NowShowingQueryMethod)
                .Include(c => c.PointOfSaleType)
                .Include(c => c.SessionRestrictUntilTime)
                .SingleOrDefaultAsync(m => m.CinemaId == id);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinema);
        }

        // POST: Cinemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cinema = await _context.Cinema.SingleOrDefaultAsync(m => m.CinemaId == id);
            _context.Cinema.Remove(cinema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CinemaExists(Guid id)
        {
            return _context.Cinema.Any(e => e.CinemaId == id);
        }
    }
}
