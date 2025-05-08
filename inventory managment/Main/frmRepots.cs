using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment.Main
{
    public partial class frmRepots : Form
    {
        public frmRepots()
        {
            InitializeComponent();
        }

        private void frmRepots_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbDays.Visible = false;
            cbMonth.Visible = false;
            cbYear.Visible = false;

        }


        void fillYearsCompoBox()
        {

            DateTime date = DateTime.Now.AddYears(-29);
            cbYear.Items.Clear();
            for(int i = 0; i < 30; i++)
            {
                cbYear.Items.Add(date.Year.ToString());
                date = date.AddYears(1);
            }
        }

        void fillMonthsComboBox()
        {
            DateTime data = Convert.ToDateTime("1/1/1");
            cbMonth.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
               
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
            {
                cbDays.Visible = false;
                cbMonth.Visible = false;
                cbYear.Visible = false;
            }
            else if(cbFilterBy.SelectedIndex == 1) 
            {
                cbYear.Visible = true;
                cbMonth.Visible = false;
                cbDays.Visible = false;
                fillYearsCompoBox();
                cbYear.SelectedIndex = 29;

            }
            else if( cbFilterBy.SelectedIndex == 2)
            {
                cbYear.Visible = true;
                cbMonth.Visible = true;
                cbDays.Visible = false;
            }
            else if (cbFilterBy.SelectedIndex == 3)
            {
                cbYear.Visible = true;
                cbMonth.Visible = true;
                cbDays.Visible = true;
            }
        }

      
    }
}
