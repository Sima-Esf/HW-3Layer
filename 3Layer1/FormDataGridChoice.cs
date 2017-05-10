using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace _3Layer1
{
    public partial class FormDataGridChoice : Form
    {
        public FormDataGridChoice()
        {
            InitializeComponent();
        }

        private void FormDataGridChoice_Load(object sender, EventArgs e)
        {
            Choice ch = new Choice();
            dgvchoice.DataSource = ch.select();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            FormChoice fch = new FormChoice();
            fch.ShowDialog();
            FormDataGridChoice_Load(null, null);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string ed = dgvchoice[0, dgvchoice.CurrentRow.Index].Value.ToString();
            Choice ch = new Choice();
            ch.cid = int.Parse(ed);
            DataTable dt = ch.selectone();
            FormChoice fch = new FormChoice();
            fch.txtcid.Text = dt.Rows[0]["cid"].ToString();
            fch.txtfid.Text = dt.Rows[0]["fid"].ToString();
            fch.txtnamel.Text = dt.Rows[0]["cnamelessen"].ToString();
            fch.txtnamet.Text = dt.Rows[0]["cnameteacher"].ToString();
            fch.txtdate.Text = dt.Rows[0]["cdate"].ToString();
            fch.txtcid.ReadOnly = true;
            fch.btninsert.Text = "ویرایش";
            fch.ShowDialog();
            FormDataGridChoice_Load(null, null);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
