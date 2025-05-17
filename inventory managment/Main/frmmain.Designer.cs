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
            this.msiUserManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.ادراةالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStocks = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStocksManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDamagedManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.msiBillsManagments = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSellPointsManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.نقطةبيعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsSettins = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsUpdateCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiUserManagment,
            this.ادراةالعملاءToolStripMenuItem,
            this.msiProducts,
            this.msiStocks,
            this.نقطةبيعToolStripMenuItem,
            this.التقاريرToolStripMenuItem,
            this.tmsSettins});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // msiUserManagment
            // 
            resources.ApplyResources(this.msiUserManagment, "msiUserManagment");
            this.msiUserManagment.Image = global::inventory_managment.Properties.Resources.People_64;
            this.msiUserManagment.Name = "msiUserManagment";
            this.msiUserManagment.Click += new System.EventHandler(this.msiUserManagment_Click);
            // 
            // ادراةالعملاءToolStripMenuItem
            // 
            resources.ApplyResources(this.ادراةالعملاءToolStripMenuItem, "ادراةالعملاءToolStripMenuItem");
            this.ادراةالعملاءToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.Drivers_64;
            this.ادراةالعملاءToolStripMenuItem.Name = "ادراةالعملاءToolStripMenuItem";
            this.ادراةالعملاءToolStripMenuItem.Click += new System.EventHandler(this.ادراةالعملاءToolStripMenuItem_Click);
            // 
            // msiProducts
            // 
            resources.ApplyResources(this.msiProducts, "msiProducts");
            this.msiProducts.Image = global::inventory_managment.Properties.Resources.Products3D_32;
            this.msiProducts.Name = "msiProducts";
            this.msiProducts.Click += new System.EventHandler(this.ادارةالمنتجاتToolStripMenuItem_Click);
            // 
            // msiStocks
            // 
            this.msiStocks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiStocksManagment,
            this.msiDamagedManagment,
            this.msiBillsManagments,
            this.msiSellPointsManagment});
            resources.ApplyResources(this.msiStocks, "msiStocks");
            this.msiStocks.Image = global::inventory_managment.Properties.Resources.Local_32;
            this.msiStocks.Name = "msiStocks";
            this.msiStocks.Click += new System.EventHandler(this.msiStocks_Click);
            // 
            // msiStocksManagment
            // 
            this.msiStocksManagment.Image = global::inventory_managment.Properties.Resources.Products3D_32;
            resources.ApplyResources(this.msiStocksManagment, "msiStocksManagment");
            this.msiStocksManagment.Name = "msiStocksManagment";
            this.msiStocksManagment.Click += new System.EventHandler(this.ادارةالكمياتToolStripMenuItem_Click);
            // 
            // msiDamagedManagment
            // 
            this.msiDamagedManagment.Image = global::inventory_managment.Properties.Resources.Damaged32;
            resources.ApplyResources(this.msiDamagedManagment, "msiDamagedManagment");
            this.msiDamagedManagment.Name = "msiDamagedManagment";
            this.msiDamagedManagment.Click += new System.EventHandler(this.msiDamagedManagment_Click);
            // 
            // msiBillsManagments
            // 
            this.msiBillsManagments.Image = global::inventory_managment.Properties.Resources.billList32;
            resources.ApplyResources(this.msiBillsManagments, "msiBillsManagments");
            this.msiBillsManagments.Name = "msiBillsManagments";
            this.msiBillsManagments.Click += new System.EventHandler(this.msiBillsManagments_Click);
            // 
            // msiSellPointsManagment
            // 
            this.msiSellPointsManagment.Image = global::inventory_managment.Properties.Resources.sellPoint32;
            resources.ApplyResources(this.msiSellPointsManagment, "msiSellPointsManagment");
            this.msiSellPointsManagment.Name = "msiSellPointsManagment";
            this.msiSellPointsManagment.Click += new System.EventHandler(this.msiSellPointsManagment_Click);
            // 
            // نقطةبيعToolStripMenuItem
            // 
            resources.ApplyResources(this.نقطةبيعToolStripMenuItem, "نقطةبيعToolStripMenuItem");
            this.نقطةبيعToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.sellPoint32;
            this.نقطةبيعToolStripMenuItem.Name = "نقطةبيعToolStripMenuItem";
            this.نقطةبيعToolStripMenuItem.Click += new System.EventHandler(this.نقطةبيعToolStripMenuItem_Click);
            // 
            // التقاريرToolStripMenuItem
            // 
            resources.ApplyResources(this.التقاريرToolStripMenuItem, "التقاريرToolStripMenuItem");
            this.التقاريرToolStripMenuItem.Image = global::inventory_managment.Properties.Resources.Reports32;
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Click += new System.EventHandler(this.التقاريرToolStripMenuItem_Click);
            // 
            // tmsSettins
            // 
            this.tmsSettins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsCurrentUser,
            this.tmsUpdateCurrentUser,
            this.toolStripSeparator1,
            this.tmsLogOut});
            resources.ApplyResources(this.tmsSettins, "tmsSettins");
            this.tmsSettins.Image = global::inventory_managment.Properties.Resources.Settings32;
            this.tmsSettins.Name = "tmsSettins";
            // 
            // tmsCurrentUser
            // 
            this.tmsCurrentUser.Image = global::inventory_managment.Properties.Resources.PersonDetails_32;
            resources.ApplyResources(this.tmsCurrentUser, "tmsCurrentUser");
            this.tmsCurrentUser.Name = "tmsCurrentUser";
            this.tmsCurrentUser.Click += new System.EventHandler(this.tmsCurrentUser_Click);
            // 
            // tmsUpdateCurrentUser
            // 
            this.tmsUpdateCurrentUser.Image = global::inventory_managment.Properties.Resources.edit_32;
            resources.ApplyResources(this.tmsUpdateCurrentUser, "tmsUpdateCurrentUser");
            this.tmsUpdateCurrentUser.Name = "tmsUpdateCurrentUser";
            this.tmsUpdateCurrentUser.Click += new System.EventHandler(this.tmsUpdateCurrentUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tmsLogOut
            // 
            this.tmsLogOut.Image = global::inventory_managment.Properties.Resources.sign_out_32__2;
            resources.ApplyResources(this.tmsLogOut, "tmsLogOut");
            this.tmsLogOut.Name = "tmsLogOut";
            this.tmsLogOut.Click += new System.EventHandler(this.tmsLogOut_Click);
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
            this.ShowIcon = false;
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
        private System.Windows.Forms.ToolStripMenuItem msiUserManagment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ادراةالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiProducts;
        private System.Windows.Forms.ToolStripMenuItem msiStocks;
        private System.Windows.Forms.ToolStripMenuItem نقطةبيعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsSettins;
        private System.Windows.Forms.ToolStripMenuItem msiStocksManagment;
        private System.Windows.Forms.ToolStripMenuItem msiDamagedManagment;
        private System.Windows.Forms.ToolStripMenuItem msiBillsManagments;
        private System.Windows.Forms.ToolStripMenuItem msiSellPointsManagment;
        private System.Windows.Forms.ToolStripMenuItem tmsCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem tmsUpdateCurrentUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsLogOut;
    }
}

