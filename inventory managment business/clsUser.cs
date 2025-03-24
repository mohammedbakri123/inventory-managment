using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsUser
    {
        enum enRole { Admin = 1 , InventoryManager = 2 , cashier = 3 }
        enum enMode { addnew = 1, update = 2 }

        private enMode mode;
        public int UserID { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public clsPerson person { set; get; }

        public int role { set; get; }

        public clsUser() 
        { 
            mode = enMode.addnew;
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            person = new clsPerson();
            role = 1;
        }

        private clsUser(int userID, string userName, string password, int personID, int role)
        {
            this.mode = enMode.update;
            UserID = userID;
            UserName = userName;
            Password = password;
            this.person = clsPerson.find(personID);
            this.role = role;
        }
    }
}
