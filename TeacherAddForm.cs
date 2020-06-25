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
    public partial class TeacherAddForm : Form
    {
        SqlCommand cmd;//创建command对象
        public TeacherAddForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string ID = TxtTcId.Text;
                string loginPwd = TxtLoPwd.Text;

                string name = TxtTcName.Text;
                string soursename = CboName.Text;
                string dep = CboDep.Text;


                string sql = string.Format("insert into tbteacher (teacherID,loginpwd,teachername,depname,coursename) values('{0}','{1}','{2}','{3}','{4}')",
                   ID, loginPwd, name, dep, soursename);

                try
                {
                    SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                    DBHelper.conn.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("添加成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作出错", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.conn.Close();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (TxtTcId.Text == "")
            {
                MessageBox.Show("请输入教师号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTcId.Focus();
                return false;
            }
            if (TxtLoPwd.Text == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoPwd.Focus();
                return false;
            }
            if (TxtLoAgainPwd.Text == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoAgainPwd.Focus();
                return false;
            }
            if (!(TxtLoPwd.Text == TxtLoAgainPwd.Text))
            {
                MessageBox.Show("两次输入密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoAgainPwd.Focus();
                return false;
            }
            if (TxtTcName.Text == "")
            {
                MessageBox.Show("请输入姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTcName.Focus();
                return false;
            }
            if (CboDep.Text == "")
            {
                MessageBox.Show("请输入系部名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboDep.Focus();
                return false;
            }
            if (CboName.Text == "")
            {
                MessageBox.Show("请输入所授课程", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboName.Focus();
                return false;
            }
            return true;
        }
        private void TeacherAddForm_Load(object sender, EventArgs e)
        {
            string sql = "select depname from tbdepartment";          //构建插入的sql语句
            cmd = new SqlCommand(sql, DBHelper.conn);   //创建command对象

            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();     //数据库连接 
            SqlDataReader sdr0 = cmd.ExecuteReader();      //执行查询

            string Depname = "";

            //循环读出所有的系部名，并添加到院系名称列表框中
            while (sdr0.Read())
            {
                Depname = (string)sdr0["depname"];
                CboDep.Items.Add(Depname);
            }

            sdr0.Close();//关闭数据库
            string sql1 = "select coursename from tbcourse";          //构建插入的sql语句
            cmd = new SqlCommand(sql1, DBHelper.conn);   //创建command对象

            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();     //数据库连接 
            SqlDataReader sdr = cmd.ExecuteReader();      //执行查询

            string course = "";

            //循环读出所有的课程名
            while (sdr.Read())
            {
                course = (string)sdr["coursename"];
                CboName.Items.Add(course);
            }
            sdr.Close();
            DBHelper.conn.Close();
        }
    }
}
