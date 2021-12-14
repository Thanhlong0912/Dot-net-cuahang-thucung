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
    class ChiTietPhieuNhapModel
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
            string sql = "SELECT * FROM ChiTietPhieuNhap";
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
        public bool ThemChiTietPhieuNhap(string maPN, string maSP, int sl, float tongtien, string chuthich)
        {
            string sqlThem = "insert into ChiTietPhieuNhap values ('" + maPN + "', '" + maSP + "','" + sl + "','" + tongtien + "','" + chuthich + "')";
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
        public bool XoaCTPN(string mactpn)
        {
            string sqlXoa = "DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap= '" + mactpn + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaCTPN(string maPN, string maSP, int sl, float tongtien, string chuthich)
        {
            string sqlSua = "UPDATE ChiTietPhieuNhap set MaSanPham= '" + maSP + "',SoLuong= '" + sl + "', TongTien= '" + tongtien + "',ChuThich= '" + chuthich + "' where MaPhieuNhap='" + maPN + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTaiTonTai(string maNV)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap where MaPhieuNhap='" + maNV + "'", conn);
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