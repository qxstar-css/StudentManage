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
    public partial class CourseForm : Form
    {
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataSet ds;
        public CourseForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //定义sql语句
            string sql = string.Format("insert into tbcourse(courseID,coursename,coursecredit) values('{0}','{1}','{2}')", TxtCourseId.Text, TxtCourseName.Text, TxtCredit.Text);
            //判断是否输入
            if (ValidateInput())
            {
                //执行sql

                DBHelper.conn.Open();       //数据库连接

                try
                {
                    cmd = new SqlCommand(sql, DBHelper.conn);      //创建command对象                    
                    int result = cmd.ExecuteNonQuery();     //执行命令

                    //根据操作结果给出信息提示
                    if (result < 1)
                    {
                        MessageBox.Show("添加失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("添加成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBHelper.conn.Close();
                }
                //清空
                TxtCourseId.Text = "";
                TxtCourseName.Text = "";
                TxtCredit.Text = "";
            }
        }
        private bool ValidateInput()
        {
            if (TxtCourseId.Text == "")    //验证是否输入了课程号
            {
                MessageBox.Show("请输入课程号！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCourseId.Focus();
                return false;
            }
            if (TxtCourseName.Text == "")       //验证是否输入了课程名
            {
                MessageBox.Show("请输入课程名！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCourseName.Focus();
                return false;
            }
            if (TxtCredit.Text == "")      //验证是否输入了学分
            {
                MessageBox.Show("请输入学分！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCredit.Focus();
                return false;
            }
            return true;
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            //提示是否修改
            DialogResult result = MessageBox.Show("确定要保存修改吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(ds, "course");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            string CourseID = DGVCourse.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            //提示是否删除
            if (CourseID == "")
                MessageBox.Show("请选择要删除的课程！");
            else
            {
                //执行删除
                string sql = "delete from tbcourse where courseID='" + CourseID + "'";
                cmd = new SqlCommand(sql, DBHelper.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("记录已成功删除");
                DBHelper.conn.Close();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //定义sql语句
            string sql = string.Format("select courseID,coursename,coursecredit from tbcourse");
            try
            {
                //执行sql
                if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
                cmd = new SqlCommand(sql, DBHelper.conn);
                cmd.CommandType = CommandType.Text;

                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                ds = new DataSet();
                if (ds.Tables.Count > 0)
                    ds.Tables[0].Clear();
                //填充到dgvCourse
                sda.Fill(ds, "course");
                DGVCourse.DataSource = ds.Tables["course"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
