using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Demo.Model
{
    class SanPhamModel
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoi kn = new KetNoi();
        //đóng mở kết nối csdl
        //Load dữ liệu cho datagidview
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable HienThiDuLieuTimKiem(string maSP) //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM SanPham where MaSanPham LIKE '%" + maSP + "%' or TenSanPham LIKE N'%" + maSP + "%' or MaNhaPhanPhoi LIKE '%" + maSP + "%' or HangSanXuat LIKE '%" + maSP + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                conn = kn.conDB();
                conn.Open(); ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }

        //Thêm 1 tài khoản mới
        public bool ThemSanPham(string maSanPham, string MaNhaPP, string TenSP, string LoaiSP, string HangSX, float GiaBan, int TonKho, string Anh, string ChuThich)
        {
            string sqlThem = "INSERT INTO [SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('" + maSanPham + "','" + MaNhaPP + "', N'" + TenSP + "','" + LoaiSP + "','" + HangSX + "'," + GiaBan + "," + TonKho + ",N'" + Anh + "',N'" + ChuThich + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maSP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham where MaSanPham='" + maSP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maSP == dr.GetString(0))
                    {
                        tatkt = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }

        public bool kiemTraMASP_HD(string maSP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where MaSanPham='" + maSP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maSP == dr.GetString(3))
                    {
                        tatkt = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }
        public bool kiemTraTonTaiChiTietKhuyenMai(string maSP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietDotKhuyenMai where MaSanPham='" + maSP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maSP == dr.GetString(1))
                    {
                        tatkt = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }
        public bool kiemTraTonTaiChiTietPhieuNhap(string maSP_PN)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap where MaSanPham='" + maSP_PN + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maSP_PN == dr.GetString(1))
                    {
                        tatkt = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }
        //public bool kiemTraTonTaiHoaDon(string maSP)
        //{
        //    conn = kn.conDB();
        //    conn.Open();
        //    bool tatkt = false;
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where MaSanPham='" + maSP + "'", conn);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (maSP == dr.GetString(3))
        //            {
        //                tatkt = true;
        //                break;
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("" + ex);
        //    }
        //    conn.Close();
        //    return tatkt;
        //}
        public bool kiemTraTonTaiChiTietHoaDon(string maSP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon where MaSanPham='" + maSP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maSP == dr.GetString(1))
                    {
                        tatkt = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }

        ////Sửa thông tin khách
        //public bool SuaKhachHang(string maKhachHang, string LienHe, string TenDonVi, string TheThanhVien)
        //{
        //    string sqlSua = "UPDATE [KhachHang] SET [MaKhachHang] = '" + maKhachHang + "',[LienHe] =  N'" + LienHe + "',[TenDonVi] =  N'" + TenDonVi + "',[TheThanhVien] = N'" + TheThanhVien + "' WHERE maKhachHang='" + maKhachHang + "'";
        //    bool kt = false;
        //    if (ExecuteNonQuery(sqlSua) > 0)
        //    {
        //        kt = true;
        //    }
        //    return kt;
        //}
        ////Xóa khách hàng
        //public bool XoaKhachHang(string maKhachHang)
        //{
        //    string sqlXoa = "DELETE FROM [KhachHang] WHERE MaKhachHang='" + maKhachHang + "'";
        //    bool kt = false;
        //    if (ExecuteNonQuery(sqlXoa) > 0)
        //    {
        //        kt = true;
        //    }
        //    return kt;
        //}

        public bool XoaSanPham(string maSP)
        {
            string sqlXoa = "DELETE FROM SanPham WHERE MaSanPham= '" + maSP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaSanPham(string maSP, string MANPP, string tenSP, string loaiSP, string
            hangSX, float giaban, int tonkho, string imgae, string chuthich)
        {
            string sqlSua = "UPDATE SanPham set MaNhaPhanPhoi= N'" + MANPP + "',TenSanPham= '" + tenSP + "', LoaiSanPham= N'" + loaiSP + "',HangSanXuat = '" + hangSX + "',GiaBan = '" + giaban + "',TonKho = '" + tonkho + "',Image='" + imgae + "',ChuThich='" + chuthich + "' where MaSanPham='" + maSP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
