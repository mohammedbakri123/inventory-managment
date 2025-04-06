namespace inventory_managment.User
{
    partial class frmShowUserinfo
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
            this.lblUserzinfo = new System.Windows.Forms.Label();
            this.ctrlShowUserInfo1 = new inventory_managment.User.Controls.ctrlShowUserInfo();
            this.SuspendLayout();
            // 
            // lblUserzinfo
            // 
            this.lblUserzinfo.AutoSize = true;
            this.lblUserzinfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserzinfo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblUserzinfo.Location = new System.Drawing.Point(355, 35);
            this.lblUserzinfo.Name = "lblUserzinfo";
            this.lblUserzinfo.Size = new System.Drawing.Size(179, 38);
            this.lblUserzinfo.TabIndex = 0;
            this.lblUserzinfo.Text = "بيانات المستخدم";
            // 
            // ctrlShowUserInfo1
            // 
            this.ctrlShowUserInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlShowUserInfo1.Location = new System.Drawing.Point(12, 87);
            this.ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            this.ctrlShowUserInfo1.Size = new System.Drawing.Size(865, 451);
            this.ctrlShowUserInfo1.TabIndex = 1;
            // 
            // frmShowUserinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(889, 535);
            this.Controls.Add(this.ctrlShowUserInfo1);
            this.Controls.Add(this.lblUserzinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowUserinfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بيانات المستخدم";
            this.Load += new System.EventHandler(this.frmShowUserinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserzinfo;
        private Controls.ctrlShowUserInfo ctrlShowUserInfo1;
    }
}