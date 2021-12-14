namespace Demo
{
    partial class fLoadHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoadHoaDon));
            this.cboMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SHOPPETDataSet = new Demo.QL_SHOPPETDataSet();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.cboMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cboMaSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.data_NgayLap = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_Sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTimKiem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.hoaDonTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.HoaDonTableAdapter();
            this.nhanVienTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.NhanVienTableAdapter();
            this.khachHangTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.KhachHangTableAdapter();
            this.sanPhamTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.SanPhamTableAdapter();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SHOPPETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaKH
            // 
            this.cboMaKH.BackColor = System.Drawing.Color.Transparent;
            this.cboMaKH.DataSource = this.khachHangBindingSource;
            this.cboMaKH.DisplayMember = "MaKhachHang";
            this.cboMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.FocusedColor = System.Drawing.Color.Empty;
            this.cboMaKH.FocusedState.Parent = this.cboMaKH;
            this.cboMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.HoverState.Parent = this.cboMaKH;
            this.cboMaKH.ItemHeight = 30;
            this.cboMaKH.ItemsAppearance.Parent = this.cboMaKH;
            this.cboMaKH.Location = new System.Drawing.Point(128, 408);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.ShadowDecoration.Parent = this.cboMaKH;
            this.cboMaKH.Size = new System.Drawing.Size(106, 36);
            this.cboMaKH.TabIndex = 183;
            this.cboMaKH.ValueMember = "MaKhachHang";
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // qL_SHOPPETDataSet
            // 
            this.qL_SHOPPETDataSet.DataSetName = "QL_SHOPPETDataSet";
            this.qL_SHOPPETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel5.Location = new System.Drawing.Point(9, 447);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(73, 31);
            this.gunaLabel5.TabIndex = 181;
            this.gunaLabel5.Text = "Tổng Tiền:";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
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
            this.txtTongTien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.HoverState.Parent = this.txtTongTien;
            this.txtTongTien.Location = new System.Drawing.Point(127, 447);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderText = "Tổng Tiền";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.ShadowDecoration.Parent = this.txtTongTien;
            this.txtTongTien.Size = new System.Drawing.Size(105, 31);
            this.txtTongTien.TabIndex = 180;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel3.Location = new System.Drawing.Point(-1, 374);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(106, 26);
            this.gunaLabel3.TabIndex = 175;
            this.gunaLabel3.Text = "Mã Nhân Viên:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel1.Location = new System.Drawing.Point(-10, 332);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 36);
            this.gunaLabel1.TabIndex = 174;
            this.gunaLabel1.Text = "Mã Hoá Đơn:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel8.Location = new System.Drawing.Point(278, 414);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(110, 20);
            this.gunaLabel8.TabIndex = 177;
            this.gunaLabel8.Text = "Ghi Chú:";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtGhiChu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGhiChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.HoverState.Parent = this.txtGhiChu;
            this.txtGhiChu.Location = new System.Drawing.Point(391, 408);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "Ghi Chú";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.ShadowDecoration.Parent = this.txtGhiChu;
            this.txtGhiChu.Size = new System.Drawing.Size(164, 77);
            this.txtGhiChu.TabIndex = 176;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 29;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(2, 0);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(754, 251);
            this.gunaDataGridView1.TabIndex = 172;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hoá Đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Nhân Viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã Sản Phẩm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày Lập Hoá Đơn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ghi Chú";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 10;
            this.gunaElipse4.TargetControl = this.gunaDataGridView1;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 10;
            this.gunaElipse5.TargetControl = this;
            // 
            // cboMaNV
            // 
            this.cboMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cboMaNV.DataSource = this.nhanVienBindingSource;
            this.cboMaNV.DisplayMember = "MaNhanVien";
            this.cboMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FocusedColor = System.Drawing.Color.Empty;
            this.cboMaNV.FocusedState.Parent = this.cboMaNV;
            this.cboMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.HoverState.Parent = this.cboMaNV;
            this.cboMaNV.ItemHeight = 30;
            this.cboMaNV.ItemsAppearance.Parent = this.cboMaNV;
            this.cboMaNV.Location = new System.Drawing.Point(128, 370);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.ShadowDecoration.Parent = this.cboMaNV;
            this.cboMaNV.Size = new System.Drawing.Size(106, 36);
            this.cboMaNV.TabIndex = 185;
            this.cboMaNV.ValueMember = "MaNhanVien";
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel4.Location = new System.Drawing.Point(-1, 414);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(116, 26);
            this.gunaLabel4.TabIndex = 184;
            this.gunaLabel4.Text = "Mã Khách Hàng:";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMaSP
            // 
            this.cboMaSP.BackColor = System.Drawing.Color.Transparent;
            this.cboMaSP.DataSource = this.sanPhamBindingSource;
            this.cboMaSP.DisplayMember = "MaSanPham";
            this.cboMaSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSP.FocusedColor = System.Drawing.Color.Empty;
            this.cboMaSP.FocusedState.Parent = this.cboMaSP;
            this.cboMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.HoverState.Parent = this.cboMaSP;
            this.cboMaSP.ItemHeight = 30;
            this.cboMaSP.ItemsAppearance.Parent = this.cboMaSP;
            this.cboMaSP.Location = new System.Drawing.Point(391, 370);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.ShadowDecoration.Parent = this.cboMaSP;
            this.cboMaSP.Size = new System.Drawing.Size(165, 36);
            this.cboMaSP.TabIndex = 187;
            this.cboMaSP.ValueMember = "MaSanPham";
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged);
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.qL_SHOPPETDataSet;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel6.Location = new System.Drawing.Point(278, 374);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(108, 26);
            this.gunaLabel6.TabIndex = 186;
            this.gunaLabel6.Text = "Mã Sản Phẩm:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_NgayLap
            // 
            this.data_NgayLap.BaseColor = System.Drawing.Color.White;
            this.data_NgayLap.BorderColor = System.Drawing.Color.Silver;
            this.data_NgayLap.CustomFormat = "dd/MM/yyyy";
            this.data_NgayLap.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.data_NgayLap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.data_NgayLap.ForeColor = System.Drawing.Color.Black;
            this.data_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_NgayLap.Location = new System.Drawing.Point(391, 328);
            this.data_NgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.data_NgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.data_NgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.data_NgayLap.Name = "data_NgayLap";
            this.data_NgayLap.OnHoverBaseColor = System.Drawing.Color.White;
            this.data_NgayLap.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgayLap.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgayLap.OnPressedColor = System.Drawing.Color.Black;
            this.data_NgayLap.Size = new System.Drawing.Size(164, 35);
            this.data_NgayLap.TabIndex = 189;
            this.data_NgayLap.Text = "05/11/2021";
            this.data_NgayLap.Value = new System.DateTime(2021, 11, 5, 14, 32, 36, 858);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel2.Location = new System.Drawing.Point(285, 332);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(94, 32);
            this.gunaLabel2.TabIndex = 188;
            this.gunaLabel2.Text = "Ngày Lập:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BaseColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Demo.Properties.Resources.debut;
            this.pictureBox1.Location = new System.Drawing.Point(464, 256);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 173;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseTransfarantBackground = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.AnimationHoverSpeed = 0.07F;
            this.btn_Sua.AnimationSpeed = 0.03F;
            this.btn_Sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Sua.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Sua.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Sua.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Sua.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.CheckedImage")));
            this.btn_Sua.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Sua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Sua.Location = new System.Drawing.Point(667, 407);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua.OnHoverImage = null;
            this.btn_Sua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua.Radius = 10;
            this.btn_Sua.Size = new System.Drawing.Size(89, 71);
            this.btn_Sua.TabIndex = 170;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AnimationHoverSpeed = 0.07F;
            this.btn_Save.AnimationSpeed = 0.03F;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Save.BorderColor = System.Drawing.Color.Black;
            this.btn_Save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Save.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Save.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.CheckedImage")));
            this.btn_Save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.Location = new System.Drawing.Point(667, 339);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save.OnHoverImage = null;
            this.btn_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save.Radius = 10;
            this.btn_Save.Size = new System.Drawing.Size(89, 63);
            this.btn_Save.TabIndex = 168;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(570, 339);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Radius = 10;
            this.btn_Them.Size = new System.Drawing.Size(92, 63);
            this.btn_Them.TabIndex = 167;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa.AnimationSpeed = 0.03F;
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Xoa.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Xoa.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.CheckedImage")));
            this.btn_Xoa.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.Location = new System.Drawing.Point(570, 410);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa.OnHoverImage = null;
            this.btn_Xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa.Radius = 10;
            this.btn_Xoa.Size = new System.Drawing.Size(92, 69);
            this.btn_Xoa.TabIndex = 169;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTimKiem.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.CheckedForeColor = System.Drawing.Color.White;
            this.btnTimKiem.CheckedImage = global::Demo.Properties.Resources.search_96px;
            this.btnTimKiem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::Demo.Properties.Resources.search_128px;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTimKiem.Location = new System.Drawing.Point(150, 256);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 10;
            this.btnTimKiem.Size = new System.Drawing.Size(82, 31);
            this.btnTimKiem.TabIndex = 191;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderRadius = 6;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.Parent = this.txt_Search;
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.FocusedState.Parent = this.txt_Search;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.HoverState.Parent = this.txt_Search;
            this.txt_Search.Location = new System.Drawing.Point(2, 256);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Tìm kiếm...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(142, 31);
            this.txt_Search.TabIndex = 190;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(127, 341);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(107, 20);
            this.txtMaHD.TabIndex = 193;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::Demo.Properties.Resources.box_48px1;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(570, 259);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(186, 76);
            this.gunaAdvenceButton1.TabIndex = 194;
            this.gunaAdvenceButton1.Text = "In thống kê";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // fLoadHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.data_NgayLap);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.cboMaSP);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fLoadHoaDon";
            this.Text = "fLoadHoaDon";
            this.Load += new System.EventHandler(this.fLoadHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SHOPPETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboMaKH;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI.WinForms.GunaCirclePictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Save;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Them;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Xoa;
        public Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaSP;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDateTimePicker data_NgayLap;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private QL_SHOPPETDataSet qL_SHOPPETDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QL_SHOPPETDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QL_SHOPPETDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QL_SHOPPETDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QL_SHOPPETDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.TextBox txtMaHD;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}