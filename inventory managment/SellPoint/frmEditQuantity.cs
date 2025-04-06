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
    public partial class frmEditQuantity : Form
    {
        public int Quantity;
        public frmEditQuantity()
        {
            InitializeComponent();
            Quantity = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Quantity = (int) numQuantity.Value;
            this.Close();
        }
    }
}
