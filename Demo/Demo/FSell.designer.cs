namespace Demo
{
    partial class FSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSell));
            this.cboxGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SHOPPETDataSet = new Demo.QL_SHOPPETDataSet();
            this.txtTenKhacHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.KhachHangTableAdapter();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.SanPhamTableAdapter();
            this.txtTenSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.hoaDonTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.HoaDonTableAdapter();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.fKHOADONKHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.DonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Them = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SHOPPETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHOADONKHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxGioiTinh
            // 
            this.cboxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboxGioiTinh.BaseColor = System.Drawing.Color.White;
            this.cboxGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cboxGioiTinh.DataSource = this.hoaDonBindingSource;
            this.cboxGioiTinh.DisplayMember = "MaHoaDon";
            this.cboxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboxGioiTinh.FormattingEnabled = true;
            this.cboxGioiTinh.Location = new System.Drawing.Point(350, 100);
            this.cboxGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxGioiTinh.Name = "cboxGioiTinh";
            this.cboxGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboxGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboxGioiTinh.Radius = 2;
            this.cboxGioiTinh.Size = new System.Drawing.Size(278, 26);
            this.cboxGioiTinh.TabIndex = 72;
            this.cboxGioiTinh.ValueMember = "MaHoaDon";
            this.cboxGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboxGioiTinh_SelectedIndexChanged);
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // qL_SHOPPETDataSet
            // 
            this.qL_SHOPPETDataSet.DataSetName = "QL_SHOPPETDataSet";
            this.qL_SHOPPETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenKhacHang
            // 
            this.txtTenKhacHang.BorderRadius = 6;
            this.txtTenKhacHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhacHang.DefaultText = "";
            this.txtTenKhacHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhacHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhacHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhacHang.DisabledState.Parent = this.txtTenKhacHang;
            this.txtTenKhacHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhacHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhacHang.FocusedState.Parent = this.txtTenKhacHang;
            this.txtTenKhacHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhacHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKhacHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhacHang.HoverState.Parent = this.txtTenKhacHang;
            this.txtTenKhacHang.Location = new System.Drawing.Point(44, 154);
            this.txtTenKhacHang.Margin = new System.Windows.Forms.Padding(16, 20, 16, 20);
            this.txtTenKhacHang.Name = "txtTenKhacHang";
            this.txtTenKhacHang.PasswordChar = '\0';
            this.txtTenKhacHang.PlaceholderText = "Tên Khách Hàng";
            this.txtTenKhacHang.SelectedText = "";
            this.txtTenKhacHang.ShadowDecoration.Parent = this.txtTenKhacHang;
            this.txtTenKhacHang.Size = new System.Drawing.Size(303, 75);
            this.txtTenKhacHang.TabIndex = 74;
            this.txtTenKhacHang.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BorderRadius = 6;
            this.txtTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSanPham.DefaultText = "";
            this.txtTenSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSanPham.DisabledState.Parent = this.txtTenSanPham;
            this.txtTenSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSanPham.FocusedState.Parent = this.txtTenSanPham;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSanPham.HoverState.Parent = this.txtTenSanPham;
            this.txtTenSanPham.Location = new System.Drawing.Point(375, 154);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PasswordChar = '\0';
            this.txtTenSanPham.PlaceholderText = "Tên Sản Phẩm";
            this.txtTenSanPham.SelectedText = "";
            this.txtTenSanPham.ShadowDecoration.Parent = this.txtTenSanPham;
            this.txtTenSanPham.Size = new System.Drawing.Size(345, 75);
            this.txtTenSanPham.TabIndex = 75;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachHangBindingSource, "TenKhachHang", true));
            this.gunaComboBox1.DataSource = this.hoaDonBindingSource;
            this.gunaComboBox1.DisplayMember = "MaKhachHang";
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(0, 32);
            this.gunaComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 2;
            this.gunaComboBox1.Size = new System.Drawing.Size(128, 26);
            this.gunaComboBox1.TabIndex = 76;
            this.gunaComboBox1.ValueMember = "MaKhachHang";
            this.gunaComboBox1.Visible = false;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // fKHOADONKHACHHANGBindingSource
            // 
            this.fKHOADONKHACHHANGBindingSource.DataMember = "FK_HOADON_KHACHHANG";
            this.fKHOADONKHACHHANGBindingSource.DataSource = this.khachHangBindingSource;
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachHangBindingSource, "TenKhachHang", true));
            this.gunaComboBox2.DataSource = this.hoaDonBindingSource;
            this.gunaComboBox2.DisplayMember = "MaSanPham";
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Location = new System.Drawing.Point(131, 32);
            this.gunaComboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Radius = 2;
            this.gunaComboBox2.Size = new System.Drawing.Size(128, 26);
            this.gunaComboBox2.TabIndex = 77;
            this.gunaComboBox2.ValueMember = "MaSanPham";
            this.gunaComboBox2.Visible = false;
            this.gunaComboBox2.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderRadius = 6;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.Parent = this.txtSoLuong;
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedState.Parent = this.txtSoLuong;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.HoverState.Parent = this.txtSoLuong;
            this.txtSoLuong.Location = new System.Drawing.Point(44, 284);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderText = "Số Lượng";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.ShadowDecoration.Parent = this.txtSoLuong;
            this.txtSoLuong.Size = new System.Drawing.Size(303, 75);
            this.txtSoLuong.TabIndex = 78;
            // 
            // DonGia
            // 
            this.DonGia.BorderRadius = 6;
            this.DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DonGia.DefaultText = "";
            this.DonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DonGia.DisabledState.Parent = this.DonGia;
            this.DonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DonGia.FocusedState.Parent = this.DonGia;
            this.DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DonGia.HoverState.Parent = this.DonGia;
            this.DonGia.Location = new System.Drawing.Point(375, 284);
            this.DonGia.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DonGia.Name = "DonGia";
            this.DonGia.PasswordChar = '\0';
            this.DonGia.PlaceholderText = "Giá";
            this.DonGia.SelectedText = "";
            this.DonGia.ShadowDecoration.Parent = this.DonGia;
            this.DonGia.Size = new System.Drawing.Size(345, 75);
            this.DonGia.TabIndex = 79;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderRadius = 6;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.Parent = this.txtTongTien;
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedState.Parent = this.txtTongTien;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.HoverState.Parent = this.txtTongTien;
            this.txtTongTien.Location = new System.Drawing.Point(44, 433);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(16, 20, 16, 20);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderText = "Tổng Tiền";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.ShadowDecoration.Parent = this.txtTongTien;
            this.txtTongTien.Size = new System.Drawing.Size(303, 75);
            this.txtTongTien.TabIndex = 80;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderRadius = 6;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.Parent = this.txtGhiChu;
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.FocusedState.Parent = this.txtGhiChu;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.HoverState.Parent = this.txtGhiChu;
            this.txtGhiChu.Location = new System.Drawing.Point(375, 433);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "Ghi Chú";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.ShadowDecoration.Parent = this.txtGhiChu;
            this.txtGhiChu.Size = new System.Drawing.Size(345, 75);
            this.txtGhiChu.TabIndex = 81;
            // 
            // btn_Them
            // 
            this.btn_Them.AnimationHoverSpeed = 0.07F;
            this.btn_Them.AnimationSpeed = 0.03F;
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Them.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Them.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Them.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Them.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.CheckedImage")));
            this.btn_Them.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Them.Location = new System.Drawing.Point(640, 100);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Radius = 10;
            this.btn_Them.Size = new System.Drawing.Size(80, 25);
            this.btn_Them.TabIndex = 82;
            this.btn_Them.Text = "In";
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 561);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.gunaComboBox2);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtTenKhacHang);
            this.Controls.Add(this.cboxGioiTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FSell";
            this.Text = "FSell";
            this.Load += new System.EventHandler(this.FSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SHOPPETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHOADONKHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cboxGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhacHang;
        private QL_SHOPPETDataSet qL_SHOPPETDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QL_SHOPPETDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QL_SHOPPETDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSanPham;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QL_SHOPPETDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.BindingSource fKHOADONKHACHHANGBindingSource;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox DonGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Them;

    }
}