namespace StudentManage
{
    partial class TeacherAddForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboDep = new System.Windows.Forms.ComboBox();
            this.CboName = new System.Windows.Forms.ComboBox();
            this.TxtLoAgainPwd = new System.Windows.Forms.TextBox();
            this.TxtLoPwd = new System.Windows.Forms.TextBox();
            this.TxtTcName = new System.Windows.Forms.TextBox();
            this.TxtTcId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(203, 365);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 50);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(489, 365);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(109, 50);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "教师号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "所授课程：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "确认密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "所在系：";
            // 
            // CboDep
            // 
            this.CboDep.FormattingEnabled = true;
            this.CboDep.Location = new System.Drawing.Point(518, 128);
            this.CboDep.Name = "CboDep";
            this.CboDep.Size = new System.Drawing.Size(198, 23);
            this.CboDep.TabIndex = 8;
            // 
            // CboName
            // 
            this.CboName.FormattingEnabled = true;
            this.CboName.Location = new System.Drawing.Point(203, 125);
            this.CboName.Name = "CboName";
            this.CboName.Size = new System.Drawing.Size(212, 23);
            this.CboName.TabIndex = 9;
            // 
            // TxtLoAgainPwd
            // 
            this.TxtLoAgainPwd.Location = new System.Drawing.Point(406, 57);
            this.TxtLoAgainPwd.Name = "TxtLoAgainPwd";
            this.TxtLoAgainPwd.Size = new System.Drawing.Size(181, 25);
            this.TxtLoAgainPwd.TabIndex = 10;
            // 
            // TxtLoPwd
            // 
            this.TxtLoPwd.Location = new System.Drawing.Point(80, 57);
            this.TxtLoPwd.Name = "TxtLoPwd";
            this.TxtLoPwd.Size = new System.Drawing.Size(213, 25);
            this.TxtLoPwd.TabIndex = 11;
            // 
            // TxtTcName
            // 
            this.TxtTcName.Location = new System.Drawing.Point(518, 48);
            this.TxtTcName.Name = "TxtTcName";
            this.TxtTcName.Size = new System.Drawing.Size(198, 25);
            this.TxtTcName.TabIndex = 12;
            // 
            // TxtTcId
            // 
            this.TxtTcId.Location = new System.Drawing.Point(203, 48);
            this.TxtTcId.Name = "TxtTcId";
            this.TxtTcId.Size = new System.Drawing.Size(212, 25);
            this.TxtTcId.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtLoAgainPwd);
            this.groupBox1.Controls.Add(this.TxtLoPwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(123, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 118);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtTcId);
            this.Controls.Add(this.TxtTcName);
            this.Controls.Add(this.CboName);
            this.Controls.Add(this.CboDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Name = "TeacherAddForm";
            this.Text = "教师添加";
            this.Load += new System.EventHandler(this.TeacherAddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboDep;
        private System.Windows.Forms.ComboBox CboName;
        private System.Windows.Forms.TextBox TxtLoAgainPwd;
        private System.Windows.Forms.TextBox TxtLoPwd;
        private System.Windows.Forms.TextBox TxtTcName;
        private System.Windows.Forms.TextBox TxtTcId;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}