using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsPayment
    {
        enum enMode { add = 1 , Update = 2 }

        enMode _mode;
        public int ID { set; get; }
        public DateTime Date { set; get; }
        public  string note { set; get; }

        public clsCLient client { set; get; }

        public int Amount { set; get; }

        public clsPayment()
        {
            _mode = enMode.add;
            ID = -1;
            Date = DateTime.Now;
            note = string.Empty;
            client = new clsCLient();
            Amount = 0;
        }

        private clsPayment( int ID, DateTime date, string note, int ClientID, int amount)
        {
            _mode = enMode.Update;
            this.ID = ID;
            Date = date;
            this.note = note;
            this.client = clsCLient.find(ClientID);
            Amount = amount;
        }

        private bool Add()
        {
            this.ID = clsPaymentData.Add(Date, note , this.client.ID , Amount);
            return this.ID != -1;

        }

        private bool Update()
        {
            return clsPaymentData.Update(ID, Date, note, this.client.ID, Amount);
        }

        public bool save()
        {
            switch(this._mode)
            {
                case enMode.add:
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

        public static clsPayment Find(int ID) 
        {
            int ClientID = -1, amount = 0;
            string note = string.Empty;
            DateTime date = DateTime.Now;

            if(clsPaymentData.Find(ID , ref date, ref note, ref ClientID, ref amount))
            {
                return new clsPayment(ID, date, note, ClientID, amount);
            }
            return null;
        
        }

        public static bool Delete(int ID)
        {
            return clsPaymentData.Delete(ID);
        }

        public static DataTable GetAll(int ID)
        {
            return clsPaymentData.GetAll(ID);
        }
    }

}
