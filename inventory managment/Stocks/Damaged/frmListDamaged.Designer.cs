namespace inventory_managment.Damaged
{
    partial class frmListDamaged
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
            this.tmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDamaged = new System.Windows.Forms.DataGridView();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamaged)).BeginInit();
            this.SuspendLayout();
            // 
            // tmsDelete
            // 
            this.tmsDelete.Image = global::inventory_managment.Properties.Resources.Delete_321;
            this.tmsDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tmsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsDelete.Name = "tmsDelete";
            this.tmsDelete.Size = new System.Drawing.Size(236, 38);
            this.tmsDelete.Text = "حذف";
            this.tmsDelete.Click += new System.EventHandler(this.tmsDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1456, 896);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 45);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(393, 411);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(232, 36);
            this.tbFilter.TabIndex = 46;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(150, 906);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(43, 24);
            this.lblRecordCount.TabIndex = 44;
            this.lblRecordCount.Text = "???";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(25, 906);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(108, 24);
            this.lblRecord.TabIndex = 43;
            this.lblRecord.Text = "الكمية التالفة :";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblProducts.Location = new System.Drawing.Point(691, 289);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(136, 36);
            this.lblProducts.TabIndex = 40;
            this.lblProducts.Text = "ادراة التوالف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.inventory_512;
            this.pictureBox1.Location = new System.Drawing.Point(627, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsUpdate,
            this.tmsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 108);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tmsUpdate
            // 
            this.tmsUpdate.Image = global::inventory_managment.Properties.Resources.edit_321;
            this.tmsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsUpdate.Name = "tmsUpdate";
            this.tmsUpdate.Size = new System.Drawing.Size(236, 38);
            this.tmsUpdate.Text = "تعديل معلومات الكمية";
            this.tmsUpdate.Click += new System.EventHandler(this.tmsUpdate_Click);
            // 
            // dgvDamaged
            // 
            this.dgvDamaged.AllowUserToAddRows = false;
            this.dgvDamaged.AllowUserToDeleteRows = false;
            this.dgvDamaged.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDamaged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamaged.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDamaged.Location = new System.Drawing.Point(12, 460);
            this.dgvDamaged.Name = "dgvDamaged";
            this.dgvDamaged.ReadOnly = true;
            this.dgvDamaged.RowHeadersWidth = 51;
            this.dgvDamaged.RowTemplate.Height = 24;
            this.dgvDamaged.Size = new System.Drawing.Size(1558, 430);
            this.dgvDamaged.TabIndex = 38;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "عرض الكل",
            "معرف التالف",
            "المنتج",
            "الرقم العالمي",
            "اسباب التلف",
            "الكمية التالفة",
            "معرف الكمية"});
            this.cbFilterBy.Location = new System.Drawing.Point(165, 410);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 37);
            this.cbFilterBy.TabIndex = 45;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            this.cbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFilterBy_KeyPress);
            // 
            // frmListDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDamaged);
            this.Controls.Add(this.cbFilterBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "frmListDamaged";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListDamaged_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamaged)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tmsDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsUpdate;
        private System.Windows.Forms.DataGridView dgvDamaged;
        private System.Windows.Forms.ComboBox cbFilterBy;
    }
}