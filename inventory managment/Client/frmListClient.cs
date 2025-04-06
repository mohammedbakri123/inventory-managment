using inventory_managment.Client.payment;
using inventory_managment.Stocks.Bills;
using inventory_managment_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.Client
{
    public partial class frmListClient : Form
    {
        DataTable _dtClients;
        public frmListClient()
        {
            InitializeComponent();
        }

        private void frmListClient_Load(object sender, EventArgs e)
        {
            _dtClients = clsCLient.GetAll();
            dgvClient.DataSource = _dtClients;
            if(dgvClient.RowCount > 0)
            {
                lblRecordCount.Text = dgvClient.RowCount.ToString();
                lblTotalDents.Text = _calculateTotalDebts().ToString();
                dgvClient.Columns[0].Width = 80;

                dgvClient.Columns[1].Width = 200;

                dgvClient.Columns[2].Width = 100;

                dgvClient.Columns[3].Width = 150;

                dgvClient.Columns[4].Width = 120;

            }
            cbFilterBy.SelectedIndex = 0;
            tbFilter.Visible = false;
        }

        private decimal _calculateTotalDebts()
        {
            decimal totalCost = 0;

            foreach (DataGridViewRow row in dgvClient.Rows)
            {
                if (!row.IsNewRow)
                {
                    object debt = row.Cells["اجمالي الديون"].Value;
                    

                    if (debt != null && int.TryParse(debt.ToString(), out int quantity))
                    {
                        totalCost += quantity;
                    }
                }
            }

            return totalCost;

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
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
                _dtClients.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvClient.RowCount.ToString();
                lblTotalDents.Text = _calculateTotalDebts().ToString();
                return;
            }
              
            if (filterColumn == "الاسم" || filterColumn == "رقم الهاتف" || filterColumn == "الاسم التوضيحي")
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
            else
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

            lblRecordCount.Text = dgvClient.RowCount.ToString();
            lblTotalDents.Text = _calculateTotalDebts().ToString();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();

            if (filterColumn != "الاسم" && filterColumn != "رقم الهاتف" && filterColumn != "الاسم التوضيحي")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient(-1);
            frm.ShowDialog();
            frmListClient_Load(null, null); 
        }

        private void tmsAddClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient(-1);
            frm.ShowDialog();
            frmListClient_Load(null, null);
        }

        private void tmsEditClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient((int)dgvClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListClient_Load(null, null);
        }

        private void tmsDeleteClient_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل ترد حذف هذا الزبون؟", "تحقق",MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK) {
               if( clsCLient.delete((int)dgvClient.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الزبون بنجاح","تم الحذف",MessageBoxButtons.OK , MessageBoxIcon.Information );
                    frmListClient_Load(null, null);
                    return;
                }
                MessageBox.Show("لم يتم حذف الزبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmsShowClientInfo_Click(object sender, EventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo((int)dgvClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tmsAddPayment_Click(object sender, EventArgs e)
        {
            frmAddPayment frm = new frmAddPayment((int)dgvClient.CurrentRow.Cells[0].Value, -1);
            frm.ShowDialog();
            frmListClient_Load(null, null);
        }

        private void tmsShowPaymentList_Click(object sender, EventArgs e)
        {
            frmListPayment frm = new frmListPayment((int)dgvClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListClient_Load(null, null);
        }

        private void tmsShowBills_Click(object sender, EventArgs e)
        {
            frmListBills frm = new frmListBills();
            frm.SetForClient((int)dgvClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
