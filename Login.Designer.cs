namespace StudentManage
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblusername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbluserpwd = new System.Windows.Forms.Label();
            this.lblusertype = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.cboLoginType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Location = new System.Drawing.Point(50, 42);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(67, 15);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "用户名：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(75, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 42);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbluserpwd
            // 
            this.lbluserpwd.AutoSize = true;
            this.lbluserpwd.BackColor = System.Drawing.Color.Transparent;
            this.lbluserpwd.Location = new System.Drawing.Point(51, 115);
            this.lbluserpwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluserpwd.Name = "lbluserpwd";
            this.lbluserpwd.Size = new System.Drawing.Size(52, 15);
            this.lbluserpwd.TabIndex = 3;
            this.lbluserpwd.Text = "密码：";
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.BackColor = System.Drawing.Color.Transparent;
            this.lblusertype.Location = new System.Drawing.Point(52, 182);
            this.lblusertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(82, 15);
            this.lblusertype.TabIndex = 4;
            this.lblusertype.Text = "用户类型：";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(141, 39);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(220, 25);
            this.txtLoginId.TabIndex = 5;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(141, 112);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(220, 25);
            this.txtLoginPwd.TabIndex = 6;
            // 
            // cboLoginType
            // 
            this.cboLoginType.FormattingEnabled = true;
            this.cboLoginType.Items.AddRange(new object[] {
            "学生",
            "教师",
            "管理员"});
            this.cboLoginType.Location = new System.Drawing.Point(141, 174);
            this.cboLoginType.Name = "cboLoginType";
            this.cboLoginType.Size = new System.Drawing.Size(220, 23);
            this.cboLoginType.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 328);
            this.Controls.Add(this.cboLoginType);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.lblusertype);
            this.Controls.Add(this.lbluserpwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblusername);
            this.Name = "Login";
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbluserpwd;
        private System.Windows.Forms.Label lblusertype;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.ComboBox cboLoginType;
    }
}

