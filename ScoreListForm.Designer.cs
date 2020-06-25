namespace StudentManage
{
    partial class ScoreListForm
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CboCourse = new System.Windows.Forms.ComboBox();
            this.CboSearchType = new System.Windows.Forms.ComboBox();
            this.CboTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSno = new System.Windows.Forms.TextBox();
            this.DGVScoreList = new System.Windows.Forms.DataGridView();
            this.CboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(45, 395);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(81, 43);
            this.BtnSelect.TabIndex = 0;
            this.BtnSelect.Text = "查询";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(190, 395);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 43);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(357, 395);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(92, 43);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(517, 395);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(85, 43);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CboCourse
            // 
            this.CboCourse.FormattingEnabled = true;
            this.CboCourse.Location = new System.Drawing.Point(204, 267);
            this.CboCourse.Name = "CboCourse";
            this.CboCourse.Size = new System.Drawing.Size(257, 23);
            this.CboCourse.TabIndex = 4;
            // 
            // CboSearchType
            // 
            this.CboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSearchType.FormattingEnabled = true;
            this.CboSearchType.Items.AddRange(new object[] {
            "按学号",
            "按课程",
            "按学期",
            "按学年"});
            this.CboSearchType.Location = new System.Drawing.Point(204, 193);
            this.CboSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.CboSearchType.Name = "CboSearchType";
            this.CboSearchType.Size = new System.Drawing.Size(257, 23);
            this.CboSearchType.TabIndex = 16;
            // 
            // CboTeam
            // 
            this.CboTeam.FormattingEnabled = true;
            this.CboTeam.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CboTeam.Location = new System.Drawing.Point(204, 309);
            this.CboTeam.Name = "CboTeam";
            this.CboTeam.Size = new System.Drawing.Size(257, 23);
            this.CboTeam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "查询方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "课程";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "学期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "学年";
            // 
            // TxtSno
            // 
            this.TxtSno.Location = new System.Drawing.Point(204, 233);
            this.TxtSno.Name = "TxtSno";
            this.TxtSno.Size = new System.Drawing.Size(257, 25);
            this.TxtSno.TabIndex = 12;
            // 
            // DGVScoreList
            // 
            this.DGVScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVScoreList.Location = new System.Drawing.Point(22, 12);
            this.DGVScoreList.Name = "DGVScoreList";
            this.DGVScoreList.RowHeadersWidth = 51;
            this.DGVScoreList.RowTemplate.Height = 27;
            this.DGVScoreList.Size = new System.Drawing.Size(628, 166);
            this.DGVScoreList.TabIndex = 1;
            // 
            // CboYear
            // 
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CboYear.Location = new System.Drawing.Point(204, 350);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(257, 23);
            this.CboYear.TabIndex = 15;
            // 
            // ScoreListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 457);
            this.Controls.Add(this.CboYear);
            this.Controls.Add(this.DGVScoreList);
            this.Controls.Add(this.TxtSno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTeam);
            this.Controls.Add(this.CboSearchType);
            this.Controls.Add(this.CboCourse);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSelect);
            this.Name = "ScoreListForm";
            this.Text = "成绩管理";
            this.Load += new System.EventHandler(this.ScoreListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CboCourse;
        private System.Windows.Forms.ComboBox CboSearchType;
        private System.Windows.Forms.ComboBox CboTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSno;
        private System.Windows.Forms.DataGridView DGVScoreList;
        private System.Windows.Forms.ComboBox CboYear;
    }
}