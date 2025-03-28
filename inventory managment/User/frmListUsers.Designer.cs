namespace inventory_managment.User
{
    partial class frmListUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterByrole = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsShowUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Location = new System.Drawing.Point(12, 422);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1086, 396);
            this.dgvUsers.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(421, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblUsers.Location = new System.Drawing.Point(456, 268);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(176, 36);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "ادارة المستخدمين";
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::inventory_managment.Properties.Resources.Add_New_User_72;
            this.btnAddUser.Location = new System.Drawing.Point(1008, 336);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 80);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(997, 824);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(8, 830);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(137, 24);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "عدد المستخدمين : ";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(151, 830);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(43, 24);
            this.lblRecordCount.TabIndex = 6;
            this.lblRecordCount.Text = "???";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "عرض الكل",
            "معرف المستخدم",
            "اسم المستخدم",
            "الاسم",
            "الرقم",
            "الوطيفة"});
            this.cbFilterBy.Location = new System.Drawing.Point(168, 380);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 24);
            this.cbFilterBy.TabIndex = 7;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(378, 382);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(193, 22);
            this.tbFilter.TabIndex = 8;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // cbFilterByrole
            // 
            this.cbFilterByrole.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterByrole.FormattingEnabled = true;
            this.cbFilterByrole.Items.AddRange(new object[] {
            "مدير النظام",
            "مسؤول المخزون",
            "أمين الصندوق",
            "موقف"});
            this.cbFilterByrole.Location = new System.Drawing.Point(378, 380);
            this.cbFilterByrole.Name = "cbFilterByrole";
            this.cbFilterByrole.Size = new System.Drawing.Size(126, 24);
            this.cbFilterByrole.TabIndex = 10;
            this.cbFilterByrole.SelectedIndexChanged += new System.EventHandler(this.cbFilterByrole_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsShowUserInfo,
            this.toolStripSeparator1,
            this.tmsAddUser,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(260, 124);
            // 
            // tmsShowUserInfo
            // 
            this.tmsShowUserInfo.Image = global::inventory_managment.Properties.Resources.PersonDetails_32;
            this.tmsShowUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsShowUserInfo.Name = "tmsShowUserInfo";
            this.tmsShowUserInfo.Size = new System.Drawing.Size(259, 38);
            this.tmsShowUserInfo.Text = "عرض معلومات المستخدم";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // tmsAddUser
            // 
            this.tmsAddUser.Image = global::inventory_managment.Properties.Resources.Add_New_User_32;
            this.tmsAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsAddUser.Name = "tmsAddUser";
            this.tmsAddUser.Size = new System.Drawing.Size(259, 38);
            this.tmsAddUser.Text = "إضافة مستخدم";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::inventory_managment.Properties.Resources.edit_32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(259, 38);
            this.toolStripMenuItem1.Text = "تعديل معلومات المستخدم";
            // 
            // frmListUsers
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1110, 885);
            this.Controls.Add(this.cbFilterByrole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "المستخدمون";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterByrole;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsShowUserInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsAddUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}