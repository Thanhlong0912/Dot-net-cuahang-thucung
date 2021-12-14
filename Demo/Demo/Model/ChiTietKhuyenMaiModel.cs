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
    class ChiTietKhuyenMaiModel
    {
   
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
      KetNoi kn = new KetNoi();
        //đóng mở kết nối csdl
    
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM ChiTietDotKhuyenMai";
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
        public bool ThemChiTietKhuyenMai(string maDot, String MaSP, float tileGG)
        {
            string sqlThem = "insert into ChiTietDotKhuyenMai values ('" + maDot + "','" + MaSP + "', '" + tileGG + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }

        public bool XoaCTKhuyenMai(string maDot)
        {
            string sqlXoa = "DELETE FROM ChiTietDotKhuyenMai WHERE MaDot= '" + maDot + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaCTKhuyenMai(string maDot, String MaSP, float tileGG)
        {
            string sqlSua = "UPDATE ChiTietDotKhuyenMai set MaSP= '" + MaSP + "',TiLeGiamGia= '" + tileGG + "' where MaDot='" + maDot + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maDot)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietDotKhuyenMai where MaDot='" + maDot + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maDot == dr.GetString(0))
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
