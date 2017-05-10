namespace _3Layer1
{
    partial class FormDataGridChoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.dgvchoice = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnamelessen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameteacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoice)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(32, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.DarkOrange;
            this.btndel.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Location = new System.Drawing.Point(219, 306);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(124, 34);
            this.btndel.TabIndex = 8;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnedit.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(434, 306);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(133, 34);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "ویرایش اطلاعات";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.DarkOrange;
            this.btnnew.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(652, 306);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(124, 34);
            this.btnnew.TabIndex = 6;
            this.btnnew.Text = "درس جدید";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvchoice.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvchoice.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvchoice.Location = new System.Drawing.Point(32, 26);
            this.dgvchoice.MultiSelect = false;
            this.dgvchoice.Name = "dgvchoice";
            this.dgvchoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvchoice.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvchoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchoice.Size = new System.Drawing.Size(744, 259);
            this.dgvchoice.TabIndex = 5;
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
            // FormDataGridChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(810, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.dgvchoice);
            this.Name = "FormDataGridChoice";
            this.ShowIcon = false;
            this.Text = "فرم درس";
            this.Load += new System.EventHandler(this.FormDataGridChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridView dgvchoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnamelessen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameteacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;

    }
}