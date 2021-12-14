using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Controller;
using System.Text.RegularExpressions;
using Demo.Model;

namespace Demo
{
    public partial class fLoadHanSanXuat : Form
    {
        NhaPhanPhoiController NhControl = new NhaPhanPhoiController();
        DataTable dtNhaPhanPhoi = new DataTable();
        NhaPhanPhoiModel nppModel = new NhaPhanPhoiModel();
        public fLoadHanSanXuat()
        {
            InitializeComponent();
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLoadHanSanXuat_Load(object sender, EventArgs e)
        {
            txtMaNPP.Enabled = false;
            btn_Save.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = true;
            loadNhaPP();
        }
        public void loadNhaPP()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                dtNhaPhanPhoi = NhControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtNhaPhanPhoi;
                //gunaDataGridView1.OptionsView.ShowGroupPanel = false;
                gunaDataGridView1.DataSource = dtNhaPhanPhoi;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaNhaPhanPhoi";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenNhaPhanPhoi";
                gunaDataGridView1.Columns[2].DataPropertyName = "DiaChi";
                gunaDataGridView1.Columns[3].DataPropertyName = "SDT";
                gunaDataGridView1.Columns[4].DataPropertyName = "Email";
                gunaDataGridView1.Columns[5].DataPropertyName = "ChuThich";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void gunaDataGridView1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    txt_MaKH.Text = gunaDataGridView1.GetRowDisplayRectangle(gunaDataGridView1.Focus, "MaNhaPhanPhoi").ToString();
            //    txtLienHe.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LienHe").ToString();
            //    txtTenKhach.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDonVi").ToString();
            //    txtLoaiThe.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TheThanhVien").ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("Không có khách hàng nào");
            //}
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //if (IsValidEmail(txtEmail.Text)==true)
            //{
            //    NhControl.ThemDuLieuNPP(txtMaNPP.Text.Trim(), txtTenNPP.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim(), txtGhiChu.Text.Trim());
            //    loadNhaPP();
            //}
            //else
            //{
            //    Message
            //}
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Save.Enabled = true;
            btn_Them.Enabled = false;
            txtMaNPP.Enabled = true;
            txtMaNPP.Text = "";
            txtTenNPP.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
            txtSDT.Text = "";
            txtMaNPP.Focus();


        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaNPP.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTenNPP.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txtDiaChi.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
            txtSDT.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
            txtEmail.Text = gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString();
            txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();
            txtMaNPP.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (NhControl.KiemTraMaTonTai(txtMaNPP.Text))
            {
                if (NhControl.KiemTraMaTonTaiTrongBangNhanVien(txtMaNPP.Text))
                {
                    MessageBox.Show("mã nhà phân phối tồn tại trong bảng nhân viên, không thể xóa nha quý dị !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (NhControl.KiemTraMaTonTaiTrongBangPhieuNhap(txtMaNPP.Text))
                    {
                        MessageBox.Show("Mã nhà phân phối tồn tại trong bảng phiếu nhập,không thể xóa nha quý dị!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            NhControl.XoaDuLieuNPP(txtMaNPP.Text);
                            loadNhaPP();
                            txtMaNPP.Text = "";
                            txtTenNPP.Text = "";
                            txtDiaChi.Text = "";
                            txtEmail.Text = "";
                            txtGhiChu.Text = "";
                            txtSDT.Text = "";
                            txtMaNPP.Focus();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Lỗi");
                        }

                    }

                }
            }



        }
        public bool IsValidEmail(string email)
        {
            try
            {
                int nFirt = int.Parse(email.Substring(0, 1));
                return false;
            }
            catch
            {
                string pattern = @"^[_a-zA-Z0-9][_.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[_.a-zA-Z0-9]+)*\.
   (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|vn|[a-zA-Z]{2})$";
                //Regular expression object
                Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
                //boolean variable to return to calling method
                bool valid = false;

                //make sure an email address was provided
                if (string.IsNullOrEmpty(email))
                {
                    valid = false;
                }
                else
                {
                    //use IsMatch to validate the address
                    valid = check.IsMatch(email.ToLower());
                }
                //return the value to the calling method
                return valid;
            }
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSDT.Text.Length > 11)
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập đúng số điện thoạt!");
            }
            else
                errorProvider1.Clear();
        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtSDT.Text.Length == 0 || txtSDT.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtMaNPP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNPP.Focus();
                return;
            }
            if (txtTenNPP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNPP.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            if (NhControl.KiemTraMaTonTai(txtMaNPP.Text) == false)
            {
                try
                {
                    NhControl.ThemDuLieuNPP(txtMaNPP.Text, txtTenNPP.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtGhiChu.Text);
                    loadNhaPP();
                    txtMaNPP.Text = "";
                    txtTenNPP.Text = "";
                    txtDiaChi.Text = "";
                    txtSDT.Text = "";
                    txtEmail.Text = "";
                    txtGhiChu.Text = "";
                    txtMaNPP.Focus();
                    btn_Them.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Sua.Enabled = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Lỗi");
                }
            }
            else
            {
                MessageBox.Show("MÃ ĐÃ TỒN TẠI TRONG BẢNG, VUI LÒNG CHỌN MÃ KHÁC", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }



        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                nppModel.SuaNPP(txtMaNPP.Text, txtTenNPP.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtGhiChu.Text);
            loadNhaPP();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
