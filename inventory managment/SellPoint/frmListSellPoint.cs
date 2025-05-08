using inventory_managment.Global;
using inventory_managment.Stocks.Bills;
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

namespace inventory_managment.SellPoint
{
    public partial class frmListSellPoint : Form
    {
        DataTable _dtSellPoint;
        public frmListSellPoint()
        {
            InitializeComponent();
        }

        private void frmListSellPoint_Load(object sender, EventArgs e)
        {
            _dtSellPoint = clsSellPoint.GetAll();
            dgvSellPoints.DataSource = _dtSellPoint;
            if(dgvSellPoints.Rows.Count > 0 )
            {
                lblRecordCount.Text = dgvSellPoints.Rows.Count.ToString();


                dgvSellPoints.Columns[0].Width = 80;

                dgvSellPoints.Columns[1].Width = 80;

                dgvSellPoints.Columns[2].Width = 200;

                dgvSellPoints.Columns[3].Width = 200;

                dgvSellPoints.Columns[4].Width = 200;

                dgvSellPoints.Columns[5].Width = 120;

                dgvSellPoints.Columns[6].Width = 120;
                cbFilterBy.SelectedIndex = 0;
                tbFilter.Visible = false;
            }
            else
            {
                cbFilterBy.Enabled = false;
                tbFilter.Visible = false; 
                contextMenuStrip1.Enabled = false;
                
            }

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

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            if (tbFilter.Text == "" || cbFilterBy.SelectedIndex == 0)
            {
                _dtSellPoint.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvSellPoints.RowCount.ToString();
                return;
            }
        
            if (filterColumn == "الاسم")
                _dtSellPoint.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
            else
                _dtSellPoint.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

            lblRecordCount.Text = dgvSellPoints.RowCount.ToString();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            if(filterColumn != "الاسم")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }


        private void btnAddSellPoint_Click(object sender, EventArgs e)
        {
            frmSellPoint frm = new frmSellPoint(clsGlobal.crruntUser.UserID, -1);
            frm.Show();
            frmListSellPoint_Load(null, null);
        }

        private void tmsAddSellPoint_Click(object sender, EventArgs e)
        {
            frmSellPoint frm = new frmSellPoint(clsGlobal.crruntUser.UserID, -1);
            frm.Show();
            frmListSellPoint_Load(null, null);
        }

        private void tmsShowBills_Click(object sender, EventArgs e)
        {
            frmListBills frm = new frmListBills();
            frm.SetForSellPoint((int)dgvSellPoints.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tmsShowSellPointInfo_Click(object sender, EventArgs e)
        {
            frmShowSellPointInfo frm = new frmShowSellPointInfo((int)dgvSellPoints.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
