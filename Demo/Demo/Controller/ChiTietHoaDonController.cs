using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class ChiTietHoaDonController
    {
        ChiTietHoaDonModel CtHdMod = new ChiTietHoaDonModel();
        public DataTable HienThiDuLieu()
        {
            return CtHdMod.HienThiDuLieu();
        }

        public bool ThemDuLieuSP(string MaHoaDon, string MaSanPham, string MucGiam, string SoLuong, string TongTien, string
            TongTienHoaDon, string NgayDat, string NgayGiao, string GhiChu)
        {
            return CtHdMod.ThemChiTietHoaDon(MaHoaDon, MaSanPham, MucGiam,  SoLuong,  TongTien, 
            TongTienHoaDon,  NgayDat, NgayGiao,  GhiChu);
        }
        public Boolean KiemTraCTHoaDon(string macthd)
        {
            return CtHdMod.kiemTraTonTai(macthd);
        }
        public bool XoaDuLieuCTHD(string maCTHD)
        {
            return CtHdMod.XoaCTHoaDon(maCTHD);
        }
        public bool kiemTraMa(string maCTHĐ)
        {
            return CtHdMod.kiemTraTonTai(maCTHĐ);
                
        }
        public bool SuaCTHĐ(string MaHoaDon, string MaSanPham, float MucGiam, int SoLuong, float TongTien, float
            TongTienHoaDon, DateTime NgayDat, DateTime NgayGiao, string GhiChu)
        {
            return CtHdMod.SuaHoaDon(MaHoaDon, MaSanPham, MucGiam, SoLuong, TongTien,
            TongTienHoaDon, NgayDat, NgayGiao, GhiChu);
        }
    }
}
