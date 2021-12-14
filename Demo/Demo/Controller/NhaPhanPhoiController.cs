using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;

namespace Demo.Controller
{
    class NhaPhanPhoiController
    {
        NhaPhanPhoiModel NhMod = new NhaPhanPhoiModel();
        public DataTable HienThiDuLieu()
        {
            return NhMod.HienThiDuLieu();
        }
        public bool ThemDuLieuNPP(string maNPP, string TenNhanPhanPhoi, string DiaChi, string SDT, string Email, string Chuthich)
        {
            return NhMod.ThemNhaPhanPhoi(maNPP, TenNhanPhanPhoi, DiaChi, SDT, Email, Chuthich);
        }
        public bool KiemTraMaTonTai(string maNPP)
        {
            return NhMod.kiemTraTonTai(maNPP);
        }
        public bool KiemTraMaTonTaiTrongBangPhieuNhap(string maNPP)
        {
            return NhMod.kiemTraTonTaiTrongBangPhieuNhap(maNPP);
        }
        public bool KiemTraMaTonTaiTrongBangNhanVien(string maNPP)
        {
            return NhMod.kiemTraTonTaiTrongBangSanPham(maNPP);
        }


        public bool XoaDuLieuNPP(string maSanPhamSP)
        {
            return NhMod.XoaNPP(maSanPhamSP);
        }

        public bool SuaDuLieuNPP(string maNPP, string TenNhanPhanPhoi, string DiaChi, string SDT, string Email, string Chuthich)
        {
            return NhMod.SuaNPP(maNPP, TenNhanPhanPhoi, DiaChi, SDT, Email, Chuthich);
        }

    }
}
