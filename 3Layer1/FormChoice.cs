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
    public partial class FormChoice : Form
    {
        public FormChoice()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Choice ch = new Choice();
            ch.cid = int.Parse(txtcid.Text);
            ch.fid = int.Parse(txtfid.Text);
            ch.cnamelessen = txtnamel.Text;
            ch.cnameteacher = txtnamet.Text;
            ch.cdate = txtdate.Text;

            if (txtcid.ReadOnly == false)
            {
                ch.insert();
                MessageBox.Show("درس جدید با موفقیت ثبت شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ch.update();
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnamel_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void txtnamet_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }
    }
}
