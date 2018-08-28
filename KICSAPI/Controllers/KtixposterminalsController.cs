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
    public class KtixposterminalsController : Controller
    {
        private readonly KICSDEVContext _context;

        public KtixposterminalsController(KICSDEVContext context)
        {
            _context = context;
        }

        // GET: Ktixposterminals
        public async Task<IActionResult> Index()
        {
            var kICSDEVContext = _context.Ktixposterminal.Include(k => k.Cinema).Include(k => k.Company).Include(k => k.KtixPosUseType);
            return View(await kICSDEVContext.ToListAsync());
        }

        public IEnumerable<KtixPosTerminalDTO> GetPosTerminalDetails(Guid KTixPosTerminalId)
        {


            var query = from p in _context.Ktixposterminal
                        where p.KtixPosTerminalId == KTixPosTerminalId
                        select p;

            var pos = query.Select(x => new KtixPosTerminalDTO()
            {
                KTixPosTerminalId = x.KtixPosTerminalId,
                KTixPosUseTypeId = x.KtixPosUseTypeId,
                KTixDescription = x.KtixDescription,
                companyId = x.CompanyId,
                cinemaId = x.CinemaId,
                DeviceName = x.DeviceName,
                DeviceId = x.DeviceId,
                DeviceModel = x.DeviceModel,
                IPAddress = x.Ipaddress,
                APIEndPoint = x.ApiendPoint
            }).ToList();

            return pos;
        }

        //KtixPosTerminalId,KtixPosUseTypeId,KtixDescription,CompanyId,CinemaId,DeviceName,DeviceId,DeviceModel,Ipaddress,ApiendPoint
        public IEnumerable<KtixPosTerminalDTO> UpdateOrCreatePosTerminal(Guid KTixPosTerminalId,int KtixPosUseTypeId,String KtixDescription,Guid CompanyId,Guid CinemaId, String DeviceName, String DeviceId, String DeviceModel, String Ipaddress, String ApiendPoint)
        {
            var query = from p in _context.Ktixposterminal
                        where p.KtixPosTerminalId == KTixPosTerminalId
                        select p;
            if (query == null || query.Count() == 0)
            {
                //create a new record
                Ktixposterminal newTerminal = new Ktixposterminal()
                {
                    KtixPosTerminalId = Guid.NewGuid(),
                    KtixPosUseTypeId = KtixPosUseTypeId,
                    KtixDescription = KtixDescription,
                    CompanyId = CompanyId,
                    CinemaId = CinemaId,
                    DeviceName = DeviceName,
                    DeviceId = DeviceId,
                    DeviceModel = DeviceModel,
                    Ipaddress = Ipaddress,
                    ApiendPoint = ApiendPoint
                };
                
                _context.Add(newTerminal);
                _context.SaveChanges();


                //returm DTO object back
                List<KtixPosTerminalDTO> Poslist = new List<KtixPosTerminalDTO>();

                var pos = new KtixPosTerminalDTO()
                {
                    KTixPosTerminalId = newTerminal.KtixPosTerminalId,
                    KTixPosUseTypeId = newTerminal.KtixPosUseTypeId,
                    KTixDescription = newTerminal.KtixDescription,
                    companyId = newTerminal.CompanyId,
                    cinemaId = newTerminal.CinemaId,
                    DeviceName = newTerminal.DeviceName,
                    DeviceId = newTerminal.DeviceId,
                    DeviceModel = newTerminal.DeviceModel,
                    IPAddress = newTerminal.Ipaddress,
                    APIEndPoint = newTerminal.ApiendPoint
                };

                Poslist.Add(pos);
                return Poslist;


            }
            //update
            else
            {

                //update object
                Ktixposterminal thisTerminal = query.FirstOrDefault();
                var todo = _context.Ktixposterminal.Find(thisTerminal.KtixPosTerminalId);

                todo.KtixPosUseTypeId = KtixPosUseTypeId;
                todo.KtixDescription = KtixDescription;
                todo.CompanyId = CompanyId;
                todo.CinemaId = CinemaId;
                todo.DeviceName = DeviceName;
                todo.DeviceId = DeviceId;
                todo.DeviceModel = DeviceModel;
                todo.Ipaddress = Ipaddress;
                todo.ApiendPoint = ApiendPoint;
                _context.Ktixposterminal.Update(todo);
                _context.SaveChanges();

                //returm DTO object back
                var pos = query.Select(x => new KtixPosTerminalDTO()
                {
                    KTixPosTerminalId = x.KtixPosTerminalId,
                    KTixPosUseTypeId = x.KtixPosUseTypeId,
                    KTixDescription = x.KtixDescription,
                    companyId = x.CompanyId,
                    cinemaId = x.CinemaId,
                    DeviceName = x.DeviceName,
                    DeviceId = x.DeviceId,
                    DeviceModel = x.DeviceModel,
                    IPAddress = x.Ipaddress,
                    APIEndPoint = x.ApiendPoint
                }).ToList();

                return pos;
            }
        }

        // GET: Ktixposterminals/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ktixposterminal = await _context.Ktixposterminal
                .Include(k => k.Cinema)
                .Include(k => k.Company)
                .Include(k => k.KtixPosUseType)
                .SingleOrDefaultAsync(m => m.KtixPosTerminalId == id);
            if (ktixposterminal == null)
            {
                return NotFound();
            }

            return View(ktixposterminal);
        }

        // GET: Ktixposterminals/Create
        public IActionResult Create()
        {
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1");
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1");
            ViewData["KtixPosUseTypeId"] = new SelectList(_context.Ktixposusetype, "KtixPosUseTypeId", "Name");
            return View();
        }

        // POST: Ktixposterminals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KtixPosTerminalId,KtixPosUseTypeId,KtixDescription,CompanyId,CinemaId,DeviceName,DeviceId,DeviceModel,Ipaddress,ApiendPoint")] Ktixposterminal ktixposterminal)
        {
            if (ModelState.IsValid)
            {
                ktixposterminal.KtixPosTerminalId = Guid.NewGuid();
                _context.Add(ktixposterminal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1", ktixposterminal.CinemaId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", ktixposterminal.CompanyId);
            ViewData["KtixPosUseTypeId"] = new SelectList(_context.Ktixposusetype, "KtixPosUseTypeId", "Name", ktixposterminal.KtixPosUseTypeId);
            return View(ktixposterminal);
        }

        // GET: Ktixposterminals/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ktixposterminal = await _context.Ktixposterminal.SingleOrDefaultAsync(m => m.KtixPosTerminalId == id);
            if (ktixposterminal == null)
            {
                return NotFound();
            }
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1", ktixposterminal.CinemaId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", ktixposterminal.CompanyId);
            ViewData["KtixPosUseTypeId"] = new SelectList(_context.Ktixposusetype, "KtixPosUseTypeId", "Name", ktixposterminal.KtixPosUseTypeId);
            return View(ktixposterminal);
        }

        // POST: Ktixposterminals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("KtixPosTerminalId,KtixPosUseTypeId,KtixDescription,CompanyId,CinemaId,DeviceName,DeviceId,DeviceModel,Ipaddress,ApiendPoint")] Ktixposterminal ktixposterminal)
        {
            if (id != ktixposterminal.KtixPosTerminalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ktixposterminal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KtixposterminalExists(ktixposterminal.KtixPosTerminalId))
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
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1", ktixposterminal.CinemaId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Address1", ktixposterminal.CompanyId);
            ViewData["KtixPosUseTypeId"] = new SelectList(_context.Ktixposusetype, "KtixPosUseTypeId", "Name", ktixposterminal.KtixPosUseTypeId);
            return View(ktixposterminal);
        }

        // GET: Ktixposterminals/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ktixposterminal = await _context.Ktixposterminal
                .Include(k => k.Cinema)
                .Include(k => k.Company)
                .Include(k => k.KtixPosUseType)
                .SingleOrDefaultAsync(m => m.KtixPosTerminalId == id);
            if (ktixposterminal == null)
            {
                return NotFound();
            }

            return View(ktixposterminal);
        }

        // POST: Ktixposterminals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ktixposterminal = await _context.Ktixposterminal.SingleOrDefaultAsync(m => m.KtixPosTerminalId == id);
            _context.Ktixposterminal.Remove(ktixposterminal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KtixposterminalExists(Guid id)
        {
            return _context.Ktixposterminal.Any(e => e.KtixPosTerminalId == id);
        }
    }
}
