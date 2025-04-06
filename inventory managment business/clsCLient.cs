using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsCLient
    {
        enum enMode { Add = 1 , Update = 2 }

        enMode _mode;
        public int ID { set; get; }
        public clsPerson Person { set; get; }

        public int TotalDebt { set; get; }

        public DateTime registereDate { set; get; }
        
        public string CompanyName { set; get; }

        public clsCLient()
        {
            _mode = enMode.Add;
            ID = -1;
            Person = new clsPerson();
            registereDate = DateTime.Now;
            CompanyName = string.Empty;
            TotalDebt = 0;
        }

        private clsCLient(int ID , int PersonID , DateTime registereDate , string CompanyName , int TotalDebt)
        {
            _mode = enMode.Update;
            this.ID = ID;
            this.Person = clsPerson.find(PersonID);
            this.registereDate = registereDate;
            this.CompanyName = CompanyName;
            this.TotalDebt = TotalDebt;
        }

        public static clsCLient find(int ID) 
        {
            int PersonID = 0, totalDebt = 0;
            DateTime date = DateTime.Now;
            string CompanyName = string.Empty;

            if(clsClientData.Find(ID, ref PersonID ,ref date,ref CompanyName ,ref totalDebt))
            {
                return new clsCLient(ID , PersonID , date , CompanyName , totalDebt);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = clsClientData.Add(this.Person.PersonID, registereDate , CompanyName , TotalDebt);
            return this.ID != -1;
        }

        private bool Update()
        {
            return clsClientData.Update(ID, this.Person.PersonID, registereDate, CompanyName, TotalDebt);
        }

        public bool save()
        {
            switch(_mode)
            {
                case enMode.Add:
                    if(this.Add())
                    {
                        _mode = enMode.Update;
                        return true;
                    }
                    return false; 
                case enMode.Update:
                    return this.Update();
            }
            return false;
        }

        public static bool delete(int ID)
        {
            return clsClientData.Delete(ID);
        }

        public static DataTable GetAll()
        {
            return clsClientData.GetAll();
        }

        public static DataTable GetAllShortened()
        {
            return clsClientData.GetAllShortened();
        }


    }
}
