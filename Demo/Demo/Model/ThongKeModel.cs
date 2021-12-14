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
    class ThongKeModel
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

                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();

            }
            catch
            { }
            return dung;
        }
        //Load dữ liệu cho datagidview
        public DataTable HienThiThongKeNam(string nam) //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT HoaDon.MaHoaDon,ChiTietHoaDon.MaSanPham, ChiTietHoaDon.SoLuong, ChiTietHoaDon.TongTien, ChiTietHoaDon.TongTienHoaDon, HoaDon.NgayLapHoaDon FROM ChiTietHoaDon INNER JOIN HoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon WHERE (YEAR(HoaDon.NgayLapHoaDon) = '" + nam + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
