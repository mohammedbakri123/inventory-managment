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
    public partial class frmListBills : Form
    {
        enum enMode { forAll = 1 , forUser = 2 , forClient = 3 , forSellPoint = 4}

        enMode _mode;
        DataTable _dtBills;


        int UserID;
        int ClientID;
        int SellPointID;
        public frmListBills()
        {
            InitializeComponent();
            _dtBills = new DataTable();
            _mode = enMode.forAll;
        }

        private void frmListBills_Load(object sender, EventArgs e)
        {
            
            switch (_mode)
            {
                case enMode.forAll:
                    _dtBills = clsBill.GetAll();
                    break;
                case enMode.forUser:
                    _dtBills = clsBill.GetAllForUser(UserID);
                    break;
                case enMode.forClient:
                   _dtBills = clsBill.GetAllForCLient(ClientID);
                    break;
                case enMode.forSellPoint:
                    _dtBills = clsBill.GetAllForSellPoint(SellPointID);
                    break;

                default:
                    _dtBills = clsBill.GetAll();
                    break;

            }
            dgvBills.DataSource = _dtBills;
            if(dgvBills.Rows.Count > 0 )
            {
                lblRecordCount.Text = dgvBills.Rows.Count.ToString();

                dgvBills.Columns[0].Width = 50;

                dgvBills.Columns[1].Width = 150;

                dgvBills.Columns[2].Width = 100;

                dgvBills.Columns[3].Width = 100;

                dgvBills.Columns[4].Width = 50;

                dgvBills.Columns[5].Width = 150;

                dgvBills.Columns[6].Width = 50;

                dgvBills.Columns[7].Width = 50;

                dgvBills.Columns[8].Width = 200;

                
               
                
            }
            else
            {
                cbFilterBy.Enabled = false;
            }
            tbFilter.Visible = false;
            cbFilterBy.SelectedIndex = 0;
        }



        public void SetForClient(int ClientID)
        {
            _mode = enMode.forClient;
           this.ClientID = ClientID;

        }
        public void SetForUser(int UserID)
        {
            _mode = enMode.forUser;
            this.UserID = UserID;
            
        }

        public void SetForSellPoint(int SellPointID)
        {
            _mode = enMode.forSellPoint;
            this.SellPointID = SellPointID;

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
                            _dtBills.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvBills.RowCount.ToString();

                return;
                }

                if(filterColumn == "اسم العميل" || filterColumn == "اسم المستخدم")
                    _dtBills.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
                else
                    _dtBills.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

                lblRecordCount.Text = dgvBills.RowCount.ToString();



            
           

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvBills.RowCount > 0)
            {
                string filterColumn = cbFilterBy.SelectedItem.ToString();
                if (filterColumn != "اسم العميل" && filterColumn != "اسم المستخدم")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void tmsShowBillInfo_Click(object sender, EventArgs e)
        {
            frmShowBillInfo frm = new frmShowBillInfo((int)dgvBills.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
