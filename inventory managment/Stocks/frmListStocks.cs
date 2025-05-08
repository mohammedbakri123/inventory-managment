using inventory_managment.Damaged;
using inventory_managment_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.Stocks
{
    public partial class frmListStocks : Form
    {
        DataTable _dtStocks;
        public frmListStocks()
        {
            InitializeComponent();
        }

        public frmListStocks(int Gtin)
        {
            InitializeComponent();
        }

        private void frmListStocks_Load(object sender, EventArgs e)
        {
            _dtStocks = clsStock.GetAll();
            dgvStocks.DataSource = _dtStocks;
            cbFilterBy.SelectedIndex = 0;
            checkShowDone.Checked = true;
            if(dgvStocks.RowCount == 0)
            {
                lblRecordCount.Text = "0";
                lblCostPrice.Text = "0";
                lblSellPrice.Text = "0";
                cbFilterBy.Enabled = false;
                checkShowDone.Enabled = false;
                return;
            }
            lblRecordCount.Text = _CalcualateQuantity().ToString();
            lblCostPrice.Text = _CalcualateCostPrice().ToString();
            lblSellPrice.Text = _CalculateSellPrice().ToString();
           
            dgvStocks.Columns[0].Width = 80;

            dgvStocks.Columns[1].Width = 100;

            dgvStocks.Columns[2].Width = 120;

            dgvStocks.Columns[3].Width = 120;

            dgvStocks.Columns[4].Width = 120;

            dgvStocks.Columns[5].Width = 80;
            
            dgvStocks.Columns[6].Width = 80;
            
            dgvStocks.Columns[7].Width = 80;
            
            dgvStocks.Columns[8].Width = 80;
            
            dgvStocks.Columns[9].Width = 200;
            
            dgvStocks.Columns[10].Width = 50;
            cbFilterBy.Enabled = true;
            checkShowDone.Enabled = true;

        }

        int _CalcualateQuantity()
        {
            int quantity = 0;

            foreach (DataGridViewRow row in dgvStocks.Rows)
            {
                if (!row.IsNewRow) // Skip the empty new row in DataGridView
                {
                    object val = row.Cells["العدد الحالي للكمية"].Value;

                    if (val != null && int.TryParse(val.ToString(), out int parsedValue))
                    {
                        quantity += parsedValue;
                    }
                }
            }

            return quantity;
        }

        decimal _CalcualateCostPrice()
        {
            decimal totalCost = 0;

            foreach (DataGridViewRow row in dgvStocks.Rows)
            {
                if (!row.IsNewRow)
                {
                    object priceVal = row.Cells["سعر الشراء للحبة"].Value;
                    object quantityVal = row.Cells["العدد الحالي للكمية"].Value;

                    if (priceVal != null && quantityVal != null &&
                        decimal.TryParse(priceVal.ToString(), out decimal costPrice) &&
                        int.TryParse(quantityVal.ToString(), out int quantity))
                    {
                        totalCost += costPrice * quantity;
                    }
                }
            }

            return totalCost;
        }
        
        decimal _CalculateSellPrice()
        {
            decimal totalCost = 0;

            foreach (DataGridViewRow row in dgvStocks.Rows)
            {
                if (!row.IsNewRow)
                {
                    object priceVal = row.Cells["سعر البيع للحبة"].Value;
                    object quantityVal = row.Cells["العدد الحالي للكمية"].Value;

                    if (priceVal != null && quantityVal != null &&
                        decimal.TryParse(priceVal.ToString(), out decimal costPrice) &&
                        int.TryParse(quantityVal.ToString(), out int quantity))
                    {
                        totalCost += costPrice * quantity;
                    }
                }
            }

            return totalCost;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditStock frm = new frmAddEditStock(-1);
            frm.ShowDialog();
            frmListStocks_Load(null,null);
        }

        private void tmsAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditStock frm = new frmAddEditStock(-1);
            frm.ShowDialog();
            frmListStocks_Load(null, null);
        }

        private void tmsUpdate_Click(object sender, EventArgs e)
        {
            frmAddEditStock frm = new frmAddEditStock((int)dgvStocks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListStocks_Load(null, null);
        }

        private void tmsDelete_Click(object sender, EventArgs e)
        {
            if(clsStock.Delete((int)dgvStocks.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListStocks_Load(null, null);
                return;
            }
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            if (tbFilter.Text == "" || cbFilterBy.SelectedIndex == 0)
            {
                _dtStocks.DefaultView.RowFilter = "";
                lblRecordCount.Text = _CalcualateQuantity().ToString();
                lblCostPrice.Text = _CalcualateCostPrice().ToString();
                lblSellPrice.Text = _CalculateSellPrice().ToString();
                return;
            }

            if(filterColumn == "المنتج" || filterColumn == "الرقم العالمي" || filterColumn == "موقع الكمية")
                _dtStocks.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
            else
                _dtStocks.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

            lblRecordCount.Text = _CalcualateQuantity().ToString();
            lblCostPrice.Text = _CalcualateCostPrice().ToString();
            lblSellPrice.Text = _CalculateSellPrice().ToString();

        }

        private void checkShowDone_CheckedChanged(object sender, EventArgs e)
        {
            string filterColumn = "تم نفاذ الكمية";
            if(checkShowDone.Checked == true)
                _dtStocks.DefaultView.RowFilter = "";
            else
                _dtStocks.DefaultView.RowFilter = string.Format("[{0}] = False", filterColumn, tbFilter.Text.Trim());

            lblRecordCount.Text = _CalcualateQuantity().ToString();
            lblCostPrice.Text = _CalcualateCostPrice().ToString();
            lblSellPrice.Text = _CalculateSellPrice().ToString();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            if (filterColumn != "المنتج" && filterColumn != "الرقم العالمي" )
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Visible = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEditDamaged frm = new frmAddEditDamaged(-1, (int)dgvStocks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListStocks_Load(null, null);
        }

        private void frmListStocks_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvStocks.RowCount == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
        }
    }
}
