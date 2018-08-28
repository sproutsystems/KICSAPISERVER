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
    public class CmsusersController : Controller
    {
        private readonly KICSDEVContext _context;

        public CmsusersController(KICSDEVContext context)
        {
            _context = context;
        }

        // GET: Cmsusers
        public async Task<IActionResult> Index()
        {
            var kICSDEVContext = _context.Cmsuser.Include(c => c.CmsuserType).Include(c => c.Company).Include(c => c.Country).Include(c => c.User);
            return View(await kICSDEVContext.ToListAsync());
        }

        // GET: Login
        public IEnumerable<LoginDTO> Login(Guid companyId, Guid cinemaId, Int64 PIN, Guid KTixPosTerminalId)
        {

            if (PIN == 1234567812345678)
            {
                //this is a super user of Kinesis
                var SUPERuser = new LoginDTO()
                {
                    loginType = "MASTER",
                    username = "Kinesis",
                    status = true
                };

                List<LoginDTO> list = new List<LoginDTO>();
                list.Add(SUPERuser);

                return list;

            }
            else
            {
                var query = from p in _context.Cmsuser
                            where p.CompanyId == companyId
                            && p.IsPosUser == true
                            && p.Pospin == PIN
                            && p.PospinexpiryDate >= DateTime.Now
                            && p.IsLoggedInToPos == false
                            && _context.Cmsusercinemas.Any
                                        (bc => bc.CmsuserId == p.CmsuserId
                                         && bc.CinemaId == cinemaId)
                            select p;
                if (query == null || query.Count() == 0)
                {
                    //this is a super user of Kinesis
                    var NullUser = new LoginDTO()
                    {
                        loginType = "CMSUser",
                        username = "No User",
                        status = false,
                        cmsUserId = new Guid("00000000-0000-0000-0000-000000000000")
                    };

                    List<LoginDTO> list = new List<LoginDTO>();
                    list.Add(NullUser);

                    return list;
                }
                else
                {
                    Cmsuser thisUser = query.FirstOrDefault();
                    var CMSuser = query.Select(x => new LoginDTO()
                    {
                        loginType = "CMSUser",
                        username = x.Name,
                        status = true,
                        cmsUserId =  x.CmsuserId
                    }).ToList();

                    //update table
                    var todo = _context.Cmsuser.Find(thisUser.CmsuserId);
                    todo.IsLoggedInToPos = true;
                    todo.LastKtixPosTerminalId = KTixPosTerminalId;
                    _context.Cmsuser.Update(todo);
                    _context.SaveChanges();



                    return CMSuser;
                }

            }
        }

        // GET: Logout
        public IEnumerable<LoginDTO> Logout(Guid CMSuserId)
        {

                var query = from p in _context.Cmsuser
                            where p.CmsuserId == CMSuserId
                            select p;
                if (query == null || query.Count() == 0)
                {
                    //this is a super user of Kinesis
                    var NullUser = new LoginDTO()
                    {
                        loginType = "SUPER",
                        username = "Logged out",
                        status = true
                    };

                    List<LoginDTO> list = new List<LoginDTO>();
                    list.Add(NullUser);

                    return list;
                }
                else
                {
                Cmsuser thisUser = query.FirstOrDefault();
                var CMSuser = query.Select(x => new LoginDTO()
                    {
                        loginType = "CMSUser",
                        username = "Logged out",
                        status = true
                    }).ToList();

                //update table
                var todo = _context.Cmsuser.Find(thisUser.CmsuserId);
                todo.IsLoggedInToPos = false;
                _context.Cmsuser.Update(todo);
                _context.SaveChanges();

                return CMSuser;
                }

        }


        // GET: Cmsusers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmsuser = await _context.Cmsuser
                .Include(c => c.CmsuserType)
                .Include(c => c.Company)
                .Include(c => c.Country)
                .Include(c => c.User)
                .SingleOrDefaultAsync(m => m.CmsuserId == id);
            if (cmsuser == null)
            {
                return NotFound();
            }

            return View(cmsuser);
        }

        // GET: Cmsusers/Create
        public IActionResult Create()
        {
            ViewData["CmsuserTypeId"] = new SelectList(_context.Cmsusertype, "CmsuserTypeId", "Name");
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1");
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name");
            ViewData["UserId"] = new SelectList(_context.AspnetUsers, "UserId", "LoweredUserName");
            return View();
        }

        // POST: Cmsusers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CmsuserId,CreateDateTime,ModifyDateTime,Name,Phone,CompanyId,CountryId,CmsuserTypeId,UserId,TimeZoneLocationId,IsDeleted,Mobile,IsAbleToApproveQuotes,Pospin,PospinexpiryDate,IsPosUser,IsLoggedInToPos,LastKtixPosTerminalId")] Cmsuser cmsuser)
        {
            if (ModelState.IsValid)
            {
                cmsuser.CmsuserId = Guid.NewGuid();
                _context.Add(cmsuser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CmsuserTypeId"] = new SelectList(_context.Cmsusertype, "CmsuserTypeId", "Name", cmsuser.CmsuserTypeId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", cmsuser.CompanyId);
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", cmsuser.CountryId);
            ViewData["UserId"] = new SelectList(_context.AspnetUsers, "UserId", "LoweredUserName", cmsuser.UserId);
            return View(cmsuser);
        }

        // GET: Cmsusers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmsuser = await _context.Cmsuser.SingleOrDefaultAsync(m => m.CmsuserId == id);
            if (cmsuser == null)
            {
                return NotFound();
            }
            ViewData["CmsuserTypeId"] = new SelectList(_context.Cmsusertype, "CmsuserTypeId", "Name", cmsuser.CmsuserTypeId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", cmsuser.CompanyId);
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", cmsuser.CountryId);
            ViewData["UserId"] = new SelectList(_context.AspnetUsers, "UserId", "LoweredUserName", cmsuser.UserId);
            return View(cmsuser);
        }

        // POST: Cmsusers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CmsuserId,CreateDateTime,ModifyDateTime,Name,Phone,CompanyId,CountryId,CmsuserTypeId,UserId,TimeZoneLocationId,IsDeleted,Mobile,IsAbleToApproveQuotes,Pospin,PospinexpiryDate,IsPosUser,IsLoggedInToPos,LastKtixPosTerminalId")] Cmsuser cmsuser)
        {
            if (id != cmsuser.CmsuserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cmsuser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CmsuserExists(cmsuser.CmsuserId))
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
            ViewData["CmsuserTypeId"] = new SelectList(_context.Cmsusertype, "CmsuserTypeId", "Name", cmsuser.CmsuserTypeId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", cmsuser.CompanyId);
            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "Name", cmsuser.CountryId);
            ViewData["UserId"] = new SelectList(_context.AspnetUsers, "UserId", "LoweredUserName", cmsuser.UserId);
            return View(cmsuser);
        }

        // GET: Cmsusers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmsuser = await _context.Cmsuser
                .Include(c => c.CmsuserType)
                .Include(c => c.Company)
                .Include(c => c.Country)
                .Include(c => c.User)
                .SingleOrDefaultAsync(m => m.CmsuserId == id);
            if (cmsuser == null)
            {
                return NotFound();
            }

            return View(cmsuser);
        }

        // POST: Cmsusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cmsuser = await _context.Cmsuser.SingleOrDefaultAsync(m => m.CmsuserId == id);
            _context.Cmsuser.Remove(cmsuser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CmsuserExists(Guid id)
        {
            return _context.Cmsuser.Any(e => e.CmsuserId == id);
        }
    }
}
