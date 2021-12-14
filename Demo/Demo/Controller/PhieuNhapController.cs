using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;
namespace Demo.Controller
{
    class PhieuNhapController
    {
        PhieuNhapModel pNMod = new PhieuNhapModel();
        public DataTable HienThiDuLieu()
        {
            return pNMod.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTimKiem(string MaPN)
        {
            return pNMod.HienThiDuLieuTimKiem(MaPN);
        }
        public bool ThemDuLieuPN(string maPN, string MaNV, string MaNPP, float Tongtien, DateTime NgayNhap, string ChuThich)
        {
            return pNMod.ThemPN(maPN, MaNV, MaNPP, Tongtien, NgayNhap, ChuThich);
        }
        public bool SuaDuLieuPN(string maPN, string MaNV, string MaNPP, float Tongtien, DateTime NgayNhap, string ChuThich)
        {
            return pNMod.SuaPN(maPN, MaNV, MaNPP, Tongtien, NgayNhap, ChuThich);
        }
        public bool XoaDuLieuSP(string maPN)
        {
            return pNMod.XoaPN(maPN);
        }
        public Boolean KiemTraSanPham(string maPN)
        {
            return pNMod.kiemTraTonTai(maPN);
        }
        public Boolean KiemTraChiTietPhieuNhap(string maPN)
        {
            return pNMod.kiemTraTonTaiChiTietPhieuNhap(maPN);
        }
    }
}

