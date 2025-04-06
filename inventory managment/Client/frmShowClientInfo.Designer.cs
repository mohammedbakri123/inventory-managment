namespace inventory_managment.Client
{
    partial class frmShowClientInfo
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
            this.ctrlClientInformation1 = new inventory_managment.Client.ctrlClientInformation();
            this.lblCkientinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlClientInformation1
            // 
            this.ctrlClientInformation1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlClientInformation1.Location = new System.Drawing.Point(12, 55);
            this.ctrlClientInformation1.Name = "ctrlClientInformation1";
            this.ctrlClientInformation1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlClientInformation1.Size = new System.Drawing.Size(859, 515);
            this.ctrlClientInformation1.TabIndex = 0;
            // 
            // lblCkientinfo
            // 
            this.lblCkientinfo.AutoSize = true;
            this.lblCkientinfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCkientinfo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblCkientinfo.Location = new System.Drawing.Point(359, 14);
            this.lblCkientinfo.Name = "lblCkientinfo";
            this.lblCkientinfo.Size = new System.Drawing.Size(152, 38);
            this.lblCkientinfo.TabIndex = 1;
            this.lblCkientinfo.Text = "بيانات العميل";
            // 
            // frmShowClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 573);
            this.Controls.Add(this.lblCkientinfo);
            this.Controls.Add(this.ctrlClientInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowClientInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmShowClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlClientInformation ctrlClientInformation1;
        private System.Windows.Forms.Label lblCkientinfo;
    }
}