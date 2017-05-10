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
    public partial class FormChangePass : Form
    {
        public FormChangePass()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            DataTable dt = new DataTable();
        }

        private void btncansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
