using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TrangThaiSPsController : Controller
    {
        private readonly DataContext _context;

        public TrangThaiSPsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/TrangThaiSPs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrangThaiSPs.ToListAsync());
        }

        // GET: Admin/TrangThaiSPs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThaiSP = await _context.TrangThaiSPs
                .FirstOrDefaultAsync(m => m.MaTTSP == id);
            if (trangThaiSP == null)
            {
                return NotFound();
            }

            return View(trangThaiSP);
        }

        // GET: Admin/TrangThaiSPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrangThaiSPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTTSP,TrangThaiProduct")] TrangThaiSP trangThaiSP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trangThaiSP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trangThaiSP);
        }

        // GET: Admin/TrangThaiSPs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThaiSP = await _context.TrangThaiSPs.FindAsync(id);
            if (trangThaiSP == null)
            {
                return NotFound();
            }
            return View(trangThaiSP);
        }

        // POST: Admin/TrangThaiSPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTTSP,TrangThaiProduct")] TrangThaiSP trangThaiSP)
        {
            if (id != trangThaiSP.MaTTSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trangThaiSP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrangThaiSPExists(trangThaiSP.MaTTSP))
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
            return View(trangThaiSP);
        }

        // GET: Admin/TrangThaiSPs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trangThaiSP = await _context.TrangThaiSPs
                .FirstOrDefaultAsync(m => m.MaTTSP == id);
            if (trangThaiSP == null)
            {
                return NotFound();
            }

            return View(trangThaiSP);
        }

        // POST: Admin/TrangThaiSPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trangThaiSP = await _context.TrangThaiSPs.FindAsync(id);
            _context.TrangThaiSPs.Remove(trangThaiSP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrangThaiSPExists(int id)
        {
            return _context.TrangThaiSPs.Any(e => e.MaTTSP == id);
        }
    }
}
