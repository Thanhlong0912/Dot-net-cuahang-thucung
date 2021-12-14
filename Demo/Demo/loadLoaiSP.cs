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
    public partial class loadLoaiSP : Form
    {
        LoaiSPController SpControl = new LoaiSPController();
        DataTable dtLoaiSP = new DataTable();
        LoaiSPModel loaiModel = new LoaiSPModel();
        public loadLoaiSP()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txtTenLoai.Text = "";
            txtMaLoai.Text = "";
            txtMaLoai.Focus();
            txtMaLoai.Enabled = true;
            btn_Save.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (SpControl.kiemTraTonTaiTrongBangSanPham(txtMaLoai.Text))
            {
                MessageBox.Show("Đã tồn mã loại sản phẩm  " + txtMaLoai.Text + "  không thể xóa!!");
            }
            else
            {
                try
                {
                    //xoa
                    SpControl.XoaDuLieuSP(txtMaLoai.Text);
                    loadLSP();
                    txtTenLoai.Text = "";
                    txtMaLoai.Text = "";
                    txtMaLoai.Focus();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }



            }

            }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                return;
            }
            if (txtTenLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }
            if (SpControl.KiemTraSanPham(txtMaLoai.Text))
            {
                MessageBox.Show("Mã loại sản phẩm đã bị trùng, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                loaiModel.ThemLoaiSP(txtMaLoai.Text, txtTenLoai.Text);
                loadLSP();
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";

                txtMaLoai.Focus();
                btn_Save.Enabled = true;
                btn_Xoa.Enabled = true;
            }
        }

        private void loadLoaiSP_Load(object sender, EventArgs e)
        {
            txtMaLoai.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Save.Enabled = false;
            loadLSP();
            LoaiSP_databiding();
        }
       public void loadLSP()
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                dtLoaiSP = SpControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtLoaiSP;
                //gunaDataGridView1.OptionsView.ShowGroupPanel = false;
                gunaDataGridView1.DataSource = dtLoaiSP;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaLoaiSanPham";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenLoaiSanPham";

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        void LoaiSP_databiding()
        {
            txtMaLoai.DataBindings.Add("Text", dtLoaiSP, "MaLoaiSanPham");
            txtTenLoai.DataBindings.Add("Text", dtLoaiSP, "TenLoaiSanPham");
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                
                SpControl.SuaDuLieuSP(txtMaLoai.Text, txtTenLoai.Text);
            loadLSP();
        }

        private void gunaDataGridView1_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = gunaDataGridView1.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = gunaDataGridView1.CurrentRow.Cells["TenLoai"].Value.ToString();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }
    }
}
