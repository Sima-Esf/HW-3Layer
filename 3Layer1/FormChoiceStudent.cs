using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DA;
using BL;

namespace _3Layer1
{
    public partial class FormChoiceStudent : Form
    {
        public FormChoiceStudent()
        {
            InitializeComponent();
        }

        private void FormChoiceStudent_Load(object sender, EventArgs e)
        {
            Choice ch = new Choice();
            dgvchoice.DataSource = ch.select();

            Lessen l = new Lessen();
            dgvcode.DataSource = l.select();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {   
            Lessen l = new Lessen();
            l.lid = int.Parse(txtid.Text);
            l.insert();
            MessageBox.Show("درس جدید با موفقیت ثبت شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormChoiceStudent_Load(null, null);
            return;
            
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int del = int.Parse(dgvcode[0, dgvcode.CurrentRow.Index].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("آیا می خواهید این درس حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Lessen l = new Lessen();
                l.lid = del;
                l.delete();
                MessageBox.Show("درس با موفقیت حذف شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormChoiceStudent_Load(null, null);
            }
        }
    }
}
