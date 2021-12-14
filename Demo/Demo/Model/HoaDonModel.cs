using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Demo.Model;
namespace Demo.Model
{
    class HoaDonModel
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
            string sql = "SELECT * FROM HoaDon";
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
            string sql = "SELECT * FROM HoaDon where MaHoaDon LIKE '%" + maSP + "%' or MaSanPham LIKE '%" + maSP + "%' or MaNhanVien LIKE '%" + maSP + "%' or NgayLapHoaDon LIKE '%" + maSP + "%'";
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
        public bool ThemHoaDon(string MaHoaDon, string MaKhachHang, string MaNhanVien, string MaSanPham, string NgayLapHoaDon, string TongTien, string GhiChu)
        {
            string sqlThem = "INSERT INTO [HoaDon] ([MaHoaDon], [MaKhachHang],[MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES " +"('" + MaHoaDon + "','" + MaKhachHang + "', '" + MaNhanVien + "','" + MaSanPham + "','" + NgayLapHoaDon + "'," + TongTien + ",N'" + GhiChu  + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool XoaHoaDon(string maHD)
        {
            string sqlXoa = "DELETE FROM HoaDon WHERE MaHoaDon= '" + maHD + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaHoaDon(string MaHoaDon, string MaKhachHang, string MaNhanVien, string MaSanPham, DateTime NgayLapHoaDon, float TongTien, string GhiChu)
        {
            string sqlSua = "UPDATE HoaDon set MaKhachHang= N'" + MaKhachHang + "',MaNhanVien= '" + MaNhanVien + "', MaSanPham= N'" + MaSanPham + "', NgayLapHoaDon = '" + NgayLapHoaDon + "',TongTien = '" + TongTien + "',GhiChu = '" + GhiChu + "' where MaHoaDon='" + MaHoaDon + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }

        public bool kiemTraTonTaiChiTietHoaDon(string maSP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon where MaHoaDon='" + maSP + "'", conn);
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
        public bool kiemTraTonTaiMaHD(string maSP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where MaHoaDon='" + maSP + "'", conn);
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
    }
}