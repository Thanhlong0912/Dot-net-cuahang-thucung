using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Demo.Model;
namespace Demo
{
    public partial class GUI_Login : Form
    {

        KetNoi kn = new KetNoi();
        SqlConnection con;
        public GUI_Login()
        {
            InitializeComponent();
        }
        
        public void Alert(string msg,Form_Alert1.enmType type)
        {
            Form_Alert1 frm = new Form_Alert1();
            frm.showAlert(msg,type);
        }
        private void GUI_Login_Load(object sender, EventArgs e)
        {
            string cd = "";
            string name = "";
            string line = "";
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    cd = line;
                    line = sr.ReadLine();
                    name = line;
                }
                txtTaiKhoan.Text = cd.ToString();
                txtMatKhau.Text = name.ToString();
                sr.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = kn.conDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Users where TenDangNhap='" + txtTaiKhoan.Text + "'and Password='" + txtMatKhau.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string userName = txtTaiKhoan.Text;
                string passWord = txtMatKhau.Text;
                fMain fMan = new fMain(txtTaiKhoan.Text);
                if (check_DangNhap.Checked)
                {
                    string[] names = new string[] { txtTaiKhoan.Text, txtMatKhau.Text };

                    using (StreamWriter sw = new StreamWriter("file.txt"))
                    {
                        foreach (string s in names)
                        {

                            sw.WriteLine(s);
                        }
                        sw.Close();
                    }
                }
                else
                {
                    string[] names = new string[] { "", "" };

                    using (StreamWriter sw = new StreamWriter("file.txt"))
                    {
                        foreach (string s in names)
                        {
                            sw.WriteLine(s);
                        }
                        sw.Close();
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    fMain fmain = new fMain(txtTaiKhoan.Text, dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());//
                    fmain.Show();
                    this.Alert("Đăng nhập thành công", Form_Alert1.enmType.Success);

                }
                //if (Login(userName, passWord))//Cách đăng nhập thứ 2 không phân quyền
                //{
                //    this.Hide();
                //    fMan.Show();
                //}
                else
                {
                    this.Alert("Đăng nhập không thành công", Form_Alert1.enmType.Error);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Chưa kết nối sql");
            }
          
        }

        private void txtDangKy_Click(object sender, EventArgs e)
        {
            this.Alert("Đăng ký thành công", Form_Alert1.enmType.Success);
            //GUI_SinUp dangky = new GUI_SinUp();
            //this.Hide();
            //dangky.ShowDialog();
            //this.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
 

        private void check_DangNhap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_QuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Alert("Vui lòng liên hệ Admin", Form_Alert1.enmType.Info);
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void peye_Click(object sender, EventArgs e)
        {
           
            if (txtMatKhau.PasswordChar =='\0')
            {
                phide.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                peye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void peye_DoubleClick(object sender, EventArgs e)
        {
            //if (Pass.PasswordChar == '\0')
            //{
            //    phide.BringToFront();
            //    Pass.PasswordChar = '*';
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KetNoiCSDL baocao = new KetNoiCSDL();
            baocao.Show();
        }
    }
}
