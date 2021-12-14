using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Model;

namespace Demo
{
    public partial class KetNoiCSDL : Form
    {
        KetNoi condb = new KetNoi();
        AppSetting appset = new AppSetting();
        public KetNoiCSDL()
        {
            InitializeComponent();
        }
        string constring;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
                constring = string.Format("server={0};database={1};Integrated Security=",
                txtServer.Text,txtDatabase.Text);
            if (txtUid.Text == "")
                constring += "true;";
            else
                constring += string.Format("false;uid={0};pwd={1}",txtUid.Text,txtPwd.Text);

            if (condb.testConnection(constring))
                MessageBox.Show("Kết nối thành công");
            else
                MessageBox.Show("Kết nối thất bại");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(constring!="")
            {
                appset.setConnectionString("QL_SHOPPETConnectionString",constring);
                MessageBox.Show("Lưu Thành Công");
            }
        }
    }
}
