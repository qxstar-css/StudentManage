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
    public partial class StudentUserAddForm : Form
    {
        public StudentUserAddForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) {
                string loginID = TxtLoginId.Text;
                string loginPwd = TxtLoginPwd.Text;

                string userStateID = RadioActive.Checked ? (string)RadioActive.Tag : (string)RadioInActive.Tag;
                string classID = CboClass.Text;
                string name = TxtStudentName.Text;
                string sex = RadioMale.Checked ? (string)RadioMale.Tag:(string)RadioFemale.Tag;
                string phone = TxtPhone.Text;
                string studentID = TxtId.Text;
                string email = TxtEmail.Text;

                string sql = string.Format("insert into tbstudent (loginId,loginPwd,userState,classId,studentName,sex,phone,studentNo,email) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                 loginID, loginPwd, userStateID, classID, name, sex, phone, studentID, email);

                try {
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

        private bool ValidateInput()
        {
            if (TxtLoginId.Text == "")
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoginId.Focus();
                return false;
            }
            if (TxtLoginPwdAgain.Text == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoginPwdAgain.Focus();
                return false;
            }
            if (TxtLoginPwdAgain.Text == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoginPwdAgain.Focus();
                return false;
            }
            if (!(TxtLoginPwd.Text == TxtLoginPwdAgain.Text))
            {
                MessageBox.Show("两次输入密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoginPwdAgain.Focus();
                return false;
            }
            if (!RadioActive.Checked && !RadioInActive.Checked)
            {
                MessageBox.Show("请设置用户状态", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RadioActive.Focus();
                return false;
            }
            if (TxtStudentName.Text == "")
            {
                MessageBox.Show("请输入学员姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtStudentName.Focus();
                return false;
            }
            if (TxtId.Text == "")
            {
                MessageBox.Show("请输入学员学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtId.Focus();
                return false;
            }
            if (!RadioMale.Checked && !RadioFemale.Checked)
            {
                MessageBox.Show("请选择学员性别", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RadioMale.Focus();
                return false;
            }
            if (CboClass.Text == "")
            {
                MessageBox.Show("请选择学员班级", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboClass.Focus();
                return false;
            }
            return true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentUserAddForm_Load(object sender, EventArgs e)
        {
            string sql = "select ClassID from tbClass";
            SqlCommand command = new SqlCommand(sql, DBHelper.conn);

            try
            {
                DBHelper.conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                string ClassID = "";

                while (dataReader.Read())
                {
                    ClassID = (string)dataReader["Classid"];
                    CboClass.Items.Add(ClassID);
                }
                dataReader.Close();
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
    }
}
