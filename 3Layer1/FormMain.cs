using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA;
using BL;

namespace _3Layer1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnchoice.Enabled = Login.lup1;
            btnlessen.Enabled = Login.lup2;
            btnstudent.Enabled = Login.lup3;
            btnchange.Enabled = Login.lup4;
        }

        private void btnchoice_Click(object sender, EventArgs e)
        {
            FormChoiceStudent fchs = new FormChoiceStudent();
            fchs.ShowDialog();
        }

        private void btnlessen_Click(object sender, EventArgs e)
        {
            FormDataGridChoice fch = new FormDataGridChoice();
            fch.ShowDialog();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            FormDataGridStudent fs = new FormDataGridStudent();
            fs.ShowDialog();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            FormChangePass fchp = new FormChangePass();
            fchp.ShowDialog();
        }
    }
}
