using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BezoekersDashboard.Models;

namespace BezoekersDashboard.Controllers
{
    public class ParkingsController : Controller
    {
        private readonly BezoekersDashboardContext _context;

        public ParkingsController(BezoekersDashboardContext context)
        {
            _context = context;
        }

        // GET: Parkings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parking.ToListAsync());
        }

        // GET: Parkings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parking = await _context.Parking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parking == null)
            {
                return NotFound();
            }

            return View(parking);
        }

        // GET: Parkings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parkings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ParkingName,Amount,Date")] Parking parking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parking);
        }

        // GET: Parkings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parking = await _context.Parking.FindAsync(id);
            if (parking == null)
            {
                return NotFound();
            }
            return View(parking);
        }


        [Route("Parking/Startdate/{startdate}/Enddate/{enddate}")]
        public async Task<IActionResult> Search(DateTime startdate, DateTime enddate)
        {
            List<Parking> parking = await _context.Parking.ToListAsync();
            List<Parking> parkfilter = new List<Parking>();
            foreach (Parking park in parking)
            {
                if (park.Date < startdate && park.Date > enddate)
                {
                    parkfilter.Add(park);
                }
            }
            return View("", parkfilter);
        }
        // POST: Parkings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ParkingName,Amount,Date")] Parking parking)
        {
            if (id != parking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkingExists(parking.Id))
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
            return View(parking);
        }

        // GET: Parkings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parking = await _context.Parking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parking == null)
            {
                return NotFound();
            }

            return View(parking);
        }

        // POST: Parkings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parking = await _context.Parking.FindAsync(id);
            _context.Parking.Remove(parking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkingExists(int id)
        {
            return _context.Parking.Any(e => e.Id == id);
        }
    }
}
