namespace inventory_managment.Person
{
    partial class CtrlAddUpdatePerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llremoveImage = new System.Windows.Forms.LinkLabel();
            this.llChangeImage = new System.Windows.Forms.LinkLabel();
            this.pbPersonPic = new System.Windows.Forms.PictureBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.llremoveImage);
            this.groupBox1.Controls.Add(this.llChangeImage);
            this.groupBox1.Controls.Add(this.pbPersonPic);
            this.groupBox1.Controls.Add(this.rtbAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbThirdName);
            this.groupBox1.Controls.Add(this.tbSecondName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(722, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الشخصية";
            // 
            // llremoveImage
            // 
            this.llremoveImage.AutoSize = true;
            this.llremoveImage.Location = new System.Drawing.Point(62, 314);
            this.llremoveImage.Name = "llremoveImage";
            this.llremoveImage.Size = new System.Drawing.Size(85, 18);
            this.llremoveImage.TabIndex = 13;
            this.llremoveImage.TabStop = true;
            this.llremoveImage.Text = "حذف الصورة";
            this.llremoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llremoveImage_LinkClicked);
            // 
            // llChangeImage
            // 
            this.llChangeImage.AutoSize = true;
            this.llChangeImage.Location = new System.Drawing.Point(62, 286);
            this.llChangeImage.Name = "llChangeImage";
            this.llChangeImage.Size = new System.Drawing.Size(87, 18);
            this.llChangeImage.TabIndex = 12;
            this.llChangeImage.TabStop = true;
            this.llChangeImage.Text = "تغيير الصورة";
            this.llChangeImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llChangeImage_LinkClicked);
            // 
            // pbPersonPic
            // 
            this.pbPersonPic.Image = global::inventory_managment.Properties.Resources.Male_512;
            this.pbPersonPic.Location = new System.Drawing.Point(27, 101);
            this.pbPersonPic.Name = "pbPersonPic";
            this.pbPersonPic.Size = new System.Drawing.Size(161, 170);
            this.pbPersonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonPic.TabIndex = 11;
            this.pbPersonPic.TabStop = false;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(233, 209);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(358, 83);
            this.rtbAddress.TabIndex = 10;
            this.rtbAddress.Text = "";
            this.rtbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "العنوان :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(466, 163);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(125, 24);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "الإيميل :";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(466, 110);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(125, 24);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(620, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 24);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "رقم الهاتف :";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(27, 56);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(125, 24);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Location = new System.Drawing.Point(171, 56);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(125, 24);
            this.tbThirdName.TabIndex = 3;
            this.tbThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(320, 56);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(125, 24);
            this.tbSecondName.TabIndex = 2;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(466, 56);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(125, 24);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(651, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "الاسم :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CtrlAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrlAddUpdatePerson";
            this.Size = new System.Drawing.Size(728, 358);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llremoveImage;
        private System.Windows.Forms.LinkLabel llChangeImage;
        private System.Windows.Forms.PictureBox pbPersonPic;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
