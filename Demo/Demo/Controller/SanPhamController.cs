using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;


namespace Demo.Controller
{
    class SanPhamController
    {
        SanPhamModel SanPhamMod = new SanPhamModel();
        public DataTable HienThiDuLieu()
        {
            return SanPhamMod.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTimKiem(string maSP)
        {
            return SanPhamMod.HienThiDuLieuTimKiem(maSP);
        }
        public bool ThemDuLieuSP(string maSanPham, string MaNhaPP, string TenSP, string LoaiSP, string HangSX, float GiaBan, int TonKho, string Anh, string ChuThich)
        {
            return SanPhamMod.ThemSanPham(maSanPham, MaNhaPP, TenSP, LoaiSP, HangSX, GiaBan, TonKho, Anh, ChuThich);
        }
        public Boolean KiemTraSanPham(string maSP)
        {
            return SanPhamMod.kiemTraTonTai(maSP);
        }
        public Boolean kiemTraTonTaiChiTietKhuyenMai(string maSPPN)
        {
            return SanPhamMod.kiemTraTonTaiChiTietKhuyenMai(maSPPN);
        }
        public Boolean kiemTraTonTaichitiethoadon(string maSP)
        {
            return SanPhamMod.kiemTraTonTaiChiTietHoaDon(maSP);
        }
        public Boolean kiemTraTonTaihoadon(string maSP)
        {
            return SanPhamMod.kiemTraMASP_HD(maSP);
        }
        public Boolean kiemTraTonTaiChiTietPhieuNhap(string maSP)
        {
            return SanPhamMod.kiemTraTonTaiChiTietPhieuNhap(maSP);
        }
        public bool XoaDuLieuSP(string maSanPhamSP)
        {
            return SanPhamMod.XoaSanPham(maSanPhamSP);
        }
        public bool KiemtraMASP(string ma)
        {
            return SanPhamMod.kiemTraMASP_HD(ma);
        }
        public bool SuaDuLieuSP(string maSanPham, string MaNhaPP, string TenSP, string LoaiSP, string HangSX, float GiaBan, int TonKho, string Anh, string ChuThich)
        {
            return SanPhamMod.SuaSanPham(maSanPham, MaNhaPP, TenSP, LoaiSP, HangSX, GiaBan, TonKho, Anh, ChuThich);
        }

    }
}
