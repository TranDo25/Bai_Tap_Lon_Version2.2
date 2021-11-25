using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;
using PagedList;
namespace Website1.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
        public ActionResult DanhSachSanPham(int? page, string sortOrder)
        {
            Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
            //lấy ra danh sách sản phẩm
            //List<product> ketQua = db.products.ToList();
            //thực hiện chức năng phân trang
            int PageSize = 12;
            //tạo biến thứ 2 là số trang hiện tại
            int PageNumber = (page ?? 1);
            ViewBag.GiaSortParm = String.IsNullOrEmpty(sortOrder) ? "gia_desc" : "";
            ViewBag.TenSortParm = sortOrder == "ten" ? "ten_desc" : "ten";
            var models = db.products.AsQueryable();
            switch (sortOrder)
            {
                case "gia_desc":
                    models = models.OrderByDescending(s => s.final_price);
                    break;
                case "ten":
                    models = models.OrderBy(s => s.pro_name);
                    break;
                case "ten_desc":
                    models = models.OrderByDescending(s => s.pro_name);
                    break;
                default:
                    models = models.OrderBy(s => s.final_price);
                    break;
            }
            return View(models.ToList().ToPagedList(PageNumber, PageSize));

        }
        //public ActionResult Index(string sortOrder)
        //{
        //    Bai_Tap_Lon_2Entities db = new Bai_Tap_Lon_2Entities();
        //    ViewBag.MaSortParm = String.IsNullOrEmpty(sortOrder) ? "ma_desc" : "";
        //    ViewBag.TenSortParm = sortOrder == "ten" ? "ten_desc" : "ten";
        //    var models = db.products.AsQueryable();
        //    switch (sortOrder)
        //    {
        //        case "ma_desc":
        //            models = models.OrderByDescending(s => s.final_price);
        //            break;
        //        case "Date":
        //            models = models.OrderBy(s => s.id);
        //            break;
        //        case "date_desc":
        //            models = models.OrderByDescending(s => s.id);
        //            break;
        //        default:
        //            models = models.OrderBy(s => s.final_price);
        //            break;
        //    }
        //    return View(models.ToList);
        //}
        //public ActionResult SapXepTheoDieuKien(string sort)
        //{
        //    return RedirectToAction("DanhSachSanPham");
        //}
        public ActionResult ChiTietSanPham(int id)
        {

            products KetQua = db.products.Find(id);
            return View(KetQua);
        }
    }
}