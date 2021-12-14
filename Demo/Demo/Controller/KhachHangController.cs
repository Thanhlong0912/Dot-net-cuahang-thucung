using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Demo.Model;
namespace Demo.Controller
{
    class KhachHangController
    {
        KhachHangModel kHMod = new KhachHangModel();
        public DataTable HienThiDuLieu()
        {
            return kHMod.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTK(string maKH)
        {
            return kHMod.HienThiDuLieuTimKiem(maKH);
        }
        public bool ThemDuLieuKH(string maKH, string tenKH, DateTime NgaySinh, string gioitinh, string diachi, string sdt, string loaiKH, string ChuThich)
        {
            return kHMod.ThemKhachHang(maKH, tenKH, NgaySinh, gioitinh, diachi, sdt, loaiKH, ChuThich);
        }
        public bool XoaDuLieuSP(string maSanPhamSP)
        {
            return kHMod.XoaKH(maSanPhamSP);
        }

        public bool SuaDuLieuSP(string maKH, string tenKH, DateTime NgaySinh, string gioitinh, string diachi, string sdt, string loaiKH, string ChuThich)
        {
            return kHMod.SuaKH(maKH, tenKH, NgaySinh, gioitinh, diachi, sdt, loaiKH, ChuThich);
        }
        public bool KiemTraMaTonTai(string maKH)
        {
            return kHMod.kiemTraTonTai(maKH);
        }
        public bool KiemTraMaTonTaiTrongBangHoaDon(string maNPP)
        {
            return kHMod.kiemTraTonTaiTrongBangHoaDon(maNPP);
        }
    }
}
