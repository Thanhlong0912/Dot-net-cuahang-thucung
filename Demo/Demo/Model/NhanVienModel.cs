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
    class NhanVienModel
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoi kn = new KetNoi();
        string path;
        //đóng mở kết nối csdl
        public void MoKetNoi()
        {
            try
            {
                if (conn == null)
                {
                    path = Path.GetFullPath(Environment.CurrentDirectory);
                    conn = new SqlConnection(@"Data Source=PCCUATRUONG\SQLEXPRESSTRUONG;Initial Catalog=QL_SHOPPET;Persist Security Info=True;User ID=sa;Password=123");
                }
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
            }
        }
        public void DongKetNoi()
        {
            try
            {
                if ((conn != null) && (conn.State == ConnectionState.Open))
                    conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!!!");
            }
        }
        //Load dữ liệu cho datagidview
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM NhanVien";
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
            string sql = "SELECT * FROM NhanVien where MaNhanVien LIKE '%" + maSP + "%' or TenNhanVien LIKE N'%" + maSP + "%' or ChucVu LIKE '%" + maSP + "%' or GioiTinh LIKE N'%" + maSP + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //phương thức sử dụng cho thêm ,xóa ,sửa
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch (Exception)
            {


            }
            return dung;
        }
        public bool ThemNhanVien(string maNV, string tenNV, DateTime ngaysinh, string gioitinh, DateTime
            ngayvl, string chucvu, string diachi, string sdt, string ghichu)
        {
            string sqlThem = "insert into NhanVien values ('" + maNV + "', '" + tenNV + "','" + ngaysinh + "',N'" + gioitinh + "','" + ngayvl + "','" + chucvu + "','" + diachi + "','" + sdt + "','" + ghichu + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        //public bool kiemTraTonTai(string maNV)
        //{
        //    conn = kn.conDB();
        //    conn.Open();
        //    bool tatkt = false;
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien where MaNhanVien='" + maNV + "'", conn);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (maNV == dr.GetString(0))
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
        public bool XoaNhanVien(string maNV)
        {
            string sqlXoa = "DELETE FROM NhanVien WHERE MaNhanVien= '" + maNV + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaNhanVien(string maNV, string tenNV, DateTime ngaysinh, string gioitinh, DateTime
            ngayvl, string chucvu, string diachi, string sdt, string ghichu)
        {
            string sqlSua = "UPDATE NhanVien set TenNhanVien= N'" + tenNV + "',NgaySinh= '" + ngaysinh + "', GioiTinh= N'" + gioitinh + "',NgayVaoLam = '" + ngayvl + "',ChucVu = N'" + chucvu + "',DiaChi = N'" + diachi + "',SoDT='" + sdt + "',GhiChu='" + ghichu + "' where MaNhanVien='" + maNV + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTaiNhanVienTonTaiTrongBangPN(string maNV)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap where MaNhanVien='" + maNV + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNV == dr.GetString(1))
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
        public bool kiemTraTonTaiNhanVienTonTaiTrongBangNV(string maNV)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien where MaNhanVien='" + maNV + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNV == dr.GetString(0))
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
        public bool kiemTraTonTaiNhanVienTonTaiTrongBangUSER(string maNV)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Users where MaNhanVien='" + maNV + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNV == dr.GetString(0))
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
        public bool kiemTraTonTaiNhanVienTonTaiTrongBangHoaDon(string maNV)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where MaNhanVien='" + maNV + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNV == dr.GetString(0))
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
