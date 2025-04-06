using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsStock
    {
        enum enMode { AddNew =  1, Update = 2 }

        enMode _mode;
        public int ID { get; set; }
        public clsProduct Product { get; set; }

        public int EntranceQuantity { get; set; }
        public int CurrentQuantity { get; set; }

        public DateTime EntranceDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public SqlMoney CostPrice { get; set; }

        public SqlMoney SellPrice { get; set;}

        public string Position { get; set; }

        public bool IsDone { get; set; }


        public clsStock()
        {
            _mode = enMode.AddNew;
            ID = -1;
            Product = new clsProduct();
            EntranceQuantity = 0;
            CurrentQuantity = 0;
            EntranceDate = DateTime.MinValue;
            ExpireDate = DateTime.MinValue;
            CostPrice = new SqlMoney();
            SellPrice = new SqlMoney();
            Position = "";
            IsDone = false;


        }

        private clsStock(int ID , int ProductID , int EntranceQuantity, int CurrentQuantity , DateTime EntranceDate, DateTime ExpireDate, SqlMoney CostPrice , SqlMoney Sellprice , string position ,bool isDone)
        {
            _mode = enMode.Update;
            this.ID = ID;
            this.Product = clsProduct.find(ProductID);
            this.EntranceQuantity = EntranceQuantity;
            this.CurrentQuantity = CurrentQuantity;
            this.EntranceDate = EntranceDate;
            this.ExpireDate = ExpireDate;
            this.CostPrice = CostPrice;
            this.SellPrice = Sellprice;
            this.Position = position;
            this.IsDone = isDone;

        }

        public static clsStock Find(int ID)
        {
            int ProductID = -1, EntranceQuantity = -1, CurrentQuantity = -1;
            DateTime EntranceDate = DateTime.MinValue, ExpireDate = DateTime.MinValue;
            SqlMoney CostPrice = new SqlMoney(), Sellprice = new SqlMoney();
            bool isDone = false;
            string  position = "";

            if (clsStockData.GetByID(ID, ref ProductID, ref EntranceQuantity, ref CurrentQuantity, ref EntranceDate,ref ExpireDate ,ref CostPrice ,ref Sellprice ,ref position , ref isDone))
            {
                return new clsStock(ID, ProductID, EntranceQuantity, CurrentQuantity, EntranceDate, ExpireDate, CostPrice, Sellprice, position, isDone);
            }
            return null;
        }

        private bool Add()
        {
            if (this.CurrentQuantity <= 0)
            {
                this.IsDone = true;
            }
            else
            {
                this.IsDone = false;
            }
            this.ID = clsStockData.Add(this.Product.ID,this.EntranceQuantity,this.CurrentQuantity,this.EntranceDate , this.ExpireDate , this.CostPrice,this.SellPrice, this.Position,this.IsDone);

            return this.ID != -1;
        }

        private bool Update()
        {
            if (this.CurrentQuantity <= 0)
            {
                this.IsDone = true;
            }
            else
            {
                this.IsDone = false;
            }
            return clsStockData.Update(this.ID, this.Product.ID, this.EntranceQuantity, this.CurrentQuantity, this.EntranceDate, this.ExpireDate, this.CostPrice, this.SellPrice, this.Position, this.IsDone);
        }

        public bool save()
        {
            switch(_mode)
            {
                case enMode.AddNew:
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

        public static bool Delete(int ID)
        {
            return clsStockData.delete(ID);
        }

        public static DataTable GetAll()
        {
            return clsStockData.GetAll();
        }

        public static DataTable GetAllShortened()
        {
            return clsStockData.GetAllShortened();
        }
    }
}
