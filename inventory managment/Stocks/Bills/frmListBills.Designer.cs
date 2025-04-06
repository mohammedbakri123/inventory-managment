namespace inventory_managment.Stocks.Bills
{
    partial class frmListBills
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
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblBills = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmsShowBillInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsEditBill = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsDeleteBill = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.AllowUserToDeleteRows = false;
            this.dgvBills.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBills.Location = new System.Drawing.Point(12, 444);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.Size = new System.Drawing.Size(1232, 396);
            this.dgvBills.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsShowBillInfo,
            this.toolStripSeparator1,
            this.tmsEditBill,
            this.tmsDeleteBill});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 152);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(410, 401);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(193, 28);
            this.tbFilter.TabIndex = 32;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "عرض الكل",
            "معرف الفاتورة",
            "قيمة الفاتورة",
            "معرف العميل",
            "اسم العميل",
            "نقطة البيع",
            "معرف المستخدم",
            "اسم المستخدم"});
            this.cbFilterBy.Location = new System.Drawing.Point(169, 398);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 30);
            this.cbFilterBy.TabIndex = 31;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(165, 852);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(21, 24);
            this.lblRecordCount.TabIndex = 30;
            this.lblRecordCount.Text = "0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(22, 852);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(105, 24);
            this.lblRecord.TabIndex = 29;
            this.lblRecord.Text = "عدد الفواتير :";
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBills.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblBills.Location = new System.Drawing.Point(584, 282);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(83, 36);
            this.lblBills.TabIndex = 26;
            this.lblBills.Text = "الفواتير";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1143, 846);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(500, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // tmsShowBillInfo
            // 
            this.tmsShowBillInfo.Image = global::inventory_managment.Properties.Resources.PersonDetails_32;
            this.tmsShowBillInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsShowBillInfo.Name = "tmsShowBillInfo";
            this.tmsShowBillInfo.Size = new System.Drawing.Size(244, 38);
            this.tmsShowBillInfo.Text = "عرض معلومات الفاتورة";
            this.tmsShowBillInfo.Click += new System.EventHandler(this.tmsShowBillInfo_Click);
            // 
            // tmsEditBill
            // 
            this.tmsEditBill.Image = global::inventory_managment.Properties.Resources.edit_32;
            this.tmsEditBill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsEditBill.Name = "tmsEditBill";
            this.tmsEditBill.Size = new System.Drawing.Size(244, 38);
            this.tmsEditBill.Text = "تعديل معلومات الفاتورة";
            // 
            // tmsDeleteBill
            // 
            this.tmsDeleteBill.Image = global::inventory_managment.Properties.Resources.Delete_32;
            this.tmsDeleteBill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tmsDeleteBill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsDeleteBill.Name = "tmsDeleteBill";
            this.tmsDeleteBill.Size = new System.Drawing.Size(244, 38);
            this.tmsDeleteBill.Text = "حذف الفاتورة";
            // 
            // frmListBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1256, 889);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1274, 936);
            this.Name = "frmListBills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tmsDeleteBill;
        private System.Windows.Forms.ToolStripMenuItem tmsShowBillInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsEditBill;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Label label1;
    }
}