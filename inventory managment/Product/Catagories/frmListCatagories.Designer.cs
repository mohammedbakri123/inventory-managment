namespace inventory_managment.Product.Catagories
{
    partial class frmListCatagories
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
            this.dgvCatagories = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagories)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatagories
            // 
            this.dgvCatagories.AllowUserToAddRows = false;
            this.dgvCatagories.AllowUserToDeleteRows = false;
            this.dgvCatagories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCatagories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatagories.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCatagories.Location = new System.Drawing.Point(5, 204);
            this.dgvCatagories.Name = "dgvCatagories";
            this.dgvCatagories.ReadOnly = true;
            this.dgvCatagories.RowHeadersWidth = 51;
            this.dgvCatagories.RowTemplate.Height = 24;
            this.dgvCatagories.Size = new System.Drawing.Size(490, 272);
            this.dgvCatagories.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.toolStripSeparator1,
            this.tmsUpdate,
            this.tmsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 124);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::inventory_managment.Properties.Resources.AddCategory_32;
            this.tsmAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(182, 38);
            this.tsmAdd.Text = "اضافة تصنيف";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // tmsUpdate
            // 
            this.tmsUpdate.Image = global::inventory_managment.Properties.Resources.edit_321;
            this.tmsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsUpdate.Name = "tmsUpdate";
            this.tmsUpdate.Size = new System.Drawing.Size(182, 38);
            this.tmsUpdate.Text = "تعديل";
            this.tmsUpdate.Click += new System.EventHandler(this.tmsUpdate_Click);
            // 
            // tmsDelete
            // 
            this.tmsDelete.Image = global::inventory_managment.Properties.Resources.Delete_321;
            this.tmsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsDelete.Name = "tmsDelete";
            this.tmsDelete.Size = new System.Drawing.Size(182, 38);
            this.tmsDelete.Text = "حذف";
            this.tmsDelete.Click += new System.EventHandler(this.tmsDelete_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(158, 513);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(35, 18);
            this.lblRecordCount.TabIndex = 19;
            this.lblRecordCount.Text = "???";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(12, 513);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(134, 18);
            this.lblRecord.TabIndex = 18;
            this.lblRecord.Text = "اجمالي عدد  الانواع :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(405, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 33);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::inventory_managment.Properties.Resources.AddCategory_32;
            this.btnAdd.Location = new System.Drawing.Point(442, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 53);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.category_512;
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmListCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(507, 555);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCatagories);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListCatagories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الانواع";
            this.Load += new System.EventHandler(this.frmListCatagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagories)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCatagories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tmsDelete;
    }
}