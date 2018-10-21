namespace QLKSdemo1
{
    partial class MucHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MucHelp));
            this.HelpNhan = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // HelpNhan
            // 
            this.HelpNhan.AutoSize = true;
            this.HelpNhan.Location = new System.Drawing.Point(3, 4);
            this.HelpNhan.Name = "HelpNhan";
            this.HelpNhan.Size = new System.Drawing.Size(513, 247);
            this.HelpNhan.TabIndex = 0;
            this.HelpNhan.Text = resources.GetString("HelpNhan.Text");
            // 
            // MucHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.HelpNhan);
            this.Name = "MucHelp";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel HelpNhan;
    }
}