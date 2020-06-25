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
    public partial class StudentUserSearchForm : Form
    {
        public StudentUserSearchForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (TxtLoginId.Text == "")
            {
                MessageBox.Show("请输入用户名", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoginId.Focus();
            }
            else
            {
                FillListView();
            }
        }

        /// <summary>
        /// 自定义FillListView方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FillListView() {
            string loginId;
            string studentName;
            string studentNO;
            int userStateId;
            string userState;

            string sql = string.Format(
                "SELECT studentId,loginId,studentNo,studentName,userState FROM tbstudent WHERE loginId like '%{0}%'", TxtLoginId.Text);
            try
            {
                SqlCommand command = new SqlCommand(sql, DBHelper.conn);//查询命令
                DBHelper.conn.Open();//打开连接

                SqlDataReader dataReader = command.ExecuteReader();

                listView1.Items.Clear();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("抱歉，没有您要找的用户！", "结果提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    while (dataReader.Read())
                    {
                        loginId = (string)dataReader["loginid"];
                        studentName = (string)dataReader["studentname"];
                        studentNO = (string)dataReader["studentNO"];
                        userStateId = (int)dataReader["userstate"];
                        userState = (userStateId == 1) ? "活动" : "非活动";

                        string[] str = new string[4];
                        str[0] = loginId;
                        str[1] = studentName;
                        str[2] = studentNO;
                        str[3] = userState;

                        ListViewItem lvi = new ListViewItem(str);
                        lvi.Tag = (int)dataReader["studentID"];
                        listView1.Items.Add(lvi);
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }
        /// <summary>
        /// 数据更新,未编写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 数据删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("您没有选择任何用户", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult choice = MessageBox.Show("确定要删除么？", "操作警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choice == DialogResult.Yes)
                {
                    string sql = string.Format("DELETE FROM tbStudent WHERE studentID={0}", (int)listView1.SelectedItems[0].Tag);

                    SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                    int result = 0;

                    try
                    {
                        DBHelper.conn.Open();
                        result = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        DBHelper.conn.Close();
                    }
                    if (result < 1)
                    {
                        MessageBox.Show("删除失败", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("删除成功", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillListView();
                    }

                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
