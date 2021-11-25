using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;
using System.Security.Cryptography;
using System.Text;

namespace Website1.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
            var DS_SanPham = db.products.ToList();
            return View(DS_SanPham.ToList());
        }
        
        //GET: register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(users _user)
        {
            Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
            if (ModelState.IsValid)
            {
                var check = db.users.FirstOrDefault(s => s.email == _user.email);
                if (check == null)
                {
                    _user.password = GetMD5(_user.password);
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.users.Add(_user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Email đã tồn tại. Thử lại bằng 1 email khác!";
                    return View();
                }


            }
            return View();


        }
        public static string GetMD5(string str)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
            if (ModelState.IsValid)
            {
                var f_password = GetMD5(password);
                var data = db.users.Where(s => s.email.Equals(email) && s.password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["FullName"] = data.FirstOrDefault().name;
                    Session["Email"] = data.FirstOrDefault().email;
                    Session["idUser"] = data.FirstOrDefault().id;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}