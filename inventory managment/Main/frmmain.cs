using inventory_managment.Client;
using inventory_managment.Damaged;
using inventory_managment.Global;
using inventory_managment.Product;
using inventory_managment.SellPoint;
using inventory_managment.Stocks;
using inventory_managment.Stocks.Bills;
using inventory_managment.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"مرحبًا بك يا {clsGlobal.crruntUser.person.FullName}، نتمنى لك تجربة ممتعة 😊", "أهلًا وسهلًا", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void msiUserManagment_Click(object sender, EventArgs e)
        {
            frmListUsers frmListUsers = new frmListUsers();
            frmListUsers.ShowDialog();
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProducts frmListProducts = new frmListProducts();
            frmListProducts.ShowDialog();
        }

        private void ادارةالكمياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStocks frm = new frmListStocks();
            frm.ShowDialog();
        }

        private void msiDamagedManagment_Click(object sender, EventArgs e)
        {
            frmListDamaged frm  = new frmListDamaged();
            frm.ShowDialog();
        }

        private void نقطةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellPoint frm = new frmSellPoint(clsGlobal.crruntUser.UserID , -1);
            frm.Show();
        }

        private void ادراةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListClient frm = new frmListClient();
            frm.ShowDialog();
        }

        private void msiBillsManagments_Click(object sender, EventArgs e)
        {
            frmListBills frm = new frmListBills();
            frm.ShowDialog();
        }
    }
}
