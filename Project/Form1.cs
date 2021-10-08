﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Project
{
    public partial class frmLogin : Form
    {
        public bool NewUser = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            
        }

        private void cbxNUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNUser.Checked == true)
            {
                tbxConPassword.Enabled = true;
                tbxConPassword.Visible = true;
                lblConPass.Visible = true;

                btnLogIn.Text = "Create User and Log In";
                NewUser = true;
            }
            else
            if (cbxNUser.Checked == false)
            {
                tbxConPassword.Enabled = false;
                tbxConPassword.Visible = false;
                lblConPass.Visible = false;

                btnLogIn.Text = "Log In";
                NewUser = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (NewUser == true)
            {
                string NameEn = tbxUsername.Text;
                string PassEn = tbxPassword.Text;
                string PassConEn = tbxConPassword.Text;

                if (NameEn.Contains(" ")||NameEn.Contains(",")|| NameEn.Length == 0)
                {
                    lblOutput.Text = "That is the wrong answer, you will perish mortal!";
                }
            }
        }
    }
}
