namespace StudentManage
{
    partial class MainFormT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormT));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsmiUserManage = new System.Windows.Forms.MenuStrip();
            this.TsmiUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNewTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNodifyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiModifyTeacherUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSearchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSearchTeacherUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiTeacherList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFaAndProManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCourseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClassManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWinFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiUserManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsmiUserManage
            // 
            this.TsmiUserManage.BackColor = System.Drawing.Color.Transparent;
            this.TsmiUserManage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TsmiUserManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiUserManagement,
            this.TsmiStudentList,
            this.TsmiTeacherList,
            this.TsmiScoreManage,
            this.TsmiFaAndProManage,
            this.TsmiCourseManage,
            this.TsmiClassManage,
            this.TsmiWinFrm});
            this.TsmiUserManage.Location = new System.Drawing.Point(0, 0);
            this.TsmiUserManage.Name = "TsmiUserManage";
            this.TsmiUserManage.Size = new System.Drawing.Size(800, 28);
            this.TsmiUserManage.TabIndex = 1;
            this.TsmiUserManage.Text = "menuStrip1";
            // 
            // TsmiUserManagement
            // 
            this.TsmiUserManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiNewUser,
            this.TsmiNodifyUser,
            this.TsmiSearchUser,
            this.TsmiExit});
            this.TsmiUserManagement.Name = "TsmiUserManagement";
            this.TsmiUserManagement.Size = new System.Drawing.Size(83, 24);
            this.TsmiUserManagement.Text = "用户管理";
            // 
            // TsmiNewUser
            // 
            this.TsmiNewUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiNewTeacher});
            this.TsmiNewUser.Name = "TsmiNewUser";
            this.TsmiNewUser.Size = new System.Drawing.Size(224, 26);
            this.TsmiNewUser.Text = "新增用户";
            // 
            // TsmiNewTeacher
            // 
            this.TsmiNewTeacher.Name = "TsmiNewTeacher";
            this.TsmiNewTeacher.Size = new System.Drawing.Size(224, 26);
            this.TsmiNewTeacher.Text = "添加教师用户";
            this.TsmiNewTeacher.Click += new System.EventHandler(this.TsmiNewTeacher_Click);
            // 
            // TsmiNodifyUser
            // 
            this.TsmiNodifyUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiModifyTeacherUser});
            this.TsmiNodifyUser.Name = "TsmiNodifyUser";
            this.TsmiNodifyUser.Size = new System.Drawing.Size(224, 26);
            this.TsmiNodifyUser.Text = "修改用户";
            // 
            // TsmiModifyTeacherUser
            // 
            this.TsmiModifyTeacherUser.Name = "TsmiModifyTeacherUser";
            this.TsmiModifyTeacherUser.Size = new System.Drawing.Size(224, 26);
            this.TsmiModifyTeacherUser.Text = "修改教师用户";
            this.TsmiModifyTeacherUser.Click += new System.EventHandler(this.TsmiModifyTeacherUser_Click);
            // 
            // TsmiSearchUser
            // 
            this.TsmiSearchUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSearchTeacherUser});
            this.TsmiSearchUser.Name = "TsmiSearchUser";
            this.TsmiSearchUser.Size = new System.Drawing.Size(224, 26);
            this.TsmiSearchUser.Text = "查询与删除用户";
            // 
            // TsmiSearchTeacherUser
            // 
            this.TsmiSearchTeacherUser.Name = "TsmiSearchTeacherUser";
            this.TsmiSearchTeacherUser.Size = new System.Drawing.Size(227, 26);
            this.TsmiSearchTeacherUser.Text = "查询及删除教师用户";
            this.TsmiSearchTeacherUser.Click += new System.EventHandler(this.TsmiSearchTeacherUser_Click);
            // 
            // TsmiExit
            // 
            this.TsmiExit.Name = "TsmiExit";
            this.TsmiExit.Size = new System.Drawing.Size(224, 26);
            this.TsmiExit.Text = "退出";
            // 
            // TsmiStudentList
            // 
            this.TsmiStudentList.Name = "TsmiStudentList";
            this.TsmiStudentList.Size = new System.Drawing.Size(113, 24);
            this.TsmiStudentList.Text = "学生信息管理";
            this.TsmiStudentList.Click += new System.EventHandler(this.TsmiStudentList_Click);
            // 
            // TsmiTeacherList
            // 
            this.TsmiTeacherList.Name = "TsmiTeacherList";
            this.TsmiTeacherList.Size = new System.Drawing.Size(113, 24);
            this.TsmiTeacherList.Text = "教师信息管理";
            this.TsmiTeacherList.Click += new System.EventHandler(this.TsmiTeacherList_Click);
            // 
            // TsmiScoreManage
            // 
            this.TsmiScoreManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiScoreManagement,
            this.TsmiScoreEntry,
            this.TsmiScoreAnalysis,
            this.TsmiScoreSelect});
            this.TsmiScoreManage.Name = "TsmiScoreManage";
            this.TsmiScoreManage.Size = new System.Drawing.Size(83, 24);
            this.TsmiScoreManage.Text = "成绩管理";
            // 
            // TsmiScoreManagement
            // 
            this.TsmiScoreManagement.Name = "TsmiScoreManagement";
            this.TsmiScoreManagement.Size = new System.Drawing.Size(152, 26);
            this.TsmiScoreManagement.Text = "成绩管理";
            this.TsmiScoreManagement.Click += new System.EventHandler(this.TsmiScoreManagement_Click);
            // 
            // TsmiScoreEntry
            // 
            this.TsmiScoreEntry.Name = "TsmiScoreEntry";
            this.TsmiScoreEntry.Size = new System.Drawing.Size(152, 26);
            this.TsmiScoreEntry.Text = "成绩录入";
            this.TsmiScoreEntry.Click += new System.EventHandler(this.TsmiScoreEntry_Click);
            // 
            // TsmiScoreAnalysis
            // 
            this.TsmiScoreAnalysis.Name = "TsmiScoreAnalysis";
            this.TsmiScoreAnalysis.Size = new System.Drawing.Size(152, 26);
            this.TsmiScoreAnalysis.Text = "成绩分析";
            this.TsmiScoreAnalysis.Click += new System.EventHandler(this.TsmiScoreAnalysis_Click);
            // 
            // TsmiScoreSelect
            // 
            this.TsmiScoreSelect.Name = "TsmiScoreSelect";
            this.TsmiScoreSelect.Size = new System.Drawing.Size(152, 26);
            this.TsmiScoreSelect.Text = "成绩查询";
            this.TsmiScoreSelect.Click += new System.EventHandler(this.TsmiScoreSelect_Click);
            // 
            // TsmiFaAndProManage
            // 
            this.TsmiFaAndProManage.Name = "TsmiFaAndProManage";
            this.TsmiFaAndProManage.Size = new System.Drawing.Size(128, 24);
            this.TsmiFaAndProManage.Text = "院系及专业管理";
            this.TsmiFaAndProManage.Click += new System.EventHandler(this.TsmiFaAndProManage_Click);
            // 
            // TsmiCourseManage
            // 
            this.TsmiCourseManage.Name = "TsmiCourseManage";
            this.TsmiCourseManage.Size = new System.Drawing.Size(83, 24);
            this.TsmiCourseManage.Text = "课程管理";
            // 
            // TsmiClassManage
            // 
            this.TsmiClassManage.Name = "TsmiClassManage";
            this.TsmiClassManage.Size = new System.Drawing.Size(83, 24);
            this.TsmiClassManage.Text = "班级管理";
            this.TsmiClassManage.Click += new System.EventHandler(this.TsmiClassManage_Click);
            // 
            // TsmiWinFrm
            // 
            this.TsmiWinFrm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAbout});
            this.TsmiWinFrm.Name = "TsmiWinFrm";
            this.TsmiWinFrm.Size = new System.Drawing.Size(53, 24);
            this.TsmiWinFrm.Text = "窗口";
            // 
            // TsmiAbout
            // 
            this.TsmiAbout.Name = "TsmiAbout";
            this.TsmiAbout.Size = new System.Drawing.Size(152, 26);
            this.TsmiAbout.Text = "关于我们";
            this.TsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // MainFormT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TsmiUserManage);
            this.MainMenuStrip = this.TsmiUserManage;
            this.Name = "MainFormT";
            this.Text = "主界面";
            this.TsmiUserManage.ResumeLayout(false);
            this.TsmiUserManage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip TsmiUserManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiUserManagement;
        private System.Windows.Forms.ToolStripMenuItem TsmiStudentList;
        private System.Windows.Forms.ToolStripMenuItem TsmiTeacherList;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiFaAndProManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiCourseManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiNewUser;
        private System.Windows.Forms.ToolStripMenuItem TsmiNewTeacher;
        private System.Windows.Forms.ToolStripMenuItem TsmiNodifyUser;
        private System.Windows.Forms.ToolStripMenuItem TsmiModifyTeacherUser;
        private System.Windows.Forms.ToolStripMenuItem TsmiSearchUser;
        private System.Windows.Forms.ToolStripMenuItem TsmiSearchTeacherUser;
        private System.Windows.Forms.ToolStripMenuItem TsmiExit;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreManagement;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreEntry;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreAnalysis;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreSelect;
        private System.Windows.Forms.ToolStripMenuItem TsmiClassManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiWinFrm;
        private System.Windows.Forms.ToolStripMenuItem TsmiAbout;
    }
}