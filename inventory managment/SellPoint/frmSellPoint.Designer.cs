namespace inventory_managment.SellPoint
{
    partial class frmSellPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellPoint));
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.dgvCurrentSolds = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsEditQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.Addbill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSellPoint = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblPiecesCount = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lbltotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeClient = new System.Windows.Forms.Button();
            this.btnPublicClientBack = new System.Windows.Forms.Button();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.btnCalculateTotalAmount = new System.Windows.Forms.Button();
            this.btnClearSolds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentSolds)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // dgvCurrentSolds
            // 
            this.dgvCurrentSolds.AllowUserToAddRows = false;
            this.dgvCurrentSolds.AllowUserToDeleteRows = false;
            this.dgvCurrentSolds.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCurrentSolds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentSolds.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgvCurrentSolds, "dgvCurrentSolds");
            this.dgvCurrentSolds.Name = "dgvCurrentSolds";
            this.dgvCurrentSolds.ReadOnly = true;
            this.dgvCurrentSolds.RowTemplate.Height = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsEditQuantity,
            this.tmsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tmsEditQuantity
            // 
            this.tmsEditQuantity.Image = global::inventory_managment.Properties.Resources.edit_321;
            resources.ApplyResources(this.tmsEditQuantity, "tmsEditQuantity");
            this.tmsEditQuantity.Name = "tmsEditQuantity";
            this.tmsEditQuantity.Click += new System.EventHandler(this.tmsEditQuantity_Click);
            // 
            // tmsDelete
            // 
            this.tmsDelete.Image = global::inventory_managment.Properties.Resources.DeleteProduct32;
            resources.ApplyResources(this.tmsDelete, "tmsDelete");
            this.tmsDelete.Name = "tmsDelete";
            this.tmsDelete.Click += new System.EventHandler(this.tmsDelete_Click);
            // 
            // Addbill
            // 
            this.Addbill.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.Addbill, "Addbill");
            this.Addbill.Name = "Addbill";
            this.Addbill.UseVisualStyleBackColor = false;
            this.Addbill.Click += new System.EventHandler(this.Addbill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.sellPoint512;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblSellPoint
            // 
            resources.ApplyResources(this.lblSellPoint, "lblSellPoint");
            this.lblSellPoint.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSellPoint.Name = "lblSellPoint";
            // 
            // lblRecord
            // 
            resources.ApplyResources(this.lblRecord, "lblRecord");
            this.lblRecord.Name = "lblRecord";
            // 
            // lblPiecesCount
            // 
            resources.ApplyResources(this.lblPiecesCount, "lblPiecesCount");
            this.lblPiecesCount.Name = "lblPiecesCount";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.cbFilterBy, "cbFilterBy");
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            resources.GetString("cbFilterBy.Items"),
            resources.GetString("cbFilterBy.Items1")});
            this.cbFilterBy.Name = "cbFilterBy";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvSearch, "dgvSearch");
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.DoubleClick += new System.EventHandler(this.dgvSearch_DoubleClick);
            // 
            // lbltotalCount
            // 
            resources.ApplyResources(this.lbltotalCount, "lbltotalCount");
            this.lbltotalCount.Name = "lbltotalCount";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblBillID
            // 
            resources.ApplyResources(this.lblBillID, "lblBillID");
            this.lblBillID.Name = "lblBillID";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblClientName
            // 
            resources.ApplyResources(this.lblClientName, "lblClientName");
            this.lblClientName.Name = "lblClientName";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbltotalCount);
            this.groupBox1.Controls.Add(this.lblClientName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblBillID);
            this.groupBox1.Controls.Add(this.lblPiecesCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRecord);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnChangeClient
            // 
            this.btnChangeClient.BackColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.btnChangeClient, "btnChangeClient");
            this.btnChangeClient.Name = "btnChangeClient";
            this.btnChangeClient.UseVisualStyleBackColor = false;
            this.btnChangeClient.Click += new System.EventHandler(this.btnChangeClient_Click);
            // 
            // btnPublicClientBack
            // 
            this.btnPublicClientBack.BackColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.btnPublicClientBack, "btnPublicClientBack");
            this.btnPublicClientBack.Name = "btnPublicClientBack";
            this.btnPublicClientBack.UseVisualStyleBackColor = false;
            this.btnPublicClientBack.Click += new System.EventHandler(this.btnPublicClientBack_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.btnNewBill, "btnNewBill");
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.UseVisualStyleBackColor = false;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // btnCalculateTotalAmount
            // 
            this.btnCalculateTotalAmount.BackColor = System.Drawing.Color.Tan;
            resources.ApplyResources(this.btnCalculateTotalAmount, "btnCalculateTotalAmount");
            this.btnCalculateTotalAmount.Name = "btnCalculateTotalAmount";
            this.btnCalculateTotalAmount.UseVisualStyleBackColor = false;
            this.btnCalculateTotalAmount.Click += new System.EventHandler(this.btnCalculateTotalAmount_Click);
            // 
            // btnClearSolds
            // 
            this.btnClearSolds.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.btnClearSolds, "btnClearSolds");
            this.btnClearSolds.Name = "btnClearSolds";
            this.btnClearSolds.UseVisualStyleBackColor = false;
            this.btnClearSolds.Click += new System.EventHandler(this.btnClearSolds_Click);
            // 
            // frmSellPoint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.btnClearSolds);
            this.Controls.Add(this.btnCalculateTotalAmount);
            this.Controls.Add(this.btnNewBill);
            this.Controls.Add(this.btnPublicClientBack);
            this.Controls.Add(this.btnChangeClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblSellPoint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Addbill);
            this.Controls.Add(this.dgvCurrentSolds);
            this.Controls.Add(this.tbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSellPoint";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSellPoint_FormClosing);
            this.Load += new System.EventHandler(this.frmSellPoint_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSellPoint_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentSolds)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.DataGridView dgvCurrentSolds;
        private System.Windows.Forms.Button Addbill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSellPoint;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblPiecesCount;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lbltotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeClient;
        private System.Windows.Forms.Button btnPublicClientBack;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.Button btnCalculateTotalAmount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsEditQuantity;
        private System.Windows.Forms.ToolStripMenuItem tmsDelete;
        private System.Windows.Forms.Button btnClearSolds;
    }
}