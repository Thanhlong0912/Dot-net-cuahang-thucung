namespace Demo
{
    partial class fMainPN
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
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(-2, 94);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1352, 662);
            this.gunaPanel2.TabIndex = 4;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.guna2Button1);
            this.gunaPanel1.Controls.Add(this.guna2Button7);
            this.gunaPanel1.Location = new System.Drawing.Point(-2, -1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1355, 100);
            this.gunaPanel1.TabIndex = 3;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button1.CheckedState.Image = global::Demo.Properties.Resources.click___collect_64px;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Demo.Properties.Resources.click___collect_50px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Location = new System.Drawing.Point(776, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(304, 60);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Chi Tiết Phiếu Nhập";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 22;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.Checked = true;
            this.guna2Button7.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button7.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button7.CheckedState.Image = global::Demo.Properties.Resources.totoro_100px;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.MistyRose;
            this.guna2Button7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Image = global::Demo.Properties.Resources.tomini;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button7.Location = new System.Drawing.Point(351, 13);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(304, 60);
            this.guna2Button7.TabIndex = 21;
            this.guna2Button7.Text = "Phiếu Nhập";
            this.guna2Button7.UseTransparentBackground = true;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // fMainPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 754);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMainPN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "fMainPN";
            this.Load += new System.EventHandler(this.fMainPN_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}