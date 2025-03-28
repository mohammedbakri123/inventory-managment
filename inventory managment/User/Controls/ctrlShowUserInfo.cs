using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_managment_business;

namespace inventory_managment.User.Controls
{
    public partial class ctrlShowUserInfo : UserControl
    {
        clsUser _User;

        public clsUser SelectedUser { get { return _User; } }

        int _UserID = -1;

        public int UserID { get { return _UserID; } }
        
        public ctrlShowUserInfo()
        {
            InitializeComponent();
        }

        public void LoadUser(int UserID)
        {
            _User = clsUser.Find(UserID);
            if( _User == null )
            {
                _ResetDefaultValues();
                MessageBox.Show("لم يتم العثور على هذا المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadUserInfo();
        }

        public void _ResetDefaultValues()
        {
            ctrlShowPersonInfo1._resetDefaultValue();
            lblRoleValue.Text = string.Empty;
            lblUserIDValue.Text = string.Empty;
            lblUserNameValue.Text = string.Empty;
        }

        private void _LoadUserInfo()
        {
            ctrlShowPersonInfo1._LoadPerson(_User.person.PersonID);
            string role = "";
            switch(_User.role)
            {
                case 0:
                    role = "مدير النظام";
                    break;
                case 1:
                    role = "مسؤول المخزون";
                    break;
                case 2:
                    role = "أمين الصندوق";
                    break;
                case 3:
                    role = "موقف";
                    break;
            }
           lblRoleValue.Text = role;
            lblUserIDValue.Text = _User.UserID.ToString();
            lblUserNameValue.Text = _User.UserName;
        }

        
    }
}
