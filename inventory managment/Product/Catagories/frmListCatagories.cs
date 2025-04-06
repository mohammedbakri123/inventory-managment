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

namespace inventory_managment.Product.Catagories
{
    public partial class frmListCatagories : Form
    {
        DataTable _dtCatagories;
        public frmListCatagories()
        {
            InitializeComponent();
        }

        private void frmListCatagories_Load(object sender, EventArgs e)
        {
            _dtCatagories = clsCatagory.GetAll();
            dgvCatagories.DataSource = _dtCatagories;
            lblRecordCount.Text = dgvCatagories.RowCount.ToString();

            dgvCatagories.Columns[0].HeaderText = "الرقم";

            dgvCatagories.Columns[0].Width = 80;

            dgvCatagories.Columns[1].HeaderText = "التسمية";

            dgvCatagories.Columns[1].Width = 210;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmsDelete_Click(object sender, EventArgs e)
        {
            if (clsCatagory.Delete((int)dgvCatagories.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("تم حذف النوع بنجاج", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.frmListCatagories_Load(null, null);
                return;
            }
            MessageBox.Show("تأكد من عدم وجود منتجات من هذا النوع", "حصل خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tmsUpdate_Click(object sender, EventArgs e)
        {
            frmAddEditCatagory frm = new frmAddEditCatagory((int)dgvCatagories.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            this.frmListCatagories_Load(null, null);

        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCatagory frm = new frmAddEditCatagory(-1);
            frm.ShowDialog();
            this.frmListCatagories_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCatagory frm = new frmAddEditCatagory(-1);
            frm.ShowDialog();
            this.frmListCatagories_Load(null, null);
        }
    }
}
