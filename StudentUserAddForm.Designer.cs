namespace StudentManage
{
    partial class StudentUserAddForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLoginId = new System.Windows.Forms.TextBox();
            this.TxtLoginPwdAgain = new System.Windows.Forms.TextBox();
            this.TxtLoginPwd = new System.Windows.Forms.TextBox();
            this.RadioActive = new System.Windows.Forms.RadioButton();
            this.RadioInActive = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioMale = new System.Windows.Forms.RadioButton();
            this.RadioFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CboClass = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(102, 21);
            this.tabControl1.Location = new System.Drawing.Point(26, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 386);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.TxtLoginPwd);
            this.tabPage1.Controls.Add(this.TxtLoginPwdAgain);
            this.tabPage1.Controls.Add(this.TxtLoginId);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户注册信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtEmail);
            this.tabPage2.Controls.Add(this.CboClass);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.TxtStudentName);
            this.tabPage2.Controls.Add(this.TxtPhone);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户基本信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "状态：";
            // 
            // TxtLoginId
            // 
            this.TxtLoginId.Location = new System.Drawing.Point(167, 38);
            this.TxtLoginId.Name = "TxtLoginId";
            this.TxtLoginId.Size = new System.Drawing.Size(283, 25);
            this.TxtLoginId.TabIndex = 4;
            // 
            // TxtLoginPwdAgain
            // 
            this.TxtLoginPwdAgain.Location = new System.Drawing.Point(167, 165);
            this.TxtLoginPwdAgain.Name = "TxtLoginPwdAgain";
            this.TxtLoginPwdAgain.Size = new System.Drawing.Size(283, 25);
            this.TxtLoginPwdAgain.TabIndex = 5;
            // 
            // TxtLoginPwd
            // 
            this.TxtLoginPwd.Location = new System.Drawing.Point(167, 98);
            this.TxtLoginPwd.Name = "TxtLoginPwd";
            this.TxtLoginPwd.Size = new System.Drawing.Size(283, 25);
            this.TxtLoginPwd.TabIndex = 6;
            // 
            // RadioActive
            // 
            this.RadioActive.AutoSize = true;
            this.RadioActive.Location = new System.Drawing.Point(51, 25);
            this.RadioActive.Name = "RadioActive";
            this.RadioActive.Size = new System.Drawing.Size(58, 19);
            this.RadioActive.TabIndex = 7;
            this.RadioActive.TabStop = true;
            this.RadioActive.Text = "活动";
            this.RadioActive.UseVisualStyleBackColor = true;
            // 
            // RadioInActive
            // 
            this.RadioInActive.AutoSize = true;
            this.RadioInActive.Location = new System.Drawing.Point(163, 25);
            this.RadioInActive.Name = "RadioInActive";
            this.RadioInActive.Size = new System.Drawing.Size(73, 19);
            this.RadioInActive.TabIndex = 8;
            this.RadioInActive.TabStop = true;
            this.RadioInActive.Text = "非活动";
            this.RadioInActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioInActive);
            this.panel1.Controls.Add(this.RadioActive);
            this.panel1.Location = new System.Drawing.Point(167, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 77);
            this.panel1.TabIndex = 9;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(167, 140);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(251, 25);
            this.TxtPhone.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(167, 184);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(251, 25);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(168, 82);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(250, 25);
            this.TxtId.TabIndex = 3;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(168, 34);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(250, 25);
            this.TxtStudentName.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadioMale);
            this.panel2.Controls.Add(this.RadioFemale);
            this.panel2.Location = new System.Drawing.Point(168, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 57);
            this.panel2.TabIndex = 5;
            // 
            // RadioMale
            // 
            this.RadioMale.AutoSize = true;
            this.RadioMale.Location = new System.Drawing.Point(49, 14);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(43, 19);
            this.RadioMale.TabIndex = 0;
            this.RadioMale.TabStop = true;
            this.RadioMale.Text = "男";
            this.RadioMale.UseVisualStyleBackColor = true;
            // 
            // RadioFemale
            // 
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.Location = new System.Drawing.Point(160, 14);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(43, 19);
            this.RadioFemale.TabIndex = 1;
            this.RadioFemale.TabStop = true;
            this.RadioFemale.Text = "女";
            this.RadioFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "电子邮件：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "班级：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "电话：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "学号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "姓名：";
            // 
            // CboClass
            // 
            this.CboClass.FormattingEnabled = true;
            this.CboClass.Location = new System.Drawing.Point(168, 298);
            this.CboClass.Name = "CboClass";
            this.CboClass.Size = new System.Drawing.Size(250, 23);
            this.CboClass.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(122, 419);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(81, 41);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(341, 419);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 41);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // StudentUserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 472);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentUserAddForm";
            this.Text = "添加学生用户";
            this.Load += new System.EventHandler(this.StudentUserAddForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioInActive;
        private System.Windows.Forms.RadioButton RadioActive;
        private System.Windows.Forms.TextBox TxtLoginPwd;
        private System.Windows.Forms.TextBox TxtLoginPwdAgain;
        private System.Windows.Forms.TextBox TxtLoginId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioFemale;
        private System.Windows.Forms.RadioButton RadioMale;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.ComboBox CboClass;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}