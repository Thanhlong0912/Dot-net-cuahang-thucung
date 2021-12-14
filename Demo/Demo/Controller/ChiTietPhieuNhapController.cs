using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class ChiTietPhieuNhapController
    {
        ChiTietPhieuNhapModel ctPNMod = new ChiTietPhieuNhapModel();
        public DataTable HienThiDuLieu()
        {
            return ctPNMod.HienThiDuLieu();
        }
        public bool ThemDuCTPN(string maPN, string maSP, int sl, float tongtien, string chuthich)
        {
            return ctPNMod.ThemChiTietPhieuNhap(maPN, maSP, sl, tongtien, chuthich);
        }
        public bool SuaCTPN(string maPN, string maSP, int sl, float tongtien, string chuthich)
        {
            return ctPNMod.SuaCTPN(maPN, maSP, sl, tongtien, chuthich);
        }
        public bool XoaCTPN(string maPN)
        {
            return ctPNMod.XoaCTPN(maPN);
        }
        public Boolean KiemTraMaSanPham(string maSP)
        {
            return ctPNMod.kiemTraTonTaiTonTai(maSP);
        }
    }
}

