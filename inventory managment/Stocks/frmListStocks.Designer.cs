namespace inventory_managment.Stocks
{
    partial class frmListStocks
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkShowDone = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::inventory_managment.Properties.Resources.add_64;
            this.btnAdd.Location = new System.Drawing.Point(1481, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 79);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvStocks.Location = new System.Drawing.Point(12, 491);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersWidth = 51;
            this.dgvStocks.RowTemplate.Height = 24;
            this.dgvStocks.Size = new System.Drawing.Size(1558, 396);
            this.dgvStocks.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsAddProduct,
            this.tmsUpdate,
            this.tmsDelete,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 190);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tmsAddProduct
            // 
            this.tmsAddProduct.Image = global::inventory_managment.Properties.Resources.add_32;
            this.tmsAddProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsAddProduct.Name = "tmsAddProduct";
            this.tmsAddProduct.Size = new System.Drawing.Size(236, 38);
            this.tmsAddProduct.Text = "إضافة كمية";
            this.tmsAddProduct.Click += new System.EventHandler(this.tmsAddProduct_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 38);
            this.toolStripMenuItem1.Text = "تعيين تالف";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(396, 438);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(232, 36);
            this.tbFilter.TabIndex = 31;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "عرض الكل",
            "معرف الكمية",
            "المنتج",
            "الرقم العالمي",
            "سعر الشراء للحبة",
            "سعر البيع للحبة",
            "عدد الكمية عند دخولها",
            "العدد الحالي للكمية"});
            this.cbFilterBy.Location = new System.Drawing.Point(168, 437);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 37);
            this.cbFilterBy.TabIndex = 30;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            this.cbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFilterBy_KeyPress);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(248, 906);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(43, 24);
            this.lblRecordCount.TabIndex = 29;
            this.lblRecordCount.Text = "???";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(12, 906);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(194, 24);
            this.lblRecord.TabIndex = 28;
            this.lblRecord.Text = "اجمالي الكمية في المخزن :";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblProducts.Location = new System.Drawing.Point(637, 319);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(252, 36);
            this.lblProducts.TabIndex = 25;
            this.lblProducts.Text = "ادارة الكميات في المخزن";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.inventory_512;
            this.pictureBox1.Location = new System.Drawing.Point(627, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.Location = new System.Drawing.Point(665, 906);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(43, 24);
            this.lblCostPrice.TabIndex = 34;
            this.lblCostPrice.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 906);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "القيمة الإجمالية للشراء :";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.Location = new System.Drawing.Point(1102, 906);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(43, 24);
            this.lblSellPrice.TabIndex = 36;
            this.lblSellPrice.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(891, 906);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "القيمة الأجمالية للبيع :";
            // 
            // checkShowDone
            // 
            this.checkShowDone.AutoSize = true;
            this.checkShowDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowDone.Location = new System.Drawing.Point(16, 391);
            this.checkShowDone.Name = "checkShowDone";
            this.checkShowDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkShowDone.Size = new System.Drawing.Size(256, 28);
            this.checkShowDone.TabIndex = 37;
            this.checkShowDone.Text = "عرض الكميات  التي قد تم نفاذها";
            this.checkShowDone.UseVisualStyleBackColor = true;
            this.checkShowDone.CheckedChanged += new System.EventHandler(this.checkShowDone_CheckedChanged);
            // 
            // frmListStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.checkShowDone);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStocks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "frmListStocks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListStocks_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmListStocks_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tmsDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkShowDone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}