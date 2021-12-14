using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demo.Properties;
using Demo.Controller;
using Demo.Model;
using System.Globalization;
namespace Demo
{
    public partial class fKhachHang : Form
    {
        KhachHangController KHControl = new KhachHangController();
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        KhachHangModel kh = new KhachHangModel();
        public fKhachHang()
        {
            InitializeComponent();
            tounage();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = true;
            LoadKH();
        }
        public void LoadKH()
        {
            gunaDataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtKH = new DataTable();
                dtKH = KHControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtKH;
                gunaDataGridView1.DataSource = dtKH;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaKhachHang";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenKhachHang";
                gunaDataGridView1.Columns[2].DataPropertyName = "Ngaysinh";
                gunaDataGridView1.Columns[3].DataPropertyName = "GioiTinh";
                gunaDataGridView1.Columns[4].DataPropertyName = "DiaChi";
                gunaDataGridView1.Columns[5].DataPropertyName = "SDT";
                gunaDataGridView1.Columns[6].DataPropertyName = "LoaiKhachHang";
                gunaDataGridView1.Columns[7].DataPropertyName = "GhiChu";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void tounage()
        {
            for (int i = 0; i < 24; i++)
            {
                if (i > 0)
                {
                    Bitmap bitmap = new Bitmap(Resources.textbox_user_1);
                    images.Add(bitmap);
                    Bitmap bitmap2 = new Bitmap(Resources.textbox_user_2);
                    images.Add(bitmap2);
                    Bitmap bitmap3 = new Bitmap(Resources.textbox_user_3);
                    images.Add(bitmap3);
                    Bitmap bitmap4 = new Bitmap(Resources.textbox_user_4);
                    images.Add(bitmap4);
                    Bitmap bitmap5 = new Bitmap(Resources.textbox_user_5);
                    images.Add(bitmap5);
                    Bitmap bitmap6 = new Bitmap(Resources.textbox_user_6);
                    images.Add(bitmap6);
                    Bitmap bitmap7 = new Bitmap(Resources.textbox_user_7);
                    images.Add(bitmap7);
                    Bitmap bitmap8 = new Bitmap(Resources.textbox_user_8);
                    images.Add(bitmap8);
                    Bitmap bitmap9 = new Bitmap(Resources.textbox_user_9);
                    images.Add(bitmap9);
                    Bitmap bitmap10 = new Bitmap(Resources.textbox_user_10);
                    images.Add(bitmap10);
                    Bitmap bitmap11 = new Bitmap(Resources.textbox_user_11);
                    images.Add(bitmap11);
                    Bitmap bitmap12 = new Bitmap(Resources.textbox_user_12);
                    images.Add(bitmap12);
                    Bitmap bitmap13 = new Bitmap(Resources.textbox_user_13);
                    images.Add(bitmap13);
                    Bitmap bitmap14 = new Bitmap(Resources.textbox_user_14);
                    images.Add(bitmap14);
                    Bitmap bitmap15 = new Bitmap(Resources.textbox_user_15);
                    images.Add(bitmap15);
                    Bitmap bitmap16 = new Bitmap(Resources.textbox_user_16);
                    images.Add(bitmap16);
                    Bitmap bitmap17 = new Bitmap(Resources.textbox_user_17);
                    images.Add(bitmap17);
                    Bitmap bitmap18 = new Bitmap(Resources.textbox_user_18);
                    images.Add(bitmap18);
                    Bitmap bitmap19 = new Bitmap(Resources.textbox_user_19);
                    images.Add(bitmap19);
                    Bitmap bitmap20 = new Bitmap(Resources.textbox_user_20);
                    images.Add(bitmap20);
                    Bitmap bitmap21 = new Bitmap(Resources.textbox_user_21);
                    images.Add(bitmap21);
                    Bitmap bitmap22 = new Bitmap(Resources.textbox_user_22);
                    images.Add(bitmap22);
                    Bitmap bitmap23 = new Bitmap(Resources.textbox_user_23);
                    images.Add(bitmap23);
                    Bitmap bitmap24 = new Bitmap(Resources.textbox_user_24);
                    images.Add(bitmap24);

                }
            }
            images.Add(Properties.Resources.textbox_password);
        }
        public void click()
        {
            if (txt_MaKH.Text.Length > 0 && txt_MaKH.Text.Length <= 15)
            {
                pictureBox1.Image = images[txt_MaKH.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txt_MaKH.Text.Length <= 0)
                pictureBox1.Image = Properties.Resources.debut;
            else
                pictureBox1.Image = images[22];
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 500; i++)
            {
                click();
            }
        }

        private void txt_MaKH_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txt_MaKH_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text.Length > 0)
                pictureBox1.Image = images[txt_MaKH.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.debut;
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;
                DataTable dtKH = new DataTable();
                dtKH = KHControl.HienThiDuLieuTK(txt_Search.Text);
                gunaDataGridView1.DataSource = dtKH;
                gunaDataGridView1.DataSource = dtKH;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaKhachHang";
                gunaDataGridView1.Columns[1].DataPropertyName = "TenKhachHang";
                gunaDataGridView1.Columns[2].DataPropertyName = "Ngaysinh";
                gunaDataGridView1.Columns[3].DataPropertyName = "GioiTinh";
                gunaDataGridView1.Columns[4].DataPropertyName = "DiaChi";
                gunaDataGridView1.Columns[5].DataPropertyName = "SDT";
                gunaDataGridView1.Columns[6].DataPropertyName = "LoaiKhachHang";
                gunaDataGridView1.Columns[7].DataPropertyName = "GhiChu";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txt_MaKH.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
                txtTenKH.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = DateTime.Parse(gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString());
                data_NgaySinh.Value = dt;
                cboxGioiTinh.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtDiaChi.Text = gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString();
                txtSDT.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();
                cboLoaiKH.Text = gunaDataGridView1.Rows[numrow].Cells[6].Value.ToString();
                txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[7].Value.ToString();
                txt_MaKH.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void gunaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            try
            {

                // string UrDate = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
                //DateTimeFormatInfo dateInfo = new DateTimeFormatInfo();
                // dateInfo.ShortDatePattern = "dd/MM/yyyy";
                // DateTime validDate = Convert.ToDateTime(UrDate, dateInfo);
                //DateTime dt = DateTime.ParseExact(gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString(), "dd/MM/yyyy", CultureInfo.InstalledUICulture);

                //data_NgaySinh.Value = validDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            cboLoaiKH.Text = "";
            txtSDT.Text = "";
            cboxGioiTinh.Text = "";
            txtGhiChu.Text = "";
            txtDiaChi.Text = "";
            data_NgaySinh.Text = "";
            txtTenKH.Text = "";
            txt_MaKH.Focus();
            btn_Save.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (KHControl.KiemTraMaTonTai(txt_MaKH.Text))
            {
                if (KHControl.KiemTraMaTonTaiTrongBangHoaDon(txt_MaKH.Text))
                {
                    MessageBox.Show(txt_MaKH.Text + "  đã tồn tại trong bảng hóa đơn nên không thể xóa nha quý dị, vui lòng chọn cái khác nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        kh.XoaKH(txt_MaKH.Text);
                        LoadKH();
                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaKH.Text = "";
                        txtTenKH.Text = "";
                        txtDiaChi.Text = "";
                        cboxGioiTinh.Text = "";
                        txtGhiChu.Text = "";
                        txtSDT.Text = "";
                        txtGhiChu.Text = "";
                        cboLoaiKH.Text = "";
                        txt_MaKH.Focus();
                        btn_Them.Enabled = true;
                        //btn_Xoa.Enabled = true;

                        //btn_Save.Enabled = true;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
            //    command = connection.CreateCommand();
            //command.CommandText = "DELETE FROM NhanVien WHERE MaNhanVien= '" + txtMaNV.Text + "'";
            //command.ExecuteNonQuery();

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSDT.Text.Length > 11)
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập đúng số điện thoạt!");
            }
            else
                errorProvider1.Clear();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtSDT.Text.Length == 0 || txtSDT.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                kh.SuaKH(txt_MaKH.Text, txtTenKH.Text, DateTime.Parse(data_NgaySinh.Text), cboxGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, cboLoaiKH.Text, txtGhiChu.Text);
            fKhachHang_Load(sender, e);
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;

            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            if (cboLoaiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chú thích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }

            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ĐỊA CHỈ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            try
            {
                if (KHControl.KiemTraMaTonTai(txt_MaKH.Text) == false)
                {
                    KHControl.ThemDuLieuKH(txt_MaKH.Text, txtTenKH.Text, DateTime.Parse(data_NgaySinh.Text), cboxGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, cboLoaiKH.Text, txtGhiChu.Text);
                    LoadKH();
                    txt_MaKH.Text = "";
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                    cboxGioiTinh.Text = "";
                    txtSDT.Text = "";
                    data_NgaySinh.Text = "";
                    txtGhiChu.Text = "";
                    cboLoaiKH.Text = "";

                    txt_MaKH.Focus();
                    btn_Them.Enabled = true;
                    btn_Xoa.Enabled = true;

                    btn_Save.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại trong bảng, vui lòng nhập mã khách hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
            catch (Exception)
            {

                throw;
            }


            //command = connection.CreateCommand();
            //command.CommandText = "insert into KhachHang values ('" + txt_MaKH.Text + "', '" + txtTenKhach.Text + "','" + DateTime.Parse(dataNgaySinh.Text) + "',N'" + cboGioiTinh.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtLoaiKH.Text + "','" + txtGhiChu.Text + "')";
            //command.ExecuteNonQuery();

        }
    }
}
