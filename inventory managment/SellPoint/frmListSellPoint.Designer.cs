namespace inventory_managment.SellPoint
{
    partial class frmListSellPoint
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSellPoints = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsShowSellPointInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsAddSellPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsShowBills = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSellPoint = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellPoints)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1346, 871);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.sellPoint512;
            this.pictureBox1.Location = new System.Drawing.Point(591, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSellPoints
            // 
            this.dgvSellPoints.AllowUserToAddRows = false;
            this.dgvSellPoints.AllowUserToDeleteRows = false;
            this.dgvSellPoints.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSellPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellPoints.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSellPoints.Location = new System.Drawing.Point(12, 457);
            this.dgvSellPoints.Name = "dgvSellPoints";
            this.dgvSellPoints.ReadOnly = true;
            this.dgvSellPoints.RowHeadersWidth = 51;
            this.dgvSellPoints.RowTemplate.Height = 24;
            this.dgvSellPoints.Size = new System.Drawing.Size(1435, 396);
            this.dgvSellPoints.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsShowSellPointInfo,
            this.tmsAddSellPoint,
            this.tmsShowBills});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(261, 146);
            // 
            // tmsShowSellPointInfo
            // 
            this.tmsShowSellPointInfo.Image = global::inventory_managment.Properties.Resources.PersonDetails_32;
            this.tmsShowSellPointInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsShowSellPointInfo.Name = "tmsShowSellPointInfo";
            this.tmsShowSellPointInfo.Size = new System.Drawing.Size(260, 38);
            this.tmsShowSellPointInfo.Text = "عرض معلومات نقطة البيع";
            this.tmsShowSellPointInfo.Click += new System.EventHandler(this.tmsShowSellPointInfo_Click);
            // 
            // tmsAddSellPoint
            // 
            this.tmsAddSellPoint.Image = global::inventory_managment.Properties.Resources.sellPoint32;
            this.tmsAddSellPoint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsAddSellPoint.Name = "tmsAddSellPoint";
            this.tmsAddSellPoint.Size = new System.Drawing.Size(260, 38);
            this.tmsAddSellPoint.Text = "بدء نقطة بيع";
            this.tmsAddSellPoint.Click += new System.EventHandler(this.tmsAddSellPoint_Click);
            // 
            // tmsShowBills
            // 
            this.tmsShowBills.Image = global::inventory_managment.Properties.Resources.PassedTests_32;
            this.tmsShowBills.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsShowBills.Name = "tmsShowBills";
            this.tmsShowBills.Size = new System.Drawing.Size(260, 38);
            this.tmsShowBills.Text = "عرض الفواتير";
            this.tmsShowBills.Click += new System.EventHandler(this.tmsShowBills_Click);
            // 
            // btnAddSellPoint
            // 
            this.btnAddSellPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSellPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSellPoint.Image = global::inventory_managment.Properties.Resources.sellPoint32;
            this.btnAddSellPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSellPoint.Location = new System.Drawing.Point(1228, 365);
            this.btnAddSellPoint.Name = "btnAddSellPoint";
            this.btnAddSellPoint.Size = new System.Drawing.Size(219, 75);
            this.btnAddSellPoint.TabIndex = 27;
            this.btnAddSellPoint.Text = "بدأ نقطة بيع";
            this.btnAddSellPoint.UseVisualStyleBackColor = true;
            this.btnAddSellPoint.Click += new System.EventHandler(this.btnAddSellPoint_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(400, 410);
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
            "معرف النقطة",
            "معرف المستخدم",
            "الاسم",
            "المبلغ الاجمالي",
            "اجمالي عدد الفواتير"});
            this.cbFilterBy.Location = new System.Drawing.Point(174, 410);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 30);
            this.cbFilterBy.TabIndex = 31;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(179, 871);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(21, 24);
            this.lblRecordCount.TabIndex = 30;
            this.lblRecordCount.Text = "0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(25, 871);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(120, 24);
            this.lblRecord.TabIndex = 29;
            this.lblRecord.Text = "عدد نقاط البيع :";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblUsers.Location = new System.Drawing.Point(673, 298);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(102, 36);
            this.lblUsers.TabIndex = 26;
            this.lblUsers.Text = "نقاط البيع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // frmListSellPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1459, 913);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSellPoints);
            this.Controls.Add(this.btnAddSellPoint);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1477, 960);
            this.Name = "frmListSellPoint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListSellPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellPoints)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSellPoints;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsShowSellPointInfo;
        private System.Windows.Forms.ToolStripMenuItem tmsAddSellPoint;
        private System.Windows.Forms.ToolStripMenuItem tmsShowBills;
        private System.Windows.Forms.Button btnAddSellPoint;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label label1;
    }
}