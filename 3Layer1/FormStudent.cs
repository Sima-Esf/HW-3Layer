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

namespace _3Layer1
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.stid = int.Parse(txtid.Text);
            s.stname = txtname.Text;
            s.stfamily = txtfamily.Text;
            s.staddress = txtaddress.Text;
            s.sttell = int.Parse(txttell.Text);
            s.stgender = txtgender.Text;
            s.fid = int.Parse(txtfield.Text);

            if (txtid.ReadOnly == false)
            {
                s.insert();
                MessageBox.Show("دانشجو جدید با موفقیت ثبت شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                s.update();
                MessageBox.Show("اطلاعات دانشجو با موفقیت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void txtfamily_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }
    }
}
