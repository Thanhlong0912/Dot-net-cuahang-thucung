using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;
namespace Demo.Controller
{
    class HoaDonController
    {
        HoaDonModel SpMod = new HoaDonModel();
        public DataTable HienThiDuLieu()
        {
            return SpMod.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTimKiem(string maHD)
        {
            return SpMod.HienThiDuLieuTimKiem(maHD);
        }
        public bool ThemHD(string MaHoaDon, string MaKhachHang, string MaNhanVien, string MaSanPham, string NgayLapHoaDon, string TongTien, string GhiChu)
        {
            return SpMod.ThemHoaDon(MaHoaDon, MaKhachHang, MaNhanVien, MaSanPham, NgayLapHoaDon, TongTien, GhiChu);
        }
        public bool XoaDuLieuHD(string maHD)
        {
            return SpMod.XoaHoaDon(maHD);
        }
        public bool SuaDuLieuhd(string MaHoaDon, string MaKhachHang, string MaNhanVien, string MaSanPham, DateTime NgayLapHoaDon, float TongTien, string GhiChu)
        {
            return SpMod.SuaHoaDon(MaHoaDon, MaKhachHang, MaNhanVien, MaSanPham, NgayLapHoaDon, TongTien, GhiChu);
        }
        public bool KiemtraMAHD(string ma)
        {
            return SpMod.kiemTraTonTaiMaHD(ma);
        }
        public Boolean kiemTraTonTaichitiethoadon(string maSP)
        {
            return SpMod.kiemTraTonTaiChiTietHoaDon(maSP);
        }
    }
}
