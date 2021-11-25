using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;
using PagedList;
namespace Website1.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
        [HttpGet]
        public ActionResult KQTimKiem(string TuKhoa, int ? page)
        {
            if(Request.HttpMethod != "GET")
            {
                page = 1;
            }
            int PageSize = 12;
            int PageNumber = (page ?? 1);
            //tìm kiếm theo tên sản phẩm
            var listSP = db.products.Where(n => n.pro_name.Contains(TuKhoa));
            ViewBag.TuKhoa = TuKhoa;
            return View(listSP.OrderBy(n => n.pro_name).ToPagedList(PageNumber, PageSize));
        }
        [HttpPost]
        public ActionResult LayTuKhoaTimKiem(string TuKhoa)
        {
            //if (Request.HttpMethod != "GET")
            //{
            //    page = 1;
            //}
            //int PageSize = 12;
            //int PageNumber = (page ?? 1);
            ////tìm kiếm theo tên sản phẩm
            //var listSP = db.products.Where(n => n.pro_name.Contains(TuKhoa));
            //ViewBag.TuKhoa = TuKhoa;
            //Gọi về hàm GET tìm kiếm
            return RedirectToAction("KQTimKiem", new {@TuKhoa = TuKhoa });
        }
    }
}