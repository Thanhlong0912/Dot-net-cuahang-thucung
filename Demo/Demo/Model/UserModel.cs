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
    class UserModel
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        KetNoi kn = new KetNoi();
        //đóng mở kết nối csdl
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
        //Load dữ liệu cho datagidview
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM Users";
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
            string sql = "SELECT * FROM Users where MaNhanVien LIKE '%" + maSP + "%' or TenDangNhap LIKE N'%" + maSP + "%' or Quyen LIKE N'%" + maSP + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool ThemUser(string maNV, string username, string password, string
            quyen)
        {
            string sqlThem = "insert into Users values ('" + maNV + "', '" + username + "','" + password + "','" + quyen + "','" + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maNV)
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
        public bool XoaUser(string maNV)
        {
            string sqlThem = "DELETE FROM Users WHERE MaNhanVien= '" + maNV + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaUser(string maNV, string username, string password, string
            quyen)
        {
            string sqlSua = "UPDATE Users set TenDangNhap= N'" + username + "',Password= '" + password + "', Quyen= N'" + quyen + "' where MaNhanVien='" + maNV + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }

    }
}