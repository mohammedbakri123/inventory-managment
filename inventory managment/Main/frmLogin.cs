using inventory_managment.Global;
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

namespace inventory_managment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(clsUser.IsUserExist(tbUserName.Text , tbPassword.Text)) {
                clsGlobal.crruntUser = clsUser.Find(tbUserName.Text, tbPassword.Text);
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة", "خطأ",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
