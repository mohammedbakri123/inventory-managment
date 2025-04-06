using inventory_managment.Properties;
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
    public partial class frmAddEditStock : Form
    {
        enum enMode { Add = 1 , Update = 2 }

        enMode _mode;
        clsStock _stock;

        clsProduct _product;

        int _StockID;

        int _ProductID;

        public frmAddEditStock(int StockID,int ProductID = -1)
        {
            InitializeComponent();
            _StockID = StockID;
            if(_StockID == -1)
            {
                _mode = enMode.Add;
                if (ProductID == -1)
                {
                    _resetProductTap();
                    _resetStock();
                }
                else
                {
                    _resetStock();
                    tpSearchForProduct.Enabled = false;
                    tabControl1.SelectedIndex = 1;
                    _product = clsProduct.find(ProductID);
                    _LoadProduct();

                }
            }
            else
            {
                _mode= enMode.Update;
                _loadStock();
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbFilter.Text == "" || tbFilter.Text == string.Empty || tbFilter.Text == null)
            {
                MessageBox.Show("يحب ادخال قيمة للبجث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch(cbFilterBy.SelectedIndex)
            {
                case 0:
                    _product = clsProduct.find(int.Parse(tbFilter.Text));
                    break;
                case 1:
                    _product = clsProduct.findByName(tbFilter.Text);
                    break;
                case 2:
                    _product = clsProduct.find(tbFilter.Text);
                    break;
            }
            if(_product != null)
            {
                _LoadProduct();
                btnNext.Enabled = true;
                tpAddeditStock.Enabled = true;
                this.AcceptButton = btnNext;
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void _LoadProduct()
        {
            //lblIDValue.Text = _product.ID.ToString();
            lblProductIDValue.Text = _product.ID.ToString();
            
            lblProductCatagoryValue.Text = _product.Catagory.Name;
            lblProductNameValue.Text = _product.Name;
            lblGTINvalue.Text = _product.GTIN;

            if(_product.ImagePath != null && _product.ImagePath != "") {
            pbProductpiv.ImageLocation = _product.ImagePath;
            }
            else
            {
                pbProductpiv.Image = Resources.Product512;
            }
        }
        private void _resetProductTap()
        {
            cbFilterBy.SelectedIndex = 0;
            _product = new clsProduct();
            this.AcceptButton = btnSearch;
            lblProductIDValue.Text ="؟؟؟؟";
            lblProductCatagoryValue.Text = "؟؟؟؟";
            lblProductNameValue.Text = "؟؟؟؟";
            lblGTINvalue.Text = "؟؟؟؟";
            pbProductpiv.Image = Resources.Product512;

            btnNext.Enabled = false;
            tpAddeditStock.Enabled = false;
        }

        private void _loadStock()
        {
            
            tpSearchForProduct.Enabled = false;
            tabControl1.SelectedIndex = 1;

            _stock = clsStock.Find(_StockID);

            if(_stock == null)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblIDValue.Text= _stock.ID.ToString();

            _product = _stock.Product;
            tbCostPrice.Text = _stock.CostPrice.ToString();
            numQuantity.Value = _stock.EntranceQuantity;
            tbSellPrice.Text = _stock.SellPrice.ToString();
            dtpEntranceDate.Value = _stock.EntranceDate;
            dtpExpireDate.Value = _stock.ExpireDate;
            rtbPlace.Text = _stock.Position;

            _LoadProduct();
        }
        private void _resetStock()
        {
            _stock = new clsStock();
            lblIDValue.Text = "؟؟؟؟";
            tbCostPrice.Text = "";
            numQuantity.Value = 0;
            tbSellPrice.Text = "";
            dtpEntranceDate.Value = DateTime.Now;
            dtpExpireDate.Value = DateTime.Now;
            rtbPlace.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            { return; }
            if (_mode == enMode.Add)
            {
                _stock.CurrentQuantity = (int)numQuantity.Value;
            }
            else
            {
                if (_stock.EntranceQuantity != numQuantity.Value)
                {
                    _stock.CurrentQuantity = _stock.CurrentQuantity + ((int)numQuantity.Value - _stock.EntranceQuantity);
                }
            }
            _stock.EntranceQuantity = (int)numQuantity.Value;
            _stock.EntranceDate = dtpEntranceDate.Value;
            _stock.ExpireDate = dtpExpireDate.Value;
            _stock.SellPrice = decimal.Parse(tbSellPrice.Text);
            _stock.CostPrice = decimal.Parse(tbCostPrice.Text);
            _stock.Position = rtbPlace.Text;
            _stock.Product = _product;

            
              
            

            if(_stock.save())
            {
                _mode = enMode.Update;
                lblAddEdit.Text = "";
                lblIDValue.Text = _stock.ID.ToString();
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnCLose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "معرف المنتج")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "يجب ملأ هذا الحقل");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void ValidateEmptyRichTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            RichTextBox Temp = ((RichTextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "يجب ملأ هذا الحقل");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

       

        private void HandlOnlyNumbertextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
