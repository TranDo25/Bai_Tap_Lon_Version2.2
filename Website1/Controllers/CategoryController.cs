using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website1.Models;

namespace Website1.Controllers
{
    public class CategoryController : Controller
    {
    
        // GET: Category
        public ActionResult Index()
        {

            Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
            var lstCategory = db.categories.ToList();
            return View(lstCategory);
        }
        public ActionResult ProductCategory(int Id)
        {
            Bai_Tap_Lon_2Entities4 db = new Bai_Tap_Lon_2Entities4();
            List<products> listProduct = db.products.Where(n => n.pro_category_id == Id).ToList();
            return View(listProduct);
        }
    }
}