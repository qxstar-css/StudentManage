namespace StudentManage
{
    partial class MainFormS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormS));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsmiUserManage = new System.Windows.Forms.MenuStrip();
            this.TsmiUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNewStu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiTeacherList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScoreSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFaAndProManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCourseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClassManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWinFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmStudentUserModifyForm = new System.Windows.Forms.ToolStripMenuItem();
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
            this.修改用户ToolStripMenuItem,
            this.TsmiExit});
            this.TsmiUserManagement.Name = "TsmiUserManagement";
            this.TsmiUserManagement.Size = new System.Drawing.Size(83, 24);
            this.TsmiUserManagement.Text = "用户管理";
            // 
            // TsmiNewUser
            // 
            this.TsmiNewUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiNewStu});
            this.TsmiNewUser.Name = "TsmiNewUser";
            this.TsmiNewUser.Size = new System.Drawing.Size(224, 26);
            this.TsmiNewUser.Text = "新增用户";
            // 
            // TsmiNewStu
            // 
            this.TsmiNewStu.Name = "TsmiNewStu";
            this.TsmiNewStu.Size = new System.Drawing.Size(224, 26);
            this.TsmiNewStu.Text = "添加学生用户";
            this.TsmiNewStu.Click += new System.EventHandler(this.TsmiNewStu_Click);
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
            this.TsmiScoreAnalysis,
            this.TsmiScoreSelect});
            this.TsmiScoreManage.Name = "TsmiScoreManage";
            this.TsmiScoreManage.Size = new System.Drawing.Size(83, 24);
            this.TsmiScoreManage.Text = "成绩管理";
            // 
            // TsmiScoreAnalysis
            // 
            this.TsmiScoreAnalysis.Name = "TsmiScoreAnalysis";
            this.TsmiScoreAnalysis.Size = new System.Drawing.Size(224, 26);
            this.TsmiScoreAnalysis.Text = "成绩分析";
            this.TsmiScoreAnalysis.Click += new System.EventHandler(this.TsmiScoreAnalysis_Click);
            // 
            // TsmiScoreSelect
            // 
            this.TsmiScoreSelect.Name = "TsmiScoreSelect";
            this.TsmiScoreSelect.Size = new System.Drawing.Size(224, 26);
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
            this.TsmiCourseManage.Click += new System.EventHandler(this.TsmiCourseManage_Click);
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
            this.TsmiAbout.Size = new System.Drawing.Size(224, 26);
            this.TsmiAbout.Text = "关于我们";
            this.TsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // 修改用户ToolStripMenuItem
            // 
            this.修改用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmStudentUserModifyForm});
            this.修改用户ToolStripMenuItem.Name = "修改用户ToolStripMenuItem";
            this.修改用户ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改用户ToolStripMenuItem.Text = "修改用户";
            // 
            // TsmStudentUserModifyForm
            // 
            this.TsmStudentUserModifyForm.Name = "TsmStudentUserModifyForm";
            this.TsmStudentUserModifyForm.Size = new System.Drawing.Size(224, 26);
            this.TsmStudentUserModifyForm.Text = "修改学生用户";
            this.TsmStudentUserModifyForm.Click += new System.EventHandler(this.TsmStudentUserModifyForm_Click);
            // 
            // MainFormS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TsmiUserManage);
            this.MainMenuStrip = this.TsmiUserManage;
            this.Name = "MainFormS";
            this.Text = "学生";
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
        private System.Windows.Forms.ToolStripMenuItem TsmiNewStu;
        private System.Windows.Forms.ToolStripMenuItem TsmiExit;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreAnalysis;
        private System.Windows.Forms.ToolStripMenuItem TsmiScoreSelect;
        private System.Windows.Forms.ToolStripMenuItem TsmiClassManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiWinFrm;
        private System.Windows.Forms.ToolStripMenuItem TsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem 修改用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmStudentUserModifyForm;
    }
}