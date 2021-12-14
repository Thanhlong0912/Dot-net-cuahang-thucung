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
    public partial class fLoadPN : Form
    {
        PhieuNhapModel PNMODEL = new PhieuNhapModel();
        PhieuNhapController PNControl = new PhieuNhapController();
        public fLoadPN()
        {
            InitializeComponent();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void fLoadPN_Load(object sender, EventArgs e)
        {
            
            txt_MaPN.Enabled = false;
            loadPN();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txt_MaPN.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
                txtMaNhanVien.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
                txtMaNPP.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
                txtTongTien.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();

                DateTime dt = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString());
                data_NgayNhap.Value = dt;
                txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                txt_MaPN.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        public void loadPN()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtPN = new DataTable();
                dtPN = PNControl.HienThiDuLieuTimKiem(txt_Search.Text);
                gunaDataGridView1.DataSource = dtPN;
                gunaDataGridView1.DataSource = dtPN;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaPhieuNhap";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[2].DataPropertyName = "MaNhaPhanPhoi";
                gunaDataGridView1.Columns[3].DataPropertyName = "TongTien";
                gunaDataGridView1.Columns[4].DataPropertyName = "NgayNhap";
                gunaDataGridView1.Columns[5].DataPropertyName = "ChuThich";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNPP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MaPN_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_NgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = true;
            btn_Save.Enabled = true;
            txt_MaPN.Enabled = true;
            txt_MaPN.Text = "";
            txtMaNPP.Text = "";
            txtGhiChu.Text = "";
            txtTongTien.Text = "";
            txtMaNhanVien.Text = "";
            data_NgayNhap.Text = "";
            txt_MaPN.Focus();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txt_MaPN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaPN.Focus();
                return;
            }
            if (txtTongTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }
            if (txtMaNPP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNPP.Focus();
                return;
            }
            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            if (PNControl.KiemTraSanPham(txt_MaPN.Text))
            {

                MessageBox.Show("Mã phiếu nhập đã bị trùng,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                PNMODEL.ThemPN(txt_MaPN.Text, txtMaNhanVien.Text, txtMaNPP.Text, float.Parse(txtTongTien.Text), DateTime.Parse(data_NgayNhap.Text), txtGhiChu.Text);
                MessageBox.Show("thêm thành công");
                loadPN();
                txtMaNhanVien.Text = "";
                txtMaNPP.Text = "";
                txtGhiChu.Text = "";
                txtTongTien.Text = "";
                txt_MaPN.Text = "";
                data_NgayNhap.Text = "";
                txt_MaPN.Focus();
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (PNControl.KiemTraChiTietPhieuNhap(txt_MaPN.Text))
            {
                MessageBox.Show("mã sản phẩm đã tồn tại trong bảng chi tiết phiếu nhập");
            }
            else
            {
                try
                {
                    PNControl.XoaDuLieuSP(txt_MaPN.Text);
                    loadPN();
                    txtMaNhanVien.Text = "";
                    txt_MaPN.Text = "";
                    txtTongTien.Text = "";
                    txtMaNPP.Text = "";
                    txtGhiChu.Text = "";
                    txt_MaPN.Focus();
                }
                catch (Exception)
                {

                    MessageBox.Show("Lỗi");
                }

            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                PNMODEL.SuaPN(txt_MaPN.Text, txtMaNhanVien.Text, txtMaNPP.Text, float.Parse(txtTongTien.Text), DateTime.Parse(data_NgayNhap.Text), txtGhiChu.Text);
            loadPN();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaNhanVien.Text = "";
            txtMaNPP.Text = "";
            txtGhiChu.Text = "";
            txtTongTien.Text = "";
            txt_MaPN.Text = "";
            data_NgayNhap.Text = "";
            txt_MaPN.Focus();
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtTongTien.Text.Length == 0 || txtTongTien.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }
    }
}
