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
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public CompaniesController(KICSDEVContext context)
        {
            _context = context;
        }

      
        //public async Task<IActionResult> Index()
        //{
        //    var kICSDEVContext = _context.Company.Include(c => c.Country).Include(c => c.CountryState).Include(c => c.Day);
        //    return View(await kICSDEVContext.ToListAsync());
        //}


        // GET: ActiveCompaniesWithKtix
        public IEnumerable<CompanyDTO> GetActiveCompanies()
        {
            var query = from p in _context.Company
                        where p.IsActive == true &&
                        p.IsDeleted == false &&   
                        _context.Cinema.Any
                                        (bc => bc.CompanyId == p.CompanyId
                                         && bc.InternetTicketingTypeId == 9 && bc.PointOfSaleTypeId == 1)
                        select p;

            var companies = query.Select(x => new CompanyDTO()
            {
                CompanyId = x.CompanyId,
                NameForDisplay = x.NameForDisplay,
                WebsiteURL = x.WebsiteUrl,
                City = x.City,
                Postcode = x.Postcode
            }).ToList();

            return companies;
        }

        public IEnumerable<CompanyNameDTO> GetCompanyByName(Guid companyId)
        {
            //if (companyId == null)
            //{
            //    return NotFound();
            //}

            var query = from p in _context.Company
                        where p.CompanyId == companyId
                        select p;

            var company = query.Select(x => new CompanyNameDTO()
            {
                CompanyId = x.CompanyId,
                NameForDisplay = x.NameForDisplay,
            }).ToList();

            return company;
        }

        //// GET: Companies/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Company
        //        .Include(c => c.Country)
        //        .Include(c => c.CountryState)
        //        .Include(c => c.Day)
        //        .SingleOrDefaultAsync(m => m.CompanyId == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(company);
        //}

        //// GET: Companies/Create
        //public IActionResult Create()
        //{
        //    ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name");
        //    ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation");
        //    ViewData["DayId"] = new SelectList(_context.Day, "DayId", "Name");
        //    return View();
        //}

        //// POST: Companies/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("CompanyId,Name,Address1,Address2,City,Postcode,Phone,WebsiteUrl,CountryId,CompanyNumber,NameForDisplay,AdministrationEmail,BillingNameOfStaff,BillingAddress1,BillingAddress2,BillingCity,BillingPostcode,BillingState,BillingPhone,BillingEmail,IsActive,IsBillingActive,IsDeleted,AdditionalCinemaAdjustmentPercentage,CreateDateTime,ModifyDateTime,CountryStateId,DayId,TimeZoneLocationId,IsUpdateReleaseDateDefault,IsUpdateLabelsDefault,IsUpdatePointOfSaleTitleDefault,SaasuContactUid,PaymentTerms,IsMemberPurchaseHistoryAvailable,SmssenderName,InitialFreePeriodEndDate,SmsratePerMessageBilledToCompany,MessageGearsAccountId,MessageGearsApikey,IsSendUsingMessageGears,IsShowOverdueWarning,IsRestrictedAccess,IsApplyTestCode,FlagCacheExpiryDateTime,PurgeDeletedMembersAfterHowManyDays,BulkSmscreditLimit")] Company company)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        company.CompanyId = Guid.NewGuid();
        //        _context.Add(company);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", company.CountryId);
        //    ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation", company.CountryStateId);
        //    ViewData["DayId"] = new SelectList(_context.Day, "DayId", "Name", company.DayId);
        //    return View(company);
        //}


        //// GET: Companies/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Company.SingleOrDefaultAsync(m => m.CompanyId == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", company.CountryId);
        //    ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation", company.CountryStateId);
        //    ViewData["DayId"] = new SelectList(_context.Day, "DayId", "Name", company.DayId);
        //    return View(company);
        //}

        //// POST: Companies/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("CompanyId,Name,Address1,Address2,City,Postcode,Phone,WebsiteUrl,CountryId,CompanyNumber,NameForDisplay,AdministrationEmail,BillingNameOfStaff,BillingAddress1,BillingAddress2,BillingCity,BillingPostcode,BillingState,BillingPhone,BillingEmail,IsActive,IsBillingActive,IsDeleted,AdditionalCinemaAdjustmentPercentage,CreateDateTime,ModifyDateTime,CountryStateId,DayId,TimeZoneLocationId,IsUpdateReleaseDateDefault,IsUpdateLabelsDefault,IsUpdatePointOfSaleTitleDefault,SaasuContactUid,PaymentTerms,IsMemberPurchaseHistoryAvailable,SmssenderName,InitialFreePeriodEndDate,SmsratePerMessageBilledToCompany,MessageGearsAccountId,MessageGearsApikey,IsSendUsingMessageGears,IsShowOverdueWarning,IsRestrictedAccess,IsApplyTestCode,FlagCacheExpiryDateTime,PurgeDeletedMembersAfterHowManyDays,BulkSmscreditLimit")] Company company)
        //{
        //    if (id != company.CompanyId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(company);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CompanyExists(company.CompanyId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", company.CountryId);
        //    ViewData["CountryStateId"] = new SelectList(_context.Countrystate, "CountryStateId", "Abbreviation", company.CountryStateId);
        //    ViewData["DayId"] = new SelectList(_context.Day, "DayId", "Name", company.DayId);
        //    return View(company);
        //}

        //// GET: Companies/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Company
        //        .Include(c => c.Country)
        //        .Include(c => c.CountryState)
        //        .Include(c => c.Day)
        //        .SingleOrDefaultAsync(m => m.CompanyId == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(company);
        //}

        //// POST: Companies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var company = await _context.Company.SingleOrDefaultAsync(m => m.CompanyId == id);
        //    _context.Company.Remove(company);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool CompanyExists(Guid id)
        {
            return _context.Company.Any(e => e.CompanyId == id);
        }
    }
}
