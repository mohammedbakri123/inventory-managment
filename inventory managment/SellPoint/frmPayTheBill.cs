using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.SellPoint
{
    public partial class frmPayTheBill : Form
    {
        public int Paid = 0;
        public frmPayTheBill()
        {
            InitializeComponent();
        }

        private void tbCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbPaidPrice.Text != string.Empty) {
                Paid = int.Parse(tbPaidPrice.Text);
            }
            this.Close();
        }
    }
}
