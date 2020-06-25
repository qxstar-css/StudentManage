namespace StudentManage
{
    partial class ScoreSearchForm
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
            this.DGVGrade = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.CboCx = new System.Windows.Forms.ComboBox();
            this.CboCourse = new System.Windows.Forms.ComboBox();
            this.CboTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVGrade
            // 
            this.DGVGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGrade.Location = new System.Drawing.Point(12, 12);
            this.DGVGrade.Name = "DGVGrade";
            this.DGVGrade.RowHeadersWidth = 51;
            this.DGVGrade.RowTemplate.Height = 27;
            this.DGVGrade.Size = new System.Drawing.Size(784, 243);
            this.DGVGrade.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(216, 477);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(78, 42);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(409, 477);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(81, 42);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CboYear
            // 
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Location = new System.Drawing.Point(255, 426);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(317, 23);
            this.CboYear.TabIndex = 3;
            // 
            // CboCx
            // 
            this.CboCx.FormattingEnabled = true;
            this.CboCx.Items.AddRange(new object[] {
            "学号",
            "课程",
            "学期",
            "学年"});
            this.CboCx.Location = new System.Drawing.Point(255, 272);
            this.CboCx.Name = "CboCx";
            this.CboCx.Size = new System.Drawing.Size(317, 23);
            this.CboCx.TabIndex = 4;
            // 
            // CboCourse
            // 
            this.CboCourse.FormattingEnabled = true;
            this.CboCourse.Location = new System.Drawing.Point(255, 353);
            this.CboCourse.Name = "CboCourse";
            this.CboCourse.Size = new System.Drawing.Size(317, 23);
            this.CboCourse.TabIndex = 5;
            // 
            // CboTeam
            // 
            this.CboTeam.FormattingEnabled = true;
            this.CboTeam.Location = new System.Drawing.Point(255, 386);
            this.CboTeam.Name = "CboTeam";
            this.CboTeam.Size = new System.Drawing.Size(317, 23);
            this.CboTeam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "课程：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "查询方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "学年：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "学期：";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(255, 310);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(317, 25);
            this.TxtId.TabIndex = 12;
            // 
            // ScoreSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 531);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTeam);
            this.Controls.Add(this.CboCourse);
            this.Controls.Add(this.CboCx);
            this.Controls.Add(this.CboYear);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DGVGrade);
            this.Name = "ScoreSearchForm";
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.ScoreSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVGrade;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.ComboBox CboCx;
        private System.Windows.Forms.ComboBox CboCourse;
        private System.Windows.Forms.ComboBox CboTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
    }
}