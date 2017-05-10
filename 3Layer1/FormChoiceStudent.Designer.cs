namespace _3Layer1
{
    partial class FormChoiceStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvchoice = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnamelessen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameteacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcode = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvchoice
            // 
            this.dgvchoice.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvchoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.fid,
            this.cnamelessen,
            this.cnameteacher,
            this.cdate});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvchoice.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvchoice.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvchoice.Location = new System.Drawing.Point(38, 29);
            this.dgvchoice.MultiSelect = false;
            this.dgvchoice.Name = "dgvchoice";
            this.dgvchoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvchoice.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvchoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchoice.Size = new System.Drawing.Size(477, 174);
            this.dgvchoice.TabIndex = 6;
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "کد درس";
            this.cid.Name = "cid";
            this.cid.Width = 66;
            // 
            // fid
            // 
            this.fid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "کد رشته";
            this.fid.Name = "fid";
            this.fid.Width = 70;
            // 
            // cnamelessen
            // 
            this.cnamelessen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnamelessen.DataPropertyName = "cnamelessen";
            this.cnamelessen.HeaderText = "نام درس";
            this.cnamelessen.Name = "cnamelessen";
            // 
            // cnameteacher
            // 
            this.cnameteacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnameteacher.DataPropertyName = "cnameteacher";
            this.cnameteacher.HeaderText = "نام استاد";
            this.cnameteacher.Name = "cnameteacher";
            // 
            // cdate
            // 
            this.cdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdate.DataPropertyName = "cdate";
            this.cdate.HeaderText = "ساعت کلاسی";
            this.cdate.Name = "cdate";
            // 
            // dgvcode
            // 
            this.dgvcode.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lid});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcode.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcode.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvcode.Location = new System.Drawing.Point(38, 280);
            this.dgvcode.MultiSelect = false;
            this.dgvcode.Name = "dgvcode";
            this.dgvcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvcode.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcode.Size = new System.Drawing.Size(477, 164);
            this.dgvcode.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("B Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtid.Location = new System.Drawing.Point(270, 229);
            this.txtid.Name = "txtid";
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.Size = new System.Drawing.Size(172, 26);
            this.txtid.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(446, 229);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "کد درس :";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.DarkOrange;
            this.btninsert.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btninsert.Location = new System.Drawing.Point(156, 227);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(93, 30);
            this.btninsert.TabIndex = 31;
            this.btninsert.Text = "ثبت";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.DarkOrange;
            this.btndel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Location = new System.Drawing.Point(38, 225);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 30);
            this.btndel.TabIndex = 32;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btncancel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncancel.Location = new System.Drawing.Point(38, 472);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(93, 30);
            this.btncancel.TabIndex = 33;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lid
            // 
            this.lid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lid.DataPropertyName = "lid";
            this.lid.HeaderText = "کد درس";
            this.lid.Name = "lid";
            // 
            // FormChoiceStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(555, 514);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcode);
            this.Controls.Add(this.dgvchoice);
            this.Name = "FormChoiceStudent";
            this.ShowIcon = false;
            this.Text = "فرم انتخاب واحد";
            this.Load += new System.EventHandler(this.FormChoiceStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvchoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnamelessen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameteacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;
        private System.Windows.Forms.DataGridView dgvcode;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btninsert;
        public System.Windows.Forms.Button btndel;
        public System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn lid;
    }
}