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
namespace Demo
{
    public partial class fNhanVien : Form
    {
        NhanVienController NVControl = new NhanVienController();
        NhanVienModel NVmodel = new NhanVienModel();
        public fNhanVien()
        {
            InitializeComponent();
            gunaDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gunaDataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Save.Enabled = false;


            loadNV();
        }
        public void loadNV()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtNV = new DataTable();
                dtNV = NVControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtNV;
                gunaDataGridView1.DataSource = dtNV;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenNhanVien";
                gunaDataGridView1.Columns[2].DataPropertyName = "NgaySinh";
                gunaDataGridView1.Columns[3].DataPropertyName = "GioiTinh";
                gunaDataGridView1.Columns[4].DataPropertyName = "NgayVaoLam";
                gunaDataGridView1.Columns[5].DataPropertyName = "ChucVu";
                gunaDataGridView1.Columns[6].DataPropertyName = "DiaChi";
                gunaDataGridView1.Columns[7].DataPropertyName = "SoDT";
                gunaDataGridView1.Columns[8].DataPropertyName = "GhiChu";
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
                DataTable dtNV = new DataTable();
                dtNV = NVControl.HienThiDuLieuTimKiem(txt_Search.Text);
                gunaDataGridView1.DataSource = dtNV;
                gunaDataGridView1.DataSource = dtNV;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenNhanVien";
                gunaDataGridView1.Columns[2].DataPropertyName = "NgaySinh";
                gunaDataGridView1.Columns[3].DataPropertyName = "GioiTinh";
                gunaDataGridView1.Columns[4].DataPropertyName = "NgayVaoLam";
                gunaDataGridView1.Columns[5].DataPropertyName = "ChucVu";
                gunaDataGridView1.Columns[6].DataPropertyName = "DiaChi";
                gunaDataGridView1.Columns[7].DataPropertyName = "SoDT";
                gunaDataGridView1.Columns[8].DataPropertyName = "GhiChu";
            }
            catch
            {
                MessageBox.Show("Thông báo", "Dữ liệu tìm kiếm không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void data_Click(object sender, EventArgs e)
        {

        }

        private void data_NgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            //Control ctr=(Control)sender;

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
              (e.KeyChar == '.' && (txtSDT.Text.Length == 0 || txtSDT.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
            if (txtSDT.Text.Length > 11)
            {
                this.errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại đúng!!!");
                txtSDT.Focus();
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txt_MaNV.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
                txtTenNhanVien.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString());
                data_NgaySinh.Value = dt;
                cboxGioiTinh.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
                DateTime dt1 = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString());
                data_NgayVaoLam.Value = dt1;
                cboxChucVu.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();
                txtDiaChi.Text = gunaDataGridView1.Rows[numrow].Cells[6].Value.ToString();
                txtSDT.Text = gunaDataGridView1.Rows[numrow].Cells[7].Value.ToString();
                txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[8].Value.ToString();
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                txt_MaNV.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Save.Enabled = true;
            btn_Them.Enabled = false;
            txt_MaNV.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            data_NgaySinh.Text = "";
            data_NgayVaoLam.Text = "";
            cboxChucVu.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            cboxGioiTinh.Text = "";
            txt_MaNV.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (NVControl.KiemTraMaSanPham(txt_MaNV.Text))
            {
                if (NVControl.kiemTraTonTaihoadon(txt_MaNV.Text))
                {
                    MessageBox.Show(txt_MaNV.Text + "  TỒN TẠI TRONG bảng  hóa đơn nên không thể xóa!!");
                }
                else
                {
                    if (NVControl.kiemTraTonTaiPhieuNhap(txt_MaNV.Text))
                    {
                        MessageBox.Show(txt_MaNV.Text + "  TỒN TẠI TRONG bảng phiếu nhập nên không thể xóa!!");
                    }
                    else
                    {
                        if (NVControl.kiemTraTonTaiUser(txt_MaNV.Text))
                        {
                            MessageBox.Show(txt_MaNV.Text + "  TỒN TẠI TRONG bảng users nên không thể xóa!!");
                        }
                        else
                        {
                            try
                            {
                                NVControl.XoaDuLieuSP(txt_MaNV.Text);
                                loadNV();
                                MessageBox.Show("Thành công!");
                                txt_MaNV.Text = "";
                                txtTenNhanVien.Text = "";
                                txtDiaChi.Text = "";
                                data_NgaySinh.Text = "";
                                data_NgayVaoLam.Text = "";
                                txtSDT.Text = "";
                                cboxChucVu.Text = "";
                                cboxGioiTinh.Text = "";
                                txtGhiChu.Text = "";
                                txt_MaNV.Focus();
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("lỗi ");
                            }
                        }

                    }
                }
            }








        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                NVControl.SuaDuLieuSP(txt_MaNV.Text, txtTenNhanVien.Text, DateTime.Parse(data_NgaySinh.Text), cboxGioiTinh.Text, DateTime.Parse(data_NgayVaoLam.Text), cboxChucVu.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
            loadNV();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_MaNV.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            data_NgaySinh.Text = "";
            data_NgayVaoLam.Text = "";
            txtSDT.Text = "";
            cboxChucVu.Text = "";
            cboxGioiTinh.Text = "";
            txtGhiChu.Text = "";
            txt_MaNV.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNV.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }




            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ĐỊA CHỈ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập SỐ ĐIỆN THOẠI nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập VÀO GHI CHÚ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            if (NVControl.KiemTraMaSanPham(txt_MaNV.Text))
            {
                MessageBox.Show("mã nhân viên đã bị trùng,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NVControl.ThemDuLieuSP(txt_MaNV.Text, txtTenNhanVien.Text, DateTime.Parse(data_NgaySinh.Text), cboxGioiTinh.Text, DateTime.Parse(data_NgayVaoLam.Text), cboxChucVu.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                loadNV();
                btn_Them_Click(sender, e);
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }


        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
