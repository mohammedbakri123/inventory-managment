using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.Client
{
    public partial class frmShowClientInfo : Form
    {
        int _ClientID;
        public frmShowClientInfo(int ID)
        {
            InitializeComponent();
            _ClientID = ID;

        }

        private void frmShowClientInfo_Load(object sender, EventArgs e)
        {
            ctrlClientInformation1.loadData(this._ClientID);
        }
    }
}
