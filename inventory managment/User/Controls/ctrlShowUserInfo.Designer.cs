namespace inventory_managment.User.Controls
{
    partial class ctrlShowUserInfo
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
            this.ctrlShowPersonInfo1 = new inventory_managment.Person.CtrlShowPersonInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlShowPersonInfo1
            // 
            this.ctrlShowPersonInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlShowPersonInfo1.Location = new System.Drawing.Point(0, 128);
            this.ctrlShowPersonInfo1.Name = "ctrlShowPersonInfo1";
            this.ctrlShowPersonInfo1.PersonID = -1;
            this.ctrlShowPersonInfo1.Size = new System.Drawing.Size(726, 283);
            this.ctrlShowPersonInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRoleValue);
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.lblUserIDValue);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.lblUserNameValue);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(726, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(359, 54);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(111, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "اسم المستخدم :";
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameValue.Location = new System.Drawing.Point(284, 54);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserNameValue.Size = new System.Drawing.Size(54, 24);
            this.lblUserNameValue.TabIndex = 3;
            this.lblUserNameValue.Text = "????";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.Location = new System.Drawing.Point(505, 54);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserIDValue.Size = new System.Drawing.Size(54, 24);
            this.lblUserIDValue.TabIndex = 5;
            this.lblUserIDValue.Text = "????";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(584, 54);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserID.Size = new System.Drawing.Size(119, 24);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "الرقم التعريفي :";
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleValue.Location = new System.Drawing.Point(52, 54);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRoleValue.Size = new System.Drawing.Size(54, 24);
            this.lblRoleValue.TabIndex = 7;
            this.lblRoleValue.Text = "????";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(127, 54);
            this.lblRole.Name = "lblRole";
            this.lblRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRole.Size = new System.Drawing.Size(119, 24);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "الدور الوظيفي :";
            // 
            // ctrlShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlShowPersonInfo1);
            this.Name = "ctrlShowUserInfo";
            this.Size = new System.Drawing.Size(726, 411);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Person.CtrlShowPersonInfo ctrlShowPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserNameValue;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblUserID;
    }
}
