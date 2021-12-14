namespace Demo
{
    partial class fUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUser));
            this.cboQuyen = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_Sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.cboMaNV = new Guna.UI.WinForms.GunaComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SHOPPETDataSet1 = new Demo.QL_SHOPPETDataSet();
            this.btnTimKiem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.nhanVienTableAdapter = new Demo.QL_SHOPPETDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SHOPPETDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboQuyen
            // 
            this.cboQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cboQuyen.BaseColor = System.Drawing.Color.White;
            this.cboQuyen.BorderColor = System.Drawing.Color.Silver;
            this.cboQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.FocusedColor = System.Drawing.Color.Empty;
            this.cboQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuyen.ForeColor = System.Drawing.Color.Black;
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "User      ",
            "Admin     ",
            "Manage    "});
            this.cboQuyen.Location = new System.Drawing.Point(129, 521);
            this.cboQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboQuyen.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboQuyen.Radius = 2;
            this.cboQuyen.Size = new System.Drawing.Size(128, 26);
            this.cboQuyen.TabIndex = 73;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel7.Location = new System.Drawing.Point(9, 521);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel7.TabIndex = 72;
            this.gunaLabel7.Text = "Quyền:";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel6.Location = new System.Drawing.Point(287, 466);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(98, 31);
            this.gunaLabel6.TabIndex = 65;
            this.gunaLabel6.Text = "Mật Khẩu:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMK
            // 
            this.txtMK.BorderRadius = 6;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.DefaultText = "";
            this.txtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.DisabledState.Parent = this.txtMK;
            this.txtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.FocusedState.Parent = this.txtMK;
            this.txtMK.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.HoverState.Parent = this.txtMK;
            this.txtMK.Location = new System.Drawing.Point(392, 466);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '\0';
            this.txtMK.PlaceholderText = "Mật Khẩu";
            this.txtMK.SelectedText = "";
            this.txtMK.ShadowDecoration.Parent = this.txtMK;
            this.txtMK.Size = new System.Drawing.Size(163, 31);
            this.txtMK.TabIndex = 64;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BorderRadius = 6;
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.DisabledState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.FocusedState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.HoverState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Location = new System.Drawing.Point(129, 466);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderText = "Tên Nhân Viên";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.ShadowDecoration.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Size = new System.Drawing.Size(162, 31);
            this.txtTenNhanVien.TabIndex = 62;
            this.txtTenNhanVien.TextChanged += new System.EventHandler(this.txtTenNhanVien_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel3.Location = new System.Drawing.Point(280, 411);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(106, 31);
            this.gunaLabel3.TabIndex = 61;
            this.gunaLabel3.Text = "Tên Tài Khoản:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BorderRadius = 6;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultText = "";
            this.txtTenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.DisabledState.Parent = this.txtTenTaiKhoan;
            this.txtTenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.FocusedState.Parent = this.txtTenTaiKhoan;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.HoverState.Parent = this.txtTenTaiKhoan;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(392, 411);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PlaceholderText = "Tên Tài Khoản";
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.ShadowDecoration.Parent = this.txtTenTaiKhoan;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(163, 31);
            this.txtTenTaiKhoan.TabIndex = 60;
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel1.Location = new System.Drawing.Point(4, 409);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(113, 31);
            this.gunaLabel1.TabIndex = 58;
            this.gunaLabel1.Text = "Mã Nhân Viên:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(752, 329);
            this.gunaDataGridView1.TabIndex = 56;
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
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Tài Khoản";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mật Khẩu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quyền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Nhân Viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 10;
            this.gunaElipse5.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BaseColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Demo.Properties.Resources.debut;
            this.pictureBox1.Location = new System.Drawing.Point(462, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseTransfarantBackground = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btn_Sua.Location = new System.Drawing.Point(660, 409);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua.OnHoverImage = null;
            this.btn_Sua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua.Radius = 10;
            this.btn_Sua.Size = new System.Drawing.Size(91, 71);
            this.btn_Sua.TabIndex = 54;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            this.btn_Xoa.Location = new System.Drawing.Point(565, 411);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa.OnHoverImage = null;
            this.btn_Xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa.Radius = 10;
            this.btn_Xoa.Size = new System.Drawing.Size(91, 69);
            this.btn_Xoa.TabIndex = 53;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_Save.Location = new System.Drawing.Point(660, 489);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save.OnHoverImage = null;
            this.btn_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save.Radius = 10;
            this.btn_Save.Size = new System.Drawing.Size(91, 63);
            this.btn_Save.TabIndex = 52;
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
            this.btn_Them.Location = new System.Drawing.Point(565, 488);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Radius = 10;
            this.btn_Them.Size = new System.Drawing.Size(91, 63);
            this.btn_Them.TabIndex = 51;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel9.Location = new System.Drawing.Point(4, 466);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(109, 31);
            this.gunaLabel9.TabIndex = 70;
            this.gunaLabel9.Text = "Tên Nhân Viên:";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMaNV
            // 
            this.cboMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cboMaNV.BaseColor = System.Drawing.Color.White;
            this.cboMaNV.BorderColor = System.Drawing.Color.Silver;
            this.cboMaNV.DataSource = this.nhanVienBindingSource;
            this.cboMaNV.DisplayMember = "MaNhanVien";
            this.cboMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FocusedColor = System.Drawing.Color.Empty;
            this.cboMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaNV.ForeColor = System.Drawing.Color.Black;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(129, 409);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboMaNV.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboMaNV.Radius = 2;
            this.cboMaNV.Size = new System.Drawing.Size(128, 26);
            this.cboMaNV.TabIndex = 71;
            this.cboMaNV.ValueMember = "MaNhanVien";
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qL_SHOPPETDataSet1;
            // 
            // qL_SHOPPETDataSet1
            // 
            this.qL_SHOPPETDataSet1.DataSetName = "QL_SHOPPETDataSet";
            this.qL_SHOPPETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnTimKiem.Location = new System.Drawing.Point(147, 335);
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
            this.btnTimKiem.TabIndex = 193;
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
            this.txt_Search.Location = new System.Drawing.Point(-1, 335);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Tìm kiếm...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(142, 31);
            this.txt_Search.TabIndex = 192;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // fUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 613);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fUser";
            this.Text = "fUser";
            this.Load += new System.EventHandler(this.fUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SHOPPETDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cboQuyen;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaCirclePictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtMK;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoan;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Xoa;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Save;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Them;
        public Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI.WinForms.GunaComboBox cboMaNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaAdvenceButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private QL_SHOPPETDataSet qL_SHOPPETDataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QL_SHOPPETDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}