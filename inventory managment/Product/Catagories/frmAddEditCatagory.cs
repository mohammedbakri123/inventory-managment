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

namespace inventory_managment.Product.Catagories
{
    public partial class frmAddEditCatagory : Form
    {
        enum enMode { AddNew = 1 , Update = 2 }

        enMode _mode;

        int _id;

        clsCatagory Catagory;
        public frmAddEditCatagory(int CatagoryID)
        {
            InitializeComponent();
            _id = CatagoryID;
            if(_id == -1 )
            {
                _mode = enMode.AddNew;
                Catagory = new clsCatagory();
                _resetDefault();
            }
            else
            {
                _mode = enMode.Update;
                lblAddEdit.Text = "تعديل النوع";
                _LoadData();
            }
        }
        void _LoadData()
        {
           
                _resetDefault();
                Catagory = clsCatagory.find(_id);
                if(Catagory != null )
                {
                    lblIDValue.Text = Catagory.ID.ToString();
                    tbName.Text = Catagory.Name;
                }
                else
                {
                    MessageBox.Show("حصل خطأ اثناء البحث عن النوع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
          
        }
        void _resetDefault()
        {
            lblAddEdit.Text = "اضافة نوع";
            lblIDValue.Text = "????";
            tbName.Text = string.Empty;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            Catagory.Name = tbName.Text;
            if(Catagory.save())
            {
                MessageBox.Show("تم حفظ النوع بنجاح","تم الحفظ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAddEdit.Text = "تعديل النوع";
                lblIDValue.Text = Catagory.ID.ToString();
                return;
            }
            MessageBox.Show("حصل خطأ اثناء حفظ النوع", "حصل خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
