namespace inventory_managment.Client
{
    partial class frmListClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsShowClientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsEditClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsShowBills = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsAddPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsShowPaymentList = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.lblTotalDents = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(409, 384);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(193, 28);
            this.tbFilter.TabIndex = 19;
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
            "معرف الزبون",
            "الاسم",
            "رقم الهاتف",
            "الاسم التوضيحي",
            "اجمالي الديون"});
            this.cbFilterBy.Location = new System.Drawing.Point(183, 384);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 30);
            this.cbFilterBy.TabIndex = 18;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(160, 839);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(21, 24);
            this.lblRecordCount.TabIndex = 17;
            this.lblRecordCount.Text = "0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(17, 839);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(100, 24);
            this.lblRecord.TabIndex = 16;
            this.lblRecord.Text = "عدد العملاء :";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblUsers.Location = new System.Drawing.Point(489, 275);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(134, 36);
            this.lblUsers.TabIndex = 13;
            this.lblUsers.Text = "ادارة العملاء";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsShowClientInfo,
            this.toolStripSeparator1,
            this.tmsAddClient,
            this.tmsEditClient,
            this.tmsDeleteClient,
            this.toolStripSeparator2,
            this.tmsShowBills,
            this.toolStripSeparator3,
            this.tmsAddPayment,
            this.tmsShowPaymentList});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 316);
            // 
            // tmsShowClientInfo
            // 
            this.tmsShowClientInfo.Image = global::inventory_managment.Properties.Resources.PersonDetails_32;
            this.tmsShowClientInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsShowClientInfo.Name = "tmsShowClientInfo";
            this.tmsShowClientInfo.Size = new System.Drawing.Size(239, 38);
            this.tmsShowClientInfo.Text = "عرض معلومات العميل";
            this.tmsShowClientInfo.Click += new System.EventHandler(this.tmsShowClientInfo_Click);
            // 
            // tmsAddClient
            // 
            this.tmsAddClient.Image = global::inventory_managment.Properties.Resources.add_32;
            this.tmsAddClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsAddClient.Name = "tmsAddClient";
            this.tmsAddClient.Size = new System.Drawing.Size(239, 38);
            this.tmsAddClient.Text = "إضافة عميل";
            this.tmsAddClient.Click += new System.EventHandler(this.tmsAddClient_Click);
            // 
            // tmsEditClient
            // 
            this.tmsEditClient.Image = global::inventory_managment.Properties.Resources.edit_32;
            this.tmsEditClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsEditClient.Name = "tmsEditClient";
            this.tmsEditClient.Size = new System.Drawing.Size(239, 38);
            this.tmsEditClient.Text = "تعديل معلومات العميل";
            this.tmsEditClient.Click += new System.EventHandler(this.tmsEditClient_Click);
            // 
            // tmsDeleteClient
            // 
            this.tmsDeleteClient.Image = global::inventory_managment.Properties.Resources.Delete_32;
            this.tmsDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tmsDeleteClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsDeleteClient.Name = "tmsDeleteClient";
            this.tmsDeleteClient.Size = new System.Drawing.Size(239, 38);
            this.tmsDeleteClient.Text = "حذف";
            this.tmsDeleteClient.Click += new System.EventHandler(this.tmsDeleteClient_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(236, 6);
            // 
            // tmsShowBills
            // 
            this.tmsShowBills.Name = "tmsShowBills";
            this.tmsShowBills.Size = new System.Drawing.Size(239, 38);
            this.tmsShowBills.Text = "عرض الفواتير";
            this.tmsShowBills.Click += new System.EventHandler(this.tmsShowBills_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // tmsAddPayment
            // 
            this.tmsAddPayment.Name = "tmsAddPayment";
            this.tmsAddPayment.Size = new System.Drawing.Size(239, 38);
            this.tmsAddPayment.Text = "اضافة ايصال";
            this.tmsAddPayment.Click += new System.EventHandler(this.tmsAddPayment_Click);
            // 
            // tmsShowPaymentList
            // 
            this.tmsShowPaymentList.Name = "tmsShowPaymentList";
            this.tmsShowPaymentList.Size = new System.Drawing.Size(239, 38);
            this.tmsShowPaymentList.Text = "عرض قائمة الايصالات";
            this.tmsShowPaymentList.Click += new System.EventHandler(this.tmsShowPaymentList_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClient.Location = new System.Drawing.Point(21, 431);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(1086, 396);
            this.dgvClient.TabIndex = 11;
            // 
            // lblTotalDents
            // 
            this.lblTotalDents.AutoSize = true;
            this.lblTotalDents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDents.Location = new System.Drawing.Point(448, 839);
            this.lblTotalDents.Name = "lblTotalDents";
            this.lblTotalDents.Size = new System.Drawing.Size(21, 24);
            this.lblTotalDents.TabIndex = 23;
            this.lblTotalDents.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 839);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "اجمالي الديون :";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1006, 833);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::inventory_managment.Properties.Resources.Add_Person_40;
            this.btnAddUser.Location = new System.Drawing.Point(1022, 350);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(85, 75);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.People_512;
            this.pictureBox1.Location = new System.Drawing.Point(430, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1130, 879);
            this.Controls.Add(this.lblTotalDents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvClient);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1148, 926);
            this.MinimizeBox = false;
            this.Name = "frmListClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListClient_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tmsEditClient;
        private System.Windows.Forms.ToolStripMenuItem tmsAddClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsShowClientInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsDeleteClient;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label lblTotalDents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tmsShowBills;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tmsAddPayment;
        private System.Windows.Forms.ToolStripMenuItem tmsShowPaymentList;
    }
}