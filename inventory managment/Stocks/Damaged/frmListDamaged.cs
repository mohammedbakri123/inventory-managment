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

namespace inventory_managment.Damaged
{
    public partial class frmListDamaged : Form
    {
        DataTable _dtDamaged;

        public frmListDamaged()
        {
            InitializeComponent();
        }

        private void frmListDamaged_Load(object sender, EventArgs e)
        {
            _dtDamaged = clsDamaged.GetAll();
            dgvDamaged.DataSource = _dtDamaged;
            cbFilterBy.SelectedIndex = 0;
            if (dgvDamaged.RowCount != 0)
            {
                lblRecordCount.Text = _CalcualateQuantity().ToString();

                dgvDamaged.Columns[0].Width = 80;

                dgvDamaged.Columns[1].Width = 150;

                dgvDamaged.Columns[2].Width = 120;

                dgvDamaged.Columns[3].Width = 120;

                dgvDamaged.Columns[4].Width = 200;

                dgvDamaged.Columns[5].Width = 80;

                dgvDamaged.Columns[6].Width = 80;

                dgvDamaged.Columns[7].Width = 80;

                dgvDamaged.Columns[8].Width = 80;

                dgvDamaged.Columns[9].Width = 120;
            }
            
        }

        int _CalcualateQuantity()
        {
            int quantity = 0;

            foreach (DataGridViewRow row in dgvDamaged.Rows)
            {
                if (!row.IsNewRow) // Skip the empty new row in DataGridView
                {
                    object val = row.Cells["الكمية التالفة"].Value;

                    if (val != null && int.TryParse(val.ToString(), out int parsedValue))
                    {
                        quantity += parsedValue;
                    }
                }
            }

            return quantity;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvDamaged.RowCount > 0)
            {
                string filterColumn = cbFilterBy.SelectedItem.ToString();
                if (tbFilter.Text == "" || cbFilterBy.SelectedIndex == 0)
                {
                    _dtDamaged.DefaultView.RowFilter = "";
                    lblRecordCount.Text = _CalcualateQuantity().ToString();

                    return;
                }

                if (filterColumn == "المنتج" || filterColumn == "الرقم العالمي" || filterColumn == "اسباب التلف")
                    _dtDamaged.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
                else
                    _dtDamaged.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

                lblRecordCount.Text = _CalcualateQuantity().ToString();
            }
         
        }

    

        private void tmsUpdate_Click(object sender, EventArgs e)
        {
            frmAddEditDamaged frm = new frmAddEditDamaged((int)dgvDamaged.CurrentRow.Cells[0].Value,-1);
            frm.ShowDialog();
            frmListDamaged_Load(null, null);
        }

        private void tmsDelete_Click(object sender, EventArgs e)
        {
            clsDamaged current = clsDamaged.Find((int)dgvDamaged.CurrentRow.Cells[0].Value);
            if (current != null)
            {
                current.DamagedStock.CurrentQuantity += current.Quantity;
                if (current.save())
                {
                    if (clsDamaged.delete(current.ID))
                    {

                        current = null;
                        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmListDamaged_Load(null, null);
                        return;
                    }
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return;

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvDamaged.RowCount > 0)
            {
                string filterColumn = cbFilterBy.SelectedItem.ToString();
                if (filterColumn != "المنتج" && filterColumn != "الرقم العالمي" && filterColumn != "اسباب التلف")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvDamaged.RowCount == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
        }
    }
}
