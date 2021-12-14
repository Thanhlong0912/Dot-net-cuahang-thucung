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
    class PhieuNhapModel
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        //đóng mở kết nối csdl
        KetNoi kn = new KetNoi();
        string path;
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
            string sql = "SELECT * FROM PhieuNhap";
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
            string sql = "SELECT * FROM PhieuNhap where MaNhanVien LIKE '%" + maSP + "%' or MaPhieuNhap LIKE '%" + maSP + "%' or MaNhaPhanPhoi LIKE '%" + maSP + "%' or NgayNhap LIKE '%" + maSP + "%'";
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
        public bool ThemPN(string maPN, string maNV, string MaNPP, float TONGTIEN, DateTime
            ngaynhap, string chuthich)
        {
            string sqlThem = "insert into PhieuNhap values ('" + maPN + "', '" + maNV + "','" + MaNPP + "','" + TONGTIEN + "','" + ngaynhap + "','" + chuthich + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maPN)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap where MaPhieuNhap='" + maPN + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maPN == dr.GetString(0))
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

        public bool kiemTraTonTaiChiTietPhieuNhap(string maPN)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap where MaPhieuNhap='" + maPN + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maPN == dr.GetString(0))
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
        public bool XoaPN(string maPN)
        {
            string sqlXoa = "DELETE FROM PhieuNhap WHERE MaPhieuNhap= '" + maPN + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaPN(string maPN, string maNV, string MaNPP, float TONGTIEN, DateTime
            ngaynhap, string chuthich)
        {
            string sqlSua = "UPDATE PhieuNhap set MaNhanVien= N'" + maNV + "',MaNhaPhanPhoi= '" + MaNPP + "', TongTien= N'" + TONGTIEN + "',NgayNhap = '" + ngaynhap + "',ChuThich = N'" + chuthich + "' where MaPhieuNhap='" + maPN + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }

    }
}
