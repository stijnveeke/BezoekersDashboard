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
    public class VisitorsController : Controller
    {
        private readonly BezoekersDashboardContext _context;

        public VisitorsController(BezoekersDashboardContext context)
        {
            _context = context;
        }

        // GET: Visitors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Visitors.OrderByDescending(s => s.Date.Year).ToListAsync());
        }

        // GET: Visitors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitors = await _context.Visitors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (visitors == null)
            {
                return NotFound();
            }

            return View(visitors);
        }

        // GET: Visitors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Zipcode,Amount,Date")] Visitors visitors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visitors);
        }

        // GET: Visitors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitors = await _context.Visitors.FindAsync(id);
            if (visitors == null)
            {
                return NotFound();
            }
            return View(visitors);
        }

        [Route("Visitors/input_zip/{zipcode}")]
        public async Task<IActionResult> GetZip(string zipcode)
        {

            if (zipcode == "" || zipcode == null)
            {
                ViewData["date"] = "test";
                return NotFound();
            }
            ViewData["date"] = zipcode;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                if (item.Zipcode == zipcode)
                {
                    realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        // GET : Visitors/Date/24-12-2018
        [Route("Visitors/input_date/{date}")]
        public async Task<IActionResult> GetDate(string date)
        {

            if (date == "" || date == null)
            {
                ViewData["date"] = "test";
                return NotFound();
            }
            ViewData["date"] = date;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                var itemdate = item.Date.ToString("yyyy-MM-d");
                if (itemdate == date)
                {
                    realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        [Route("Visitors/input_month/{month}")]
        public async Task<IActionResult> GetMonth(string month)
        {

            if (month == "" || month == null)
            {
                ViewData["month"] = "test";
                return NotFound();
            }
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            ViewData["month"] = month;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                var itemmonth = item.Date.ToString("MM");
                if (itemmonth == month)
                {
                    realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        [Route("Visitors/input_year/{year}")]
        public async Task<IActionResult> GetYear(string year)
        {

            if (year == "" || year == null)
            {
                ViewData["year"] = "test";
                return NotFound();
            }
            ViewData["month"] = year;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                var itemyear = item.Date.ToString("yyyy");
                if (itemyear == year)
                {
                    realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        [Route("Visitors/input_date/{date}/input_zip/{zipcode}")]
        public async Task<IActionResult> GetDateZip(string date, string zipcode)
        {

            if (date == "" || date == null || zipcode == "" || zipcode == null)
            {
                ViewData["date"] = "test";
                return NotFound();
            }
            ViewData["date"] = date;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                var itemdate = item.Date.ToString("yyyy-MM-d");
                if (itemdate == date)
                {
                    if (item.Zipcode == zipcode)
                    {
                        realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                    }
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        [Route("Visitors/input_month/{month}/input_zip/{zipcode}")]
        public async Task<IActionResult> GetMonthZip(string month, string zipcode)
        {

            if (month == "" || month == null || zipcode == "" || zipcode == null)
            {
                ViewData["month"] = "test";
                return NotFound();
            }
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            ViewData["month"] = month;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                var itemmonth = item.Date.ToString("MM");
                if (itemmonth == month)
                {
                    if (item.Zipcode == zipcode)
                    {
                        realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                    }
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        [Route("Visitors/input_year/{year}/input_zip/{zipcode}")]
        public async Task<IActionResult> GetYearZip(string year, string zipcode)
        {

            if (year == "" || year == null || zipcode == "" || zipcode == null)
            {
                ViewData["year"] = "test";
                return NotFound();
            }
            ViewData["month"] = year;
            var visit = await _context.Visitors.ToListAsync();
            List<Visitors> realvisit = new List<Visitors>();
            foreach (var item in visit)
            {
                var itemyear = item.Date.ToString("yyyy");
                if (itemyear == year)
                {
                    if (item.Zipcode == zipcode)
                    {
                        realvisit.Add(await _context.Visitors.FindAsync(item.Id));
                    }
                }
            }
            if (realvisit == null)
            {
                return NotFound();
            }
            return View("Visitors", realvisit.OrderBy(s => s.Date.Year));
        }

        // POST: Visitors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Zipcode,Amount,Date")] Visitors visitors)
        {
            if (id != visitors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitorsExists(visitors.Id))
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
            return View(visitors);
        }

        // GET: Visitors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitors = await _context.Visitors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (visitors == null)
            {
                return NotFound();
            }

            return View(visitors);
        }

        // POST: Visitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitors = await _context.Visitors.FindAsync(id);
            _context.Visitors.Remove(visitors);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitorsExists(int id)
        {
            return _context.Visitors.Any(e => e.Id == id);
        }
    }
}
