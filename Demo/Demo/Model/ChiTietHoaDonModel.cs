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
    class ChiTietHoaDonModel
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
            string sql = "SELECT * FROM ChiTietHoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool XoaCTHoaDon(string maSP)
        {
            string sqlXoa = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon= '" + maSP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaHoaDon(string MaHoaDon, string MaSanPham, float MucGiam, int SoLuong, float TongTien,float 
            TongTienHoaDon, DateTime NgayDat, DateTime NgayGiao, string GhiChu)
        {
            string sqlSua = "UPDATE ChiTietHoaDon set MaSanPham= N'" + MaSanPham + "',MucGiam= '" + MucGiam + "'," +
                " SoLuong= N'" + SoLuong + "',TongTien = '" + TongTien + "',TongTienHoaDon = '" + TongTienHoaDon + "',NgayDat = '" + NgayDat + "',NgayGiao='" + NgayGiao + "',GhiChu='" + GhiChu + "' where MaHoaDon='" + MaHoaDon + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
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
        public bool ThemChiTietHoaDon(string MaHoaDon, string MaSanPham, string MucGiam, string SoLuong, string TongTien, string
            TongTienHoaDon, string NgayDat, string NgayGiao, string GhiChu)
        {
            string sqlThem = "INSERT INTO ChiTietHoaDon ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('"+ MaHoaDon + "','" + MaSanPham + "', " + MucGiam + "," + SoLuong+ "," + TongTien + "," + TongTienHoaDon + ",'" + NgayDat + "','" + NgayGiao + "',N'" + GhiChu + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maCTHĐ)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon where MaHoaDon='" + maCTHĐ + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maCTHĐ == dr.GetString(0))
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
