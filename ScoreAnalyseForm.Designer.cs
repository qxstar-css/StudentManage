namespace StudentManage
{
    partial class ScoreAnalyseForm
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
            this.BtnAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CboCourseName = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassRate = new System.Windows.Forms.TextBox();
            this.TxtExcellentRate = new System.Windows.Forms.TextBox();
            this.TxtAVG = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnalysis
            // 
            this.BtnAnalysis.Location = new System.Drawing.Point(530, 17);
            this.BtnAnalysis.Name = "BtnAnalysis";
            this.BtnAnalysis.Size = new System.Drawing.Size(114, 41);
            this.BtnAnalysis.TabIndex = 0;
            this.BtnAnalysis.Text = "分析";
            this.BtnAnalysis.UseVisualStyleBackColor = true;
            this.BtnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择课程：";
            // 
            // CboCourseName
            // 
            this.CboCourseName.FormattingEnabled = true;
            this.CboCourseName.Location = new System.Drawing.Point(186, 26);
            this.CboCourseName.Name = "CboCourseName";
            this.CboCourseName.Size = new System.Drawing.Size(297, 23);
            this.CboCourseName.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(86, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 281);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "优秀率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "平均分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "通过率：";
            // 
            // TxtPassRate
            // 
            this.TxtPassRate.Location = new System.Drawing.Point(171, 382);
            this.TxtPassRate.Name = "TxtPassRate";
            this.TxtPassRate.Size = new System.Drawing.Size(100, 25);
            this.TxtPassRate.TabIndex = 7;
            // 
            // TxtExcellentRate
            // 
            this.TxtExcellentRate.Location = new System.Drawing.Point(405, 379);
            this.TxtExcellentRate.Name = "TxtExcellentRate";
            this.TxtExcellentRate.Size = new System.Drawing.Size(100, 25);
            this.TxtExcellentRate.TabIndex = 8;
            // 
            // TxtAVG
            // 
            this.TxtAVG.Location = new System.Drawing.Point(627, 379);
            this.TxtAVG.Name = "TxtAVG";
            this.TxtAVG.Size = new System.Drawing.Size(100, 25);
            this.TxtAVG.TabIndex = 9;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(668, 17);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 41);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ScoreAnalyseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtAVG);
            this.Controls.Add(this.TxtExcellentRate);
            this.Controls.Add(this.TxtPassRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CboCourseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAnalysis);
            this.Name = "ScoreAnalyseForm";
            this.Text = "成绩分析";
            this.Load += new System.EventHandler(this.ScoreAnalyseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCourseName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassRate;
        private System.Windows.Forms.TextBox TxtExcellentRate;
        private System.Windows.Forms.TextBox TxtAVG;
        private System.Windows.Forms.Button BtnExit;
    }
}