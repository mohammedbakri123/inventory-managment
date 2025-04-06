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

namespace inventory_managment.Client.payment
{
    public partial class frmAddPayment : Form
    {
        enum enMode { Add = 1, Update = 2 }

        enMode _mode;
        int ClientID;
        int PaymentID;
        clsPayment _payment;
        clsCLient _client;

        public frmAddPayment(int ClientID , int PaymentID)
        {
            InitializeComponent();
            this.ClientID = ClientID;
            this.PaymentID = PaymentID;
            _payment = new clsPayment();
            _mode = enMode.Add;
            
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            if(this.PaymentID == -1)
            {
                this.restData();
                ctrlClientInformation1.loadData(ClientID);

            }
            else
            {
                _payment = clsPayment.Find(PaymentID);
                if (_payment != null)
                {
                    _mode = enMode.Update;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على هذا الايصال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void restData()
        {
            ctrlClientInformation1._resetData();
            lblPaymentID.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            tbAmount.Text = string.Empty;
            rtbNotes.Text = string.Empty;

        }

        void LoadData()
        {
            ctrlClientInformation1.loadData(this.ClientID);
            lblPaymentID.Text = _payment.ID.ToString();
            dtpDate.Value = _payment.Date;
            tbAmount.Text = _payment.Amount.ToString();
            rtbNotes.Text = _payment.note;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void reCalculateClientDebt()
        {
            if(_mode == enMode.Add)
            {
                _client.TotalDebt -= int.Parse(tbAmount.Text);
            }
            else
            {  
                    _client.TotalDebt -= (int.Parse(tbAmount.Text) - _payment.Amount);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _client = clsCLient.find(ClientID);
            reCalculateClientDebt();
            if (_client.save())
            {
                _payment.Date = dtpDate.Value;
                _payment.note = rtbNotes.Text;
                _payment.Amount = int.Parse(tbAmount.Text);
                _payment.client = _client;

                if (_payment.save())
                {
                    MessageBox.Show("تم حفظ الايصال بنجاح","تمت العملية",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPaymentID.Text = _payment.ID.ToString();
                    lblCkientinfo.Text = "تعديل قيمة الايصال";
                    _mode = enMode.Update;

                    return;
                }
                MessageBox.Show("لم يتم حفظ ايصال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("تم خصم المبلغ من اجمالي ديون الزبون", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                MessageBox.Show("لم يتم خصم المبلغ من اجمالي ديون الزبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
