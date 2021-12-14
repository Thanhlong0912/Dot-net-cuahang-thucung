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
    class NhaPhanPhoiModel
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
            string sql = "SELECT * FROM NhaPhanPhoi";
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

        //Thêm 1 tài khoản mới
        public bool ThemNhaPhanPhoi(string maNPP, string tenNPP, string DIACHI, string SDT,
            string EMAIL, string ghichu)
        {
            string sqlThem = "insert into NhaPhanPhoi values ('" + maNPP + "', '" + tenNPP + "','" + DIACHI + "','" + SDT + "','" + EMAIL + "','" + ghichu + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }



        //
        public bool kiemTraTonTai(string maNPP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaPhanPhoi where MaNhaPhanPhoi='" + maNPP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNPP == dr.GetString(0))
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
        public bool kiemTraTonTaiTrongBangSanPham(string maNPP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham where MaNhaPhanPhoi='" + maNPP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNPP == dr.GetString(1))
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
        public bool kiemTraTonTaiTrongBangPhieuNhap(string maNPP)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap where MaNhaPhanPhoi='" + maNPP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNPP == dr.GetString(2))
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
        //Sửa thông tin khách
        public bool SuaNPP(string maNPP, string tenNPP, string DIACHI, string SDT,
            string EMAIL, string ghichu)
        {
            string sqlSua = "UPDATE NhaPhanPhoi set TenNhaPhanPhoi= N'" + tenNPP + "',DiaChi= '" + DIACHI + "', SDT= N'" + SDT + "',Email = '" + EMAIL + "',ChuThich = N'" + ghichu + "' where MaNhaPhanPhoi='" + maNPP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        //Xóa khách hàng
        public bool XoaNPP(string maNPP)
        {
            string sqlXoa = "DELETE FROM [NhaPhanPhoi] WHERE MaNhaPhanPhoi='" + maNPP + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
