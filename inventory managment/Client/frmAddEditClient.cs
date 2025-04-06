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

namespace inventory_managment.Client
{
    public partial class frmAddEditClient : Form
    {
        enum enMode { Add = 1 , Update = 2}

        enMode _mode;

        int ClientID;

        clsCLient _client;
        public frmAddEditClient(int ClientID)
        {
            InitializeComponent();
            this.ClientID = ClientID;
        }



        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            _reset();
            if(this.ClientID == -1)
            {
                _mode = enMode.Add;
                lblAddUpdate.Text = "اضافة عميل";
                _client = new clsCLient();
                return;
            }
            _mode = enMode.Update;
            lblAddUpdate.Text = "تعديل معلومات العميل";
            _loadData();
            
        }

        void _loadData()
        {
            _client = clsCLient.find(ClientID);
            if(_client != null )
            {
                ctrlAddUpdatePerson1.start(_client.Person.PersonID);
                tbCompanyName.Text = _client.CompanyName;
                lblClientIDValue.Text = _client.ID.ToString();
                
            }
        }
        void _reset()
        {
            ctrlAddUpdatePerson1.start(-1);
            tbCompanyName.Text = string.Empty;
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
            if(!ctrlAddUpdatePerson1.save())
            {
                MessageBox.Show("خطأ اثناء حفظ المعلومات الشخصية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!this.ValidateChildren())
          return;

            _client.CompanyName = tbCompanyName.Text;
            _client.Person = ctrlAddUpdatePerson1.SelectedPerson;
            if(_mode == enMode.Add)
            {
                _client.TotalDebt = 0;
                _client.registereDate = DateTime.Now;
                
            }

            if(_client.save())
            {
                MessageBox.Show("تم حفط معلومات العميل بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mode = enMode.Update;
                lblAddUpdate.Text = "تعديل معلومات العميل";
                lblClientIDValue.Text = _client.ID.ToString();
                return;
            }
            MessageBox.Show("خطأ اثناء حفظ معلومات العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
