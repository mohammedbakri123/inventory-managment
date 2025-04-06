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
    public partial class frmSelectClient : Form
    {
        DataTable _dtClients;

        public int ClientId = 1;
        public frmSelectClient()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmSelectClient_Load(object sender, EventArgs e)
        {
            _dtClients = clsCLient.GetAllShortened();
            dgvClient.DataSource = _dtClients;
            if (dgvClient.RowCount > 0)
            {
               
                dgvClient.Columns[0].Width = 80;

                dgvClient.Columns[1].Width = 200;

                dgvClient.Columns[2].Width = 100;

                dgvClient.Columns[3].Width = 150;


            }
            cbFilterBy.SelectedIndex = 0;
            tbFilter.Visible = false;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
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
                return;
            }

            if (filterColumn == "الاسم" || filterColumn == "الاسم التوضيحي")
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
            else
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();

            if (filterColumn != "الاسم"  && filterColumn != "الاسم التوضيحي")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ClientId = (int)dgvClient.CurrentRow.Cells[0].Value;
            this.Close();
        }
    }
}
