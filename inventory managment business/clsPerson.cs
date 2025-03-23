using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsPerson
    {
        enum enMode {AddNew = 1 , Update = 2 };
        enMode _mode;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get  { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageLocation { get; set; }
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
            ImageLocation = string.Empty;
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
            ImageLocation = imageLocation;
            Address = address;
        }
    }
    
}
