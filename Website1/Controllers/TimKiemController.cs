using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;
namespace Website1.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        Bai_Tap_Lon_2Entities db = new Bai_Tap_Lon_2Entities();
        [HttpGet]
        public ActionResult KQTimKiem(string TuKhoa)
        {

            //tìm kiếm theo tên sản phẩm
            var listSP = db.products.Where(n => n.pro_name.Contains(TuKhoa));
            return View(listSP.OrderBy(n => n.pro_name));
        }
    }
}