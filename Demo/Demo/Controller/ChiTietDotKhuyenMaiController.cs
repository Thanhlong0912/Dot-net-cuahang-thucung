using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class ChiTietDotKhuyenMaiController
    {
        ChiTietKhuyenMaiModel CtdkmMod = new ChiTietKhuyenMaiModel();
        public DataTable HienThiDuLieu()
        {
            return CtdkmMod.HienThiDuLieu();
        }
        public bool ThemDuLieuCTKM(string maDot, string MaSP, float tileGG)
        {
            return CtdkmMod.ThemChiTietKhuyenMai(maDot, MaSP, tileGG);
        }
        public Boolean KiemTraMaCTHD(string maDot)
        {
            return CtdkmMod.kiemTraTonTai(maDot);
        }
        public bool SuaKhuyenMai(string maDot, string MaSP, float tileGG)
        {
            return CtdkmMod.SuaCTKhuyenMai(maDot, MaSP, tileGG);
        }
        public bool XoaKhuyenMai(string maDot)
        {
            return CtdkmMod.XoaCTKhuyenMai(maDot);
        }
        
    }
}
