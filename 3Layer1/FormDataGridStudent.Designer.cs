namespace _3Layer1
{
    partial class FormDataGridStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvstu = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.stid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstu
            // 
            this.dgvstu.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stid,
            this.stname,
            this.stfamily,
            this.stadress,
            this.sttell,
            this.stgender,
            this.fid});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvstu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvstu.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvstu.Location = new System.Drawing.Point(41, 28);
            this.dgvstu.Name = "dgvstu";
            this.dgvstu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvstu.Size = new System.Drawing.Size(875, 264);
            this.dgvstu.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(41, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.DarkOrange;
            this.btndel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Location = new System.Drawing.Point(263, 314);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(140, 34);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "حذف اطلاعات";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnedit.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(524, 314);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(143, 34);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "ویرایش اطلاعات";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.DarkOrange;
            this.btnnew.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(780, 314);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(136, 34);
            this.btnnew.TabIndex = 10;
            this.btnnew.Text = "دانشجو جدید";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // stid
            // 
            this.stid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stid.DataPropertyName = "stid";
            this.stid.HeaderText = "شماره دانشجویی";
            this.stid.Name = "stid";
            this.stid.Width = 103;
            // 
            // stname
            // 
            this.stname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stname.DataPropertyName = "stname";
            this.stname.HeaderText = "نام";
            this.stname.Name = "stname";
            this.stname.Width = 45;
            // 
            // stfamily
            // 
            this.stfamily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stfamily.DataPropertyName = "stfamily";
            this.stfamily.HeaderText = "نام خانوادگی";
            this.stfamily.Name = "stfamily";
            this.stfamily.Width = 87;
            // 
            // stadress
            // 
            this.stadress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stadress.DataPropertyName = "staddress";
            this.stadress.HeaderText = "آدرس";
            this.stadress.Name = "stadress";
            // 
            // sttell
            // 
            this.sttell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sttell.DataPropertyName = "sttell";
            this.sttell.HeaderText = "تلفن";
            this.sttell.Name = "sttell";
            this.sttell.Width = 51;
            // 
            // stgender
            // 
            this.stgender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stgender.DataPropertyName = "stgender";
            this.stgender.HeaderText = "جنسیت";
            this.stgender.Name = "stgender";
            this.stgender.Width = 64;
            // 
            // fid
            // 
            this.fid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "کد رشته";
            this.fid.Name = "fid";
            this.fid.Width = 65;
            // 
            // FormDataGridStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(965, 379);
            this.Controls.Add(this.dgvstu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Name = "FormDataGridStudent";
            this.ShowIcon = false;
            this.Text = "فرم دانشجو";
            this.Load += new System.EventHandler(this.FormDataGridStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvstu;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btndel;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn stid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttell;
        private System.Windows.Forms.DataGridViewTextBoxColumn stgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
    }
}