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
    class KhachHangModel
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
            string sql = "SELECT * FROM KhachHang";
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
            string sql = "SELECT * FROM KhachHang where MaKhachHang LIKE '%" + maSP + "%' or TenKhachHang LIKE N'%" + maSP + "%' or GioiTinh LIKE N'%" + maSP + "%' or LoaiKhachHang LIKE N'%" + maSP + "%'";
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
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }
        public bool ThemKhachHang(string maKH, string tenKH, DateTime ngaysinh, string gioitinh, string
            diachi, string sdt, string loaiKH, string ghichu)
        {
            string sqlThem = "insert into KhachHang values ('" + maKH + "', '" + tenKH + "','" + ngaysinh + "','" + gioitinh + "','" + diachi + "','" + sdt + "','" + loaiKH + "','" + ghichu + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maKH)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang where MaKhachHang='" + maKH + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maKH == dr.GetString(0))
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
        public bool kiemTraTonTaiTrongBangHoaDon(string maKH)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where MaKhachHang='" + maKH + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maKH == dr.GetString(1))
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
        public bool XoaKH(string maKH)
        {
            string sqlXoa = "DELETE FROM KhachHang WHERE MaKhachHang= '" + maKH + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaKH(string maKH, string tenKH, DateTime ngaysinh, string gioitinh, string
            diachi, string sdt, string loaiKH, string ghichu)
        {
            string sqlSua = "UPDATE KhachHang set TenKhachHang= N'" + tenKH + "',Ngaysinh= '" + ngaysinh + "', GioiTinh= N'" + gioitinh + "',DiaChi = '" + diachi + "',SDT = N'" + sdt + "',LoaiKhachHang = N'" + loaiKH + "',GhiChu='" + ghichu + "' where MaKhachHang='" + maKH + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
