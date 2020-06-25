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
    public partial class MainFormS : Form
    {
        public MainFormS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiNewStu_Click(object sender, EventArgs e)
        {
            StudentUserAddForm stuFrm = new StudentUserAddForm();
            stuFrm.Show();
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

        private void TsmStudentUserModifyForm_Click(object sender, EventArgs e)
        {
            StudentUserModifyForm sumFrm = new StudentUserModifyForm();
            sumFrm.Show();
        }

        private void TsmiCourseManage_Click(object sender, EventArgs e)
        {
            CourseForm cFrm = new CourseForm();
            cFrm.Show();

        }
    }
}
