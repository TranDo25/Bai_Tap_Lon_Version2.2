using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;

namespace Website1.Controllers
{
    public class ThanhToanController : Controller
    {
        // GET: ThanhToan
        Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
        public ActionResult Index()
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                //lấy thông tin từ giỏ hàng từ biến Session
                var lstCart = (List<CartModel>)Session["cart"];
                //gán dữ liệu cho order
                transactions objOrder = new transactions();
                objOrder.tr_note = "DonHang " + DateTime.Now.ToString("yyyyMMddHHmmss");
                objOrder.tr_user_id = int.Parse(Session["idUser"].ToString());
                objOrder.created_at = DateTime.Now;
                db.transactions.Add(objOrder);
                //lưu thông tin dữ liệu vào bảng order
                db.SaveChanges();
                //lấy Orderid vừa mới tạo để lưu vào OrderDetail
                int intOrderid = objOrder.id;
                List<orders> lstOrderDetail = new List<orders>();
                foreach(var item in lstCart)
                {
                    orders obj = new orders();
                    obj.or_transaction_id = intOrderid;
                    obj.or_product_id = item.Product.id;
                    lstOrderDetail.Add(obj);
                }
                db.orders.AddRange(lstOrderDetail);
                db.SaveChanges();
            }
            return View();
        }
    }
}