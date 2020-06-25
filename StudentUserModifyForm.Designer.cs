namespace StudentManage
{
    partial class StudentUserModifyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtStuNo = new System.Windows.Forms.TextBox();
            this.TxtStuName = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtLoginPwd = new System.Windows.Forms.TextBox();
            this.CboClass = new System.Windows.Forms.ComboBox();
            this.BtnModifyStudent = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RadioActive = new System.Windows.Forms.RadioButton();
            this.RadionInActive = new System.Windows.Forms.RadioButton();
            this.RadioMale = new System.Windows.Forms.RadioButton();
            this.RadioFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtLoginPwd);
            this.groupBox1.Controls.Add(this.TxtLogin);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户注册信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.CboClass);
            this.groupBox2.Controls.Add(this.TxtStuNo);
            this.groupBox2.Controls.Add(this.TxtStuName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 250);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户个人信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "状态；";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "用户名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "学号：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioActive);
            this.panel1.Controls.Add(this.RadionInActive);
            this.panel1.Location = new System.Drawing.Point(125, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 50);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadioMale);
            this.panel2.Controls.Add(this.RadioFemale);
            this.panel2.Location = new System.Drawing.Point(123, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 56);
            this.panel2.TabIndex = 0;
            // 
            // TxtStuNo
            // 
            this.TxtStuNo.Location = new System.Drawing.Point(123, 90);
            this.TxtStuNo.Name = "TxtStuNo";
            this.TxtStuNo.Size = new System.Drawing.Size(309, 25);
            this.TxtStuNo.TabIndex = 0;
            // 
            // TxtStuName
            // 
            this.TxtStuName.Location = new System.Drawing.Point(125, 41);
            this.TxtStuName.Name = "TxtStuName";
            this.TxtStuName.Size = new System.Drawing.Size(309, 25);
            this.TxtStuName.TabIndex = 1;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(123, 30);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(304, 25);
            this.TxtLogin.TabIndex = 2;
            // 
            // TxtLoginPwd
            // 
            this.TxtLoginPwd.Location = new System.Drawing.Point(123, 76);
            this.TxtLoginPwd.Name = "TxtLoginPwd";
            this.TxtLoginPwd.Size = new System.Drawing.Size(304, 25);
            this.TxtLoginPwd.TabIndex = 3;
            // 
            // CboClass
            // 
            this.CboClass.FormattingEnabled = true;
            this.CboClass.Location = new System.Drawing.Point(121, 212);
            this.CboClass.Name = "CboClass";
            this.CboClass.Size = new System.Drawing.Size(311, 23);
            this.CboClass.TabIndex = 4;
            // 
            // BtnModifyStudent
            // 
            this.BtnModifyStudent.Location = new System.Drawing.Point(92, 516);
            this.BtnModifyStudent.Name = "BtnModifyStudent";
            this.BtnModifyStudent.Size = new System.Drawing.Size(88, 47);
            this.BtnModifyStudent.TabIndex = 5;
            this.BtnModifyStudent.Text = "修改";
            this.BtnModifyStudent.UseVisualStyleBackColor = true;
            this.BtnModifyStudent.Click += new System.EventHandler(this.BtnModifyStudent_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(379, 516);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(93, 47);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RadioActive
            // 
            this.RadioActive.AutoSize = true;
            this.RadioActive.Location = new System.Drawing.Point(30, 15);
            this.RadioActive.Name = "RadioActive";
            this.RadioActive.Size = new System.Drawing.Size(58, 19);
            this.RadioActive.TabIndex = 7;
            this.RadioActive.TabStop = true;
            this.RadioActive.Text = "活动";
            this.RadioActive.UseVisualStyleBackColor = true;
            // 
            // RadionInActive
            // 
            this.RadionInActive.AutoSize = true;
            this.RadionInActive.Location = new System.Drawing.Point(175, 15);
            this.RadionInActive.Name = "RadionInActive";
            this.RadionInActive.Size = new System.Drawing.Size(73, 19);
            this.RadionInActive.TabIndex = 8;
            this.RadionInActive.TabStop = true;
            this.RadionInActive.Text = "非活动";
            this.RadionInActive.UseVisualStyleBackColor = true;
            // 
            // RadioMale
            // 
            this.RadioMale.AutoSize = true;
            this.RadioMale.Location = new System.Drawing.Point(46, 17);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(43, 19);
            this.RadioMale.TabIndex = 9;
            this.RadioMale.TabStop = true;
            this.RadioMale.Text = "男";
            this.RadioMale.UseVisualStyleBackColor = true;
            // 
            // RadioFemale
            // 
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.Location = new System.Drawing.Point(194, 17);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(43, 19);
            this.RadioFemale.TabIndex = 10;
            this.RadioFemale.TabStop = true;
            this.RadioFemale.Text = "女";
            this.RadioFemale.UseVisualStyleBackColor = true;
            // 
            // StudentUserModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnModifyStudent);
            this.Name = "StudentUserModifyForm";
            this.Text = "学生信息修改";
            this.Load += new System.EventHandler(this.StudentUserModifyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CboClass;
        private System.Windows.Forms.TextBox TxtLoginPwd;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtStuName;
        private System.Windows.Forms.TextBox TxtStuNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModifyStudent;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RadionInActive;
        private System.Windows.Forms.RadioButton RadioActive;
        private System.Windows.Forms.RadioButton RadioMale;
        private System.Windows.Forms.RadioButton RadioFemale;
    }
}