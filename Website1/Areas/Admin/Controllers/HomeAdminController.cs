using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;

namespace Website1.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/Home
        private Entities db = new Entities();
        public ActionResult Index()
        {
            if (Session["id"] != null)
            {
                var data = (from s in db.products select s).ToList();
                ViewBag.products = data;
                return View();
            }
            return RedirectToAction("LoginAdmin", "HomeAdmin");
        }
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginAdmin(String email, String password)
        {
            if (ModelState.IsValid)
            {
                var data = db.admins.Where(s => s.email.Equals(email) && s.password.Equals(password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["Name"] = data.FirstOrDefault().name;
                    Session["Email"] = data.FirstOrDefault().email;
                    Session["id"] = data.FirstOrDefault().id;
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else
                {
                    ViewBag.error = "Login failed";
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "HomeAdmin");
        }
    }
}