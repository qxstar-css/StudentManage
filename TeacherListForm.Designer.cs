namespace StudentManage
{
    partial class TeacherListForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.CboDep = new System.Windows.Forms.ComboBox();
            this.CboCName = new System.Windows.Forms.ComboBox();
            this.BtnRefersh = new System.Windows.Forms.Button();
            this.DataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师信息列表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "职工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "所授课：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "所在系：";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(55, 395);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(97, 43);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(320, 395);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(92, 43);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(195, 395);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(87, 43);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(433, 233);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(109, 36);
            this.BtnSelect.TabIndex = 9;
            this.BtnSelect.Text = "查询";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(602, 395);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(104, 43);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(488, 286);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(218, 25);
            this.TxtPwd.TabIndex = 11;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(199, 286);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(194, 25);
            this.TxtName.TabIndex = 12;
            // 
            // TxtNo
            // 
            this.TxtNo.Location = new System.Drawing.Point(199, 244);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Size = new System.Drawing.Size(194, 25);
            this.TxtNo.TabIndex = 13;
            // 
            // CboDep
            // 
            this.CboDep.FormattingEnabled = true;
            this.CboDep.Location = new System.Drawing.Point(488, 341);
            this.CboDep.Name = "CboDep";
            this.CboDep.Size = new System.Drawing.Size(218, 23);
            this.CboDep.TabIndex = 14;
            this.CboDep.SelectedIndexChanged += new System.EventHandler(this.CboDep_SelectedIndexChanged);
            // 
            // CboCName
            // 
            this.CboCName.FormattingEnabled = true;
            this.CboCName.Location = new System.Drawing.Point(195, 338);
            this.CboCName.Name = "CboCName";
            this.CboCName.Size = new System.Drawing.Size(198, 23);
            this.CboCName.TabIndex = 15;
            this.CboCName.SelectedIndexChanged += new System.EventHandler(this.CboCName_SelectedIndexChanged);
            // 
            // BtnRefersh
            // 
            this.BtnRefersh.Location = new System.Drawing.Point(463, 395);
            this.BtnRefersh.Name = "BtnRefersh";
            this.BtnRefersh.Size = new System.Drawing.Size(89, 43);
            this.BtnRefersh.TabIndex = 16;
            this.BtnRefersh.Text = "刷新";
            this.BtnRefersh.UseVisualStyleBackColor = true;
            this.BtnRefersh.Click += new System.EventHandler(this.BtnRefersh_Click);
            // 
            // DataGridViewTeacher
            // 
            this.DataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataGridViewTeacher.Location = new System.Drawing.Point(68, 54);
            this.DataGridViewTeacher.Name = "DataGridViewTeacher";
            this.DataGridViewTeacher.RowHeadersWidth = 51;
            this.DataGridViewTeacher.RowTemplate.Height = 27;
            this.DataGridViewTeacher.Size = new System.Drawing.Size(685, 157);
            this.DataGridViewTeacher.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "teacherID";
            this.Column1.HeaderText = "职工号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "teacherName";
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "coursename";
            this.Column3.HeaderText = "所授课";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "depname";
            this.Column4.HeaderText = "所在系";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // TeacherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewTeacher);
            this.Controls.Add(this.BtnRefersh);
            this.Controls.Add(this.CboCName);
            this.Controls.Add(this.CboDep);
            this.Controls.Add(this.TxtNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherListForm";
            this.Text = "教师管理";
            this.Load += new System.EventHandler(this.TeacherListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNo;
        private System.Windows.Forms.ComboBox CboDep;
        private System.Windows.Forms.ComboBox CboCName;
        private System.Windows.Forms.Button BtnRefersh;
        private System.Windows.Forms.DataGridView DataGridViewTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}