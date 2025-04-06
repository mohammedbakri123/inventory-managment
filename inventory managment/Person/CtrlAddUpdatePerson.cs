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
using inventory_managment.Global;

namespace inventory_managment.Person
{
    public partial class CtrlAddUpdatePerson : UserControl
    {
        enum enMode { Addnew = 1, UpdateNew = 2 }

        enMode _mode = enMode.Addnew;

        private clsPerson _person;
        public clsPerson SelectedPerson { get { return _person; } }

        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } set { } }
        public CtrlAddUpdatePerson()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            if(_PersonID == -1)
            {
                _person = new clsPerson();
                _mode = enMode.Addnew;
                return;
            }
            _mode = enMode.UpdateNew;
            _person = clsPerson.find(PersonID);
            tbFirstName.Text = _person.FirstName;
            tbLastName.Text = _person.LastName;
            tbSecondName.Text = _person.SecondName;
            tbThirdName.Text = _person.ThirdName;
            tbPhone.Text = _person.Phone;
            tbEmail.Text = _person.Email;
            rtbAddress.Text = _person.Address;
            if(_person.ImagePath != "")
            {
                pbPersonPic.ImageLocation = _person.ImagePath;
            }
            llremoveImage.Visible = _person.ImagePath != "";
        }

        private void _ResetDefaultValue()
        {
            _mode = enMode.Addnew;
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            rtbAddress.Text = "";
            pbPersonPic.Image = Resources.Male_512;
        }

        public void start(int personID)
        {
            this._PersonID  = personID;
            
            if(personID == -1) {
                _ResetDefaultValue();
                
            }
            _LoadData();
            
        }

        private bool _HandlImage()
        {
            if(_person.ImagePath != pbPersonPic.ImageLocation)
            {
                if(_person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_person.ImagePath);
                    }
                    catch 
                    { 
                    
                    }
                }
                if(pbPersonPic.ImageLocation != null) 
                {
                    string sourceFile = pbPersonPic.ImageLocation;
                    if(clsUtil.CopyImageToProjectImagesFolder(ref sourceFile , 1))
                    {
                        pbPersonPic.ImageLocation = sourceFile;
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

        public bool save()
        {
            if(!this.ValidateChildren()) 
                return false;

            if(!_HandlImage())
            {
                return false;
                
            }
            _PersonID = _person.PersonID;
            _person.FirstName = tbFirstName.Text;
            _person.LastName = tbLastName.Text;
            _person.SecondName = tbSecondName.Text;
            _person.ThirdName = tbThirdName.Text;
            _person.Phone = tbPhone.Text;
            _person.Email = tbEmail.Text;
            _person.Address = rtbAddress.Text;

            if(pbPersonPic.ImageLocation != null)
            {
                _person.ImagePath = pbPersonPic.ImageLocation; 
            }
            else
            {
                _person.ImagePath = "";
            }


            return _person.save();
            
               
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
                pbPersonPic.Load(selectedFilePath);
                llremoveImage.Visible = true;
                // ...
            }
        }

        private void llremoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonPic.ImageLocation = null;

            pbPersonPic.Image = Resources.Male_512;

            llremoveImage.Visible = false;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp,"يجب ملأ هذا الحقل");
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

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "")
                return;
            if (!clsUtil.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email Address Format!");

            }
            else
            {
                errorProvider1.SetError(tbEmail, null);

            }
        }
    }
}
