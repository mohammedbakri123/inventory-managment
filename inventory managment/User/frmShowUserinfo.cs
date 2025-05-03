﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_managment_business;

namespace inventory_managment.User
{
    public partial class frmShowUserinfo : Form
    {
        int _UserID = -1;
        public int userID { get { return _UserID; } }



        public frmShowUserinfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmShowUserinfo_Load(object sender, EventArgs e)
        {
            ctrlShowUserInfo1.LoadUser(_UserID);
        }
    }
}
