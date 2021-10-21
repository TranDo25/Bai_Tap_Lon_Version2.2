using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;

namespace Website1.Areas.Admin.Controllers
{
    public class AddAndEditAndRemoveController : Controller
    {
        // GET: Admin/AddAndEditAndRemove
        private Entities db = new Entities();
        public ActionResult AddProduct()
        {
            if (Session["id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginAdmin", "HomeAdmin");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(product sp)
        {
            if (ModelState.IsValid)
            {
                var pro_name = sp.pro_name;
                var count = db.products.Where(s => s.pro_name.Contains(pro_name)).Count();
                if (count > 0)
                {
                    ViewBag.message = "San pham da ton tai, hay su dung Edit thay vì Add";
                    return View();
                }
                sp.pro_author_id = 1;
                sp.created_at = DateTime.Now;
                sp.updated_at = DateTime.Now;
                db.products.Add(sp);
                db.SaveChanges();
                return RedirectToAction("Index", "HomeAdmin");
            }
            ViewBag.message = "Them san pham that bai";
            return View();
        }
    }
}