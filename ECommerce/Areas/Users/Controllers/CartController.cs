﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using ECommerce.Areas.Users.Helper;
using ECommerce.Data;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

namespace ECommerce.Areas.Users.Controllers
{
    [Area("Users")]
    public class CartController : Controller
    {
        private readonly DataContext _context;
        public CartController(DataContext _context)
        {
            this._context = _context;

        }
        public IActionResult Null()
        {
            return View();
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            return View(cart);
        }
        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart") == null)
            {
                List<ProductToCart> cart = new List<ProductToCart>();
                cart.Add(new ProductToCart
                {
                    SanPham = _context.SanPhams.FirstOrDefault(p => p.MaSP == id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductToCart
                    {
                        SanPham = _context.SanPhams.FirstOrDefault(p => p.MaSP == id),
                        Quantity = 1
                    });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }



        [Route("remove/{id}")]

        public IActionResult Remove(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].SanPham.MaSP == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult Checkout()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout([Bind("MaDH,NgayTaoDH,GhiChuDH,TenKH,DiaChiNhan,SoDienThoai,Email")] DonHang donhang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donhang);
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Redirect("/Users/Cart/Success");

            
            
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}

