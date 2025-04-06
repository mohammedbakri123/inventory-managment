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

namespace inventory_managment.Product
{
    public partial class frmShowProductInfo : Form
    {
        clsProduct _product { set; get; }
        int _productId { set; get; }    
        public frmShowProductInfo(int ProductID)
        {
            InitializeComponent();

            _productId = ProductID;
        }
        private void frmShowProductInfo_Load(object sender, EventArgs e)
        {
            _product = clsProduct.find(_productId);
            if (_product != null)
            {
                _loadData();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _resDefaultValues();
            }

        }
        private void _loadData()
        {
            _resDefaultValues();
            lblProductIDValue.Text = _product.ID.ToString();
            lblProductNameValue.Text = _product.Name;
            lblSupplierValue.Text = _product.Supplier;
            lblProductCatagoryValue.Text = _product.Catagory.Name;
            lblInfoValue.Text = _product.Description;
            lblGTINvalue.Text = _product.GTIN;
            if(_product.ImagePath != "")
            pbProductpiv.ImageLocation = _product.ImagePath;


        }
        private void _resDefaultValues()
        {
            lblProductIDValue.Text = "";
            lblProductNameValue.Text = string.Empty;
            lblSupplierValue.Text = string.Empty;
            lblProductCatagoryValue.Text = string.Empty;
            lblInfoValue.Text = string.Empty;
            lblGTINvalue.Text = string.Empty;
            pbProductpiv.Image = Resources.Product512;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct(_productId);
            frm.ShowDialog();
            this.frmShowProductInfo_Load(null,null);
        }

        
    }
}
