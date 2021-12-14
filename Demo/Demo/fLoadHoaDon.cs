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
    public partial class fLoadHoaDon : Form
    {
        HoaDonController HDControl = new HoaDonController();
        DataTable dtHD = new DataTable();
        public fLoadHoaDon()
        {
            InitializeComponent();
            gunaDataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void fLoadHoaDon_Load(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = true;
            btn_Save.Enabled = false;
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_SHOPPETDataSet.SanPham);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_SHOPPETDataSet.KhachHang);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_SHOPPETDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qL_SHOPPETDataSet.HoaDon);
            LoadHoaDon();

        }
        public void LoadHoaDon()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                dtHD = HDControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtHD;
                gunaDataGridView1.DataSource = dtHD;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaHoaDon";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaKhachHang";
                gunaDataGridView1.Columns[2].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[3].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[4].DataPropertyName = "NgayLapHoaDon";
                gunaDataGridView1.Columns[5].DataPropertyName = "TongTien";
                gunaDataGridView1.Columns[6].DataPropertyName = "GhiChu";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                dtHD = HDControl.HienThiDuLieuTimKiem(txt_Search.Text);
                gunaDataGridView1.DataSource = dtHD;
                gunaDataGridView1.DataSource = dtHD;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaHoaDon";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaKhachHang";
                gunaDataGridView1.Columns[2].DataPropertyName = "MaNhanVien";
                gunaDataGridView1.Columns[3].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[4].DataPropertyName = "NgayLapHoaDon";
                gunaDataGridView1.Columns[5].DataPropertyName = "TongTien";
                gunaDataGridView1.Columns[6].DataPropertyName = "GhiChu";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi"+ex+"");
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaHD.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
                cboMaKH.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString());
                data_NgayLap.Value = dt;
                cboMaNV.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
                cboMaSP.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtTongTien.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();           
                txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[6].Value.ToString();
                txtMaHD.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void cboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninbaocao_Click(object sender, EventArgs e)
        {
            
            new frmInBaoCao(dtHD).Show();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            txtMaHD.Text = "";
            cboMaKH.Text = "";
            cboMaNV.Text = "";
            txtGhiChu.Text = "";
            txtTongTien.Text = "";
            cboMaSP.Text = "";
            
            txtMaHD.Focus();
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
                return;
            }  
            if (txtTongTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return;
            }

            if (HDControl.KiemtraMAHD(txtMaHD.Text))
            {
                MessageBox.Show("Mã sản phẩm " + txtMaHD.Text.Trim() + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                try
                {

                    HDControl.ThemHD(txtMaHD.Text, cboMaKH.Text, cboMaNV.Text, cboMaSP.Text, data_NgayLap.Text,txtTongTien.Text, txtGhiChu.Text);
                    LoadHoaDon();
                    MessageBox.Show("Thành công!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi"+ex);
                }
            }
            
            
                
            
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (HDControl.KiemtraMAHD(txtMaHD.Text))
            {
                if (HDControl.kiemTraTonTaichitiethoadon(txtMaHD.Text))
                {
                    MessageBox.Show(txtMaHD.Text + " TỒN TẠI TRONG bảng  chi tiết hóa đơn nên không thể xóa!!");
                }
                else
                {
                    HDControl.XoaDuLieuHD(txtMaHD.Text);
                    MessageBox.Show(txtMaHD.Text + " xóa thành công");

                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = false;
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                HDControl.SuaDuLieuhd(txtMaHD.Text, cboMaKH.Text, cboMaNV.Text, cboMaSP.Text, DateTime.Parse(data_NgayLap.Text), float.Parse(txtTongTien.Text),  txtGhiChu.Text);
            LoadHoaDon();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaHD.Enabled = true;
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtTongTien.Text.Length == 0 || txtTongTien.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmInBaoCao baocao = new frmInBaoCao(dtHD);
            baocao.Show();
            
        }
    }
    }

