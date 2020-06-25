namespace StudentManage
{
    partial class StudentListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDep = new System.Windows.Forms.Label();
            this.LblClass = new System.Windows.Forms.Label();
            this.TxtStuNo = new System.Windows.Forms.TextBox();
            this.TxtStuName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboSex = new System.Windows.Forms.ComboBox();
            this.CboClass = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnRefersh = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.DGVStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboDep = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "院系：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDep);
            this.groupBox1.Controls.Add(this.LblClass);
            this.groupBox1.Controls.Add(this.TxtStuNo);
            this.groupBox1.Controls.Add(this.TxtStuName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboSex);
            this.groupBox1.Location = new System.Drawing.Point(745, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // LblDep
            // 
            this.LblDep.AutoSize = true;
            this.LblDep.Location = new System.Drawing.Point(119, 48);
            this.LblDep.Name = "LblDep";
            this.LblDep.Size = new System.Drawing.Size(23, 15);
            this.LblDep.TabIndex = 17;
            this.LblDep.Text = "  ";
            // 
            // LblClass
            // 
            this.LblClass.AutoSize = true;
            this.LblClass.Location = new System.Drawing.Point(328, 48);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(23, 15);
            this.LblClass.TabIndex = 16;
            this.LblClass.Text = "  ";
            // 
            // TxtStuNo
            // 
            this.TxtStuNo.Location = new System.Drawing.Point(122, 99);
            this.TxtStuNo.Name = "TxtStuNo";
            this.TxtStuNo.Size = new System.Drawing.Size(280, 25);
            this.TxtStuNo.TabIndex = 0;
            // 
            // TxtStuName
            // 
            this.TxtStuName.Location = new System.Drawing.Point(122, 173);
            this.TxtStuName.Name = "TxtStuName";
            this.TxtStuName.Size = new System.Drawing.Size(280, 25);
            this.TxtStuName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "院系";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "班级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "学生ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // CboSex
            // 
            this.CboSex.FormattingEnabled = true;
            this.CboSex.Location = new System.Drawing.Point(122, 249);
            this.CboSex.Name = "CboSex";
            this.CboSex.Size = new System.Drawing.Size(280, 23);
            this.CboSex.TabIndex = 3;
            // 
            // CboClass
            // 
            this.CboClass.FormattingEnabled = true;
            this.CboClass.Location = new System.Drawing.Point(370, 45);
            this.CboClass.Name = "CboClass";
            this.CboClass.Size = new System.Drawing.Size(206, 23);
            this.CboClass.TabIndex = 4;
            this.CboClass.SelectedIndexChanged += new System.EventHandler(this.CboClass_SelectedIndexChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(53, 463);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(80, 37);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(296, 463);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(81, 37);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRefersh
            // 
            this.BtnRefersh.Location = new System.Drawing.Point(533, 463);
            this.BtnRefersh.Name = "BtnRefersh";
            this.BtnRefersh.Size = new System.Drawing.Size(86, 37);
            this.BtnRefersh.TabIndex = 8;
            this.BtnRefersh.Text = "刷新";
            this.BtnRefersh.UseVisualStyleBackColor = true;
            this.BtnRefersh.Click += new System.EventHandler(this.BtnRefersh_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(816, 463);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(88, 37);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(1076, 463);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(87, 37);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(637, 32);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(92, 41);
            this.BtnOk.TabIndex = 11;
            this.BtnOk.Text = "确认";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // DGVStudent
            // 
            this.DGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGVStudent.Location = new System.Drawing.Point(53, 97);
            this.DGVStudent.Name = "DGVStudent";
            this.DGVStudent.RowHeadersWidth = 51;
            this.DGVStudent.RowTemplate.Height = 27;
            this.DGVStudent.Size = new System.Drawing.Size(676, 336);
            this.DGVStudent.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "loginId";
            this.Column1.HeaderText = "用户名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "studentId";
            this.Column2.HeaderText = "序号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sex";
            this.Column3.HeaderText = "性别";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "classId";
            this.Column4.HeaderText = "班级";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "studentNo";
            this.Column5.HeaderText = "学号";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "studentName";
            this.Column6.HeaderText = "姓名";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // CboDep
            // 
            this.CboDep.FormattingEnabled = true;
            this.CboDep.Location = new System.Drawing.Point(108, 43);
            this.CboDep.Name = "CboDep";
            this.CboDep.Size = new System.Drawing.Size(184, 23);
            this.CboDep.TabIndex = 13;
            this.CboDep.SelectedIndexChanged += new System.EventHandler(this.CboDep_SelectedIndexChanged);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 606);
            this.Controls.Add(this.CboDep);
            this.Controls.Add(this.DGVStudent);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnRefersh);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.CboClass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentListForm";
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtStuNo;
        private System.Windows.Forms.TextBox TxtStuName;
        private System.Windows.Forms.ComboBox CboSex;
        private System.Windows.Forms.ComboBox CboClass;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnRefersh;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.DataGridView DGVStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox CboDep;
        private System.Windows.Forms.Label LblDep;
        private System.Windows.Forms.Label LblClass;
    }
}