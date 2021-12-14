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
namespace Demo
{
    public partial class fHome : Form
    {
        string location;
        public fHome()
        {
            InitializeComponent();
            location = @"D:\CNNT\DOAN\NET\Demo\Demo\Player\pet.mp4";
            btnMedia.Visible = false;
            btnMedia.Click += btnMedia_Click;
            btnMedia_Click(null, EventArgs.Empty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ButtonShowingPuppy = !ButtonShowingPuppy;
            //if (ButtonShowingPuppy)
            //{
            //    //button1.Image = Properties.Resources.lion_gif_80;
            //}
            //else
            //{
            //    button1.Image = Demo.Properties.Resources._9f276fdc2c11dacb82f60b917d73e282;
            //}
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            txt = label4.Text;
            len = txt.Length;
            label4.Text = "";
            timer4.Start();
            ImageDong();
            ImageDong1();
            ImageDong2();
            timer5.Start();
        }
        public void ImageDong()
        {
            timer2.Enabled = true;
            timer2.Start();
            i = 0;
            ListImage = Split(Resources._9f276fdc2c11dacb82f60b917d73e282, 130, 130);
            count = ListImage.Images.Count;
        }
        public void ImageDong1()
        {
            timer1.Enabled = true;
            timer1.Start();
            i1 = 0;
            ListImage1 = Split(Resources.b32b85829b4cf33cadee39ca54790affv_3, 130, 130);
            count1 = ListImage1.Images.Count;
        }
        int i2 = 0;
        public void ImageDong2()
        {
            timer3.Enabled = true;
            timer3.Start();
            i2 = 0;
            ListImage2 = Split(Resources._420f9b50a43926654eff153d65e179bf, 130, 130);
            count2 = ListImage2.Images.Count;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
        ImageList ListImage1;
        ImageList ListImage2;
        int count = 0;
        int i = 0;
        int count1 = 0;
        int i1 = 0;
        int count2 = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Image = ListImage1.Images[i1];
            i1++;
            if (i1 == count1) { i1 = 0; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = ListImage.Images[i];
            i++;
            if (i == count) { i = 0; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //pictureBox5.Image = ListImage2.Images[i2];
            //i2++;
            //if (i2 == count2) { i2 = 0; }
        }
        int counter = 0;
        int len = 0;
        string txt;
        private void timer4_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                label4.Text = "";
            }

            else
            {

                label4.Text = txt.Substring(0, counter);

                if (label4.ForeColor == Color.Blue)
                    label4.ForeColor = Color.Orange;
                else
                    label4.ForeColor = Color.Blue;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = location;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int x;
        private void timer5_Tick(object sender, EventArgs e)
        {
            x = label2.Location.X;
            x--;
            label2.Location = new Point(x, label2.Location.Y);

            if (x == 0)
            {
                fHome fr = new fHome();
                x = fr.Size.Width;
                label2.Location = new Point(fr.Size.Width, label2.Location.Y);
            }
        }

        private void txtketnoicsdl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KetNoiCSDL baocao = new KetNoiCSDL();
            baocao.Show();
        }
    }
}
