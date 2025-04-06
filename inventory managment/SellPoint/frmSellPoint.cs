using inventory_managment_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.SellPoint
{
    public partial class frmSellPoint : Form
    {
        enum enMode { MainSellPoint = 1 , NewBill = 2}

        enMode _mode;
        clsUser _user;

        int _sellerID;

        clsSellPoint _seller;

        clsBill _CurrentBill;


        List<clsSold> _soldList;

        clsCLient _client;

        DataTable _dtStocks;

        DataTable _dtBillItems;

        int _userID;


        public frmSellPoint(int UserID , int SellPointID)
        {
            InitializeComponent();
            _userID = UserID;
            if(SellPointID == -1 )
            {
                _mode = enMode.MainSellPoint;
            }
            else
            {
                _mode = enMode.NewBill;
                _sellerID = SellPointID;
            }
            _seller = new clsSellPoint();
          
            _dtStocks = new DataTable();
            _dtBillItems = new DataTable();
            _CurrentBill = new clsBill();
            _client = new clsCLient();
            _user = new clsUser();
            _soldList = new List<clsSold>();
            


        }



        private bool _setToDefualtClient()
        {
            _client = clsCLient.find(1);
            return _client != null;
        }

 
        private void frmSellPoint_Load(object sender, EventArgs e)
        {
            if (_setToDefualtClient()) {
                _user = clsUser.Find(_userID);

                if (_user != null)
                {

                    if (_mode == enMode.MainSellPoint)
                    {
                        _seller = new clsSellPoint();
                        _seller.Start = DateTime.Now;
                        _seller.End = DateTime.Now;
                        _seller.Amount = 0;
                        _seller.user = _user;
                    }
                    else
                    {
                        _seller = clsSellPoint.find(_sellerID);
                    }
                   

                    if (_seller.save())
                    {
                        _CurrentBill = new clsBill();
                        _CurrentBill.totalPrice = 0;
                        _CurrentBill.PaidPrice = 0;
                        _CurrentBill.IssueDate = DateTime.Now;
                        _CurrentBill.Client = _client;
                        _CurrentBill.SellPoint = _seller;
                        if(_CurrentBill.save())
                        {
                            _loadPage();
                            cbFilterBy.SelectedIndex = 1;
                            tbFilter.Focus();
                        }
                    }
                }
            }
        }

        private void _loadPage()
        {
            lblBillID.Text = _CurrentBill.ID.ToString();
            lblClientName.Text = _client.CompanyName.ToString();
            lblUserName.Text = _user.person.FullName;
            ReLoadSearch();

        }

        private void ReLoadSearch()
        {
            _dtStocks = clsStock.GetAllShortened();
            dgvSearch.DataSource = _dtStocks;
            if (dgvSearch.RowCount > 0)
            {
                dgvSearch.Columns[0].Width = 80;

                dgvSearch.Columns[1].Width = 300;

                dgvSearch.Columns[2].Width = 180;

                dgvSearch.Columns[3].Width = 150;


            }
        }

        private void resetDefault()
        {
            if (_setToDefualtClient())
            {
                _CurrentBill = new clsBill();
                _CurrentBill.totalPrice = 0;
                _CurrentBill.PaidPrice = 0;
                _CurrentBill.IssueDate = DateTime.Now;
                _CurrentBill.Client = _client;
                _CurrentBill.SellPoint = _seller;
                if (_CurrentBill.save())
                {
                    _loadPage();
                    cbFilterBy.SelectedIndex = 1;
                    tbFilter.Focus();
                }
                _soldList.Clear();
                loadBillItems();

            }
        }

        public static DataTable ConvertToDataTableForDisplay(List<clsSold> items)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("اسم المنتج", typeof(string));
            dt.Columns.Add("الكمية", typeof(int));
            dt.Columns.Add("السعر للوحدة", typeof(decimal));
            dt.Columns.Add("السعر الإجمالي", typeof(decimal));

            foreach (var item in items)
            {
                string productName = item.Stock?.Product?.Name ?? "غير معروف";
                int quantity = item.quantity;
                decimal pricePerOne = item.PricePerOne.Value;
                decimal totalPrice = item.TotalPrice.Value;

                dt.Rows.Add(productName, quantity, pricePerOne, totalPrice);
            }

            return dt;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            if (dgvSearch.RowCount > 0)
            {
                
                _dtStocks.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, tbFilter.Text.Trim());
                
            }
            if (tbFilter.Text == "")
            {
                _dtStocks.DefaultView.RowFilter = "";
            }
        }

        int CalculateBillTotalPrice()
        {
            int Price = 0;
            foreach (var item in _soldList)
            {


                Price += (int)item.TotalPrice;



            }

            return Price;



        }
        int CalculateBillTotalPieces()
        {
            int quantity = 0;
            foreach (var item in _soldList)
            {


                quantity += (int)item.quantity;



            }

            return quantity;
        }

        private void loadBillItems()
        {
            _dtBillItems = ConvertToDataTableForDisplay(_soldList);
            dgvCurrentSolds.DataSource = _dtBillItems;
            if (dgvCurrentSolds.RowCount > 0)
            {
                dgvCurrentSolds.Columns[0].Width = 250;

                dgvCurrentSolds.Columns[1].Width = 80;

                dgvCurrentSolds.Columns[2].Width = 180;

                dgvCurrentSolds.Columns[3].Width = 150;
                lbltotalCount.Text = CalculateBillTotalPrice().ToString() ;
                lblPiecesCount.Text = CalculateBillTotalPieces().ToString();
            }

        }

        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSearch.RowCount > 0)
            {
                clsSold newsold = new clsSold();
                newsold.Bill = _CurrentBill;
                newsold.PricePerOne = new SqlMoney((decimal)dgvSearch.CurrentRow.Cells[3].Value);
                newsold.Stock = clsStock.Find((int)dgvSearch.CurrentRow.Cells[0].Value);
                newsold.quantity = 1;
                newsold.Stock.CurrentQuantity -= newsold.quantity;
                newsold.TotalPrice = newsold.PricePerOne * newsold.quantity;

                if (newsold.save())
                {
                    _soldList.Add(newsold);
                    loadBillItems();
                    ReLoadSearch();
                    tbFilter.Focus();
                    cbFilterBy.SelectedIndex = 1;
                }
            }
                
            
        }

        private void Addbill_Click(object sender, EventArgs e)
        {
            _CurrentBill.totalPrice =new SqlMoney(CalculateBillTotalPrice());
            _CurrentBill.Client = _client;
            _CurrentBill.IssueDate = DateTime.Now;
            
            if(_CurrentBill.Client.ID == 1 && _user.role == 1)
            {
                _CurrentBill.PaidPrice = _CurrentBill.totalPrice;
            }
            else
            {
                frmPayTheBill payTheBill = new frmPayTheBill();
                payTheBill.ShowDialog();
                _CurrentBill.PaidPrice = payTheBill.Paid;
            }
            if(_CurrentBill.save())
            {
                MessageBox.Show("تم حفظ الفاتورة بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetDefault();
                return;
            }
            MessageBox.Show("حصل خطأ اثناء حفظ الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

    

        private void frmSellPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_soldList.Count > 0)
            {

                foreach (var item in _soldList)
                {

                    if (clsSold.delete(item.ID))
                    {
                        item.Stock = clsStock.Find(item.Stock.ID);
                        item.Stock.CurrentQuantity += item.quantity;
                        item.Stock.save();


                    }
                }
                _soldList.Clear();
            }
            clsBill.delete(_CurrentBill.ID);
            if (_mode == enMode.MainSellPoint)
            {
                _seller.TotoalBills = clsSellPoint.GetTotalBills(_seller.ID);

                _seller.Amount = new SqlMoney(clsSellPoint.GetTotalAmount(_seller.ID));
                _seller.End = DateTime.Now;
                if (_seller.TotoalBills == 0)
                {
                    clsSellPoint.Delete(_seller.ID);
                }
                else
                {
                    _seller.save();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_soldList.Count > 0)
            {

                foreach (var item in _soldList)
                {

                    if (clsSold.delete(item.ID))
                    {
                        item.Stock = clsStock.Find(item.Stock.ID);
                        item.Stock.CurrentQuantity += item.quantity;
                        item.Stock.save();


                    }
                }
                _soldList.Clear();
                loadBillItems();
                ReLoadSearch();
            }
        }

        private void btnPublicClientBack_Click(object sender, EventArgs e)
        {
            _setToDefualtClient();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            frmSellPoint frm = new frmSellPoint(_userID, _seller.ID);
            frm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvCurrentSolds.RowCount == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void tmsDelete_Click(object sender, EventArgs e)
        {
            clsSold item = new clsSold();
           item = _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index);
            if (item != null)
            {
                if (clsSold.delete(item.ID))
                {
                    item.Stock = clsStock.Find(item.Stock.ID);
                    item.Stock.CurrentQuantity += item.quantity;
                    item.Stock.save();
                    _soldList.RemoveAt(dgvCurrentSolds.CurrentRow.Index);
                    loadBillItems();
                    ReLoadSearch();
                }
                else
                {
                    MessageBox.Show("حصل خطأ اثناء حذف العنصر من الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tmsEditQuantity_Click(object sender, EventArgs e)
        {
            int QuantityWanted;
            
            frmEditQuantity frm = new frmEditQuantity();
            frm.ShowDialog();
            QuantityWanted = frm.Quantity;

            int CurrentStockQuantity = _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).Stock.CurrentQuantity;
            int CurrentSoldQuantity = _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).quantity;
            if (CurrentSoldQuantity < QuantityWanted)
            {
                if (QuantityWanted > CurrentStockQuantity)
                {
                    int QuantityOutOfRange = 0;
                    string ProductGTIN = _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).Stock.Product.GTIN;
                    QuantityOutOfRange = QuantityWanted - CurrentStockQuantity;

                    _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).quantity += CurrentStockQuantity;
                    _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).Stock.CurrentQuantity = 0;
                    _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).save();

                    loadBillItems();
                    ReLoadSearch();


                    foreach (DataGridViewRow row in dgvSearch.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string rowProductGTIN = row.Cells["الرقم العالمي"].Value.ToString();

                        if (rowProductGTIN != ProductGTIN)
                            continue;

                        int stockID = Convert.ToInt32(row.Cells["الرقم"].Value);
                        clsStock stock = clsStock.Find(stockID); // لازم تكون عندك دالة Find
                        if (stock == null || stock.CurrentQuantity < QuantityOutOfRange)
                        {
                            MessageBox.Show("الكمية التي ادخلتها اكبر من الكمية المتوفرة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        clsSold newSold = new clsSold();
                        newSold.Stock = stock;
                        newSold.Bill = _CurrentBill;
                        newSold.quantity = QuantityOutOfRange;
                        newSold.PricePerOne = stock.SellPrice;
                        newSold.TotalPrice = newSold.PricePerOne * newSold.quantity;
                        newSold.Stock.CurrentQuantity = newSold.Stock.CurrentQuantity - QuantityOutOfRange;

                        if (newSold.save())
                        {
                            _soldList.Add(newSold);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("الكمية التي ادخلتها اكبر من الكمية المتوفرة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }




                    }


                }
                else
                {

                    _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).quantity = QuantityWanted;
                    _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).Stock.CurrentQuantity -= QuantityWanted - 1;
                    _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).save();

                }
            }
            else
            {
                int OverFlowQuantity = _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).quantity - QuantityWanted;
                _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).quantity = QuantityWanted;
                _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).Stock.CurrentQuantity += OverFlowQuantity;
                _soldList.ElementAt(dgvCurrentSolds.CurrentRow.Index).save();
            }
            loadBillItems();
            ReLoadSearch();
        }

        private void frmSellPoint_MouseMove(object sender, MouseEventArgs e)
        {
            tbFilter.Focus();
        }

        private void btnChangeClient_Click(object sender, EventArgs e)
        {
            frmSelectClient frm = new frmSelectClient();
            frm.ShowDialog();
            this._client = clsCLient.find(frm.ClientId);
            lblClientName.Text = _client.CompanyName;
        }
    }
}
