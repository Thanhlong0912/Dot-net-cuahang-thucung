using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class fSanPham : Form
    {
        public fSanPham()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            fLoadSP frm2 = new fLoadSP();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            fLoadSP frm2 = new fLoadSP();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            loadLoaiSP frm2 = new loadLoaiSP();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            fLoadHanSanXuat frm2 = new fLoadHanSanXuat();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }
    }
}
