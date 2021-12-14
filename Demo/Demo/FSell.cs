using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Demo.Model;
namespace Demo
{
    public partial class FSell : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection con;
        SqlCommand cm;
        public FSell()
        {
            InitializeComponent();
        }

        private void FSell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qL_SHOPPETDataSet.HoaDon);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_SHOPPETDataSet.SanPham);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_SHOPPETDataSet.KhachHang);

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("Select TenKhachHang from KhachHang where MaKhachHang='" + gunaComboBox1.Text + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtTenKhacHang.Text = reader.GetString(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("Select TenSanPham from SanPham where MaSanPham='" + gunaComboBox2.Text + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtTenSanPham.Text = reader.GetString(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }
        public void Alert(string msg, Form_Alert1.enmType type)
        {
            Form_Alert1 frm = new Form_Alert1();
            frm.showAlert(msg, type);
        }
        private void cboxGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("Select SoLuong from ChiTietHoaDon where MaHoaDon='" + cboxGioiTinh.Text + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string b = reader.GetInt32(0).ToString();
                    txtSoLuong.Text = b.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("Select TongTienHoaDon from ChiTietHoaDon where MaHoaDon='" + cboxGioiTinh.Text + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string b = reader.GetDouble(0).ToString();
                    txtTongTien.Text = b.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("Select TongTien from ChiTietHoaDon where MaHoaDon='" + cboxGioiTinh.Text + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string b = reader.GetDouble(0).ToString();
                    DonGia.Text = b.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "----------------------------CỬA HÀNG THÚ CƯNG SHOPPET------------------------";
                string a = "Tên Khách Hàng: " + txtTenKhacHang.Text + "";
                string b = "Tên Sản Phẩm: " + txtTenSanPham.Text + "";
                string c = "Số Lương: " + txtSoLuong.Text + "";
                string d = "Giá: " + DonGia.Text + "";
                string g = "Tổng Tiền: " + txtTongTien.Text + "";
                string f = "Ghi chú: " + txtGhiChu.Text + "";
                string name2 = "----------------------------XIN CHÂN THÀNH CẢM ƠN QUÝ KHÁCH------------------------";
                string[] names = new string[] { name, a, b, c, d, g, f ,name2};

                using (StreamWriter sw = new StreamWriter("hoadon.txt"))
                {
                    foreach (string s in names)
                    {

                        sw.WriteLine(s);
                    } sw.Close();
                }
                this.Alert("Xuất Hoá Đơn Thành Công", Form_Alert1.enmType.Success);
            }
            catch
            {
                this.Alert("Đã xảy ra lỗi!!", Form_Alert1.enmType.Error);
            }
            
        }
    }
}
