namespace inventory_managment.Stocks.Bills
{
    partial class frmShowBillInfo
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
            this.dgvSolds = new System.Windows.Forms.DataGridView();
            this.lblBills = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClientCompanyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBillTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolds
            // 
            this.dgvSolds.AllowUserToAddRows = false;
            this.dgvSolds.AllowUserToDeleteRows = false;
            this.dgvSolds.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSolds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolds.Location = new System.Drawing.Point(12, 368);
            this.dgvSolds.Name = "dgvSolds";
            this.dgvSolds.ReadOnly = true;
            this.dgvSolds.RowHeadersWidth = 51;
            this.dgvSolds.RowTemplate.Height = 24;
            this.dgvSolds.Size = new System.Drawing.Size(993, 396);
            this.dgvSolds.TabIndex = 25;
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBills.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblBills.Location = new System.Drawing.Point(408, 40);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(176, 36);
            this.lblBills.TabIndex = 27;
            this.lblBills.Text = "معلومات الفاتورة";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::inventory_managment.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(904, 768);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "    إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDValue.Location = new System.Drawing.Point(181, 126);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(60, 26);
            this.lblIDValue.TabIndex = 31;
            this.lblIDValue.Text = "؟؟؟؟";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "معرف الفاتورة :";
            // 
            // lblClientCompanyName
            // 
            this.lblClientCompanyName.AutoSize = true;
            this.lblClientCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCompanyName.Location = new System.Drawing.Point(181, 191);
            this.lblClientCompanyName.Name = "lblClientCompanyName";
            this.lblClientCompanyName.Size = new System.Drawing.Size(60, 26);
            this.lblClientCompanyName.TabIndex = 33;
            this.lblClientCompanyName.Text = "؟؟؟؟";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "اسم العميل :";
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.Location = new System.Drawing.Point(181, 250);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(60, 26);
            this.lblUserFullName.TabIndex = 35;
            this.lblUserFullName.Text = "؟؟؟؟";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "اسم المستخدم :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(748, 126);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(60, 26);
            this.lblBillDate.TabIndex = 37;
            this.lblBillDate.Text = "؟؟؟؟";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "تاريخ اصدار الفاتورة :";
            // 
            // lblBillTotalPrice
            // 
            this.lblBillTotalPrice.AutoSize = true;
            this.lblBillTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotalPrice.Location = new System.Drawing.Point(748, 191);
            this.lblBillTotalPrice.Name = "lblBillTotalPrice";
            this.lblBillTotalPrice.Size = new System.Drawing.Size(60, 26);
            this.lblBillTotalPrice.TabIndex = 39;
            this.lblBillTotalPrice.Text = "؟؟؟؟";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(548, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 38;
            this.label9.Text = "قيمة الفاتورة :";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(748, 250);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(60, 26);
            this.lblPaidAmount.TabIndex = 41;
            this.lblPaidAmount.Text = "؟؟؟؟";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(548, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 26);
            this.label11.TabIndex = 40;
            this.label11.Text = "المبلغ المدفوع :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 26);
            this.label12.TabIndex = 42;
            this.label12.Text = "الاصناف :";
            // 
            // frmShowBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 816);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPaidAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBillTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblClientCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.dgvSolds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowBillInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmShowBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolds;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClientCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBillTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}