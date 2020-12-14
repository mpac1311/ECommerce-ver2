using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using ECommerce.Models;
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
        public ActionResult SearchPrice(string NameProduct,string Price1,string Price2)
        {
                List<SanPham> product = _context.SanPhams.ToList();
                var search = from x in product.AsEnumerable()
                             select x;
                if (!String.IsNullOrEmpty(NameProduct))
                {
                    search = search.Where(s => s.TenSP.Contains(NameProduct));
                }
                if (!String.IsNullOrEmpty(Price1))
                {
                    search = search.Where(s => Convert.ToDouble(s.DonGia) >= Convert.ToDouble(Price1));
                }
                if (!String.IsNullOrEmpty(Price2))
                {
                    search = search.Where(s => Convert.ToDouble(s.DonGia) <= Convert.ToDouble(Price2));
                }
                return View(search.ToList());
        }
        public ActionResult Iphone()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Điện thoại" && x.ThuongHieu.TenTH == "Apple"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public ActionResult SamSung()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Điện thoại" && x.ThuongHieu.TenTH == "Samsung"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public ActionResult TabletApple()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Máy tính bảng" && x.ThuongHieu.TenTH == "Apple"
                               select x).ToList();


            return View(searchmovie.ToList());
        }
        public ActionResult TabletSamSung()
        {

            var searchmovie = (from x in _context.SanPhams
                               where x.Loai.TenLoai == "Máy tính bảng" && x.ThuongHieu.TenTH == "Samsung"
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
