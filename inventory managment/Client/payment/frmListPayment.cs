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

namespace inventory_managment.Client.payment
{
    public partial class frmListPayment : Form
    {
        int ClientID;
        clsCLient _client;
        DataTable dtPayments;
        public frmListPayment(int ID)
        {
            InitializeComponent();
            ClientID = ID;
        }

        private void frmListPayment_Load(object sender, EventArgs e)
        {
            
            _client = clsCLient.find(ClientID);
            if(_client != null)
            {
                ctrlClientInformation1.loadData(_client.ID);
                dtPayments = clsPayment.GetAll(_client.ID);
                dgvPayments.DataSource = dtPayments;
                if(dgvPayments.RowCount > 0)
                {
                    dgvPayments.Columns[0].Width = 80;

                    dgvPayments.Columns[1].Width = 200;

                    dgvPayments.Columns[2].Width = 200;

                    dgvPayments.Columns[3].Width = 150;
                }
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            frmAddPayment frm = new frmAddPayment(ClientID , -1);
            frm.ShowDialog();
            frmListPayment_Load(null,null);
        }

        private void tmsAddPayment_Click(object sender, EventArgs e)
        {
            frmAddPayment frm = new frmAddPayment(ClientID, -1);
            frm.ShowDialog();
            frmListPayment_Load(null, null);
        }

        private void tmsUpdate_Click(object sender, EventArgs e)
        {
            frmAddPayment frm = new frmAddPayment(ClientID, (int)dgvPayments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListPayment_Load(null, null);

        }
    }
}
