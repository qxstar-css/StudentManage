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
    public partial class ScoreListForm : Form
    {
        class Status
        {
            public static string sql1;
            public static string sql2;
            public static string sql3;
        }
        public ScoreListForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (CboSearchType.Text == "")
            {
                MessageBox.Show("请选择查询类型！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboSearchType.Focus();
            }
            else if (CboSearchType.Text == "按学号")
            {
                if (TxtSno.Text == "")
                {
                    MessageBox.Show("请输入学号！", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtSno.Focus();
                }
                string sql = string.Format("select distinct studentNo 学号,courseID 课程号,score 成绩,term 学期,Year 学年 from tbscore where studentNo='{0}'", TxtSno.Text);
                DBHelper.conn.Open();
                SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                sda.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                DGVScoreList.DataSource = dv;
                DBHelper.conn.Close();
            }
            else if (CboSearchType.Text == "按课程")
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
                    DGVScoreList.DataSource = dv;
                    DBHelper.conn.Close();
                }
            }
            else if (CboSearchType.Text == "按学期")
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
                    DGVScoreList.DataSource = dv;
                    DBHelper.conn.Close();
                }
            }
            else if (CboSearchType.Text == "按学年")
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
                    DGVScoreList.DataSource = dv;
                    DBHelper.conn.Close();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int RowNumber = DGVScoreList.CurrentCell.RowIndex;

            string str = DGVScoreList.Rows[RowNumber].Cells[0].Value.ToString();
            if (RowNumber == -1)
            {
                MessageBox.Show("请选中要删除的项！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("确实要删除选中项吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    string sql = string.Format("delete from tbscore where studentNo='{0}'", str);
                    try
                    {
                        DBHelper.conn.Open();
                        SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                        int result1 = command.ExecuteNonQuery();
                        if (result1 < 1)
                        {
                            MessageBox.Show("删除失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (result1 >= 1)
                        {
                            MessageBox.Show("删除成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DGVScoreList.Rows.RemoveAt(RowNumber);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误:" + ex.Message);
                    }
                    finally
                    {
                        DBHelper.conn.Close();
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int rowNumber = DGVScoreList.CurrentCell.RowIndex;

            string sNo = DGVScoreList.Rows[rowNumber].Cells[0].Value.ToString();
            string cNo = DGVScoreList.Rows[rowNumber].Cells[1].Value.ToString();
            string score = DGVScoreList.Rows[rowNumber].Cells[2].Value.ToString();
            string term = DGVScoreList.Rows[rowNumber].Cells[3].Value.ToString();
            string Syear = DGVScoreList.Rows[rowNumber].Cells[4].Value.ToString();

            try
            {
                string sql = string.Format("update tbscore set score='{0}' where studentNo='{1}' ", score, sNo);
                DBHelper.conn.Open();
                SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                int result = command.ExecuteNonQuery();
                if (result < 1)
                {
                    MessageBox.Show("修改失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误:" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        private void ScoreListForm_Load(object sender, EventArgs e)
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
