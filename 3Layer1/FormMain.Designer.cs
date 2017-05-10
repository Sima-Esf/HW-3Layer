namespace _3Layer1
{
    partial class FormMain
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnchoice = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnlessen = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btncancel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncancel.Location = new System.Drawing.Point(44, 187);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(148, 34);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnchoice
            // 
            this.btnchoice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnchoice.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnchoice.Location = new System.Drawing.Point(44, 27);
            this.btnchoice.Name = "btnchoice";
            this.btnchoice.Size = new System.Drawing.Size(148, 34);
            this.btnchoice.TabIndex = 10;
            this.btnchoice.Text = "انتخاب واحد";
            this.btnchoice.UseVisualStyleBackColor = false;
            this.btnchoice.Click += new System.EventHandler(this.btnchoice_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.Color.DarkOrange;
            this.btnstudent.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnstudent.Location = new System.Drawing.Point(44, 107);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(148, 34);
            this.btnstudent.TabIndex = 12;
            this.btnstudent.Text = "اطلاعات دانشجو";
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnlessen
            // 
            this.btnlessen.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlessen.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlessen.Location = new System.Drawing.Point(44, 67);
            this.btnlessen.Name = "btnlessen";
            this.btnlessen.Size = new System.Drawing.Size(148, 34);
            this.btnlessen.TabIndex = 13;
            this.btnlessen.Text = "اطلاعات دروس";
            this.btnlessen.UseVisualStyleBackColor = false;
            this.btnlessen.Click += new System.EventHandler(this.btnlessen_Click);
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnchange.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnchange.Location = new System.Drawing.Point(44, 147);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(148, 34);
            this.btnchange.TabIndex = 11;
            this.btnchange.Text = "تغییر پسورد";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(228, 262);
            this.Controls.Add(this.btnlessen);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btnchoice);
            this.Controls.Add(this.btncancel);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.Button btnchoice;
        public System.Windows.Forms.Button btnstudent;
        public System.Windows.Forms.Button btnlessen;
        public System.Windows.Forms.Button btnchange;
    }
}