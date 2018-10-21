namespace QLKSdemo1
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.TaiKhoanBox = new MetroFramework.Controls.MetroTextBox();
            this.MatKhauBox = new MetroFramework.Controls.MetroTextBox();
            this.NutLogin = new MetroFramework.Controls.MetroButton();
            this.Help = new MetroFramework.Controls.MetroButton();
            this.PasswordNhan = new MetroFramework.Controls.MetroLabel();
            this.IDnhan = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // TaiKhoanBox
            // 
            this.TaiKhoanBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            // 
            // 
            // 
            this.TaiKhoanBox.CustomButton.Image = null;
            this.TaiKhoanBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.TaiKhoanBox.CustomButton.Name = "";
            this.TaiKhoanBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TaiKhoanBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TaiKhoanBox.CustomButton.TabIndex = 1;
            this.TaiKhoanBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TaiKhoanBox.CustomButton.UseSelectable = true;
            this.TaiKhoanBox.CustomButton.Visible = false;
            this.TaiKhoanBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TaiKhoanBox.Lines = new string[0];
            this.TaiKhoanBox.Location = new System.Drawing.Point(155, 170);
            this.TaiKhoanBox.MaxLength = 32767;
            this.TaiKhoanBox.Name = "TaiKhoanBox";
            this.TaiKhoanBox.PasswordChar = '\0';
            this.TaiKhoanBox.PromptText = "Tài khoản";
            this.TaiKhoanBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TaiKhoanBox.SelectedText = "";
            this.TaiKhoanBox.SelectionLength = 0;
            this.TaiKhoanBox.SelectionStart = 0;
            this.TaiKhoanBox.ShortcutsEnabled = true;
            this.TaiKhoanBox.Size = new System.Drawing.Size(204, 29);
            this.TaiKhoanBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.TaiKhoanBox.TabIndex = 1;
            this.TaiKhoanBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TaiKhoanBox.UseSelectable = true;
            this.TaiKhoanBox.UseStyleColors = true;
            this.TaiKhoanBox.WaterMark = "Tài khoản";
            this.TaiKhoanBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TaiKhoanBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TaiKhoanBox.Click += new System.EventHandler(this.TaiKhoanBox_Click);
            // 
            // MatKhauBox
            // 
            // 
            // 
            // 
            this.MatKhauBox.CustomButton.Image = null;
            this.MatKhauBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.MatKhauBox.CustomButton.Name = "";
            this.MatKhauBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.MatKhauBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MatKhauBox.CustomButton.TabIndex = 1;
            this.MatKhauBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MatKhauBox.CustomButton.UseSelectable = true;
            this.MatKhauBox.CustomButton.Visible = false;
            this.MatKhauBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MatKhauBox.Icon = ((System.Drawing.Image)(resources.GetObject("MatKhauBox.Icon")));
            this.MatKhauBox.Lines = new string[0];
            this.MatKhauBox.Location = new System.Drawing.Point(155, 233);
            this.MatKhauBox.MaxLength = 32767;
            this.MatKhauBox.Name = "MatKhauBox";
            this.MatKhauBox.PasswordChar = '*';
            this.MatKhauBox.PromptText = "Mật khẩu";
            this.MatKhauBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MatKhauBox.SelectedText = "";
            this.MatKhauBox.SelectionLength = 0;
            this.MatKhauBox.SelectionStart = 0;
            this.MatKhauBox.ShortcutsEnabled = true;
            this.MatKhauBox.Size = new System.Drawing.Size(204, 29);
            this.MatKhauBox.TabIndex = 3;
            this.MatKhauBox.UseSelectable = true;
            this.MatKhauBox.UseStyleColors = true;
            this.MatKhauBox.WaterMark = "Mật khẩu";
            this.MatKhauBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MatKhauBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MatKhauBox.Click += new System.EventHandler(this.MatKhauBox_Click);
            // 
            // NutLogin
            // 
            this.NutLogin.DisplayFocus = true;
            this.NutLogin.Location = new System.Drawing.Point(155, 294);
            this.NutLogin.Name = "NutLogin";
            this.NutLogin.Size = new System.Drawing.Size(203, 30);
            this.NutLogin.Style = MetroFramework.MetroColorStyle.Green;
            this.NutLogin.TabIndex = 7;
            this.NutLogin.Text = "Đăng nhập";
            this.NutLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NutLogin.UseCustomForeColor = true;
            this.NutLogin.UseSelectable = true;
            this.NutLogin.UseStyleColors = true;
            this.NutLogin.Click += new System.EventHandler(this.NutLogin_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(5, 348);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(26, 25);
            this.Help.TabIndex = 8;
            this.Help.Text = "?";
            this.Help.UseSelectable = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // PasswordNhan
            // 
            this.PasswordNhan.AutoSize = true;
            this.PasswordNhan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PasswordNhan.Location = new System.Drawing.Point(155, 211);
            this.PasswordNhan.Name = "PasswordNhan";
            this.PasswordNhan.Size = new System.Drawing.Size(68, 19);
            this.PasswordNhan.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordNhan.TabIndex = 10;
            this.PasswordNhan.Text = "Mật khẩu";
            this.PasswordNhan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordNhan.Visible = false;
            // 
            // IDnhan
            // 
            this.IDnhan.AutoSize = true;
            this.IDnhan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.IDnhan.ForeColor = System.Drawing.Color.Black;
            this.IDnhan.Location = new System.Drawing.Point(155, 148);
            this.IDnhan.Name = "IDnhan";
            this.IDnhan.Size = new System.Drawing.Size(68, 19);
            this.IDnhan.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDnhan.TabIndex = 11;
            this.IDnhan.Text = "Tài khoản";
            this.IDnhan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDnhan.Visible = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 377);
            this.Controls.Add(this.IDnhan);
            this.Controls.Add(this.PasswordNhan);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.NutLogin);
            this.Controls.Add(this.MatKhauBox);
            this.Controls.Add(this.TaiKhoanBox);
            this.Name = "DangNhap";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TaiKhoanBox;
        private MetroFramework.Controls.MetroTextBox MatKhauBox;
        private MetroFramework.Controls.MetroButton NutLogin;
        private MetroFramework.Controls.MetroButton Help;
        private MetroFramework.Controls.MetroLabel PasswordNhan;
        private MetroFramework.Controls.MetroLabel IDnhan;
    }
}