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
    public partial class FThongKe : Form
    {
        ThongKeController tkControl = new ThongKeController();
        public FThongKe()
        {
            InitializeComponent();
            tong();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtUs = new DataTable();
                dtUs = tkControl.HienThiDuLieuThongKe(txtNam.Text);
                gunaDataGridView1.DataSource = dtUs;
                gunaDataGridView1.DataSource = dtUs;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaHoaDon";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[2].DataPropertyName = "SoLuong";
                gunaDataGridView1.Columns[3].DataPropertyName = "TongTien";
                gunaDataGridView1.Columns[4].DataPropertyName = "TongTienHoaDon";
                gunaDataGridView1.Columns[5].DataPropertyName = "NgayLapHoaDon";
            }
            catch
            {
                MessageBox.Show("Không thể thống kê năm");
            }
            tong();
        }
        public void tong()
        {
            int tien = gunaDataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            lblTongTien.Text = thanhtien.ToString();
        }
        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtNam.Text.Length == 0 || txtNam.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
