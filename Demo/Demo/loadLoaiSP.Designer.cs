namespace Demo
{
    partial class loadLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadLoaiSP));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 10;
            this.gunaElipse4.TargetControl = this.gunaDataGridView1;
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
            this.MaLoai,
            this.TenLoai});
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(3, 2);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(442, 206);
            this.gunaDataGridView1.TabIndex = 79;
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
            this.gunaDataGridView1.Click += new System.EventHandler(this.gunaDataGridView1_Click);
            // 
            // MaLoai
            // 
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Tên Loại";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
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
            // pictureBox1
            // 
            this.pictureBox1.BaseColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Demo.Properties.Resources.debut;
            this.pictureBox1.Location = new System.Drawing.Point(194, 210);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel3.Location = new System.Drawing.Point(227, 278);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel3.TabIndex = 84;
            this.gunaLabel3.Text = "Tên Loại:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BorderRadius = 6;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.DefaultText = "";
            this.txtTenLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.DisabledState.Parent = this.txtTenLoai;
            this.txtTenLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.FocusedState.Parent = this.txtTenLoai;
            this.txtTenLoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenLoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.HoverState.Parent = this.txtTenLoai;
            this.txtTenLoai.Location = new System.Drawing.Point(319, 278);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.PasswordChar = '\0';
            this.txtTenLoai.PlaceholderText = "Tên Loại";
            this.txtTenLoai.SelectedText = "";
            this.txtTenLoai.ShadowDecoration.Parent = this.txtTenLoai;
            this.txtTenLoai.Size = new System.Drawing.Size(127, 31);
            this.txtTenLoai.TabIndex = 83;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaLabel1.Location = new System.Drawing.Point(9, 278);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 31);
            this.gunaLabel1.TabIndex = 81;
            this.gunaLabel1.Text = "Mã Loại:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BorderRadius = 6;
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoai.DefaultText = "";
            this.txtMaLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoai.DisabledState.Parent = this.txtMaLoai;
            this.txtMaLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoai.FocusedState.Parent = this.txtMaLoai;
            this.txtMaLoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaLoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoai.HoverState.Parent = this.txtMaLoai;
            this.txtMaLoai.Location = new System.Drawing.Point(80, 278);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.PasswordChar = '\0';
            this.txtMaLoai.PlaceholderText = "Mã Loại";
            this.txtMaLoai.SelectedText = "";
            this.txtMaLoai.ShadowDecoration.Parent = this.txtMaLoai;
            this.txtMaLoai.Size = new System.Drawing.Size(127, 31);
            this.txtMaLoai.TabIndex = 80;
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
            this.btn_Sua.Location = new System.Drawing.Point(211, 322);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua.OnHoverImage = null;
            this.btn_Sua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua.Radius = 10;
            this.btn_Sua.Size = new System.Drawing.Size(181, 64);
            this.btn_Sua.TabIndex = 77;
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
            this.btn_Save.Location = new System.Drawing.Point(211, 406);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save.OnHoverImage = null;
            this.btn_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save.Radius = 10;
            this.btn_Save.Size = new System.Drawing.Size(181, 69);
            this.btn_Save.TabIndex = 75;
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
            this.btn_Them.Location = new System.Drawing.Point(12, 322);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Radius = 10;
            this.btn_Them.Size = new System.Drawing.Size(195, 64);
            this.btn_Them.TabIndex = 74;
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
            this.btn_Xoa.Location = new System.Drawing.Point(11, 406);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa.OnHoverImage = null;
            this.btn_Xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa.Radius = 10;
            this.btn_Xoa.Size = new System.Drawing.Size(195, 69);
            this.btn_Xoa.TabIndex = 76;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 10;
            this.gunaElipse5.TargetControl = this;
            // 
            // loadLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loadLoaiSP";
            this.Text = "loadLoaiSP";
            this.Load += new System.EventHandler(this.loadLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaCirclePictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoai;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoai;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Save;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Them;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Xoa;
        public Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
    }
}