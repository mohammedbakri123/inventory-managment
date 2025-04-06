using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsCatagory
    {
        enum enMode { Addnew = 1 , Upate = 2}

        enMode _mode;
        public int ID { set; get; }

        public string Name { set; get; }

        private clsCatagory(int catagoryID, string name)
        {
            _mode = enMode.Upate;
            this.ID = catagoryID;
            Name = name;
        }

        public clsCatagory() {
            _mode = enMode.Addnew;
            ID = -1;
            Name = string.Empty;
        }

        public static clsCatagory find(int ID)
        {
            string Name = "";
            if(clsCatagoryData.GetByID(ID , ref Name))
            {
                return new clsCatagory(ID, Name);
            }
            return null;
        }
        public static clsCatagory find(string name)
        {
            int ID = -1;
            if (clsCatagoryData.GetByName(name, ref ID))
            {
                return new clsCatagory(ID, name);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = clsCatagoryData.Add(this.Name);

            return this.ID != -1;
        }

        private bool Update()
        {
            return clsCatagoryData.Update(this.ID , this.Name);
        }

        public bool save()
        {
            switch(_mode)
            {
                case enMode.Upate:
                    return Update();
                case enMode.Addnew:
                    _mode  = enMode.Upate;
                    return Add();
            }
            return false;
        }
        public static DataTable GetAll()
        {
            return clsCatagoryData.GetAll();
        }

        public static bool Delete(int ID) 
        {
            return clsCatagoryData.Delete(ID);
        }
    }
}
