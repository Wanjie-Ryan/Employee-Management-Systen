﻿using Employee_Management_Systen.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Systen
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
        }
    }
}
