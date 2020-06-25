namespace StudentManage
{
    partial class ScoreAddFrom
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
            this.CboCourse = new System.Windows.Forms.ComboBox();
            this.CboSno = new System.Windows.Forms.ComboBox();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.CboTeam = new System.Windows.Forms.ComboBox();
            this.DGVScore = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtGrade = new System.Windows.Forms.TextBox();
            this.BtnScoreAdd = new System.Windows.Forms.Button();
            this.BtnSoreAddCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVScore)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "成绩：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学年：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "学期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "学号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "成绩录入";
            // 
            // CboCourse
            // 
            this.CboCourse.FormattingEnabled = true;
            this.CboCourse.Location = new System.Drawing.Point(127, 71);
            this.CboCourse.Name = "CboCourse";
            this.CboCourse.Size = new System.Drawing.Size(234, 23);
            this.CboCourse.TabIndex = 6;
            this.CboCourse.SelectedIndexChanged += new System.EventHandler(this.CboCourse_SelectedIndexChanged);
            // 
            // CboSno
            // 
            this.CboSno.FormattingEnabled = true;
            this.CboSno.Location = new System.Drawing.Point(457, 71);
            this.CboSno.Name = "CboSno";
            this.CboSno.Size = new System.Drawing.Size(260, 23);
            this.CboSno.TabIndex = 7;
            // 
            // CboYear
            // 
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Location = new System.Drawing.Point(127, 124);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(234, 23);
            this.CboYear.TabIndex = 8;
            // 
            // CboTeam
            // 
            this.CboTeam.FormattingEnabled = true;
            this.CboTeam.Location = new System.Drawing.Point(457, 129);
            this.CboTeam.Name = "CboTeam";
            this.CboTeam.Size = new System.Drawing.Size(260, 23);
            this.CboTeam.TabIndex = 9;
            // 
            // DGVScore
            // 
            this.DGVScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVScore.Location = new System.Drawing.Point(6, 24);
            this.DGVScore.Name = "DGVScore";
            this.DGVScore.RowHeadersWidth = 51;
            this.DGVScore.RowTemplate.Height = 27;
            this.DGVScore.Size = new System.Drawing.Size(716, 243);
            this.DGVScore.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVScore);
            this.groupBox1.Location = new System.Drawing.Point(49, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 273);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成绩信息";
            // 
            // TxtGrade
            // 
            this.TxtGrade.Location = new System.Drawing.Point(309, 183);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(247, 25);
            this.TxtGrade.TabIndex = 1;
            // 
            // BtnScoreAdd
            // 
            this.BtnScoreAdd.Location = new System.Drawing.Point(184, 223);
            this.BtnScoreAdd.Name = "BtnScoreAdd";
            this.BtnScoreAdd.Size = new System.Drawing.Size(103, 32);
            this.BtnScoreAdd.TabIndex = 2;
            this.BtnScoreAdd.Text = "确认";
            this.BtnScoreAdd.UseVisualStyleBackColor = true;
            this.BtnScoreAdd.Click += new System.EventHandler(this.BtnScoreAdd_Click);
            // 
            // BtnSoreAddCancel
            // 
            this.BtnSoreAddCancel.Location = new System.Drawing.Point(481, 223);
            this.BtnSoreAddCancel.Name = "BtnSoreAddCancel";
            this.BtnSoreAddCancel.Size = new System.Drawing.Size(100, 32);
            this.BtnSoreAddCancel.TabIndex = 12;
            this.BtnSoreAddCancel.Text = "取消";
            this.BtnSoreAddCancel.UseVisualStyleBackColor = true;
            this.BtnSoreAddCancel.Click += new System.EventHandler(this.BtnSoreAddCancel_Click);
            // 
            // ScoreAddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 556);
            this.Controls.Add(this.BtnSoreAddCancel);
            this.Controls.Add(this.TxtGrade);
            this.Controls.Add(this.BtnScoreAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CboTeam);
            this.Controls.Add(this.CboYear);
            this.Controls.Add(this.CboSno);
            this.Controls.Add(this.CboCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScoreAddFrom";
            this.Text = "成绩录入";
            this.Load += new System.EventHandler(this.ScoreAddFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVScore)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox CboCourse;
        private System.Windows.Forms.ComboBox CboSno;
        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.ComboBox CboTeam;
        private System.Windows.Forms.DataGridView DGVScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnScoreAdd;
        private System.Windows.Forms.TextBox TxtGrade;
        private System.Windows.Forms.Button BtnSoreAddCancel;
    }
}