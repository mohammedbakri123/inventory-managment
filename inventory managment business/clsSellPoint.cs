using inventory_managment_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_business
{
    public class clsSellPoint
    {
        enum enMode { Add = 1 , Update =  2 }

        enMode _mode;
        public int ID { set; get; }

        public clsUser user { set; get; }

        public DateTime Start {  set; get; }

        public DateTime End { set; get; }

        public SqlMoney Amount { set; get; }

        public int TotoalBills { set; get; }

        public clsSellPoint() 
        {
            _mode = enMode.Add;
            ID = -1;
            user = new clsUser();
            Start = DateTime.Now;
            End = DateTime.Now;
            Amount = new SqlMoney();
            TotoalBills = 0;
        }

        private clsSellPoint(int ID, int UserID, DateTime Start, DateTime End, SqlMoney Amount, int TotalBills)
        {
            _mode = enMode.Update;
            this.ID = ID;
            this.user = clsUser.Find(UserID);
            this.Start = Start;
            this.End = End;
            this.Amount = Amount;
            this.TotoalBills = TotalBills;

        }

        public static clsSellPoint find(int ID)
        {
            int UserID = -1, totalbills = 0;
            SqlMoney Amount = new SqlMoney();
            DateTime start = DateTime.Now , end = DateTime.Now;
            if(clsSellPointData.Find(ID ,ref UserID , ref start , ref end , ref Amount , ref totalbills))
            {
                return new clsSellPoint(ID, UserID, start, end, Amount, totalbills);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = clsSellPointData.Add(this.user.UserID , this.Start , this.End , this.Amount , this.TotoalBills);
            return this.ID != -1;
        }

        private bool Update()
        {
            return clsSellPointData.Update(this.ID, this.user.UserID, this.Start, this.End, this.Amount, this.TotoalBills);
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
        public static bool Delete(int ID) 
        {
            return clsSellPointData.Delete(ID);
        }

        public static DataTable GetAll()
        {
            return clsSellPointData.GetAll();
        }

        public static int GetTotalAmount(int ID)
        {
            return clsSellPointData.GetTotalAmount(ID);
        
        }

        public static int GetTotalBills(int ID)
        {
            return clsSellPointData.GetTotalBills(ID);
        }
    }
}
