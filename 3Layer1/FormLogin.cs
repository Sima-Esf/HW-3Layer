using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BL;
using DA;

namespace _3Layer1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            if (l.login(txtuser.Text, txtpass.Text.Trim()) == true)
            {
                l.permission(txtuser.Text);
                this.Visible = false;
                FormMain fm = new FormMain();
                fm.ShowDialog();
            }
            else
                MessageBox.Show("خطا در ورود به سیستم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btncansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
