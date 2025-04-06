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
    public partial class frmAddUpdateUser : Form
    {
        enum enMode { AddNew = 1, Update = 2 }
        int _personID;
        public int UserID { get { return _personID; } }

        clsUser _user;

        enMode _mode;


        public frmAddUpdateUser(int PersonID)
        {
            _personID = PersonID;
            InitializeComponent();
            if (_personID == -1)
            {
                _mode = enMode.AddNew;
                lblAddUpdate.Text = "اظافة مستخدم";
            }
            else
                _mode = enMode.Update;
            lblAddUpdate.Text = "تعديل مستخدم";

        }

        private void _ResetDefaultValue()
        {
            ctrlAddUpdatePerson1.start(-1);
            tbUserName.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            lblUserIDValue.Text = "؟؟؟؟";

        }

        private void LoadData()
        {
            if(_mode == enMode.AddNew)
            {
                _user = new clsUser();
                return;
            }
            _user = clsUser.Find(_personID);
            tbUserName.Text = _user.UserName;
            tbPassword.Text = _user.Password;
            tbConfirmPassword.Text = _user.Password;
            ctrlAddUpdatePerson1.start(_user.person.PersonID);
            cbRole.SelectedIndex = _user.role;
            lblUserIDValue.Text = _user.UserID.ToString();

        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.AddNew)
            {
                _ResetDefaultValue();
                
            }
            LoadData();
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

        private void ValidateEmptyComboBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            ComboBox Temp = ((ComboBox)sender);
            if (Temp.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "يجب اختيار عنصر");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("تأكد من ملئ جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!ctrlAddUpdatePerson1.save())
            {
                MessageBox.Show("تأكد من ملئ المعلومات الشخصية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user.UserName = tbUserName.Text;
            _user.Password = tbPassword.Text;
            _user.role = cbRole.SelectedIndex;
            _user.person = ctrlAddUpdatePerson1.SelectedPerson;
            if(_user.Save())
            {
                lblAddUpdate.Text = "تعديل مستخدم";
                _mode = enMode.Update;
                MessageBox.Show("تم حفظ بيانات المستخدم بنجاح","تم الحفظ",MessageBoxButtons.OK , MessageBoxIcon.Information );
                return;

            }
            MessageBox.Show("حصل خطأ اثناء حفظ بيانات المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (Temp.Text != tbPassword.Text )
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "يجب تأكيد كلمة المرور");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
    }
}
