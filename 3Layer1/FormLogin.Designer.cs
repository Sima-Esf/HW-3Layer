namespace _3Layer1
{
    partial class FormLogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("B Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtpass.Location = new System.Drawing.Point(40, 58);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpass.Size = new System.Drawing.Size(193, 26);
            this.txtpass.TabIndex = 1;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("B Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtuser.Location = new System.Drawing.Point(40, 26);
            this.txtuser.Name = "txtuser";
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtuser.Size = new System.Drawing.Size(193, 26);
            this.txtuser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(239, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "رمز عبور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "نام کاربری :";
            // 
            // btncansel
            // 
            this.btncansel.BackColor = System.Drawing.Color.DarkOrange;
            this.btncansel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncansel.Location = new System.Drawing.Point(42, 102);
            this.btncansel.Name = "btncansel";
            this.btncansel.Size = new System.Drawing.Size(93, 35);
            this.btncansel.TabIndex = 3;
            this.btncansel.Text = "انصراف";
            this.btncansel.UseVisualStyleBackColor = false;
            this.btncansel.Click += new System.EventHandler(this.btncansel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlogin.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlogin.Location = new System.Drawing.Point(141, 102);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(93, 35);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "ورود";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(354, 162);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncansel);
            this.Controls.Add(this.btnlogin);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.Text = "فرم ورود به سیستم";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btncansel;
        public System.Windows.Forms.Button btnlogin;
    }
}