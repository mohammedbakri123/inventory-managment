namespace inventory_managment.Damaged
{
    partial class frmAddEditDamaged
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCLose2 = new System.Windows.Forms.Button();
            this.lblDamagedID = new System.Windows.Forms.Label();
            this.lblStockID = new System.Windows.Forms.Label();
            this.lblAddEdit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDamagedIDValue = new System.Windows.Forms.Label();
            this.lblStockIDValue = new System.Windows.Forms.Label();
            this.dtpDamagedDate = new System.Windows.Forms.DateTimePicker();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.rtbResons = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductIDValue = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(17, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCLose2
            // 
            this.btnCLose2.BackColor = System.Drawing.Color.Crimson;
            this.btnCLose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLose2.Location = new System.Drawing.Point(780, 472);
            this.btnCLose2.Name = "btnCLose2";
            this.btnCLose2.Size = new System.Drawing.Size(99, 34);
            this.btnCLose2.TabIndex = 30;
            this.btnCLose2.Text = "اغلاق";
            this.btnCLose2.UseVisualStyleBackColor = false;
            this.btnCLose2.Click += new System.EventHandler(this.btnCLose2_Click);
            // 
            // lblDamagedID
            // 
            this.lblDamagedID.AutoSize = true;
            this.lblDamagedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamagedID.Location = new System.Drawing.Point(12, 128);
            this.lblDamagedID.Name = "lblDamagedID";
            this.lblDamagedID.Size = new System.Drawing.Size(118, 26);
            this.lblDamagedID.TabIndex = 32;
            this.lblDamagedID.Text = "معرف التالف :";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(456, 128);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(117, 26);
            this.lblStockID.TabIndex = 33;
            this.lblStockID.Text = "معرف الكمية :";
            // 
            // lblAddEdit
            // 
            this.lblAddEdit.AutoSize = true;
            this.lblAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEdit.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAddEdit.Location = new System.Drawing.Point(351, 31);
            this.lblAddEdit.Name = "lblAddEdit";
            this.lblAddEdit.Size = new System.Drawing.Size(187, 29);
            this.lblAddEdit.TabIndex = 34;
            this.lblAddEdit.Text = "ادخال كمية للمخزن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "اسباب التلف :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "تاريخ التلف :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "الكمية التالفة :";
            // 
            // lblDamagedIDValue
            // 
            this.lblDamagedIDValue.AutoSize = true;
            this.lblDamagedIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamagedIDValue.Location = new System.Drawing.Point(195, 128);
            this.lblDamagedIDValue.Name = "lblDamagedIDValue";
            this.lblDamagedIDValue.Size = new System.Drawing.Size(60, 26);
            this.lblDamagedIDValue.TabIndex = 38;
            this.lblDamagedIDValue.Text = "؟؟؟؟";
            // 
            // lblStockIDValue
            // 
            this.lblStockIDValue.AutoSize = true;
            this.lblStockIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockIDValue.Location = new System.Drawing.Point(658, 128);
            this.lblStockIDValue.Name = "lblStockIDValue";
            this.lblStockIDValue.Size = new System.Drawing.Size(60, 26);
            this.lblStockIDValue.TabIndex = 39;
            this.lblStockIDValue.Text = "؟؟؟؟";
            // 
            // dtpDamagedDate
            // 
            this.dtpDamagedDate.CustomFormat = "dd/M/yyyy";
            this.dtpDamagedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDamagedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDamagedDate.Location = new System.Drawing.Point(159, 279);
            this.dtpDamagedDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDamagedDate.Name = "dtpDamagedDate";
            this.dtpDamagedDate.Size = new System.Drawing.Size(167, 30);
            this.dtpDamagedDate.TabIndex = 40;
            this.dtpDamagedDate.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(598, 282);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 30);
            this.numQuantity.TabIndex = 41;
            // 
            // rtbResons
            // 
            this.rtbResons.Location = new System.Drawing.Point(159, 363);
            this.rtbResons.Name = "rtbResons";
            this.rtbResons.Size = new System.Drawing.Size(366, 82);
            this.rtbResons.TabIndex = 42;
            this.rtbResons.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "معرف المنتج :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 44;
            this.label5.Text = "اسم المنتج :";
            // 
            // lblProductIDValue
            // 
            this.lblProductIDValue.AutoSize = true;
            this.lblProductIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDValue.Location = new System.Drawing.Point(195, 210);
            this.lblProductIDValue.Name = "lblProductIDValue";
            this.lblProductIDValue.Size = new System.Drawing.Size(60, 26);
            this.lblProductIDValue.TabIndex = 45;
            this.lblProductIDValue.Text = "؟؟؟؟";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(658, 210);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(60, 26);
            this.lblProductName.TabIndex = 46;
            this.lblProductName.Text = "؟؟؟؟";
            // 
            // frmAddEditDamaged
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnCLose2;
            this.ClientSize = new System.Drawing.Size(891, 518);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductIDValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResons);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.dtpDamagedDate);
            this.Controls.Add(this.lblStockIDValue);
            this.Controls.Add(this.lblDamagedIDValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddEdit);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.lblDamagedID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCLose2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(909, 565);
            this.Name = "frmAddEditDamaged";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddEditDamaged_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCLose2;
        private System.Windows.Forms.Label lblDamagedID;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Label lblAddEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDamagedIDValue;
        private System.Windows.Forms.Label lblStockIDValue;
        private System.Windows.Forms.DateTimePicker dtpDamagedDate;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.RichTextBox rtbResons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductIDValue;
        private System.Windows.Forms.Label lblProductName;
    }
}