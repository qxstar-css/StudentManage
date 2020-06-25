using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManage
{
    public partial class ScoreAddFrom : Form
    {
        public ScoreAddFrom()
        {
            InitializeComponent();
        }
        class Status
        {
            public static string sql;
        }
        private void ViewInfo()
        {
            string sql = string.Format("select distinct studentNo 学号,courseID 课程号,score 成绩,term 学期,Year 学年 from tbscore");
            DBHelper.conn.Open();
            SqlCommand command = new SqlCommand(sql, DBHelper.conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = command;
            sda.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            DGVScore.DataSource = dv;
            DBHelper.conn.Close();
        }
        private void BtnScoreAdd_Click(object sender, EventArgs e)
        {
            if (CboSno.Text == "")
            {
                MessageBox.Show("请选择学号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboSno.Focus();
            }
            else if (CboCourse.Text == "")
            {
                MessageBox.Show("请选择课程号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboCourse.Focus();
            }
            else if (CboYear.Text == "")
            {
                MessageBox.Show("请选择学年！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboYear.Focus();
            }
            else if (CboTeam.Text == "")
            {
                MessageBox.Show("请选择学期！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboTeam.Focus();
            }
            else if (TxtGrade.Text == "")
            {
                MessageBox.Show("请输入成绩！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtGrade.Focus();
            }
            else
            {
                try
                {


                    string str = string.Format(" insert into tbscore(studentNo,courseID,score,term,Year) values('{0}','{1}','{2}','{3}','{4}')", CboSno.Text, Status.sql, int.Parse(TxtGrade.Text), CboTeam.Text, CboYear.Text);
                    DBHelper.conn.Open();
                    SqlCommand command = new SqlCommand(str, DBHelper.conn);
                    int result = command.ExecuteNonQuery();

                    if (result < 1)
                    {
                        MessageBox.Show("成绩录入失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("成绩录入成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库操作错误:" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBHelper.conn.Close();
                    this.ViewInfo();
                }
            }
        }

        private void BtnSoreAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = string.Format("select courseID from tbcourse where courseName='{0}'", CboCourse.Text);
            DBHelper.conn.Open();
            SqlCommand cmd = new SqlCommand(str, DBHelper.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Status.sql = (string)reader["courseID"];
            }
            DBHelper.conn.Close();
        }

        private void ScoreAddFrom_Load(object sender, EventArgs e)
        {
            this.ViewInfo();

            CboSno.Items.Clear();
            CboCourse.Items.Clear();

            string sql1 = "select studentNo from tbstudent";


            try
            {
                DBHelper.conn.Open();
                SqlCommand command1 = new SqlCommand(sql1, DBHelper.conn);
                SqlDataReader datareader1 = command1.ExecuteReader();
                while (datareader1.Read())
                {
                    string sno = (string)datareader1["studentNo"];
                    CboSno.Items.Add(sno);
                }
                DBHelper.conn.Close();

                DBHelper.conn.Open();
                string sql2 = string.Format("select coursename from tbcourse");
                SqlCommand command2 = new SqlCommand(sql2, DBHelper.conn);
                SqlDataReader datareader2 = command2.ExecuteReader();
                while (datareader2.Read())
                {
                    string cno = (string)datareader2["courseName"];
                    CboCourse.Items.Add(cno);
                }
                DBHelper.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误:" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
