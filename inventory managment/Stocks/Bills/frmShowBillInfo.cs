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

namespace inventory_managment.Stocks.Bills
{
    public partial class frmShowBillInfo : Form
    {
        //fix the shite

        int BillID;
        clsBill _bill;
        DataTable dtSolds;
        public frmShowBillInfo(int ID)
        {
            InitializeComponent();
            BillID = ID;
        }

        private void frmShowBillInfo_Load(object sender, EventArgs e)
        {
            ResetData();
            _bill = clsBill.find(BillID);
            if( _bill != null )
            {
                LoadData();
                return;
            }
        }

        void LoadData()
        {
            lblIDValue.Text = _bill.ID.ToString();
            lblBillDate.Text = _bill.IssueDate.ToString();
            lblBillTotalPrice.Text = _bill.totalPrice.ToString();
            lblClientCompanyName.Text = _bill.Client.CompanyName;
            lblPaidAmount.Text = _bill.PaidPrice.ToString();
            lblUserFullName.Text = _bill.SellPoint.user.person.FullName;
            dtSolds = clsSold.GetALl(_bill.ID);
            dgvSolds.DataSource = dtSolds;
            if(dgvSolds.Rows.Count > 0 )
            {
                dgvSolds.Columns[0].Width = 50;

                dgvSolds.Columns[1].Width = 120;

                dgvSolds.Columns[2].Width = 200;

                dgvSolds.Columns[3].Width = 100;

                dgvSolds.Columns[4].Width = 120;

                dgvSolds.Columns[5].Width = 120;
            }
        }

        void ResetData()
        {
            lblIDValue.Text = string.Empty;
            lblBillDate.Text = string.Empty;
            lblBillTotalPrice.Text = string.Empty;
            lblClientCompanyName.Text = string.Empty;
            lblPaidAmount.Text = string.Empty;
            lblUserFullName.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
