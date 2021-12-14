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
    public partial class fLoadChiTietHD : Form
    {
        ChiTietHoaDonController CTHDControl = new ChiTietHoaDonController();
        public fLoadChiTietHD()
        {
            InitializeComponent();
            gunaDataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            gunaDataGridView1.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void fLoadChiTietHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.ChiTietDotKhuyenMai' table. You can move, or remove it, as needed.
            this.chiTietDotKhuyenMaiTableAdapter.Fill(this.qL_SHOPPETDataSet.ChiTietDotKhuyenMai);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.DotKhuyenMai' table. You can move, or remove it, as needed.
            this.dotKhuyenMaiTableAdapter.Fill(this.qL_SHOPPETDataSet.DotKhuyenMai);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_SHOPPETDataSet.SanPham);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_SHOPPETDataSet.KhachHang);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qL_SHOPPETDataSet.HoaDon);
            LoadChiTietHD();

        }
        public void LoadChiTietHD()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtCTHD = new DataTable();
                dtCTHD = CTHDControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtCTHD;
                gunaDataGridView1.DataSource = dtCTHD;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaHoaDon";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[2].DataPropertyName = "MucGiam";
                gunaDataGridView1.Columns[3].DataPropertyName = "SoLuong";
                gunaDataGridView1.Columns[4].DataPropertyName = "TongTien";
                gunaDataGridView1.Columns[5].DataPropertyName = "TongTienHoaDon";
                gunaDataGridView1.Columns[6].DataPropertyName = "NgayDat";
                gunaDataGridView1.Columns[7].DataPropertyName = "NgayGiao";
                gunaDataGridView1.Columns[8].DataPropertyName = "GhiChu";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMucGiam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                cboxMaHD.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
                cboxMaSP.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[6].Value.ToString());
                data_NgayDat.Value = dt;
                DateTime dt1 = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[7].Value.ToString());
                data_NgayGiao.Value = dt1;
                txtTongTienHD.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();
                txtTongTien.Text = gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString();
                SoLuong.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[8].Value.ToString();
                cboxMucGiam.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void data_NgayGiao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtTongTien.Text.Length == 0 || txtTongTien.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txtTongTienHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtTongTienHD.Text.Length == 0 || txtTongTienHD.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            cboxMaHD.Enabled = true;
            cboxMaSP.Enabled = true;
            cboxMucGiam.Enabled = true;
            data_NgayDat.Enabled = true;
            data_NgayGiao.Enabled=true;
            txtTongTien.Text = "";
            txtTongTienHD.Text = "";
            txtGhiChu.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTongTien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tổng tiền");
                }

                else if (txtTongTienHD.Text.Trim().Length==0)
                    {
                        MessageBox.Show("Vui lòng  nhập tổng tiền hóa đơn");
                    }
                
                else{

                    if (CTHDControl.ThemDuLieuSP(cboxMaHD.Text, cboxMaSP.Text, cboxMucGiam.Text, SoLuong.Text, txtTongTien.Text, txtTongTienHD.Text, data_NgayDat.Text, data_NgayGiao.Text, txtGhiChu.Text))
                    {
                        LoadChiTietHD();

                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
	

               
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (CTHDControl.KiemTraCTHoaDon(cboxMaHD.Text))
            {
                MessageBox.Show(cboxMaHD.Text + "đã tồn tại trong bảng hóa đơn, không thể xóa nha quý dị");
            }
            else
            {
                try
                {

                    CTHDControl.XoaDuLieuCTHD(cboxMaHD.Text);

                    LoadChiTietHD();
                    MessageBox.Show("Xóa thành công");
                    btn_Them_Click(sender, e);
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
                CTHDControl.SuaCTHĐ(cboxMaHD.Text, cboxMaSP.Text, float.Parse(cboxMucGiam.Text), int.Parse(SoLuong.Text), float.Parse(txtTongTien.Text), float.Parse(txtTongTienHD.Text), DateTime.Parse(data_NgayDat.Text), DateTime.Parse(data_NgayGiao.Text), txtGhiChu.Text);
            LoadChiTietHD();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Them_Click(sender, e);
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
