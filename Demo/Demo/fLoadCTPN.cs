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
    public partial class fLoadCTPN : Form
    {
        ChiTietPhieuNhapController CTPNControl = new ChiTietPhieuNhapController();
        public fLoadCTPN()
        {
            InitializeComponent();
        }

        private void fLoadCTPN_Load(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Save.Enabled = false;
            cbpMaPN.Enabled = false;
            cboMaSP.Enabled = false;
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_SHOPPETDataSet.SanPham);

            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qL_SHOPPETDataSet.PhieuNhap);
            loadCTPN();

        }
        public void loadCTPN()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtCTPN = new DataTable();
                dtCTPN = CTPNControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtCTPN;
                gunaDataGridView1.DataSource = dtCTPN;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaPhieuNhap";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[2].DataPropertyName = "SoLuong";
                gunaDataGridView1.Columns[3].DataPropertyName = "TongTien";
                gunaDataGridView1.Columns[4].DataPropertyName = "ChuThich";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                cbpMaPN.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
                cboMaSP.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
                SoLuong.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
                txtTongTien.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString();
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void SoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtTongTien.Text.Length == 0 || txtTongTien.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Save.Enabled = true;
            btn_Them.Enabled = false;
            cboMaSP.Enabled = true;
            cbpMaPN.Enabled = true;
            cbpMaPN.Text = "";
            cboMaSP.Text = "";
            txtTongTien.Text = "";
            txtGhiChu.Text = "";
            SoLuong.Text = "";


            cbpMaPN.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Save.Enabled = true;
            btn_Them.Enabled = false;
            cboMaSP.Enabled = true;
            cbpMaPN.Enabled = true;
            cbpMaPN.Text = "";
            cboMaSP.Text = "";
            txtTongTien.Text = "";
            txtGhiChu.Text = "";
            SoLuong.Text = "";


            cbpMaPN.Focus();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            if (CTPNControl.KiemTraMaSanPham(cbpMaPN.Text))
            {
                CTPNControl.XoaCTPN(cbpMaPN.Text);
                MessageBox.Show("Xóa thành công");
                loadCTPN();
                btn_Them_Click(sender, e);
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Save.Enabled = true;
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                CTPNControl.SuaCTPN(cbpMaPN.Text, cboMaSP.Text, int.Parse(SoLuong.Text), float.Parse(txtTongTien.Text), txtGhiChu.Text);
            loadCTPN();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Them_Click(sender, e);
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }
            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }





            if (CTPNControl.KiemTraMaSanPham(cboMaSP.Text))
            {
                MessageBox.Show("mã phiếu nhập đã bị trùng,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CTPNControl.ThemDuCTPN(cbpMaPN.Text, cboMaSP.Text, int.Parse(SoLuong.Text), float.Parse(txtTongTien.Text), txtGhiChu.Text);
                loadCTPN();
                btn_Them_Click(sender, e);
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
        }
    }
}
