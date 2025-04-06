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
    public class clsBill
    {
        enum enMode { add = 1 , Update = 2 }

        enMode _mode;
        public int ID { set; get; }

        public clsCLient Client { set; get; }

        public clsSellPoint SellPoint { set; get; }

        public DateTime IssueDate { set; get; }

        public SqlMoney totalPrice { set; get; }

        public SqlMoney PaidPrice { set; get; }

        public clsBill()
        {
            _mode = enMode.add;
            ID = -1;
            Client = new clsCLient();
            SellPoint = new clsSellPoint();
            IssueDate = new DateTime();
            totalPrice = new SqlMoney();
            PaidPrice = new SqlMoney();

        }

        private clsBill(int ID, int ClientID, int SellPointID, DateTime issueDate, SqlMoney totalPrice , SqlMoney PaidPrice)
        {
            _mode = enMode.Update;
            this.ID = ID;
            this.Client = clsCLient.find(ClientID);
            this.SellPoint = clsSellPoint.find(SellPointID);
            this.IssueDate = issueDate;
            this.totalPrice = totalPrice;
            this.PaidPrice = PaidPrice;
        }

        public static clsBill find(int ID)
        {
            int ClientID = -1, sellPointID = -1;
            DateTime issueDate = new DateTime();
            SqlMoney totalPrice = new SqlMoney();
            SqlMoney PaidPrice = new SqlMoney();
            if(clsBillData.find(ID, ref ClientID ,ref sellPointID ,ref issueDate ,ref totalPrice ,ref PaidPrice))
            {
                return new clsBill(ID, ClientID, sellPointID, issueDate, totalPrice, PaidPrice);
            }
            return null;
        }

        private bool Add()
        {
            this.ID = clsBillData.Add(this.Client.ID, this.SellPoint.ID, this.IssueDate, totalPrice, PaidPrice);
            return this.ID != -1;
        }

        private bool Update()
        {
            return clsBillData.Update(this.ID, this.Client.ID, this.SellPoint.ID, this.IssueDate, totalPrice, PaidPrice);
        }

        public bool save()
        {
            switch(_mode)
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

        public static bool delete(int ID)
        {
            return clsBillData.Delete(ID);
        }

        public static DataTable GetAll() 
        {
            return clsBillData.GetAll();
        }

        public static DataTable GetAllForUser(int ID)
        {
            return clsBillData.GetAllForUser(ID);
        }

        public static DataTable GetAllForCLient(int ID)
        {
            return clsBillData.GetAllForClient(ID);
        }

        public static DataTable GetAllForSellPoint(int ID)
        {
            return clsBillData.GetAllForSellPoint(ID);
        }

    }
}
