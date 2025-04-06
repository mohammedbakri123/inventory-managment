namespace inventory_managment.Product
{
    partial class frmAddEditProduct
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
            this.pbProductpic = new System.Windows.Forms.PictureBox();
            this.llChangeImage = new System.Windows.Forms.LinkLabel();
            this.llDeleteImage = new System.Windows.Forms.LinkLabel();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProductIDValue = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.tbGTIN = new System.Windows.Forms.TextBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.cbCatagory = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblProductAddEdit = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProductpic
            // 
            this.pbProductpic.Image = global::inventory_managment.Properties.Resources.Product512;
            this.pbProductpic.Location = new System.Drawing.Point(514, 103);
            this.pbProductpic.Name = "pbProductpic";
            this.pbProductpic.Size = new System.Drawing.Size(259, 230);
            this.pbProductpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductpic.TabIndex = 16;
            this.pbProductpic.TabStop = false;
            // 
            // llChangeImage
            // 
            this.llChangeImage.AutoSize = true;
            this.llChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llChangeImage.Location = new System.Drawing.Point(598, 353);
            this.llChangeImage.Name = "llChangeImage";
            this.llChangeImage.Size = new System.Drawing.Size(87, 18);
            this.llChangeImage.TabIndex = 17;
            this.llChangeImage.TabStop = true;
            this.llChangeImage.Text = "تغيير الصورة";
            this.llChangeImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llChangeImage_LinkClicked);
            // 
            // llDeleteImage
            // 
            this.llDeleteImage.AutoSize = true;
            this.llDeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDeleteImage.Location = new System.Drawing.Point(600, 385);
            this.llDeleteImage.Name = "llDeleteImage";
            this.llDeleteImage.Size = new System.Drawing.Size(85, 18);
            this.llDeleteImage.TabIndex = 18;
            this.llDeleteImage.TabStop = true;
            this.llDeleteImage.Text = "حذف الصورة";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(65, 87);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(99, 25);
            this.lblProductID.TabIndex = 19;
            this.lblProductID.Text = "رقم المنتج :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "اسم المنتج :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "نوع النتج :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "الرقم العالمي :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "المورد :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "وصف المنتج :";
            // 
            // lblProductIDValue
            // 
            this.lblProductIDValue.AutoSize = true;
            this.lblProductIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDValue.Location = new System.Drawing.Point(215, 89);
            this.lblProductIDValue.Name = "lblProductIDValue";
            this.lblProductIDValue.Size = new System.Drawing.Size(54, 24);
            this.lblProductIDValue.TabIndex = 25;
            this.lblProductIDValue.Text = "؟؟؟؟";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductName.Location = new System.Drawing.Point(219, 150);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(187, 28);
            this.tbProductName.TabIndex = 26;
            this.tbProductName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbSupplier
            // 
            this.tbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplier.Location = new System.Drawing.Point(219, 269);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(187, 28);
            this.tbSupplier.TabIndex = 27;
            this.tbSupplier.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbGTIN
            // 
            this.tbGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGTIN.Location = new System.Drawing.Point(219, 323);
            this.tbGTIN.Name = "tbGTIN";
            this.tbGTIN.Size = new System.Drawing.Size(187, 28);
            this.tbGTIN.TabIndex = 28;
            this.tbGTIN.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(191, 403);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(310, 96);
            this.rtbInfo.TabIndex = 29;
            this.rtbInfo.Text = "";
            this.rtbInfo.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyRichTextBox);
            // 
            // cbCatagory
            // 
            this.cbCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCatagory.FormattingEnabled = true;
            this.cbCatagory.Location = new System.Drawing.Point(219, 207);
            this.cbCatagory.Name = "cbCatagory";
            this.cbCatagory.Size = new System.Drawing.Size(187, 30);
            this.cbCatagory.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(674, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 41);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(12, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblProductAddEdit
            // 
            this.lblProductAddEdit.AutoSize = true;
            this.lblProductAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAddEdit.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblProductAddEdit.Location = new System.Drawing.Point(326, 23);
            this.lblProductAddEdit.Name = "lblProductAddEdit";
            this.lblProductAddEdit.Size = new System.Drawing.Size(122, 36);
            this.lblProductAddEdit.TabIndex = 33;
            this.lblProductAddEdit.Text = "اضافة منتج";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.lblProductAddEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCatagory);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.tbGTIN);
            this.Controls.Add(this.tbSupplier);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lblProductIDValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.llDeleteImage);
            this.Controls.Add(this.llChangeImage);
            this.Controls.Add(this.pbProductpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProductpic;
        private System.Windows.Forms.LinkLabel llChangeImage;
        private System.Windows.Forms.LinkLabel llDeleteImage;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProductIDValue;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbSupplier;
        private System.Windows.Forms.TextBox tbGTIN;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ComboBox cbCatagory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblProductAddEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}