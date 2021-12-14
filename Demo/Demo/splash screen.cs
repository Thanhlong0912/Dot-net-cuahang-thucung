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
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                GUI_Login form = new GUI_Login();
                form.Show();
                this.Hide();
            }
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            //GUI_Login f = new GUI_Login();
            //this.Hide();
            //this.Show();
            lblGif.BackColor = SystemColors.Control;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblGif_Click(object sender, EventArgs e)
        {

        }
    }
}
