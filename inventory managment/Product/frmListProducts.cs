using inventory_managment.Product.Catagories;
using inventory_managment.Stocks;
using inventory_managment_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.Product
{
    public partial class frmListProducts : Form
    {
        private static DataTable _dtAllProducts;
        public frmListProducts()
        {

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            _FillCatagoriesComboBox();
            _dtAllProducts = clsProduct.GetAll();
            dgvProducts.DataSource = _dtAllProducts;
            cbFilterBy.SelectedIndex = 0;
            cbFilterByCatagory.Visible = false;
            lblRecordCount.Text = "0";
            if (dgvProducts.RowCount != 0)
            {
                lblRecordCount.Text = dgvProducts.RowCount.ToString();
                dgvProducts.Columns[0].Width = 100;


                dgvProducts.Columns[1].Width = 120;

                dgvProducts.Columns[2].Width = 320;

                dgvProducts.Columns[3].Width = 120;

                dgvProducts.Columns[4].Width = 120;

                dgvProducts.Columns[4].Width = 200;
            }
        }

        private void _FillCatagoriesComboBox()
        {
            DataTable dt = clsCatagory.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbFilterByCatagory.Items.Add(dr[1].ToString());
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 4)
            {
                cbFilterByCatagory.Visible = true;
                tbFilter.Visible = false;
                cbFilterByCatagory.Focus();
                cbFilterByCatagory.SelectedIndex = 0;
            }
            else
            {
                cbFilterByCatagory.Visible = false;
                tbFilter.Visible = cbFilterBy.SelectedIndex != 0;
                tbFilter.Text = "";
                tbFilter.Focus();

            }
        }

        private void cbFilterByCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "التصنيف";
            string FilteerValue = cbFilterByCatagory.SelectedItem.ToString();
            if (cbFilterByCatagory.SelectedIndex == 0)
            {
                _dtAllProducts.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvProducts.RowCount.ToString();
                return;
            }
            _dtAllProducts.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilteerValue);
            lblRecordCount.Text = dgvProducts.RowCount.ToString();



        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();

            if (tbFilter.Text == "" || cbFilterBy.SelectedIndex == 0)
            {
                _dtAllProducts.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvProducts.RowCount.ToString();
                return;
            }
            if (filterColumn == "معرف المنتج")
                _dtAllProducts.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());

            else
                _dtAllProducts.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());

            lblRecordCount.Text = dgvProducts.RowCount.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "معرف المنتج")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void tmsShowProductInfo_Click(object sender, EventArgs e)
        {
            frmShowProductInfo frmShowProductInfo = new frmShowProductInfo((int)dgvProducts.CurrentRow.Cells[0].Value);
            frmShowProductInfo.ShowDialog();
            this.frmListProducts_Load(null , null);
        }

        private void tmsAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct(-1);
            frm.ShowDialog();
            this.frmListProducts_Load(null, null);

        }

        private void tmsUpdate_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct((int)dgvProducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            this.frmListProducts_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct(-1);
            frm.ShowDialog();
            this.frmListProducts_Load(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListCatagories frm = new frmListCatagories();
            frm.ShowDialog();
        }

        private void tmsAddStock_Click(object sender, EventArgs e)
        {
            frmAddEditStock frm = new frmAddEditStock(-1, (int)dgvProducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
