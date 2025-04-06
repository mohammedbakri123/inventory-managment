namespace inventory_managment.Stocks
{
    partial class frmAddEditStock
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearchForProduct = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProductpiv = new System.Windows.Forms.PictureBox();
            this.lblGTINvalue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductCatagoryValue = new System.Windows.Forms.Label();
            this.lblProductNameValue = new System.Windows.Forms.Label();
            this.lblProductIDValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tpAddeditStock = new System.Windows.Forms.TabPage();
            this.tbSellPrice = new System.Windows.Forms.TextBox();
            this.tbCostPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCLose2 = new System.Windows.Forms.Button();
            this.rtbPlace = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEntranceDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddEdit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpSearchForProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductpiv)).BeginInit();
            this.tpAddeditStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSearchForProduct);
            this.tabControl1.Controls.Add(this.tpAddeditStock);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSearchForProduct
            // 
            this.tpSearchForProduct.Controls.Add(this.btnNext);
            this.tpSearchForProduct.Controls.Add(this.btnClose);
            this.tpSearchForProduct.Controls.Add(this.btnSearch);
            this.tpSearchForProduct.Controls.Add(this.groupBox1);
            this.tpSearchForProduct.Controls.Add(this.label1);
            this.tpSearchForProduct.Controls.Add(this.tbFilter);
            this.tpSearchForProduct.Controls.Add(this.cbFilterBy);
            this.tpSearchForProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSearchForProduct.Location = new System.Drawing.Point(4, 35);
            this.tpSearchForProduct.Name = "tpSearchForProduct";
            this.tpSearchForProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchForProduct.Size = new System.Drawing.Size(831, 470);
            this.tpSearchForProduct.TabIndex = 0;
            this.tpSearchForProduct.Text = "بحث عن منتج";
            this.tpSearchForProduct.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SlateBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(724, 424);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 34);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "النالي";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(8, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 34);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(112, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 36);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbProductpiv);
            this.groupBox1.Controls.Add(this.lblGTINvalue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblProductCatagoryValue);
            this.groupBox1.Controls.Add(this.lblProductNameValue);
            this.groupBox1.Controls.Add(this.lblProductIDValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 321);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المنتج";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbProductpiv
            // 
            this.pbProductpiv.Image = global::inventory_managment.Properties.Resources.Product512;
            this.pbProductpiv.Location = new System.Drawing.Point(26, 41);
            this.pbProductpiv.Name = "pbProductpiv";
            this.pbProductpiv.Size = new System.Drawing.Size(253, 234);
            this.pbProductpiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductpiv.TabIndex = 17;
            this.pbProductpiv.TabStop = false;
            // 
            // lblGTINvalue
            // 
            this.lblGTINvalue.AutoSize = true;
            this.lblGTINvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTINvalue.Location = new System.Drawing.Point(481, 232);
            this.lblGTINvalue.Name = "lblGTINvalue";
            this.lblGTINvalue.Size = new System.Drawing.Size(54, 24);
            this.lblGTINvalue.TabIndex = 16;
            this.lblGTINvalue.Text = "؟؟؟؟";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "الرقم العالمي :";
            // 
            // lblProductCatagoryValue
            // 
            this.lblProductCatagoryValue.AutoSize = true;
            this.lblProductCatagoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCatagoryValue.Location = new System.Drawing.Point(481, 178);
            this.lblProductCatagoryValue.Name = "lblProductCatagoryValue";
            this.lblProductCatagoryValue.Size = new System.Drawing.Size(54, 24);
            this.lblProductCatagoryValue.TabIndex = 14;
            this.lblProductCatagoryValue.Text = "؟؟؟؟";
            // 
            // lblProductNameValue
            // 
            this.lblProductNameValue.AutoSize = true;
            this.lblProductNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameValue.Location = new System.Drawing.Point(427, 122);
            this.lblProductNameValue.Name = "lblProductNameValue";
            this.lblProductNameValue.Size = new System.Drawing.Size(54, 24);
            this.lblProductNameValue.TabIndex = 13;
            this.lblProductNameValue.Text = "؟؟؟؟";
            // 
            // lblProductIDValue
            // 
            this.lblProductIDValue.AutoSize = true;
            this.lblProductIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDValue.Location = new System.Drawing.Point(481, 59);
            this.lblProductIDValue.Name = "lblProductIDValue";
            this.lblProductIDValue.Size = new System.Drawing.Size(54, 24);
            this.lblProductIDValue.TabIndex = 12;
            this.lblProductIDValue.Text = "؟؟؟؟";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "نوع النتج :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "اسم المنتج :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(684, 57);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(99, 25);
            this.lblProductID.TabIndex = 9;
            this.lblProductID.Text = "رقم المنتج :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "بحث بإستخدام :";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(182, 33);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(232, 36);
            this.tbFilter.TabIndex = 22;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "معرف المنتج",
            "اسم المنتج",
            "الرقم العالمي"});
            this.cbFilterBy.Location = new System.Drawing.Point(435, 33);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(204, 37);
            this.cbFilterBy.TabIndex = 21;
            // 
            // tpAddeditStock
            // 
            this.tpAddeditStock.Controls.Add(this.tbSellPrice);
            this.tpAddeditStock.Controls.Add(this.tbCostPrice);
            this.tpAddeditStock.Controls.Add(this.btnSave);
            this.tpAddeditStock.Controls.Add(this.btnCLose2);
            this.tpAddeditStock.Controls.Add(this.rtbPlace);
            this.tpAddeditStock.Controls.Add(this.label13);
            this.tpAddeditStock.Controls.Add(this.lbl);
            this.tpAddeditStock.Controls.Add(this.label12);
            this.tpAddeditStock.Controls.Add(this.dtpExpireDate);
            this.tpAddeditStock.Controls.Add(this.label10);
            this.tpAddeditStock.Controls.Add(this.dtpEntranceDate);
            this.tpAddeditStock.Controls.Add(this.label9);
            this.tpAddeditStock.Controls.Add(this.numQuantity);
            this.tpAddeditStock.Controls.Add(this.label8);
            this.tpAddeditStock.Controls.Add(this.lblIDValue);
            this.tpAddeditStock.Controls.Add(this.label6);
            this.tpAddeditStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddeditStock.Location = new System.Drawing.Point(4, 35);
            this.tpAddeditStock.Name = "tpAddeditStock";
            this.tpAddeditStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddeditStock.Size = new System.Drawing.Size(831, 470);
            this.tpAddeditStock.TabIndex = 1;
            this.tpAddeditStock.Text = "ادخال للمخزن";
            this.tpAddeditStock.UseVisualStyleBackColor = true;
            // 
            // tbSellPrice
            // 
            this.tbSellPrice.Location = new System.Drawing.Point(58, 142);
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.Size = new System.Drawing.Size(176, 28);
            this.tbSellPrice.TabIndex = 31;
            this.tbSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandlOnlyNumbertextbox_KeyPress);
            this.tbSellPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbCostPrice
            // 
            this.tbCostPrice.Location = new System.Drawing.Point(58, 70);
            this.tbCostPrice.Name = "tbCostPrice";
            this.tbCostPrice.Size = new System.Drawing.Size(176, 28);
            this.tbCostPrice.TabIndex = 30;
            this.tbCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandlOnlyNumbertextbox_KeyPress);
            this.tbCostPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(726, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCLose2
            // 
            this.btnCLose2.BackColor = System.Drawing.Color.Crimson;
            this.btnCLose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLose2.Location = new System.Drawing.Point(10, 428);
            this.btnCLose2.Name = "btnCLose2";
            this.btnCLose2.Size = new System.Drawing.Size(99, 34);
            this.btnCLose2.TabIndex = 28;
            this.btnCLose2.Text = "اغلاق";
            this.btnCLose2.UseVisualStyleBackColor = false;
            this.btnCLose2.Click += new System.EventHandler(this.btnCLose2_Click);
            // 
            // rtbPlace
            // 
            this.rtbPlace.Location = new System.Drawing.Point(293, 282);
            this.rtbPlace.Name = "rtbPlace";
            this.rtbPlace.Size = new System.Drawing.Size(366, 82);
            this.rtbPlace.TabIndex = 15;
            this.rtbPlace.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(689, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 26);
            this.label13.TabIndex = 14;
            this.label13.Text = "مكان التخزين :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(254, 140);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(93, 26);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "سعر البيع :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(254, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "سعر الشراء :";
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.CustomFormat = "dd/M/yyyy";
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireDate.Location = new System.Drawing.Point(58, 208);
            this.dtpExpireDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(167, 28);
            this.dtpExpireDate.TabIndex = 9;
            this.dtpExpireDate.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(254, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "تاريخ الانتهاء :";
            // 
            // dtpEntranceDate
            // 
            this.dtpEntranceDate.CustomFormat = "dd/M/yyyy";
            this.dtpEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntranceDate.Location = new System.Drawing.Point(496, 208);
            this.dtpEntranceDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEntranceDate.Name = "dtpEntranceDate";
            this.dtpEntranceDate.Size = new System.Drawing.Size(167, 28);
            this.dtpEntranceDate.TabIndex = 7;
            this.dtpEntranceDate.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(692, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "تاريخ الدخول :";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(543, 142);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 28);
            this.numQuantity.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "الكمية :";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDValue.Location = new System.Drawing.Point(594, 70);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(60, 26);
            this.lblIDValue.TabIndex = 1;
            this.lblIDValue.Text = "؟؟؟؟";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(692, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "معرف الكمية :";
            // 
            // lblAddEdit
            // 
            this.lblAddEdit.AutoSize = true;
            this.lblAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEdit.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAddEdit.Location = new System.Drawing.Point(331, 9);
            this.lblAddEdit.Name = "lblAddEdit";
            this.lblAddEdit.Size = new System.Drawing.Size(187, 29);
            this.lblAddEdit.TabIndex = 1;
            this.lblAddEdit.Text = "ادخال كمية للمخزن";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(839, 573);
            this.Controls.Add(this.lblAddEdit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditStock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "x";
            this.tabControl1.ResumeLayout(false);
            this.tpSearchForProduct.ResumeLayout(false);
            this.tpSearchForProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductpiv)).EndInit();
            this.tpAddeditStock.ResumeLayout(false);
            this.tpAddeditStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSearchForProduct;
        private System.Windows.Forms.TabPage tpAddeditStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProductCatagoryValue;
        private System.Windows.Forms.Label lblProductNameValue;
        private System.Windows.Forms.Label lblProductIDValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblGTINvalue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbProductpiv;
        private System.Windows.Forms.Label lblAddEdit;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbPlace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEntranceDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbSellPrice;
        private System.Windows.Forms.TextBox tbCostPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCLose2;
    }
}