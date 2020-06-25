using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManage
{
    public partial class MainFormT : Form
    {
        public MainFormT()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiNewTeacher_Click(object sender, EventArgs e)
        {
            TeacherAddForm teaFrm = new TeacherAddForm();
            teaFrm.Show();
        }

        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiModifyTeacherUser_Click(object sender, EventArgs e)
        {
            TeacherListForm teaListFrm = new TeacherListForm();
            teaListFrm.Show();
        }
        
        /// <summary>
        /// 查询及删除老师用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiSearchTeacherUser_Click(object sender, EventArgs e)
        {
            TeacherListForm teaListFrm = new TeacherListForm();
            teaListFrm.Show();
        }

        /// <summary>
        /// 学生信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiStudentList_Click(object sender, EventArgs e)
        {
            StudentListForm slFrm = new StudentListForm();
            slFrm.Show();
        }
        
        /// <summary>
        /// 教师信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiTeacherList_Click(object sender, EventArgs e)
        {
            TeacherListForm tlFrm = new TeacherListForm();
            tlFrm.Show();
        }
        /// <summary>
        /// 成绩管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiScoreManagement_Click(object sender, EventArgs e)
        {
            ScoreListForm Score1Frm = new ScoreListForm();
            Score1Frm.Show();
        }
        /// <summary>
        /// 成绩录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiScoreEntry_Click(object sender, EventArgs e)
        {
            ScoreAddFrom Score2Frm = new ScoreAddFrom();
            Score2Frm.Show();
        }
        /// <summary>
        /// 成绩分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiScoreAnalysis_Click(object sender, EventArgs e)
        {
            ScoreAnalyseForm Score3Frm = new ScoreAnalyseForm();
            Score3Frm.Show();
        }
        /// <summary>
        /// 成绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiScoreSelect_Click(object sender, EventArgs e)
        {
            ScoreSearchForm Score4Frm = new ScoreSearchForm();
            Score4Frm.Show();
        }
        /// <summary>
        /// 院系及专业管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiFaAndProManage_Click(object sender, EventArgs e)
        {
            FaAndProForm FAPFrm = new FaAndProForm();
            FAPFrm.Show();
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            About.Show();
        }
        /// <summary>
        /// 班级管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiClassManage_Click(object sender, EventArgs e)
        {
            ClassForm Class = new ClassForm();
            Class.Show();
        }
    }
}
