using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsProduct
    {
        enum enMode { Addnew = 1 , Update = 2}

        enMode _mode ;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public clsCatagory Catagory { get; set; }

        public string Supplier { get; set; }

        public string GTIN { get; set; }

        public string ImagePath { get; set; }

        public clsProduct()
        {
            _mode = enMode.Addnew;
            ID = -1;
            Name = string.Empty;
            Description = string.Empty;
            Supplier = string.Empty;
            GTIN = string.Empty;
            ImagePath = string.Empty;
            Catagory = new clsCatagory();
        }

        private clsProduct(int ID, string name, string description, int catagoryID, string supplier, string GTIN, string imagePath)
        {
            _mode = enMode.Update;
            this.ID = ID;
            Name = name;
            Description = description;
            Catagory = clsCatagory.find(catagoryID);
            Supplier = supplier;
            this.GTIN = GTIN;
            ImagePath = imagePath;
        }

        public static clsProduct find(int ID)
        {
            string name = "", Description = "", Supplier = "", GTIN = "", ImagePath = "";
            int CatID = -1;

            if(clsProductData.GetByID(ID , ref name , ref Description , ref CatID , ref Supplier , ref GTIN , ref ImagePath))
            {
                return new clsProduct(ID, name, Description, CatID, Supplier, GTIN, ImagePath);
            }
            return null;
        }
        public static clsProduct find(string GTIN)
        {
            string name = "", Description = "", Supplier = "",  ImagePath = "";
            int CatID = -1 , ID = -1;

            if (clsProductData.GetByGTIN(ref ID, ref name, ref Description, ref CatID, ref Supplier,  GTIN, ref ImagePath))
            {
                return new clsProduct(ID, name, Description, CatID, Supplier, GTIN, ImagePath);
            }
            return null;
        }
        public static clsProduct findByName(string Name)
        {
            string  Description = "", Supplier = "", GTIN = "", ImagePath = "";
            int CatID = -1 , ID = -1;

            if (clsProductData.GetByName(ref ID,  Name, ref Description, ref CatID, ref Supplier, ref GTIN, ref ImagePath))
            {
                return new clsProduct(ID, Name, Description, CatID, Supplier, GTIN, ImagePath);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = (int)clsProductData.Add(this.Name, this.Description, this.Catagory.ID, this.Supplier, this.GTIN, this.ImagePath);
            if(this.ID != -1 )
            {
                _mode = enMode.Update;
                return true;
            }
            return false;
        }

        private bool Update()
        {
            return clsProductData.Update(this.ID, Name, Description, this.Catagory.ID, Supplier, GTIN, ImagePath);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.Addnew:
                    return Add();
                case enMode.Update:
                    return Update();

            }
            return false;

        }

        public static DataTable GetAll()
        {
            return clsProductData.GetAll();
        }

        public static bool Delete(int ID) {
            return clsProductData.Delete(ID);
        }
    }
}
