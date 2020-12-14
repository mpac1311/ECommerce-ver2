using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Areas.Users.Controllers
{
    [Area("Users")]
    public class SanPhamController : Controller
    {
        private readonly DataContext _context;
        public SanPhamController(DataContext context)
        {
            _context = context;
        }
        public ActionResult Search(string search)
        {

            var searchSP = from x in _context.SanPhams
                              select x;
            if (!String.IsNullOrEmpty(search))
            {
                searchSP = searchSP.Where(x => x.TenSP.Contains(search));
            }

            return View(searchSP);
        }
        public ActionResult Iphone()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Iphone"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public ActionResult SamSung()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Samsung"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public ActionResult TabletApple()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Ipad"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public ActionResult TabletSamSung()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Stab"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public IActionResult Index()
        {
            return View(_context.SanPhams);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.Loai)
                .Include(s => s.NhaCungCap)
                .Include(s => s.ThuongHieu)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }
    }
}
