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
       
        public ActionResult DanhSachSanPham(int? page)
        {
            Bai_Tap_Lon_2Entities db = new Bai_Tap_Lon_2Entities();
            //lấy ra danh sách sản phẩm
            List<product> ketQua = db.products.ToList();
            //thực hiện chức năng phân trang
            int PageSize = 12;
            //tạo biên thứ 2 là số trang hiện tại
            int PageNumber = (page ?? 1);
            return View(ketQua.OrderBy(n=>n.final_price ).ToPagedList(PageNumber, PageSize));
        }
    }
}