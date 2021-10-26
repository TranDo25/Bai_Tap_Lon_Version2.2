using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website1.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult DanhSachSanPham()
        {
            return View();
        }
        public ActionResult ChiTietSanPham()
        {
            return View();
        }

    }
}