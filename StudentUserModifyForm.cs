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
    public partial class StudentUserModifyForm : Form
    {
        public int studentId;
        public StudentUserModifyForm()
        {
            InitializeComponent();
        }

        private void BtnModifyStudent_Click(object sender, EventArgs e)
        {
            string loginid = TxtLogin.Text;
            string loginpwd = TxtLoginPwd.Text;
            int stateid = RadioActive.Checked ? 1 : 0;
            string name = TxtStuName.Text;
            string stuNO = TxtStuNo.Text;
            string sex = RadioMale.Checked ? "男" : "女";
            string classid = CboClass.Text;

            //string sql = string.Format("UPDATE tbstudent SET loginid='{0}',loginpwd='{1}',userstate='{2}',studentname='{3}',studentNO='{4}',Sex='{5}',classID='{6}',studentID={7}",
            // loginid, loginpwd, stateid, name, stuNO, sex, classid,this.studentId);
            string sql = string.Format("UPDATE tbstudent SET loginid='" + loginid.Trim() + "',loginpwd='" + loginpwd.Trim() + "',userstate='" + stateid + "',studentname='" + name.Trim() + "',studentNO='" + stuNO.Trim() + "',sex='" + sex.Trim() + "',classID='" + classid.Trim() + "' where studentID='" + studentId.ToString() + "'");

            SqlCommand command = new SqlCommand(sql, DBHelper.conn);
            try
            {
                command.CommandText = sql;

                DBHelper.conn.Open();
                int result = command.ExecuteNonQuery();
                if (result < 1)
                {
                    MessageBox.Show("修改失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void StudentUserModifyForm_Load(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT loginid,loginpwd,userstate,studentname,studentNO,Sex,classID FROM tbstudent WHERE studentID='{0}'", studentId);
            try
            {
                SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                string classId = "";

                if (dataReader.Read())
                {
                    TxtLogin.Text = (string)dataReader["loginid"];
                    TxtLoginPwd.Text = (string)dataReader["loginpwd"];

                    int userstate = (int)dataReader["userstate"];
                    if (userstate == 1)
                    {
                        RadioActive.Checked = true;
                    }
                    else
                    {
                        RadionInActive.Checked = true;
                    }

                    TxtStuName.Text = (string)dataReader["studentname"];
                    TxtStuNo.Text = (string)dataReader["studentNO"];
                    if ((string)dataReader["Sex"] == "男")
                    {
                        RadioMale.Checked = true;
                    }
                    else
                    {
                        RadioFemale.Checked = true;
                    }
                    classId = (string)dataReader["classID"];
                }
                dataReader.Close();

                sql = "SELECT classID,classname FROM tbclass";
                command.CommandText = sql;
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    CboClass.Items.Add((string)dataReader["classID"]);

                    if (classId == (string)dataReader["classID"])
                    {
                        CboClass.Text = (string)dataReader["classID"];
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }
    }
}
