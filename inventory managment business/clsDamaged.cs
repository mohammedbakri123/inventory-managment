using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_managment_Data;

namespace inventory_managment_business
{
    public class clsDamaged
    {
        enum enMode { Add = 1 , Update = 2 }

        enMode _mode;

        public int ID { set; get; }

        public clsStock DamagedStock { set; get; }

        public string Resons { set; get; }

        public DateTime Date { set; get; }

        public int Quantity { set; get; }

        public clsDamaged()
        {
            _mode = enMode.Add;
            ID = -1;
            DamagedStock = new clsStock();
            Resons = "";
            Date = DateTime.Now;
            Quantity = 0;

        }

        private clsDamaged(int ID, int StockID , string Resons ,DateTime date , int Quantity)
        {
            _mode = enMode.Update;
            this.ID = ID;
            this.DamagedStock = clsStock.Find(StockID);
            this.Resons = Resons;
            this.Date = date;
            this.Quantity = Quantity;
        }

        public static clsDamaged Find(int ID)
        {
            int DamagedStock = 0, Quantity = 0;
            string resons = "";
            DateTime Date = DateTime.Now;
            if(clsDamagedData.find(ID , ref DamagedStock , ref resons ,ref Date ,ref Quantity))
            {
                return new clsDamaged(ID , DamagedStock , resons , Date , Quantity);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = clsDamagedData.Add(DamagedStock.ID, Resons , Date , Quantity);

            return this.ID != -1;
        }
        private bool Update()
        {
            return clsDamagedData.Update(ID, DamagedStock.ID, Resons, Date, Quantity);
        }

        public bool save()
        {
            if (this.DamagedStock.save())
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
            return clsDamagedData.Delete(ID);
        }

        public static DataTable GetAll()
        {
            return clsDamagedData.GetAll();
        }
    }
}
