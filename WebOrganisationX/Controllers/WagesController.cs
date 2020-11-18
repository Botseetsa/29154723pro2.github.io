using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebOrganisationX.Data;
using WebOrganisationX.Models;

namespace WebOrganisationX.Controllers
{
    [Authorize]
    public class WagesController : Controller
    {
        private readonly DimensionDContext _context;

        public WagesController(DimensionDContext context)
        {
            _context = context;
        }

        // GET: Wages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wages.ToListAsync());
        }

        // GET: Wages/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wage = await _context.Wages
                .FirstOrDefaultAsync(m => m.WageId == id);
            if (wage == null)
            {
                return NotFound();
            }

            return View(wage);
        }

        // GET: Wages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WageId,HourlyRate,MonthlyRate,OverTime")] Wage wage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wage);
        }

        // GET: Wages/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wage = await _context.Wages.FindAsync(id);
            if (wage == null)
            {
                return NotFound();
            }
            return View(wage);
        }

        // POST: Wages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("WageId,HourlyRate,MonthlyRate,OverTime")] Wage wage)
        {
            if (id != wage.WageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WageExists(wage.WageId))
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
            return View(wage);
        }

        // GET: Wages/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wage = await _context.Wages
                .FirstOrDefaultAsync(m => m.WageId == id);
            if (wage == null)
            {
                return NotFound();
            }

            return View(wage);
        }

        // POST: Wages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var wage = await _context.Wages.FindAsync(id);
            _context.Wages.Remove(wage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WageExists(string id)
        {
            return _context.Wages.Any(e => e.WageId == id);
        }
    }
}
