using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsSold
    {
        enum enMode { Add = 1 , Update = 2}
        enMode _mode;

        public int ID { get; set; }

        public clsStock Stock { get; set; }

        public clsBill Bill { get; set; }

        public int quantity { get; set; }

        public SqlMoney PricePerOne { get; set; }

        public SqlMoney TotalPrice { get; set; }

        public clsSold()
        {
            _mode = enMode.Add;
            ID = -1;
            Stock = new clsStock();
            Bill = new clsBill();
            PricePerOne = new SqlMoney();
            TotalPrice = new SqlMoney();
            quantity = 0;

        }

        private clsSold( int iD, int stockID, int billID, int quantity, SqlMoney pricePerOne, SqlMoney totalPrice)
        {
            _mode = enMode.Update;
            ID = iD;
            Stock = clsStock.Find(stockID);
            Bill = clsBill.find(billID);
            this.quantity = quantity;
            PricePerOne = pricePerOne;
            TotalPrice = totalPrice;
        }

        public static clsSold find(int ID)
        {
            int StockID = -1 , BillID = -1 ,quantity = 0;
            SqlMoney PricePerone = new SqlMoney();
            SqlMoney TotalPrice = new SqlMoney();
            if(clsSoldData.find(ID ,ref StockID , ref BillID, ref quantity , ref PricePerone , ref TotalPrice))
            {
                return new clsSold(ID, StockID, BillID, quantity, PricePerone, TotalPrice);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = clsSoldData.Add(this.Stock.ID , this.Bill.ID , quantity , PricePerOne , TotalPrice);
            return this.ID != -1;

        }

        private bool Update()
        {
            return clsSoldData.Update(this.ID , this.Stock.ID, this.Bill.ID, quantity, PricePerOne, TotalPrice);
        }

        public bool save()
        {
            if (this.Stock.save())
            {
                switch (_mode)
                {
                    case enMode.Add:
                        if (this.Add())
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

            return false;
        }

        public static bool delete(int ID)
        {
            return clsSoldData.Delete(ID);
        }

        public static DataTable GetALl(int ID)
        {
            return clsSoldData.GetAll(ID);
        }

    }
}
