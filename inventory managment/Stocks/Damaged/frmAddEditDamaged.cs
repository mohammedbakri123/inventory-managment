using inventory_managment_business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.Damaged
{
    public partial class frmAddEditDamaged : Form
    {
        enum enMode { Add = 1 , Update = 2 }

        enMode _mode;

        int _DamagedID;

        clsDamaged _Damaged;

       

        

        public frmAddEditDamaged(int DamagedID, int stockID)
        {
            InitializeComponent();
            _DamagedID = DamagedID;
            if (DamagedID == -1)
            {
                _mode = enMode.Add;
                _Damaged = new clsDamaged();
                _Damaged.DamagedStock = clsStock.Find(stockID);
                lblAddEdit.Text = "اضافة تالف";
            }
            else
            {
                _mode = enMode.Update;
                _Damaged = clsDamaged.Find(DamagedID);
                lblAddEdit.Text = "تعديل تالف";

            }
        }

        private void frmAddEditDamaged_Load(object sender, EventArgs e)
        {
            _resetDamaged();
            if(_mode == enMode.Add)
            {
                if(_Damaged.DamagedStock == null)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                _loadStockInfo();
            }
            else
            {
                if (_Damaged == null)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                _loadDamaged();
            }
        }
        void _loadDamaged()
        {
            lblDamagedIDValue.Text = _Damaged.ID.ToString();
            _loadStockInfo();
            numQuantity.Value = _Damaged.Quantity;
            rtbResons.Text = _Damaged.Resons ;
            dtpDamagedDate.Value = _Damaged.Date;
        }

        void _loadStockInfo()
        {
            lblStockIDValue.Text = _Damaged.DamagedStock.ID.ToString();
            lblProductIDValue.Text = _Damaged.DamagedStock.Product.ID.ToString();
            lblProductName.Text = _Damaged.DamagedStock.Product.Name;
            if (_mode == enMode.Add)
            {
                numQuantity.Maximum = _Damaged.DamagedStock.CurrentQuantity;
            }
            else
            {
                numQuantity.Maximum = _Damaged.DamagedStock.CurrentQuantity + _Damaged.Quantity;

            }
        }

        void _resetDamaged()
        {
            lblDamagedIDValue.Text = "؟؟؟؟";
            lblStockIDValue.Text = "؟؟؟؟";
            lblProductIDValue.Text = "؟؟؟؟";
            lblProductName.Text = "؟؟؟؟";
            numQuantity.Value = 0;
            rtbResons.Text = "";
            dtpDamagedDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_mode == enMode.Add)
            {
                _Damaged.DamagedStock.CurrentQuantity -= (int)numQuantity.Value;
            }
            else
            {
                if (_Damaged.Quantity != (int)numQuantity.Value)
                {
                    _Damaged.DamagedStock.CurrentQuantity += (_Damaged.Quantity - (int)numQuantity.Value);
                }
                
            }
            _Damaged.Quantity = (int)numQuantity.Value;
            _Damaged.Date = dtpDamagedDate.Value;
            _Damaged.Resons = rtbResons.Text;
            if(_Damaged.save())
            {
                _mode = enMode.Update;
                lblAddEdit.Text = "تعديل تالف";
                lblDamagedIDValue.Text = _Damaged.ID.ToString() ;
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnCLose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
