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
    public class SessionsController : Controller
    {
        private readonly KICSDEVContext _context;

        public SessionsController(KICSDEVContext context)
        {
            _context = context;
        }

        // GET: Sessions
        public async Task<IActionResult> Index()
        {
            var kICSDEVContext = _context.Session.Include(s => s.Cinema).Include(s => s.MovieInstance).Include(s => s.Screen);
            return View(await kICSDEVContext.ToListAsync());
        }

        // GET: GetCinemasForCompany
        public IEnumerable<SessionsByCinemaDTO> GetSessionsByCinema(Guid cinemaId)
        {
            //if (companyId == null)
            //{
            //    return NotFound();
            //}

            var query = from s in _context.Session
                        where s.CinemaId == cinemaId
                        && s.DateTime >= DateTime.Now
                        && s.MovieInstance.IsDeleted == false
                        && s.MovieInstance.IsActive == true
                        select s;

            var cinemas = query.Select(x => new SessionsByCinemaDTO()
            {
                SessionId = x.SessionId,
                CinemaId = x.CinemaId,
                SessionDateTime = x.DateTime,
                CinemaName = x.Cinema.Name,
                ScreenName = x.Screen.Name,
                MovieTitle = x.MovieInstance.MovieDetail.Title,
                PriceGroup = x.Ktixsession.ToString(),
                PosterURL = x.Cinema.WebsiteUrl + "/SharedContent/" + x.MovieInstance.MovieDetail.Movie.MovieId.ToString() + ".jpg",
                RunningTimeInMin = x.MovieInstance.MovieDetail.RunningTime.ToString(),
                RatingName = x.MovieInstance.MovieDetail.Rating.Name,
            }).ToList();

            return cinemas;
        }


        // GET: Sessions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .Include(s => s.Cinema)
                .Include(s => s.MovieInstance)
                .Include(s => s.Screen)
                .SingleOrDefaultAsync(m => m.SessionId == id);
            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        // GET: Sessions/Create
        public IActionResult Create()
        {
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1");
            ViewData["MovieInstanceId"] = new SelectList(_context.Movieinstance, "MovieInstanceId", "MovieInstanceId");
            ViewData["ScreenId"] = new SelectList(_context.Screen, "ScreenId", "Code");
            return View();
        }

        // POST: Sessions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SessionId,MovieInstanceId,CinemaId,ScreenId,DateTime,PointOfSaleId,SeatsRemaining,IsOnlineTicketing,CreateDateTime,BookingUrl")] Session session)
        {
            if (ModelState.IsValid)
            {
                _context.Add(session);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1", session.CinemaId);
            ViewData["MovieInstanceId"] = new SelectList(_context.Movieinstance, "MovieInstanceId", "MovieInstanceId", session.MovieInstanceId);
            ViewData["ScreenId"] = new SelectList(_context.Screen, "ScreenId", "Code", session.ScreenId);
            return View(session);
        }

        // GET: Sessions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session.SingleOrDefaultAsync(m => m.SessionId == id);
            if (session == null)
            {
                return NotFound();
            }
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1", session.CinemaId);
            ViewData["MovieInstanceId"] = new SelectList(_context.Movieinstance, "MovieInstanceId", "MovieInstanceId", session.MovieInstanceId);
            ViewData["ScreenId"] = new SelectList(_context.Screen, "ScreenId", "Code", session.ScreenId);
            return View(session);
        }

        // POST: Sessions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("SessionId,MovieInstanceId,CinemaId,ScreenId,DateTime,PointOfSaleId,SeatsRemaining,IsOnlineTicketing,CreateDateTime,BookingUrl")] Session session)
        {
            if (id != session.SessionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(session);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionExists(session.SessionId))
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
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "Address1", session.CinemaId);
            ViewData["MovieInstanceId"] = new SelectList(_context.Movieinstance, "MovieInstanceId", "MovieInstanceId", session.MovieInstanceId);
            ViewData["ScreenId"] = new SelectList(_context.Screen, "ScreenId", "Code", session.ScreenId);
            return View(session);
        }

        // GET: Sessions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .Include(s => s.Cinema)
                .Include(s => s.MovieInstance)
                .Include(s => s.Screen)
                .SingleOrDefaultAsync(m => m.SessionId == id);
            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        // POST: Sessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var session = await _context.Session.SingleOrDefaultAsync(m => m.SessionId == id);
            _context.Session.Remove(session);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessionExists(long id)
        {
            return _context.Session.Any(e => e.SessionId == id);
        }
    }
}
