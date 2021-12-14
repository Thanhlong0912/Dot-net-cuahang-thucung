using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Properties;
using System.Diagnostics;
using System.Threading;
namespace Demo
{
    public partial class fMain : Form
    {
        string name = "", tenTK = "", matKhau = "", Quyen = "", maNV = "", tenNV = "";
        public fMain()
        {
            InitializeComponent();

        }
        public fMain(string name, string maNV, string tenTK, string matKhau, string Quyen, string tenNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.Quyen = Quyen;
            this.tenNV = tenNV;
            this.name = name;
        }
        private string _mess;
        public fMain(string Mess) : this()
        {
            _mess = Mess;
            lblXinChao.Text = "Xin chào " + _mess + ",";
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào " + name + ",";
            if (Quyen == "User      ")
            {
                guna2Button5.Visible = false;
                guna2Button8.Visible = false;

            }
            else if (Quyen == "Manage      ")
            {
                guna2Button8.Visible = false;
            }
            pictureBox3.Visible = false;
            fHome frm2 = new fHome();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fHome frm2 = new fHome();
            //frm2.TopLevel = false;
            //panel2.Controls.Add(frm2);
            //frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //frm2.Dock = DockStyle.Fill;
            //frm2.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fSanPham frmSP = new fSanPham();
            //frmSP.TopLevel = false;
            //panel2.Controls.Add(frmSP);
            //frmSP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //frmSP.Dock = DockStyle.Fill;
            //frmSP.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
                GUI_Login login = new GUI_Login();
                login.Show();
            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGif_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click_2(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //ListImage = Split(Resources.sprite, 130, 130);
            //count = ListImage.Images.Count;
            ////this.CenterToScreen();
            //panel1.Visible = false;
            //panel2.Visible = false;
            //pictureBox1.Location = new Point((this.Width / 2) - (pictureBox1.Width / 2),
            //          (this.Height / 2) - (pictureBox1.Height / 2));
            //pictureBox1.Refresh();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TransparencyKey = SystemColors.Control;
            //timer2.Enabled = true;
            ////e.Cancel = true;
        }
        private ImageList Split(Bitmap image, int width, int height)
        {
            ImageList rows = new ImageList();
            rows.ImageSize = new Size(width, height);
            rows.Images.AddStrip(image);
            ImageList cells = new ImageList();
            cells.ImageSize = new Size(width, height);
            foreach (Image row in rows.Images)
            {
                cells.Images.AddStrip(row);
            }
            return cells;
        }
        ImageList ListImage;
        int count = 0;
        int i = 0;
        int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 20)
            {
                Thread.Sleep(500);
                timer1.Enabled = false;
                Process.GetCurrentProcess().Kill();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = ListImage.Images[i];
            i++;
            if (i == count) { i = 0; }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox3.Visible = true;
            timer1.Enabled = true;
            ListImage = Split(Resources.bye, 130, 130);
            count = ListImage.Images.Count;
            this.CenterToScreen();
            gunaPanel1.Visible = false;
            btnGif.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            pictureBox3.Location = new Point((this.Width / 2) - (pictureBox1.Width / 2),
                      (this.Height / 2) - (pictureBox1.Height / 2));
            pictureBox3.Refresh();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = SystemColors.Control;
            this.BackColor = SystemColors.Control;
            timer2.Enabled = true;
            e.Cancel = true;
        }

        private void btnGif_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            fSanPham frmSP = new fSanPham();
            frmSP.TopLevel = false;
            panel2.Controls.Add(frmSP);
            //frmSP.Dock = DockStyle.Fill;
            frmSP.Show();

        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fHome frm2 = new fHome();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fNhanVien frm2 = new fNhanVien();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            //frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fKhachHang frmKH = new fKhachHang();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
        }

        private void btnGif_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fMainSales frmKH = new fMainSales();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fUser frmKH = new fUser();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fMainPN frmKH = new fMainPN();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fMainHoaDon frmKH = new fMainHoaDon();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();

        }

        private void Statistical_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FThongKe frmKH = new FThongKe();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FSell frmKH = new FSell();
            frmKH.TopLevel = false;
            panel2.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
        }
    }
}
