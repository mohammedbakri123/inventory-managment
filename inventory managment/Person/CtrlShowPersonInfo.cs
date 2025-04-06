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

namespace inventory_managment.Person
{
    public partial class CtrlShowPersonInfo : UserControl
    {

        private clsPerson _person;

        public clsPerson SelectedPerson { get { return _person; } }

        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } set { }  }
        public CtrlShowPersonInfo()
        {
            InitializeComponent();
        }

        public void _LoadPerson(int PersonID)
        {
           _person = clsPerson.find(PersonID);
            if(_person == null) {
                _resetDefaultValue();
                MessageBox.Show("لم يتم العثور على هذا المستخدم", "خطأ" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        public void _resetDefaultValue()
        {
            lblEmailValue.Text = "????";
            lblNameValue.Text = "????";
            lblPhoneValue.Text = "????";
            lblAddressValue.Text = "????";
            pbPersonPic.Image = Resources.Male_512;

        }



        private void _FillPersonInfo()
        {
            lblEmailValue.Text = _person.Email;
            lblNameValue.Text = _person.FullName;
            lblPhoneValue.Text = _person.Phone;
            lblAddressValue.Text = _person.Address;
            if(_person.ImagePath != "")
            pbPersonPic.ImageLocation = _person.ImagePath;
        }

    }
}
