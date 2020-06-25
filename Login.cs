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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;
            string message = "";
            if (ValidateInput())
            {
                isValidUser = ValidateUser(
                    cboLoginType.Text,
                    txtLoginId.Text,
                    txtLoginPwd.Text,
                    ref message);
                if (isValidUser)
                {
                    UserHelper.loginId = txtLoginId.Text;
                    UserHelper.loginType = cboLoginType.Text;

                    ShowUserForm();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show(message, "登录失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// 取消功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// sql语句 
        /// </summary>
        /// <param name="loginType"></param>
        /// <param name="loginId"></param>
        /// <param name="loginPwd"></param>
        /// <param name="message"></param>
        /// <returns>isValidUser</returns>
        public bool ValidateUser(string loginType, string loginId, string loginPwd, ref string message)
        {
            //定义受影响的行数
            int count = 0;
            //定义标签
            bool isValidUser = false;
            if (loginType == "管理员") {
                string sql = string.Format(
                    "SELECT COUNT (*) FROM tbadmin WHERE loginid='{0}'AND loginpwd='{1}'", loginId, loginPwd);
                try
                {
                    DBHelper.conn.Open();//打开数据库
                    //执行查询
                    SqlCommand command = new SqlCommand();
                    //获取或设置数据库的连接对象
                    command.Connection = DBHelper.conn;
                    //Command 对象中要执行的 SQL 语句
                    command.CommandText = sql;
                    //获取或设置命令类型
                    command.CommandType = CommandType.Text;

                    //返回查询结果中第 1 行第 1 列的值
                    count = (int)command.ExecuteScalar();
                    if (count == 1)
                    {
                        isValidUser = true;
                    }
                    else
                    {
                        message = "用户名或密码不存在";
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    MessageBox.Show(ex.Message);
                }
                finally {
                    DBHelper.conn.Close();
                }
            } else if (loginType == "学生")
            {
                string sql = string.Format(
                    "select COUNT (*) from tbstudent where loginId='{0}'and loginPwd='{1}'", txtLoginId.Text, txtLoginPwd.Text);
                try {
                    DBHelper.conn.Open();//打开数据库
                    SqlCommand command = new SqlCommand();
                    //执行查询
                    command.Connection = DBHelper.conn;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    //如果没有找到，则是非法用户
                    count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isValidUser = true;
                    }
                    else
                    {
                        message = "用户或密码不存在！";
                        isValidUser = false;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                finally {
                    DBHelper.conn.Close();
                }
            } else if (loginType == "教师") {
                string sql = string.Format(
                    "select COUNT (*) from tbteacher where teacherID='{0}'and loginpwd='{1}'", txtLoginId.Text, txtLoginPwd.Text);
                try {
                    DBHelper.conn.Open();//打开数据库
                    SqlCommand command = new SqlCommand();
                    //执行查询
                    command.Connection = DBHelper.conn;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    //如果没有找到，则是非法用户
                    count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isValidUser = true;
                    }
                    else
                    {
                        message = "用户或密码不存在！";
                        isValidUser = false;
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                } finally {
                    DBHelper.conn.Close();
                }
            }

            return isValidUser;
        }

            /// <summary>
            /// 验证输入
            /// </summary>
            /// <returns>若结果为空，则结果返回false</returns>
            private bool ValidateInput() {
            if (txtLoginId.Text.Trim()=="") {
                MessageBox.Show("请输入用户名","请提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //获得输入焦点.调用方法就会让该控制获得输入焦点.
                txtLoginId.Focus();
                return false;
            }
            else if (txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            else if (cboLoginType.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLoginType.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 登录时对应的不同类型所显示不同窗体
        /// </summary>
        public void ShowUserForm()
        {
            switch (cboLoginType.Text)
            {
                //如果是学员，显示学员窗体
                case "学生":
                    MessageBox.Show("欢迎您，同学");
                    MainFormS mfs = new MainFormS();
                    mfs.Show();
                    break;
                case "教师":
                    MainFormT mft = new MainFormT();
                    mft.Show();
                    break;
                case "管理员":
                    MainForm mf = new MainForm();
                    mf.Show();
                    break;
                default:
                    MessageBox.Show("Sorry，您请求的功能尚未完成！");
                    break;
            }
        }
    }
}
