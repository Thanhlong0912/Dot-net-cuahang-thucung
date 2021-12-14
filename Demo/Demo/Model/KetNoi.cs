using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Demo.Model
{
    class KetNoi
    {
   
        SqlConnection conn;
        AppSetting appset = new AppSetting();

        //public KetNoi()
        //{
        //    string con = appset.getConnectionString("QL_SHOPPETConnectionString");
        //   con = new SqlConnection(conDB);
        //}
        public SqlConnection conDB()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N211K22\SQL;Initial Catalog=QL_SHOPPET;Persist Security Info=True;User ID=sa;Password=123");
            //return con;
            SqlConnection con = new SqlConnection(appset.getConnectionString("QL_SHOPPETConnectionString"));
            return con;

        }
        public bool testConnection(string conne)
        {
            try
            {
                conn = new SqlConnection(conne);
                conn.Open();
                conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

         }
        //public void MoKetNoi()
        //{
        //    try
        //    {
        //        if (conn == null)
        //        {
        //            path = Path.GetFullPath(Environment.CurrentDirectory);
        //            conn = new SqlConnection(@"Data Source=DESKTOP-80GNDH8\SQLEXPRESS;Initial Catalog=QL_SHOPPET;Persist Security Info=True;User ID=sa;Password=123");
        //        }
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
        //    }
        //}
        //public void DongKetNoi()
        //{
        //    try
        //    {
        //        if (conn != null && conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }
        //    catch { MessageBox.Show("Lỗi cơ sở dữ liệu"); }
        //}
        //public DataTable DuLieuTable(string sql)
        //{
        //    try
        //    {
        //        MoKetNoi();
        //        da = new SqlDataAdapter(sql, conn);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //    }
        //    catch
        //    { }
        //    return dt;
        //}
        //public int ExeCuteNonQuery(String sql)
        //{
        //    int re = 0;
        //    try
        //    {
        //        MoKetNoi();
        //        cmd = new SqlCommand(sql, conn);
        //        re = cmd.ExecuteNonQuery();
        //        DongKetNoi();
        //    }
        //    catch
        //    {

        //    }
        //    return re;
        //}
        //public string LoadDuLieu(string sql)
        //{
        //    string ketQua = "";
        //    MoKetNoi();
        //    cmd = new SqlCommand(sql, conn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        ketQua = dr[0].ToString();
        //    }
        //    DongKetNoi();
        //    return ketQua;
        //}
        //public void Update(String sql, DataTable table)
        //{
        //    try
        //    {
        //        da = new SqlDataAdapter(sql, conn);
        //        cmb = new SqlCommandBuilder(da);
        //        da.Update(table);
        //    }
        //    catch
        //    { MessageBox.Show("Lỗi"); }
        //}
    }
}