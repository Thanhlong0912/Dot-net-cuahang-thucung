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
    public partial class fMainSales : Form
    {
        KhuyenMaiController KMControl = new KhuyenMaiController();
        ChiTietDotKhuyenMaiController CTKMControl = new ChiTietDotKhuyenMaiController();
        public fMainSales()
        {
            InitializeComponent();
            gunaDataGridViewKhuyenMai.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gunaDataGridViewKhuyenMai.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //gunaPanel2.Controls.Clear();
            //fLoadKM frm2 = new fLoadKM();
            //frm2.TopLevel = false;
            //gunaPanel2.Controls.Add(frm2);
            //frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //frm2.Dock = DockStyle.Fill;
            //frm2.Show();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {

            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            gunaDataGridViewChieTietKhuyenMai.Enabled = true;

        }

        private void fMainSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_SHOPPETDataSet.SanPham);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.DotKhuyenMai' table. You can move, or remove it, as needed.
            this.dotKhuyenMaiTableAdapter.Fill(this.qL_SHOPPETDataSet.DotKhuyenMai);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            txt_MaKM.Enabled = false;

            LoadKM();
            LoadCTKM();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            gunaDataGridViewKhuyenMai.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void LoadKM()
        {
            try
            {
                gunaDataGridViewKhuyenMai.AutoGenerateColumns = false;
                DataTable dtKM = new DataTable();
                dtKM = KMControl.HienThiDuLieu();
                gunaDataGridViewKhuyenMai.DataSource = dtKM;
                gunaDataGridViewKhuyenMai.DataSource = dtKM;
                gunaDataGridViewKhuyenMai.Columns[0].DataPropertyName = "MaDot";
                gunaDataGridViewKhuyenMai.Columns[1].DataPropertyName = "NgayBD";
                gunaDataGridViewKhuyenMai.Columns[2].DataPropertyName = "NgayKT";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        public void LoadCTKM()
        {
            try
            {
                gunaDataGridViewChieTietKhuyenMai.AutoGenerateColumns = false;
                DataTable dtCTKM = new DataTable();
                dtCTKM = CTKMControl.HienThiDuLieu();
                gunaDataGridViewChieTietKhuyenMai.DataSource = dtCTKM;
                gunaDataGridViewChieTietKhuyenMai.DataSource = dtCTKM;
                gunaDataGridViewChieTietKhuyenMai.Columns[0].DataPropertyName = "MaDot";
                gunaDataGridViewChieTietKhuyenMai.Columns[1].DataPropertyName = "MaSanPham";
                gunaDataGridViewChieTietKhuyenMai.Columns[2].DataPropertyName = "TiLeGiamGia";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_TLSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_NgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txt_MaKM.Text = gunaDataGridViewKhuyenMai.Rows[numrow].Cells[0].Value.ToString();
                DateTime dt = DateTime.Parse(gunaDataGridViewKhuyenMai.Rows[numrow].Cells[1].Value.ToString());
                data_NgayBD.Value = dt;
                DateTime dt1 = DateTime.Parse(gunaDataGridViewKhuyenMai.Rows[numrow].Cells[2].Value.ToString());
                data_NgayKetThuc.Value = dt1;
                txt_MaKM.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                cbox_MaDot.Text = gunaDataGridViewChieTietKhuyenMai.Rows[numrow].Cells[0].Value.ToString();
                cb_MaSP.Text = gunaDataGridViewChieTietKhuyenMai.Rows[numrow].Cells[1].Value.ToString();
                cbx_TLGiam.Text = gunaDataGridViewChieTietKhuyenMai.Rows[numrow].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void gunaDataGridView3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                    KMControl.SuaKhuyenMai(txt_MaKM.Text, DateTime.Parse(data_NgayBD.Text), DateTime.Parse(data_NgayKetThuc.Text));
                LoadKM();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txt_MaKM.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi sửa dữ liệu");

            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaKM.Enabled = true;
            txt_MaKM.Text = "";

            txt_MaKM.Focus();
        }

        private void btn_XoaKM_Click(object sender, EventArgs e)
        {
            if (KMControl.KiemTraSanPham(txt_MaKM.Text))
            {
                if (KMControl.KiemTraSanPhamChiTietKhuyenMai(txt_MaKM.Text))
                {
                    MessageBox.Show(txt_MaKM.Text + "  TỒN TẠI TRONG bảng  chi tiết khuyến mãi nên không thể xóa!!");
                }
                else
                {
                    KMControl.XoaKhuyenMai(txt_MaKM.Text);
                    LoadKM();
                    btn_Them_Click(sender, e);
                }
            }
        }

        private void btn_SaveKM_Click(object sender, EventArgs e)
        {



            //if (txt_MaKM.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập VÀO mã  khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MaKM.Focus();
            //    return;
            //}
            try
            {
                if (KMControl.KiemTraSanPham(txt_MaKM.Text))
                {
                    MessageBox.Show("Mã khuyến mãi " + txt_MaKM.Text.Trim() + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    KMControl.ThemDuLieuKM(txt_MaKM.Text, DateTime.Parse(data_NgayBD.Text), DateTime.Parse(data_NgayKetThuc.Text));
                    LoadKM();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("lỗi thêm dữ liệu");
            }





        }

        private void btnThemCTKM_Click(object sender, EventArgs e)
        {
            cbox_MaDot.Text = "";
            cb_MaSP.Text = "";
            cbx_TLGiam.Text = "";
        }

        private void btnXoaCTKM_Click(object sender, EventArgs e)
        {
            try
            {
               CTKMControl.XoaKhuyenMai(cbox_MaDot.Text);
                LoadCTKM();
                btnThemCTKM_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi xóa dữu liệu");
            }
                
            
        }

        private void btnSuaCTKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                    CTKMControl.SuaKhuyenMai(cbox_MaDot.Text, cb_MaSP.Text, float.Parse(cbx_TLGiam.Text));
                LoadCTKM();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txt_MaKM.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi sửa dữ liệu");

            }
        }

        private void btnLuuCTKM_Click(object sender, EventArgs e)
        {
            if (CTKMControl.KiemTraMaCTHD(cbox_MaDot.Text))
            {
                MessageBox.Show(cbox_MaDot.Text + "đã tồn tại trong ,không thể thêm");
            }
            else
            {
                CTKMControl.ThemDuLieuCTKM(cbox_MaDot.Text, cb_MaSP.Text, float.Parse(cbx_TLGiam.Text));
                LoadCTKM();
                MessageBox.Show("thêm chi tiết khuyến mãi thành công");
            }
            
        }
    }
}

