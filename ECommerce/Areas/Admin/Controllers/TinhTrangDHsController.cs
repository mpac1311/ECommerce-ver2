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
    public class TinhTrangDHsController : Controller
    {
        private readonly DataContext _context;

        public TinhTrangDHsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/TinhTrangDHs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TinhTrangDH.ToListAsync());
        }

        // GET: Admin/TinhTrangDHs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhTrangDH = await _context.TinhTrangDH
                .FirstOrDefaultAsync(m => m.MaTT == id);
            if (tinhTrangDH == null)
            {
                return NotFound();
            }

            return View(tinhTrangDH);
        }

        // GET: Admin/TinhTrangDHs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TinhTrangDHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTT,TrangThaiDH")] TinhTrangDH tinhTrangDH)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinhTrangDH);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tinhTrangDH);
        }

        // GET: Admin/TinhTrangDHs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhTrangDH = await _context.TinhTrangDH.FindAsync(id);
            if (tinhTrangDH == null)
            {
                return NotFound();
            }
            return View(tinhTrangDH);
        }

        // POST: Admin/TinhTrangDHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTT,TrangThaiDH")] TinhTrangDH tinhTrangDH)
        {
            if (id != tinhTrangDH.MaTT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinhTrangDH);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinhTrangDHExists(tinhTrangDH.MaTT))
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
            return View(tinhTrangDH);
        }

        // GET: Admin/TinhTrangDHs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhTrangDH = await _context.TinhTrangDH
                .FirstOrDefaultAsync(m => m.MaTT == id);
            if (tinhTrangDH == null)
            {
                return NotFound();
            }

            return View(tinhTrangDH);
        }

        // POST: Admin/TinhTrangDHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinhTrangDH = await _context.TinhTrangDH.FindAsync(id);
            _context.TinhTrangDH.Remove(tinhTrangDH);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinhTrangDHExists(int id)
        {
            return _context.TinhTrangDH.Any(e => e.MaTT == id);
        }
    }
}
