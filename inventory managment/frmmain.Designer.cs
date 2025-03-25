namespace inventory_managment
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ادارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادراةالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المخزنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نقطةبيعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الأعدادتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارةالمستخدمينToolStripMenuItem,
            this.ادراةالعملاءToolStripMenuItem,
            this.ادارةالمنتجاتToolStripMenuItem,
            this.المخزنToolStripMenuItem,
            this.نقطةبيعToolStripMenuItem,
            this.التقاريرToolStripMenuItem,
            this.الأعدادتToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ادارةالمستخدمينToolStripMenuItem
            // 
            resources.ApplyResources(this.ادارةالمستخدمينToolStripMenuItem, "ادارةالمستخدمينToolStripMenuItem");
            this.ادارةالمستخدمينToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.People_64;
            this.ادارةالمستخدمينToolStripMenuItem.Name = "ادارةالمستخدمينToolStripMenuItem";
            // 
            // ادراةالعملاءToolStripMenuItem
            // 
            resources.ApplyResources(this.ادراةالعملاءToolStripMenuItem, "ادراةالعملاءToolStripMenuItem");
            this.ادراةالعملاءToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.Drivers_64;
            this.ادراةالعملاءToolStripMenuItem.Name = "ادراةالعملاءToolStripMenuItem";
            // 
            // ادارةالمنتجاتToolStripMenuItem
            // 
            resources.ApplyResources(this.ادارةالمنتجاتToolStripMenuItem, "ادارةالمنتجاتToolStripMenuItem");
            this.ادارةالمنتجاتToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.product322;
            this.ادارةالمنتجاتToolStripMenuItem.Name = "ادارةالمنتجاتToolStripMenuItem";
            // 
            // المخزنToolStripMenuItem
            // 
            resources.ApplyResources(this.المخزنToolStripMenuItem, "المخزنToolStripMenuItem");
            this.المخزنToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.Local_32;
            this.المخزنToolStripMenuItem.Name = "المخزنToolStripMenuItem";
            // 
            // نقطةبيعToolStripMenuItem
            // 
            resources.ApplyResources(this.نقطةبيعToolStripMenuItem, "نقطةبيعToolStripMenuItem");
            this.نقطةبيعToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.sellPoint32;
            this.نقطةبيعToolStripMenuItem.Name = "نقطةبيعToolStripMenuItem";
            // 
            // التقاريرToolStripMenuItem
            // 
            resources.ApplyResources(this.التقاريرToolStripMenuItem, "التقاريرToolStripMenuItem");
            this.التقاريرToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.Schedule_Test_32;
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            // 
            // الأعدادتToolStripMenuItem
            // 
            this.الأعدادتToolStripMenuItem.Name = "الأعدادتToolStripMenuItem";
            resources.ApplyResources(this.الأعدادتToolStripMenuItem, "الأعدادتToolStripMenuItem");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::inventory_managment.Properties.Resources.Automated_inventory_systems;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمستخدمينToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ادراةالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المخزنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نقطةبيعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الأعدادتToolStripMenuItem;
    }
}

