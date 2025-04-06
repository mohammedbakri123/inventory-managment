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

namespace inventory_managment.User
{
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers;

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.AllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            cbFilterByrole.Visible = false;

            if(dgvUsers.RowCount == 0)
            {
                lblRecordCount.Text = "0";
                return;
            }
            lblRecordCount.Text = dgvUsers.RowCount.ToString();
            
            dgvUsers.Columns[0].Width = 110;

   
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].Width = 320;

            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].Width = 120;
            


        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 5)
            {
                cbFilterByrole.Visible=true;
                tbFilter.Visible=false;
                cbFilterByrole.Focus();
                cbFilterByrole.SelectedIndex = 0;
            }
            else
            {
                cbFilterByrole.Visible = false;
                tbFilter.Visible = cbFilterBy.SelectedIndex != 0;
                tbFilter.Text = "";
                tbFilter.Focus();

            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(cbFilterBy.SelectedIndex)
            {
                case 0:
                    FilterColumn = "";
                    break;
                case 1:
                    FilterColumn = "معرف المستخدم";
                    break;
                case 2:
                    FilterColumn = "اسم المستخدم";
                    break;
                case 3:
                    FilterColumn = "الاسم";
                    break;
                case 4:
                    FilterColumn = "رقم الهاتف";
                    break;
                case 5:
                    FilterColumn = "الدور الوظيفي";
                    break;
                default:
                    FilterColumn = "";    
                    break;
            }
            if (tbFilter.Text == "" || cbFilterBy.SelectedIndex == 0)
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvUsers.RowCount.ToString();
                return;
            }
            if(FilterColumn == "معرف المستخدم")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim()); 

            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", FilterColumn, tbFilter.Text.Trim());

            lblRecordCount.Text = dgvUsers.RowCount.ToString();
        }

        private void cbFilterByrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "الدور الوظيفي";
            string FilteerValue = "";
            switch (cbFilterByrole.SelectedIndex)
            {
                case 0:
                    FilteerValue = "مدير النظام";
                    break;
                case 1:
                    FilteerValue = "مسؤول المخزون";
                    break;
                case 2:
                    FilteerValue = "أمين الصندوق";
                    break;
                case 3:
                    FilteerValue = "موقف";
                    break;

            }

            if(cbFilterByrole.SelectedIndex == 0)
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvUsers.RowCount.ToString();
                return;

            }
            _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", FilterColumn, FilteerValue);
            lblRecordCount.Text = dgvUsers.RowCount.ToString();

        }

        private void tmsShowUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserinfo ShowUserInfo = new frmShowUserinfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            ShowUserInfo.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser(-1);
            frmAddUpdateUser.ShowDialog();
            frmListUsers_Load(null, null);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmAddUpdateUser.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void tmsAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser(-1);
            frmAddUpdateUser.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void tmsStopUser_Click(object sender, EventArgs e)
        {
            if(clsUser.SetStop((int)dgvUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "معرف المستخدم")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
