namespace _3Layer1
{
    partial class FormChangePass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncansel = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtchangepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("B Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtpass.Location = new System.Drawing.Point(44, 59);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpass.Size = new System.Drawing.Size(193, 26);
            this.txtpass.TabIndex = 31;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("B Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtuser.Location = new System.Drawing.Point(44, 27);
            this.txtuser.Name = "txtuser";
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtuser.Size = new System.Drawing.Size(193, 26);
            this.txtuser.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(243, 59);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "رمز عبور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(243, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "نام کاربری :";
            // 
            // btncansel
            // 
            this.btncansel.BackColor = System.Drawing.Color.DarkOrange;
            this.btncansel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncansel.Location = new System.Drawing.Point(46, 138);
            this.btncansel.Name = "btncansel";
            this.btncansel.Size = new System.Drawing.Size(93, 35);
            this.btncansel.TabIndex = 33;
            this.btncansel.Text = "انصراف";
            this.btncansel.UseVisualStyleBackColor = false;
            this.btncansel.Click += new System.EventHandler(this.btncansel_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.DarkOrange;
            this.btninsert.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btninsert.Location = new System.Drawing.Point(145, 138);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(93, 35);
            this.btninsert.TabIndex = 32;
            this.btninsert.Text = "ثبت";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtchangepass
            // 
            this.txtchangepass.Font = new System.Drawing.Font("B Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtchangepass.Location = new System.Drawing.Point(45, 91);
            this.txtchangepass.Name = "txtchangepass";
            this.txtchangepass.PasswordChar = '*';
            this.txtchangepass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtchangepass.Size = new System.Drawing.Size(193, 26);
            this.txtchangepass.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(244, 91);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "تغییر رمز عبور :";
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(371, 201);
            this.Controls.Add(this.txtchangepass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncansel);
            this.Controls.Add(this.btninsert);
            this.Name = "FormChangePass";
            this.ShowIcon = false;
            this.Text = "فرم تغییر رمز عبور";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btncansel;
        public System.Windows.Forms.Button btninsert;
        public System.Windows.Forms.TextBox txtchangepass;
        private System.Windows.Forms.Label label3;
    }
}