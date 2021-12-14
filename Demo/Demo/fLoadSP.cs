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
using Demo.Controller;
using Demo.Model;
namespace Demo
{
    public partial class fLoadSP : Form
    {
        //DAO.ketNoiCSDL_2 db = new DAO.ketNoiCSDL_2();
        ////DataTable dtSanPham;
        //DataColumn[] keylop = new DataColumn[1];
        ////bool ThemMoi = false;
        SanPhamController SpControl = new SanPhamController();
        DataTable dtSanPham = new DataTable();

        public fLoadSP()
        {
            InitializeComponent();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fLoadSP_Load(object sender, EventArgs e)
        {
            loadSP();
            btn_Save.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Them.Enabled = true;
            txt_MaSP.Enabled = false;

        }
        public void loadSP()
        {
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this.qL_SHOPPETDataSet.LoaiSanPham);
            // TODO: This line of code loads data into the 'qL_SHOPPETDataSet.NhaPhanPhoi' table. You can move, or remove it, as needed.
            this.nhaPhanPhoiTableAdapter.Fill(this.qL_SHOPPETDataSet.NhaPhanPhoi);
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;

                dtSanPham = SpControl.HienThiDuLieu();
                gunaDataGridView1.DataSource = dtSanPham;
                gunaDataGridView1.DataSource = dtSanPham;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaNhaPhanPhoi";
                gunaDataGridView1.Columns[2].DataPropertyName = "TenSanPham";
                gunaDataGridView1.Columns[3].DataPropertyName = "LoaiSanPham";
                gunaDataGridView1.Columns[4].DataPropertyName = "HangSanXuat";
                gunaDataGridView1.Columns[5].DataPropertyName = "GiaBan";
                gunaDataGridView1.Columns[6].DataPropertyName = "TonKho";
                gunaDataGridView1.Columns[7].DataPropertyName = "Image";
                gunaDataGridView1.Columns[8].DataPropertyName = "ChuThich";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            //LayTenHinh();
        }
        public void LayTenHinh()
        {
            label1.Text = "";
            label1.DataBindings.Add("Text", dtSanPham, "Image");
            txtIamge.DataBindings.Add("Text", dtSanPham, "Image");
        }
        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
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
        //ImageList img;
        private void guna2PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            OpenFileDialog1.FilterIndex = 1;
            OpenFileDialog1.RestoreDirectory = true;
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName;
                label1.Text = OpenFileDialog1.FileName;
                txtIamge.Text = OpenFileDialog1.FileName;
                guna2PictureBox1.BackgroundImage = null;

            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkImage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try 
            //{
            //    guna2PictureBox1.Image = Image.FromFile(@"" + label1.Text + "");
            //    guna2PictureBox1.BackgroundImage = null;
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi");
            //}
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_MaSP.Text = gunaDataGridView1.Rows[numrow].Cells[0].Value.ToString();
            cb_NPP.Text = gunaDataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txt_TenSanPham.Text = gunaDataGridView1.Rows[numrow].Cells[2].Value.ToString();
            cbLoaiSP.Text = gunaDataGridView1.Rows[numrow].Cells[3].Value.ToString();
            txtHSX.Text = gunaDataGridView1.Rows[numrow].Cells[4].Value.ToString();
            txtGiaBan.Text = gunaDataGridView1.Rows[numrow].Cells[5].Value.ToString();
            txtTonKho.Text = gunaDataGridView1.Rows[numrow].Cells[6].Value.ToString();
            label1.Text = gunaDataGridView1.Rows[numrow].Cells[7].Value.ToString();
            txtGhiChu.Text = gunaDataGridView1.Rows[numrow].Cells[8].Value.ToString();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            try
            {
                guna2PictureBox1.Image = Image.FromFile(@"" + label1.Text + "");
                guna2PictureBox1.BackgroundImage = null;
            }
            catch
            {
                MessageBox.Show("Không thể tải ảnh", "Lỗi",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaSP.Enabled = true;
            txt_MaSP.Text = "";
            txt_TenSanPham.Text = "";
            label1.Text = "";
            txtGhiChu.Text = "";
            txtGiaBan.Text = "";
            txtHSX.Text = "";
            txtTonKho.Text = "";
            cb_NPP.Text = "";
            cbLoaiSP.Text = "";
            txt_MaSP.Focus();
            btn_Save.Enabled = true;
        }

        private void gunaDataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;

                dtSanPham = SpControl.HienThiDuLieuTimKiem(txt_Search.Text);
                gunaDataGridView1.DataSource = dtSanPham;
                gunaDataGridView1.DataSource = dtSanPham;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaNhaPhanPhoi";
                gunaDataGridView1.Columns[2].DataPropertyName = "TenSanPham";
                gunaDataGridView1.Columns[3].DataPropertyName = "LoaiSanPham";
                gunaDataGridView1.Columns[4].DataPropertyName = "HangSanXuat";
                gunaDataGridView1.Columns[5].DataPropertyName = "GiaBan";
                gunaDataGridView1.Columns[6].DataPropertyName = "TonKho";
                gunaDataGridView1.Columns[7].DataPropertyName = "Image";
                gunaDataGridView1.Columns[8].DataPropertyName = "ChuThich";
            }
            catch
            {
                MessageBox.Show("Thông báo", "Dữ liệu tìm kiếm không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.AutoGenerateColumns = false;

                dtSanPham = SpControl.HienThiDuLieuTimKiem(txt_MaSP.Text);
                gunaDataGridView1.DataSource = dtSanPham;
                gunaDataGridView1.DataSource = dtSanPham;
                gunaDataGridView1.Columns[0].DataPropertyName = "MaSanPham";
                gunaDataGridView1.Columns[1].DataPropertyName = "MaNhaPhanPhoi";
                gunaDataGridView1.Columns[2].DataPropertyName = "TenSanPham";
                gunaDataGridView1.Columns[3].DataPropertyName = "LoaiSanPham";
                gunaDataGridView1.Columns[4].DataPropertyName = "HangSanXuat";
                gunaDataGridView1.Columns[5].DataPropertyName = "GiaBan";
                gunaDataGridView1.Columns[6].DataPropertyName = "TonKho";
                gunaDataGridView1.Columns[7].DataPropertyName = "Image";
                gunaDataGridView1.Columns[8].DataPropertyName = "ChuThich";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTonKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtTonKho.Text.Length == 0 || txtTonKho.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
               (e.KeyChar == '.' && (txtGiaBan.Text.Length == 0 || txtGiaBan.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txtTonKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //if(SpControl.KiemtraMASP(txt_MaSP.Text))
            //{
            //        MessageBox.Show("Có tồn tại");
            //}
            //else
            //{
            //    MessageBox.Show("K Có tồn tại");
            //}
            //if (SpControl.KiemTraSanPham(txt_MaSP.Text))
            //{
            //    MessageBox.Show("Có tồn tại");
            //}
            //else
            //{
            //    MessageBox.Show("Thành công");
            //}
            if (SpControl.KiemTraSanPham(txt_MaSP.Text))
            {


                if (SpControl.kiemTraTonTaihoadon(txt_MaSP.Text))
                {
                    MessageBox.Show(txt_MaSP.Text + "  TỒN TẠI TRONG bảng  hóa đơn nên không thể xóa!!");
                }
                else
                {
                    if (SpControl.kiemTraTonTaiChiTietKhuyenMai(txt_MaSP.Text))
                    {
                        MessageBox.Show(txt_MaSP.Text + "  TỒN TẠI TRONG bảng chi tiết khuyến mãi nên không thể xóa!!");
                    }
                    else
                    {
                        if (SpControl.kiemTraTonTaiChiTietPhieuNhap(txt_MaSP.Text))
                        {
                            MessageBox.Show(txt_MaSP.Text + " TỒN TẠI TRONG bảng chi tiết phiếu nhập nên không thể xóa!!");
                        }
                        else
                        {
                            if (SpControl.kiemTraTonTaihoadon(txt_MaSP.Text))
                            {
                                MessageBox.Show(txt_MaSP.Text + " TỒN TẠI TRONG bảng  hóa đơn nên không thể xóa!!");
                            }
                            else
                            {
                                try
                                {
                                    SpControl.XoaDuLieuSP(txt_MaSP.Text);
                                    loadSP();
                                    MessageBox.Show("Thành công!");
                                    txt_MaSP.Text = "";
                                    txt_TenSanPham.Text = "";
                                    cb_NPP.Text = "";
                                    txtTonKho.Text = "";
                                    cbLoaiSP.Text = "";
                                    txtHSX.Text = "";
                                    txtGiaBan.Text = "";
                                    txtGhiChu.Text = "";
                                    txt_MaSP.Focus();
                                }
                                catch
                                {
                                    MessageBox.Show("Lỗi câu lệnh sai");
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " chưa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //

            //if (SpControl.kiemTraTonTaichitiethoadon(txt_MaSP.Text) == false && SpControl.kiemTraTonTaiChiTietKhuyenMai(txt_MaSP.Text) == false && SpControl.kiemTraTonTaiChiTietPhieuNhap(txt_MaSP.Text) == false && SpControl.kiemTraTonTaihoadon(txt_MaSP.Text) == false)
            //{
            //    try
            //    {
            //        SPModel.XoaSanPham(txt_MaSP.Text);
            //        MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại | không thể xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //        //MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        loadSP();
            //        txt_MaSP.Text = "";
            //        txt_TenSanPham.Text = "";
            //        cb_NPP.Text = "";
            //        txtTonKho.Text = "";
            //        cbLoaiSP.Text = "";
            //        txtHSX.Text = "";
            //        txtGiaBan.Text = "";
            //        txtGhiChu.Text = "";
            //        label1.Text = "";

            //        txt_MaSP.Focus();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("lỗi rồi ");

            //    }
            //}
            //else
            //{
            //    //MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại | không thể xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    //MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại | không thể xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    loadSP();
            //}


            //    if (SpControl.kiemTraTonTaichitiethoadon(txt_MaSP.Text))
            //    {
            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    loadSP();

            //    }
            //else if (SpControl.kiemTraTonTaihoadon(txt_MaSP.Text))
            //{
            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    loadSP();
            //}
            //else if (SpControl.kiemTraTonTaiChiTietPhieuNhap(txt_MaSP.Text))
            //{
            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    loadSP();
            //}
            //else if (SpControl.kiemTraTonTaiChiTietKhuyenMai(txt_MaSP.Text))
            //{
            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    loadSP();
            //}
            //else
            //    {
            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    loadSP();
            //    MessageBox.Show("Xóa không thành công1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_MaSP.Text = "";
            //    txt_TenSanPham.Text = "";
            //    cb_NPP.Text = "";
            //    txtTonKho.Text = "";
            //    cbLoaiSP.Text = "";
            //    txtHSX.Text = "";
            //    txtGiaBan.Text = "";
            //    txtGhiChu.Text = "";
            //    label1.Text = "";

            //    txt_MaSP.Focus();
            //}





            //MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //SPModel.XoaSanPham(txt_MaSP.Text);
            //loadSP();
            //MessageBox.Show("Xóa không thành công1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //txt_MaSP.Text = "";
            //txt_TenSanPham.Text = "";
            //cb_NPP.Text = "";
            //txtTonKho.Text = "";
            //cbLoaiSP.Text = "";
            //txtHSX.Text = "";
            //txtGiaBan.Text = "";
            //txtGhiChu.Text = "";
            //label1.Text = "";

            //txt_MaSP.Focus();

            //else if (SPModel.kiemTraTonTaiChiTietKhuyenMai(txt_MaSP.Text))
            //{
            //    //MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bang chi tiết khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    loadSP();
            //    MessageBox.Show("Xóa không thành công2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_MaSP.Text = "";
            //    txt_TenSanPham.Text = "";
            //    cb_NPP.Text = "";
            //    txtTonKho.Text = "";
            //    cbLoaiSP.Text = "";
            //    txtHSX.Text = "";
            //    txtGiaBan.Text = "";
            //    txtGhiChu.Text = "";
            //    label1.Text = "";

            //    txt_MaSP.Focus();
            //}
            //else if (SPModel.kiemTraTonTaiChiTietPhieuNhap(txt_MaSP.Text))
            //{
            //    //MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    loadSP();
            //    MessageBox.Show("Xóa không thành công3", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_MaSP.Text = "";
            //    txt_TenSanPham.Text = "";
            //    cb_NPP.Text = "";
            //    txtTonKho.Text = "";
            //    cbLoaiSP.Text = "";
            //    txtHSX.Text = "";
            //    txtGiaBan.Text = "";
            //    txtGhiChu.Text = "";
            //    label1.Text = "";

            //    txt_MaSP.Focus();
            //}
            //else if (SPModel.kiemTraTonTaiHoaDon(txt_MaSP.Text))
            //{
            //    //MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    SPModel.XoaSanPham(txt_MaSP.Text);
            //    loadSP();
            //    MessageBox.Show("Xóa không thành công4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_MaSP.Text = "";
            //    txt_TenSanPham.Text = "";
            //    cb_NPP.Text = "";
            //    txtTonKho.Text = "";
            //    cbLoaiSP.Text = "";
            //    txtHSX.Text = "";
            //    txtGiaBan.Text = "";
            //    txtGhiChu.Text = "";
            //    label1.Text = "";

            //    txt_MaSP.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại trong bảng chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}

            //if (SPModel.kiemTraTonTaiChiTietHoaDon(txt_MaSP.Text)  || SPModel.kiemTraTonTaiChiTietKhuyenMai(txt_MaSP.Text) || SPModel.kiemTraTonTaiChiTietPhieuNhap(txt_MaSP.Text) || SPModel.kiemTraTonTaiHoaDon(txt_MaSP.Text))
            //{
            //    try
            //    {
            //        SPModel.XoaSanPham(txt_MaSP.Text);
            //        loadSP();
            //        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_MaSP.Text = "";
            //        txt_TenSanPham.Text = "";
            //        cb_NPP.Text = "";
            //        txtTonKho.Text = "";
            //        cbLoaiSP.Text = "";
            //        txtHSX.Text = "";
            //        txtGiaBan.Text = "";
            //        txtGhiChu.Text = "";
            //        label1.Text = "";

            //        txt_MaSP.Focus();
            //    }
            //    catch (Exception)
            //    {


            //    }




            //}

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_MaSP.Enabled = false;
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    command = connection.CreateCommand();
                //command.CommandText = "UPDATE NhanVien set TenNhanVien= N'"+txtTenNV.Text + "',NgaySinh= '" + txtNgaySinh.Text +"', GioiTinh= N'" + txtGioiTinh.Text + "',NgayVaoLam = '"+txtNVL.Text+"',ChucVu = N'"+txtChucVu.Text+ "',DiaChi = N'"+txtDiaChi.Text+"',SoDT='"+txtSDT.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaNhanVien='"+txtMaNV.Text+"'" ;
                //command.ExecuteNonQuery();
                SpControl.SuaDuLieuSP(txt_MaSP.Text, cb_NPP.Text, txt_TenSanPham.Text, cbLoaiSP.Text, txtHSX.Text, float.Parse(txtGiaBan.Text), int.Parse(txtTonKho.Text), label1.Text, txtGhiChu.Text);
            loadSP();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_MaSP.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaSP.Focus();
                return;
            }
            if (cb_NPP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_NPP.Focus();
                return;
            }
            if (txt_TenSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenSanPham.Focus();
                return;
            }
            if (cbLoaiSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLoaiSP.Focus();
                return;
            }
            if (txtHSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHSX.Focus();
                return;
            }

            if (txtGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return;
            }

            if (txtTonKho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tồn kho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTonKho.Focus();
                return;
            }



            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập VÀO chú thích sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            try
            {
                if (SpControl.KiemTraSanPham(txt_MaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm " + txt_MaSP.Text.Trim() + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    SpControl.ThemDuLieuSP(txt_MaSP.Text, cb_NPP.Text, txt_TenSanPham.Text, cbLoaiSP.Text, txtHSX.Text, float.Parse(txtGiaBan.Text), int.Parse(txtTonKho.Text), label1.Text, txtGhiChu.Text);

                    loadSP();
                    MessageBox.Show("Thành công!");
                    txt_MaSP.Text = "";
                    txt_TenSanPham.Text = "";
                    cb_NPP.Text = "";
                    txtTonKho.Text = "";
                    cbLoaiSP.Text = "";
                    txtHSX.Text = "";
                    txtGiaBan.Text = "";
                    txtGhiChu.Text = "";
                    label1.Text = "";
                    txt_MaSP.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại" + ex);
            }
        }
    }
}
