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
    class LoaiSPModel
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
                    conn = new SqlConnection(@"Data Source=DESKTOP-N211K22\SQL;Initial Catalog=QL_SHOPPET;Persist Security Info=True;User ID=sa;Password=123");
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
            //try
            //{

            //}
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM LoaiSanPham";
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
        public bool ThemLoaiSP(string maSanPham, string tenLoaiSP)
        {
            string sqlThem = "INSERT INTO [LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('" + maSanPham + "','" + tenLoaiSP + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaLoaiSP(string maLoaiSP, string TenLoaiSP)
        {
            string sqlSua = "UPDATE LoaiSanPham set TenLoaiSanPham= N'" + TenLoaiSP + "' where MaLoaiSanPham='" + maLoaiSP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool XoaSanPham(string maLoaiSP)
        {
            string sqlXoa = "DELETE FROM LoaiSanPham WHERE MaLoaiSanPham= '" + maLoaiSP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTaiTrongBangSanPham(string maLoai)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham where LoaiSanPham='" + maLoai + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maLoai == dr.GetString(3))
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
        public bool kiemTraTonTaiLoaiSP(string maLoaisp)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiSanPham where MaLoaiSanPham='" + maLoaisp + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maLoaisp == dr.GetString(0))
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