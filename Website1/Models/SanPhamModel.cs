using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website1.Models
{
    public class SanPhamModel
    {
        public int ID { set; get; }
        public string TenSanPham { set; get; }
        public float GiaTien { set; get; }
        public string size { set; get; }
        public string moTa { set; get; }
        public List<SanPhamModel> DanhSach()
        {
            var listKetQua = new List<SanPhamModel>();

            SanPhamModel sp1 = new SanPhamModel();
            sp1.ID = 1;
            sp1.TenSanPham = "YEEZY BOOST 380 STONE SALT";
            sp1.GiaTien = 6500000;
            sp1.size = "L";
            sp1.moTa = "phiên bản original hầm hố với 2 màu đen trắng";
            listKetQua.Add(sp1);
            SanPhamModel sp2 = new SanPhamModel();
            sp2.ID = 2;
            sp2.TenSanPham = "YEEZY BOOST 380 STONE SALT sản phẩm 2";
            sp2.GiaTien = 6500000;
            sp2.size = "L";
            sp2.moTa = "phiên bản original hầm hố với 2 màu đen trắng";
            listKetQua.Add(sp2);
            SanPhamModel sp3 = new SanPhamModel();
            sp3.ID = 3;
            sp3.TenSanPham = "YEEZY BOOST 380 STONE SALT sản phẩm 3";
            sp3.GiaTien = 6500000;
            sp3.size = "L";
            sp3.moTa = "phiên bản original hầm hố với 2 màu đen trắng ";
            listKetQua.Add(sp3);
            SanPhamModel sp4 = new SanPhamModel();
            sp4.ID = 4;
            sp4.TenSanPham = "YEEZY BOOST 380 STONE SALT sản phẩm 4";
            sp4.GiaTien = 6500000;
            sp4.size = "L";
            sp4.moTa = "phiên bản original hầm hố với 2 màu đen trắng";
            listKetQua.Add(sp4);
            return listKetQua;
        }
        public SanPhamModel ChiTietThongTin(int id)
        {
            //id = 1 return sp1
         if(id == 1)
            {
                SanPhamModel sp1 = new SanPhamModel();
                sp1.ID = 1;
                sp1.TenSanPham = "YEEZY BOOST 380 STONE SALT";
                sp1.GiaTien = 6500000;
                sp1.size = "L";
                sp1.moTa = "phiên bản original hầm hố với 2 màu đen trắng";
                return sp1;
            }
            //id = 2 return sp2
           else if(id == 2)
            {
                SanPhamModel sp2 = new SanPhamModel();
                sp2.ID = 2;
                sp2.TenSanPham = "quần sooc 3 sọc kẻ";
                sp2.GiaTien = 1300000;
                sp2.size = "M";
                sp2.moTa = "quần chất liệu vải thấm hút mồ hôi";    
                return sp2;
            }
            //return null;
            return null;
        }
    }
}