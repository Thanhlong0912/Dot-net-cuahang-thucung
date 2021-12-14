namespace Demo
{
    partial class fNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboxChucVu = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.cboxGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_Sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_MaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.data = new Guna.UI.WinForms.GunaLabel();
            this.btnTimKiem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.data_NgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.data_NgayVaoLam = new Guna.UI.WinForms.GunaDateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxChucVu
            // 
            this.cboxChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cboxChucVu.BaseColor = System.Drawing.Color.White;
            this.cboxChucVu.BorderColor = System.Drawing.Color.Silver;
            this.cboxChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxChucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cboxChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxChucVu.ForeColor = System.Drawing.Color.Black;
            this.cboxChucVu.FormattingEnabled = true;
            this.cboxChucVu.Items.AddRange(new object[] {
            "Quản Lý    ",
            "Nhân Viên    "});
            this.cboxChucVu.Location = new System.Drawing.Point(292, 470);
            this.cboxChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.cboxChucVu.Name = "cboxChucVu";
            this.cboxChucVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboxChucVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboxChucVu.Radius = 2;
            this.cboxChucVu.Size = new System.Drawing.Size(129, 26);
            this.cboxChucVu.TabIndex = 73;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel7.Location = new System.Drawing.Point(224, 466);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel7.TabIndex = 72;
            this.gunaLabel7.Text = "Chức Vụ:";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxGioiTinh
            // 
            this.cboxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboxGioiTinh.BaseColor = System.Drawing.Color.White;
            this.cboxGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cboxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboxGioiTinh.FormattingEnabled = true;
            this.cboxGioiTinh.Items.AddRange(new object[] {
            "None",
            "Nam",
            "Nữ"});
            this.cboxGioiTinh.Location = new System.Drawing.Point(76, 470);
            this.cboxGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboxGioiTinh.Name = "cboxGioiTinh";
            this.cboxGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboxGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboxGioiTinh.Radius = 2;
            this.cboxGioiTinh.Size = new System.Drawing.Size(128, 26);
            this.cboxGioiTinh.TabIndex = 71;
            this.cboxGioiTinh.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel9.Location = new System.Drawing.Point(10, 470);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel9.TabIndex = 70;
            this.gunaLabel9.Text = "Giới Tính:";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BaseColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Demo.Properties.Resources.debut;
            this.pictureBox1.Location = new System.Drawing.Point(464, 336);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel8.Location = new System.Drawing.Point(427, 508);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(64, 45);
            this.gunaLabel8.TabIndex = 67;
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
            this.txtGhiChu.Location = new System.Drawing.Point(500, 511);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "Ghi Chú";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.ShadowDecoration.Parent = this.txtGhiChu;
            this.txtGhiChu.Size = new System.Drawing.Size(167, 31);
            this.txtGhiChu.TabIndex = 66;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel6.Location = new System.Drawing.Point(224, 511);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel6.TabIndex = 65;
            this.gunaLabel6.Text = "SĐT:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderRadius = 6;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(294, 511);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Số Điện Thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(127, 31);
            this.txtSDT.TabIndex = 64;
            this.txtSDT.TextChanged += new System.EventHandler(this.guna2TextBox6_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel5.Location = new System.Drawing.Point(10, 514);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel5.TabIndex = 63;
            this.gunaLabel5.Text = "Địa Chỉ:";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderRadius = 6;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(76, 514);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "Địa Chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(127, 31);
            this.txtDiaChi.TabIndex = 62;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 10;
            this.gunaElipse5.TargetControl = this;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel3.Location = new System.Drawing.Point(224, 410);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel3.TabIndex = 61;
            this.gunaLabel3.Text = "Tên NV:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
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
            this.btn_Sua.Location = new System.Drawing.Point(674, 466);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua.OnHoverImage = null;
            this.btn_Sua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua.Radius = 10;
            this.btn_Sua.Size = new System.Drawing.Size(78, 71);
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
            this.btn_Xoa.Location = new System.Drawing.Point(756, 392);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa.OnHoverImage = null;
            this.btn_Xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa.Radius = 10;
            this.btn_Xoa.Size = new System.Drawing.Size(78, 71);
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
            this.btn_Save.Location = new System.Drawing.Point(756, 466);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save.OnHoverImage = null;
            this.btn_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save.Radius = 10;
            this.btn_Save.Size = new System.Drawing.Size(78, 71);
            this.btn_Save.TabIndex = 52;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this;
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
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.FocusedState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.HoverState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Location = new System.Drawing.Point(294, 410);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderText = "Tên Nhân Viên";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.ShadowDecoration.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Size = new System.Drawing.Size(127, 31);
            this.txtTenNhanVien.TabIndex = 60;
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
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.GioiTinh,
            this.NVL,
            this.ChucVu,
            this.DiaChi,
            this.SDT,
            this.GhiChu});
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(1, -1);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(833, 332);
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
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            this.gunaDataGridView1.Click += new System.EventHandler(this.gunaDataGridView1_Click);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NVL
            // 
            this.NVL.HeaderText = "Ngày Vào Làm";
            this.NVL.Name = "NVL";
            this.NVL.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
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
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel2.Location = new System.Drawing.Point(422, 410);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 41);
            this.gunaLabel2.TabIndex = 59;
            this.gunaLabel2.Text = "Ngày Sinh:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel1.Location = new System.Drawing.Point(5, 410);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel1.TabIndex = 58;
            this.gunaLabel1.Text = "Mã NV:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderRadius = 6;
            this.txt_MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.DefaultText = "";
            this.txt_MaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNV.DisabledState.Parent = this.txt_MaNV;
            this.txt_MaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNV.FocusedState.Parent = this.txt_MaNV;
            this.txt_MaNV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_MaNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_MaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNV.HoverState.Parent = this.txt_MaNV;
            this.txt_MaNV.Location = new System.Drawing.Point(76, 410);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.PasswordChar = '\0';
            this.txt_MaNV.PlaceholderText = "Mã Nhân Viên";
            this.txt_MaNV.SelectedText = "";
            this.txt_MaNV.ShadowDecoration.Parent = this.txt_MaNV;
            this.txt_MaNV.Size = new System.Drawing.Size(127, 31);
            this.txt_MaNV.TabIndex = 57;
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
            this.btn_Them.Location = new System.Drawing.Point(674, 392);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Radius = 10;
            this.btn_Them.Size = new System.Drawing.Size(78, 69);
            this.btn_Them.TabIndex = 51;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.data.Location = new System.Drawing.Point(422, 464);
            this.data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(74, 41);
            this.data.TabIndex = 74;
            this.data.Text = "Ngày Vào Làm:";
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.data.Click += new System.EventHandler(this.data_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(148, 336);
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
            this.txt_Search.Location = new System.Drawing.Point(1, 336);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Tìm kiếm...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(142, 31);
            this.txt_Search.TabIndex = 192;
            // 
            // data_NgaySinh
            // 
            this.data_NgaySinh.BaseColor = System.Drawing.Color.White;
            this.data_NgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.data_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.data_NgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.data_NgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.data_NgaySinh.ForeColor = System.Drawing.Color.Black;
            this.data_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_NgaySinh.Location = new System.Drawing.Point(500, 410);
            this.data_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.data_NgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.data_NgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.data_NgaySinh.Name = "data_NgaySinh";
            this.data_NgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.data_NgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.data_NgaySinh.Size = new System.Drawing.Size(164, 31);
            this.data_NgaySinh.TabIndex = 194;
            this.data_NgaySinh.Text = "05/11/2021";
            this.data_NgaySinh.Value = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            this.data_NgaySinh.ValueChanged += new System.EventHandler(this.data_NgayNhap_ValueChanged);
            // 
            // data_NgayVaoLam
            // 
            this.data_NgayVaoLam.BaseColor = System.Drawing.Color.White;
            this.data_NgayVaoLam.BorderColor = System.Drawing.Color.Silver;
            this.data_NgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.data_NgayVaoLam.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.data_NgayVaoLam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.data_NgayVaoLam.ForeColor = System.Drawing.Color.Black;
            this.data_NgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_NgayVaoLam.Location = new System.Drawing.Point(500, 470);
            this.data_NgayVaoLam.Margin = new System.Windows.Forms.Padding(2);
            this.data_NgayVaoLam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.data_NgayVaoLam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.data_NgayVaoLam.Name = "data_NgayVaoLam";
            this.data_NgayVaoLam.OnHoverBaseColor = System.Drawing.Color.White;
            this.data_NgayVaoLam.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgayVaoLam.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_NgayVaoLam.OnPressedColor = System.Drawing.Color.Black;
            this.data_NgayVaoLam.Size = new System.Drawing.Size(164, 31);
            this.data_NgayVaoLam.TabIndex = 195;
            this.data_NgayVaoLam.Text = "05/11/2021";
            this.data_NgayVaoLam.Value = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 613);
            this.Controls.Add(this.data_NgayVaoLam);
            this.Controls.Add(this.data_NgaySinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.data);
            this.Controls.Add(this.cboxChucVu);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.cboxGioiTinh);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.btn_Them);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fNhanVien";
            this.Text = "fNhanVien";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cboxChucVu;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox cboxGioiTinh;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaCirclePictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Xoa;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Save;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNV;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Them;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        public Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaLabel data;
        private Guna.UI.WinForms.GunaAdvenceButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI.WinForms.GunaDateTimePicker data_NgaySinh;
        private Guna.UI.WinForms.GunaDateTimePicker data_NgayVaoLam;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}