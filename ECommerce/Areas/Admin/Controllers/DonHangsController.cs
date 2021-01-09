using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Areas.Users.Helper;
using MimeKit;
using MailKit.Net.Smtp;

namespace ECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DonHangsController : Controller
    {
        private readonly DataContext _context;

        public DonHangsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/DonHangs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonHangs.ToListAsync());
        }

        // GET: Admin/DonHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHangs
                .FirstOrDefaultAsync(m => m.MaDH == id);
            if (donHang == null)
            {
                return NotFound();
            }

            return View(donHang);
        }

        // GET: Admin/DonHangs/Create
        public IActionResult Create()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            return View();
        }

        // POST: Admin/DonHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDH,NgayTaoDH,GhiChuDH,TenKH,DiaChiNhan,SoDienThoai,Email,MaTT")] DonHang donHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donHang);
                await _context.SaveChangesAsync();
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("nguyenphat7509@gmail.com"));
                message.To.Add(new MailboxAddress(donHang.Email));
                message.Subject = "Dat hang thanh cong";
                message.Body = new TextPart("plain")
                {
                    Text = "Dat hang thanh cong" + "---------------" +" MaDH: "+donHang.MaDH+" -Ten khach hang: "+donHang.TenKH + " -Dia chi nhan: " + donHang.DiaChiNhan + "-"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("nguyenphat7509@gmail.com", "Myhoa0903$$$");
                    client.Send(message);
                    client.Disconnect(true);
                }
                donHang.NgayTaoDH = DateTime.Now;

            }
            
            return Redirect("/Users/Cart/Success");

           
        }

        // GET: Admin/DonHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHangs.FindAsync(id);
            if (donHang == null)
            {
                return NotFound();
            }
            return View(donHang);
        }

        // POST: Admin/DonHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDH,NgayTaoDH,GhiChuDH,TenKH,DiaChiNhan,SoDienThoai,Email,MaTT")] DonHang donHang)
        {
            if (id != donHang.MaDH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonHangExists(donHang.MaDH))
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
            return View(donHang);
        }

        // GET: Admin/DonHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHangs
                .FirstOrDefaultAsync(m => m.MaDH == id);
            if (donHang == null)
            {
                return NotFound();
            }

            return View(donHang);
        }

        // POST: Admin/DonHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donHang = await _context.DonHangs.FindAsync(id);
            _context.DonHangs.Remove(donHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonHangExists(int id)
        {
            return _context.DonHangs.Any(e => e.MaDH == id);
        }
    }
}
