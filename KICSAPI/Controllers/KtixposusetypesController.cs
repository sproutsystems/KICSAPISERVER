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
    public class KtixposusetypesController : Controller
    {
        private readonly KICSDEVContext _context;

        public KtixposusetypesController(KICSDEVContext context)
        {
            _context = context;
        }

        // GET: Ktixposusetypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ktixposusetype.ToListAsync());
        }

        // GET: GetPOSUseTypes
        public IEnumerable<Ktixposusetype> GetPOSUseTypes()
        {
            var query = from p in _context.Ktixposusetype
                        select p;

            return query.ToList();
        }

        // GET: GetPOSUseTypes
        public IEnumerable<KtixPosTypeNameDTO> GetPOSUseTypeById(int id)
        {
            var query = from p in _context.Ktixposusetype
                        where p.KtixPosUseTypeId == id
                        select p;

            var ktixpostype = query.Select(x => new KtixPosTypeNameDTO()
            {
                KTixPosTypeName = x.Name,
    
            }).ToList();

            return ktixpostype;
        }

        // GET: Ktixposusetypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ktixposusetype = await _context.Ktixposusetype
                .SingleOrDefaultAsync(m => m.KtixPosUseTypeId == id);
            if (ktixposusetype == null)
            {
                return NotFound();
            }

            return View(ktixposusetype);
        }

        // GET: Ktixposusetypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ktixposusetypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KtixPosUseTypeId,Name")] Ktixposusetype ktixposusetype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ktixposusetype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ktixposusetype);
        }

        // GET: Ktixposusetypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ktixposusetype = await _context.Ktixposusetype.SingleOrDefaultAsync(m => m.KtixPosUseTypeId == id);
            if (ktixposusetype == null)
            {
                return NotFound();
            }
            return View(ktixposusetype);
        }

        // POST: Ktixposusetypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KtixPosUseTypeId,Name")] Ktixposusetype ktixposusetype)
        {
            if (id != ktixposusetype.KtixPosUseTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ktixposusetype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KtixposusetypeExists(ktixposusetype.KtixPosUseTypeId))
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
            return View(ktixposusetype);
        }

        // GET: Ktixposusetypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ktixposusetype = await _context.Ktixposusetype
                .SingleOrDefaultAsync(m => m.KtixPosUseTypeId == id);
            if (ktixposusetype == null)
            {
                return NotFound();
            }

            return View(ktixposusetype);
        }

        // POST: Ktixposusetypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ktixposusetype = await _context.Ktixposusetype.SingleOrDefaultAsync(m => m.KtixPosUseTypeId == id);
            _context.Ktixposusetype.Remove(ktixposusetype);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KtixposusetypeExists(int id)
        {
            return _context.Ktixposusetype.Any(e => e.KtixPosUseTypeId == id);
        }
    }
}
