using inventory_managment_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.SellPoint
{
    public partial class frmShowSellPointInfo : Form
    {
        int SellPointID;
        clsSellPoint sellPoint;

        public frmShowSellPointInfo(int SellPointID)
        {
            InitializeComponent();
            this.SellPointID = SellPointID;
        }

        private void frmShowSellPointInfo_Load(object sender, EventArgs e)
        {
            resetData();
            sellPoint = clsSellPoint.find(SellPointID);
            if(sellPoint != null )
            {
                LoadData();
            }

        }

        void LoadData()
        {
            lblEndTime.Text = sellPoint.End.ToString();
            lblIDValue.Text = sellPoint.ID.ToString();
            lblStartTime.Text = sellPoint.Start.ToString();
            lblTotalAmount.Text = sellPoint.Amount.ToString();
            lblTotalBills.Text = sellPoint.TotoalBills.ToString();
            lblUserName.Text = sellPoint.user.person.FullName;
            
        }

        void resetData()
        {
            lblEndTime.Text = string.Empty;
            lblIDValue.Text = string.Empty;
            lblStartTime.Text = string.Empty;
            lblTotalAmount.Text = string.Empty;
            lblTotalBills.Text = string.Empty;
            lblUserName.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
