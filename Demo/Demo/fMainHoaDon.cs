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
    public partial class fMainHoaDon : Form
    {
        public fMainHoaDon()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            fLoadHoaDon frm2 = new fLoadHoaDon();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void fMainHoaDon_Load(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            fLoadHoaDon frm2 = new fLoadHoaDon();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gunaPanel2.Controls.Clear();
            fLoadChiTietHD frm2 = new fLoadChiTietHD();
            frm2.TopLevel = false;
            gunaPanel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }
    }
}
