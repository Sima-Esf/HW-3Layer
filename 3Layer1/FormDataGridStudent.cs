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
    public partial class FormDataGridStudent : Form
    {
        public FormDataGridStudent()
        {
            InitializeComponent();
        }

        private void FormDataGridStudent_Load(object sender, EventArgs e)
        {
            Student s = new Student();
            dgvstu.DataSource = s.select();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.ShowDialog();
            FormDataGridStudent_Load(null, null);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string ed = dgvstu[0, dgvstu.CurrentRow.Index].Value.ToString();
            Student s = new Student();
            s.stid = int.Parse(ed);
            DataTable dt = s.selectone();
            FormStudent fs = new FormStudent();
            fs.txtid.Text = dt.Rows[0]["stid"].ToString();
            fs.txtname.Text = dt.Rows[0]["stname"].ToString();
            fs.txtfamily.Text = dt.Rows[0]["stfamily"].ToString();
            fs.txtaddress.Text = dt.Rows[0]["staddress"].ToString();
            fs.txttell.Text = dt.Rows[0]["sttell"].ToString();
            fs.txtgender.Text = dt.Rows[0]["stgender"].ToString();
            fs.txtfield.Text = dt.Rows[0]["fid"].ToString();
            fs.txtid.ReadOnly = true;
            fs.btninsert.Text = "ویرایش";
            fs.ShowDialog();
            FormDataGridStudent_Load(null, null);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int del = int.Parse(dgvstu[0, dgvstu.CurrentRow.Index].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("آیا می خواهید این دانشجو حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Student s = new Student();
                s.stid = del;
                s.delete();
                MessageBox.Show("اطلاعات دانشجو با موفقیت حذف شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDataGridStudent_Load(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
