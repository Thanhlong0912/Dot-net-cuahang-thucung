using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class NhanVienController
    {
        NhanVienModel NvMod = new NhanVienModel();
        public DataTable HienThiDuLieu()
        {
            return NvMod.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTimKiem(string maNV)
        {
            return NvMod.HienThiDuLieuTimKiem(maNV);
        }
        public bool ThemDuLieuSP(string maNV, string TenNV, DateTime NgaySinh, string GioiTinh, DateTime NVL, string chucvu, string diachi, string sdt, string GhiChu)
        {
            return NvMod.ThemNhanVien(maNV, TenNV, NgaySinh, GioiTinh, NVL, chucvu, diachi, sdt, GhiChu);
        }
        public Boolean KiemTraMaSanPham(string maSP)
        {
            return NvMod.kiemTraTonTaiNhanVienTonTaiTrongBangNV(maSP);
        }
        public Boolean kiemTraTonTaiUser(string maUsser)
        {
            return NvMod.kiemTraTonTaiNhanVienTonTaiTrongBangUSER(maUsser);
        }
        public Boolean kiemTraTonTaihoadon(string maSP)
        {
            return NvMod.kiemTraTonTaiNhanVienTonTaiTrongBangHoaDon(maSP);
        }
        public Boolean kiemTraTonTaiPhieuNhap(string maSP)
        {
            return NvMod.kiemTraTonTaiNhanVienTonTaiTrongBangPN(maSP);
        }

        public bool XoaDuLieuSP(string maSanPhamSP)
        {
            return NvMod.XoaNhanVien(maSanPhamSP);
        }

        public bool SuaDuLieuSP(string maNV, string TenNV, DateTime NgaySinh, string GioiTinh, DateTime NVL, string chucvu, string diachi, string sdt, string GhiChu)
        {
            return NvMod.SuaNhanVien(maNV, TenNV, NgaySinh, GioiTinh, NVL, chucvu, diachi, sdt, GhiChu);
        }
    }
}
