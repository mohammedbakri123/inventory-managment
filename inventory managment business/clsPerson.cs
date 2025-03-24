using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsPerson
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode _mode;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string Phone { get; set; }
        public string Email { get; set; }
        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public string Address { get; set; }

        public clsPerson() {
            _mode = enMode.AddNew;
            PersonID = -1;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            ImagePath = string.Empty;
            Address = string.Empty;

        }
        private clsPerson(int personID, string firstName, string secondName, string thirdName, string lastName, string phone, string email, string imageLocation, string address)
        {
            _mode = enMode.Update;
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            ImagePath = imageLocation;
            Address = address;
        }

        public static clsPerson find(int personID)
        {

           
            string firstName = "",lastName = "", secondName = "", thirdName = "", phone = "", email = "", imagelocation = "", address = "";
           
            bool isFound = clsPersonData.GetByID(personID, ref firstName, ref secondName, ref thirdName, ref lastName , ref phone, ref email, ref imagelocation, ref address);
            
            if (isFound)
            {
                return new clsPerson(personID, firstName,secondName ,thirdName, lastName, phone, email,imagelocation, address);
            }
            else
                return null;
        }

        private bool Addnew()
        {
            this.PersonID = clsPersonData.AddPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Phone, this.Email, this.ImagePath, this.Address);

            return this.PersonID != -1;
        }

        private bool Update()
        {
            return clsPersonData.UpdatePersonByID(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Phone, this.Email, this.ImagePath, this.Address);
        }

        public bool save()
        {
            switch(_mode)
            {
                case enMode.AddNew:
                    if (Addnew())
                    {
                        _mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                    case enMode.Update:
                        return Update();

            }
            return false;
        }

        public static bool Delete(int personID)
        {
           return clsPersonData.DeletePersonByID(personID);
        }
    }
    
}
