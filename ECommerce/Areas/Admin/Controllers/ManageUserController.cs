using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using ECommerce.Areas.Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class ManageUserController : Controller
    {
        private readonly DataContext _context;


        public ManageUserController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<ApplicationUser> model = _context.Users.AsEnumerable();
            ViewBag.Number = model.Count();
            return View(model);
        }
        public IActionResult Delete(string Id)

        {

            var model = _context.Users.Find(Id);

            return View(model);

        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        [ActionName("Delete")]

        public IActionResult DeleteConfirmed(string Id)

        {

            ApplicationUser model = null;

            try

            {

                model = _context.Users.Find(Id);

                _context.Users.Remove(model);

                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            catch (Exception ex)

            {

                ModelState.AddModelError("", ex.Message);

                return View("Delete", model);

            }

        }
    }
}
