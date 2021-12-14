using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Controller;
using Demo.Model;
using System.Data.SqlClient;

namespace Demo
{
    public partial class fUser : Form
    {
        UsersController usControl = new UsersController();
        KetNoi kn = new KetNoi();
        SqlConnection con;
        SqlCommand cm;
        UserModel usmodel = new UserModel();
        public fUser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_SHOPPETDataSet1.NhanVien);
            loadUser();
        }
        public void loadUser()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtUs = new DataTable();
                dtUs = usControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtUs;
                gunaDataGridView1.DataSource = dtUs;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenDangNhap";
                gunaDataGridView1.Columns[2].DataPropertyName = "Password";
                gunaDataGridView1.Columns[3].DataPropertyName = "Quyen";
                gunaDataGridView1.Columns[4].DataPropertyName = "TenNhanVien";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtUs = new DataTable();
                dtUs = usControl.HienThiDuLieuTiemKiem(txt_Search.Text);
                gunaDataGridView1.DataSource = dtUs;
                gunaDataGridView1.DataSource = dtUs;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenDangNhap";
                gunaDataGridView1.Columns[2].DataPropertyName = "Password";
                gunaDataGridView1.Columns[3].DataPropertyName = "Quyen";
                gunaDataGridView1.Columns[4].DataPropertyName = "TenNhanVien";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            cboMaNV.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTenTaiKhoan.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txtMK.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
            cboQuyen.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
            //txtTenNhanVien.Text = gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString();

        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("Select TenNhanVien from NhanVien where MaNhanVien='" + cboMaNV.Text + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtTenNhanVien.Text = reader.GetString(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            cboMaNV.Text = "";
            txtTenTaiKhoan.Text = "";
            txt_Search.Text = "";
            txtMK.Text = "";
            cboQuyen.Text = "";
            txtTenNhanVien.Text = "";
            cboMaNV.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn xóa '" + txtTenNhanVien.Text.Trim() + "'?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
                {
                    usmodel.XoaUser(cboMaNV.Text);
                    MessageBox.Show("Hoàn thành");
                    fUser_Load(sender, e);
                }

            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn sửa '" + txtTenNhanVien.Text.Trim() + "'?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
                {
                    usmodel.SuaUser(cboMaNV.Text, txtTenTaiKhoan.Text, txtMK.Text, cboQuyen.Text);
                    MessageBox.Show("Hoàn thành");
                    fUser_Load(sender, e);
                }

            }
            catch { }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtTenTaiKhoan.Text == "") || (txtMK.Text == ""))
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                }
                else
                {
                    if (usmodel.ThemUser(cboMaNV.Text, txtTenTaiKhoan.Text.Trim(), txtMK.Text.Trim(), cboQuyen.Text))
                    {
                        MessageBox.Show("Thêm thành công nhân viên'" + txtTenNhanVien.Text.Trim() + "'", "Thông báo");
                        fUser_Load(sender, e);
                        btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = true;
                    }
                    else
                        MessageBox.Show("Thêm thất bại. Mã nhân viên '" + cboMaNV.Text + "' đã tồn tại ", "Thông báo");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = "";
            txtMK.Text = "";
            txtTenTaiKhoan.Text = "";
            txt_Search.Text = "";
            loadUser();
        }
    }
}
