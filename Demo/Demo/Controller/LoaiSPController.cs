using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class LoaiSPController
    {
        LoaiSPModel SpMod = new LoaiSPModel();
        public DataTable HienThiDuLieu()
        {
            return SpMod.HienThiDuLieu();
        }
        public bool ThemDuLieuLoaiSP(string maLSanPham, string TenLoaiSP)
        {
            return SpMod.ThemLoaiSP(maLSanPham, TenLoaiSP);
        }
        public Boolean KiemTraSanPham(string maSP)
        {
            return SpMod.kiemTraTonTaiLoaiSP(maSP);
        }

        public Boolean kiemTraTonTaiTrongBangSanPham(string maSP)
        {
            return SpMod.kiemTraTonTaiTrongBangSanPham(maSP);
        }
        public bool XoaDuLieuSP(string maSanPhamSP)
        {
            return SpMod.XoaSanPham(maSanPhamSP);
        }

        public bool SuaDuLieuSP(string maSanPham, string TenLoaiSP)
        {
            return SpMod.SuaLoaiSP(maSanPham, TenLoaiSP);
        }
    }
}
