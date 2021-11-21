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
            return View();
        }
        public ActionResult Login()
        {
            return View();
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
            Bai_Tap_Lon_2Entities3 db = new Bai_Tap_Lon_2Entities3();
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Register(user user)
        //{
        //    return View();
        //}
        public ActionResult Products()
        {
            return View();
        }
    }
}