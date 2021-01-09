using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Areas.Admin
{
    [Area("Admin")]
    public class PhiShipsController : Controller
    {
        private readonly DataContext _context;

        public PhiShipsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/PhiShips
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhiShip.ToListAsync());
        }

        // GET: Admin/PhiShips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phiShip = await _context.PhiShip
                .FirstOrDefaultAsync(m => m.MaShip == id);
            if (phiShip == null)
            {
                return NotFound();
            }

            return View(phiShip);
        }

        // GET: Admin/PhiShips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PhiShips/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaShip,TenPhiShip,ShipPrice")] PhiShip phiShip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phiShip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phiShip);
        }

        // GET: Admin/PhiShips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phiShip = await _context.PhiShip.FindAsync(id);
            if (phiShip == null)
            {
                return NotFound();
            }
            return View(phiShip);
        }

        // POST: Admin/PhiShips/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaShip,TenPhiShip,ShipPrice")] PhiShip phiShip)
        {
            if (id != phiShip.MaShip)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phiShip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhiShipExists(phiShip.MaShip))
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
            return View(phiShip);
        }

        // GET: Admin/PhiShips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phiShip = await _context.PhiShip
                .FirstOrDefaultAsync(m => m.MaShip == id);
            if (phiShip == null)
            {
                return NotFound();
            }

            return View(phiShip);
        }

        // POST: Admin/PhiShips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phiShip = await _context.PhiShip.FindAsync(id);
            _context.PhiShip.Remove(phiShip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhiShipExists(int id)
        {
            return _context.PhiShip.Any(e => e.MaShip == id);
        }
    }
}
