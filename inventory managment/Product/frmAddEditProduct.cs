using inventory_managment.Global;
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
using System.IO;

namespace inventory_managment.Product
{
    public partial class frmAddEditProduct : Form
    {
        enum enMode { addnew = 1 , Update = 2 }

        enMode _mode;
        public int ProductID { get; set; } 

        private clsProduct _product = new clsProduct();
        public frmAddEditProduct(int ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;

            if (this.ProductID == -1)
            {

                _mode = enMode.addnew;
                lblProductAddEdit.Text = "اضافة منتج";
                _resetDefaultValue();
            }

            else
            {
             
                _mode = enMode.Update;
                lblProductAddEdit.Text = "تعديل المنتج";
                _resetDefaultValue();
                _LoadData();
            }  
        }

        private void _resetDefaultValue()
        {
            _FillCatagoriesComboBox();
            tbProductName.Text = "";
            tbGTIN.Text = "";
            tbSupplier.Text = "";
            lblProductIDValue.Text = "؟؟؟؟";
            rtbInfo.Text = "";
            cbCatagory.SelectedIndex = 0;
            pbProductpic.Image = Resources.Product512;
            llDeleteImage.Visible = false;
        }

        private void _LoadData()
        {
            _product = clsProduct.find(ProductID);
            if (_product == null)
            {
                MessageBox.Show("لم يتم العثور على المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error) ;

                return;
                


            }

            tbProductName.Text = _product.Name;
            tbGTIN.Text = _product.GTIN;
            tbSupplier.Text = _product.Supplier;
            lblProductIDValue.Text = _product.ID.ToString();
            rtbInfo.Text = _product.Description;
            cbCatagory.SelectedIndex = cbCatagory.FindString(_product.Catagory.Name) ;
            if (_product.ImagePath != "")
            {
                pbProductpic.ImageLocation = _product.ImagePath;
                llDeleteImage.Visible = true;
            }
            else
            {
                pbProductpic.Image = Resources.Product512;
                llDeleteImage.Visible = false;
            }

        }

        private void _FillCatagoriesComboBox()
        {
            DataTable dt = clsCatagory.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbCatagory.Items.Add(dr[1].ToString());
            }
        }

        private bool _HandlImage()
        {
            if (_product.ImagePath != pbProductpic.ImageLocation)
            {
                if (_product.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_product.ImagePath);
                    }
                    catch
                    {

                    }
                }
                if (pbProductpic.ImageLocation != null)
                {
                    string sourceFile = pbProductpic.ImageLocation;
                    if (clsUtil.CopyImageToProjectImagesFolder(ref sourceFile, 2))
                    {
                        pbProductpic.ImageLocation = sourceFile;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_HandlImage())
            {
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("تأكد من ملأ كل الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            _product.GTIN = tbGTIN.Text;
            _product.Description = rtbInfo.Text;
            _product.Supplier = tbSupplier.Text;
            _product.Catagory = clsCatagory.find(cbCatagory.SelectedItem.ToString());
            _product.Name = tbProductName.Text;
            if (pbProductpic.ImageLocation != "")
                _product.ImagePath = pbProductpic.ImageLocation;
            else
                _product.ImagePath = ""; 
            
            if(_product.Save())
            {
                MessageBox.Show("تم حفظ بيانات المنتج بنجاح","تم الحفظ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mode = enMode.Update;
                lblProductAddEdit.Text = "تعديل المنتج";
                return;
            }
            MessageBox.Show("حصل خطأ اثناء حفظ بيانات النتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


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

        private void llChangeImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbProductpic.Load(selectedFilePath);
                pbProductpic.Visible = true;
                // ...
            }
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
