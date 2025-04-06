namespace inventory_managment.Client.payment
{
    partial class frmListPayment
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsAddPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPayments = new System.Windows.Forms.Label();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlClientInformation1 = new inventory_managment.Client.ctrlClientInformation();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPayments.Location = new System.Drawing.Point(12, 605);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(859, 274);
            this.dgvPayments.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsAddPayment,
            this.tmsUpdate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // tmsAddPayment
            // 
            this.tmsAddPayment.Name = "tmsAddPayment";
            this.tmsAddPayment.Size = new System.Drawing.Size(210, 24);
            this.tmsAddPayment.Text = "اضافة ايصال";
            this.tmsAddPayment.Click += new System.EventHandler(this.tmsAddPayment_Click);
            // 
            // tmsUpdate
            // 
            this.tmsUpdate.Name = "tmsUpdate";
            this.tmsUpdate.Size = new System.Drawing.Size(210, 24);
            this.tmsUpdate.Text = "تعديل";
            this.tmsUpdate.Click += new System.EventHandler(this.tmsUpdate_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayments.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPayments.Location = new System.Drawing.Point(344, 28);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(166, 36);
            this.lblPayments.TabIndex = 30;
            this.lblPayments.Text = "قائمة الايصالات";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPayment.Location = new System.Drawing.Point(724, 896);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(147, 41);
            this.btnAddPayment.TabIndex = 31;
            this.btnAddPayment.Text = "اضافة ايصال";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(12, 896);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 41);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // ctrlClientInformation1
            // 
            this.ctrlClientInformation1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlClientInformation1.Location = new System.Drawing.Point(12, 84);
            this.ctrlClientInformation1.Name = "ctrlClientInformation1";
            this.ctrlClientInformation1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlClientInformation1.Size = new System.Drawing.Size(859, 515);
            this.ctrlClientInformation1.TabIndex = 0;
            // 
            // frmListPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(883, 951);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.ctrlClientInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(901, 998);
            this.Name = "frmListPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlClientInformation ctrlClientInformation1;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsAddPayment;
        private System.Windows.Forms.ToolStripMenuItem tmsUpdate;
    }
}