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
    public partial class ScoreSearchForm : Form
    {
        public ScoreSearchForm()
        {
            InitializeComponent();
        }
        class Status
        {
            public static string sql1;
            public static string sql2;
            public static string sql3;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CboCx.Text == "")
            {
                MessageBox.Show("请选择查询类型！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboCx.Focus();
            }
            else if (CboCx.Text == "学号")
            {
                if (TxtId.Text == "")
                {
                    MessageBox.Show("请输入学号！", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtId.Focus();
                }
                string sql = string.Format("select distinct studentNo 学号,courseID 课程号,score 成绩,term 学期,Year 学年 from tbscore where studentNo='{0}'", TxtId.Text);
                DBHelper.conn.Open();
                SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                sda.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                DGVGrade.DataSource = dv;
                DBHelper.conn.Close();
            }
            else if (CboCx.Text == "课程")
            {
                if (CboCourse.Text == "")
                {
                    MessageBox.Show("请选择课程！", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboCourse.Focus();
                }
                else
                {
                    string sql1 = string.Format("select courseID from tbcourse where courseName='{0}'", CboCourse.Text);
                    if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
                    else { DBHelper.conn.Close(); DBHelper.conn.Open(); }

                    SqlCommand command = new SqlCommand(sql1, DBHelper.conn);
                    SqlDataReader datareader = command.ExecuteReader();
                    while (datareader.Read())
                    {
                        Status.sql1 = (string)datareader["courseID"];
                    }
                    DBHelper.conn.Close();

                    string str = string.Format("select distinct studentNo 学号,courseID 课程号,score 成绩,term 学期,Year 学年 from tbscore where courseID='{0}'", Status.sql1);
                    DBHelper.conn.Open();
                    SqlCommand cmd = new SqlCommand(str, DBHelper.conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    DataView dv = new DataView(ds.Tables[0]);
                    DGVGrade.DataSource = dv;
                    DBHelper.conn.Close();
                }
            }
            else if (CboCx.Text == "学期")
            {
                if (CboTeam.Text == "")
                {
                    MessageBox.Show("请选择学期", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboTeam.Focus();
                }
                else
                {
                    Status.sql2 = "select distinct studentNo 学号,courseID 课程号,score 成绩,term 学期,Year 学年 from tbscore where term='" + CboTeam.Text.Trim() + "'";

                    DBHelper.conn.Open();
                    SqlCommand command = new SqlCommand(Status.sql2, DBHelper.conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = command;
                    sda.Fill(ds);
                    DataView dv = new DataView(ds.Tables[0]);
                    DGVGrade.DataSource = dv;
                    DBHelper.conn.Close();
                }
            }
            else if (CboCx.Text == "学年")
            {
                if (CboYear.Text == "")
                {
                    MessageBox.Show("请选择学年！", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboYear.Focus();
                }
                else
                {
                    Status.sql3 = "select distinct studentNo 学号,courseID 课程号,score 成绩,term 学期,Year 学年 from tbscore where Year='" + CboYear.Text.Trim() + "'";

                    DBHelper.conn.Open();
                    SqlCommand command = new SqlCommand(Status.sql3, DBHelper.conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = command;
                    sda.Fill(ds);
                    DataView dv = new DataView(ds.Tables[0]);
                    DGVGrade.DataSource = dv;
                    DBHelper.conn.Close();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreSearchForm_Load(object sender, EventArgs e)
        {
            DBHelper.conn.Open();
            string sql4 = string.Format("select coursename from tbcourse");
            SqlCommand command = new SqlCommand(sql4, DBHelper.conn);
            SqlDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                string cno = (string)datareader["courseName"];
                CboCourse.Items.Add(cno);
            }
            DBHelper.conn.Close();
        }
    }
}
