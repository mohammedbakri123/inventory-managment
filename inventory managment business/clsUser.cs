using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private bool Addnew()
        {

            this.UserID = clsUserData.AddNew(this.UserName, this.Password, this.role, this.person.PersonID);
            if (this.UserID != -1)
            {
                mode = enMode.update;
                return true;
            }
            return false;
        }

        private bool Update()
        {
            return clsUserData.Update(this.UserID , this.UserName , this.Password , this.role, this.person.PersonID);
        }

        public static clsUser Find(int userID)
        {
            string UserName = "" , Password = ""  ;
            int role = 1 , personID = -1;

            bool isFound = clsUserData.GetByUserID(userID , ref UserName , ref Password , ref role , ref personID);

            if(isFound )
            {
                return new clsUser(userID , UserName , Password , personID , role);
            }
            return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            int role = 1, personID = -1, userID = -1;

            bool isFound = clsUserData.GetByUserNameAndPassword(ref userID,  UserName,  Password, ref role, ref personID);

            if (isFound)
            {
                return new clsUser(userID, UserName, Password, personID, role);
            }
            return null;

        }

        public bool Save()
        {
            switch(mode)
            {
                case enMode.addnew:
                    return Addnew();
                case enMode.update:
                    return Update();

            }
            return false;
        }

        public static bool delete(int UserID)
        {
            return clsUserData.Delete(UserID);
        }

        public static bool IsUserExist(int userID)
        {
            return clsUserData.isUserExistByID(userID);
        }

        public static bool IsUserExist(string UserName, string Password)
        {
            return clsUserData.isUserExistByUserNameAndPassword(UserName, Password);
        }

        public static DataTable AllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool SetStop(int UserID)
        {
            return clsUserData.SetUserStop(UserID);
        }
    }
}
