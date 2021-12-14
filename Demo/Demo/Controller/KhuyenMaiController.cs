using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;
namespace Demo.Controller
{
    class KhuyenMaiController
    {
        KhuyenMaiModel KmMod = new KhuyenMaiModel();
        public DataTable HienThiDuLieu()
        {
            return KmMod.HienThiDuLieu();
        }
        public bool ThemDuLieuKM(string maDot, DateTime NgayBD, DateTime NgayKT)
        {
            return KmMod.ThemKhuyenMai(maDot, NgayBD, NgayKT);
        }
        public Boolean KiemTraSanPham(string maDot)
        {
            return KmMod.kiemTraTonTai(maDot);
        }
        public bool SuaKhuyenMai(string maDot, DateTime NgayBD, DateTime NgayKT)
        {
            return KmMod.SuaKhuyenMai(maDot, NgayBD, NgayBD);
        }
        public bool XoaKhuyenMai(string maDot)
        {
            return KmMod.XoaKhuyenMai(maDot);
        }
        public Boolean KiemTraSanPhamChiTietKhuyenMai(string maDot)
        {
            return KmMod.kiemTraTonTaiChiTietKhuyenMai(maDot);
        }
    }
}
