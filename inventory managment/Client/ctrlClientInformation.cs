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

namespace inventory_managment.Client
{
    public partial class ctrlClientInformation : UserControl
    {
        clsCLient _client;
        public clsCLient _selectedClient { get { return _client; } }
        public ctrlClientInformation()
        {
            InitializeComponent();
        }

        public void loadData(int ClientID)
        {
            _client = new clsCLient();
            this._resetData();
            if(ClientID == -1) 
            {
                return;
            }
            _client = clsCLient.find(ClientID);
            if( _client != null )
            {
                
                LoadClientInfo();
            }
            else
                MessageBox.Show("لم يتم العثور على العميل","خطأ",MessageBoxButtons.OK , MessageBoxIcon.Error );
        }

        public void _resetData()
        {
            lblClientID.Text = string.Empty;
            lblCompanyName.Text = string.Empty;
            lblRigstDate.Text = string.Empty;
            lblTotalDebt.Text = string.Empty;
            ctrlShowPersonInfo1._resetDefaultValue();
        }

        private void LoadClientInfo()
        {
            lblClientID.Text = _client.ID.ToString();
            lblCompanyName.Text = _client.CompanyName;
            lblRigstDate.Text = _client.registereDate.ToString();
            lblTotalDebt.Text =_client.TotalDebt.ToString();
            ctrlShowPersonInfo1._LoadPerson(_client.Person.PersonID);
        }

        private void ctrlClientInfo_Load(object sender, EventArgs e)
        {
            this._resetData();
        }
    }
}
