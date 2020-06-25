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
    public partial class ClassForm : Form
    {
        class Status
        {
            public static string sql;
        }
        SqlCommand cmd;//创建command对象
        public ClassForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string sql1 = string.Format("select depID from tbdepartment where depname='{0}'", CboDepName.Text);
                if (DBHelper.conn.State == ConnectionState.Open)
                {
                    DBHelper.conn.Close();
                    DBHelper.conn.Open();
                }
                else if (DBHelper.conn.State == ConnectionState.Closed)
                {
                    DBHelper.conn.Open();
                }
                SqlCommand command = new SqlCommand(sql1, DBHelper.conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Status.sql = (string)reader["depID"];

                }
                DBHelper.conn.Close();
                //获取要插入数据库的每一个字段的值
                string classId = TxtCId.Text;    //班级代码
                string className = TxtCName.Text;      //班级名称
                string studentNum = TxtNum.Text;        //学生人数


                //调用获取班级id的方法，获取班级id
                string deptName = CboDepName.Text;

                //构建插入的sql语句
                string sql = string.Format("insert into tbclass(classID,className,depID,studentnum) values('{0}','{1}','{2}','{3}')", classId, className, Status.sql, studentNum);
                DBHelper.conn.Open();       //数据库连接

                try
                {
                    cmd = new SqlCommand(sql, DBHelper.conn);      //创建command对象                    
                    //listView1.View = View.Details;
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
                    MessageBox.Show("操作数据库出错！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);//出现异常，打开异常消息
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.conn.Close();     //关闭数据库连接
                }
                listView1.Clear();//清空listview
                validateput1();
            }
        }
        private bool ValidateInput()
        {
            if (TxtCId.Text == "")    //验证是否输入了班级代码
            {
                MessageBox.Show("请输入班级号！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCId.Focus();
                return false;
            }
            if (TxtCName.Text == "")       //验证是否输入了班级名称
            {
                MessageBox.Show("请输入班级名称！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCName.Focus();
                return false;
            }
            if (TxtNum.Text == "")      //验证是否输入了人数
            {
                MessageBox.Show("请输入学生人数！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNum.Focus();
                return false;
            }
            return true;
        }
        private void validateput1()
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();  //打开数据库
            string str = string.Format("select classID,classname,tbclass.depID,depname,studentnum from tbclass,tbdepartment where tbclass.depID=tbdepartment.depID");//构建插入的sql语句
            cmd = new SqlCommand(str, DBHelper.conn); //构建command对象

            //依次创建列名班级号、班级名称、系部号、系部名称、班级人数的列

            //创建listview
            ColumnHeader col1 = new ColumnHeader();
            col1.Text = "班级号";
            listView1.Columns.Add(col1);

            ColumnHeader col2 = new ColumnHeader();
            col2.Text = "班级名称";
            listView1.Columns.Add(col2);

            ColumnHeader col3 = new ColumnHeader();
            col3.Text = "系部号";
            listView1.Columns.Add(col3);

            ColumnHeader col4 = new ColumnHeader();
            col4.Text = "系部名称";
            listView1.Columns.Add(col4);

            ColumnHeader col5 = new ColumnHeader();
            col5.Text = "班级人数";
            listView1.Columns.Add(col5);


            listView1.View = View.Details;
            SqlDataReader sdr = cmd.ExecuteReader();  //执行查询

            //循环读出所有的列，并添加到listview中
            while (sdr.Read())
            {
                string[] st = new string[5];
                st[0] = sdr[0].ToString();
                st[1] = sdr[1].ToString();
                st[2] = sdr[2].ToString();
                st[3] = sdr[3].ToString();
                st[4] = sdr[4].ToString();

                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Insert(0, lv);
            }
            DBHelper.conn.Close();//关闭数据库连接
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //赋值
            string classno = TxtCId.Text;
            string classname = TxtCName.Text;
            string studentnum = TxtNum.Text;
            //把系部名转换为系部号并赋值
            string sql1 = string.Format("select depID from tbdepartment where depname='{0}'", CboDepName.Text);
            if (DBHelper.conn.State == ConnectionState.Open)
            {
                DBHelper.conn.Close();
                DBHelper.conn.Open();
            }
            else if (DBHelper.conn.State == ConnectionState.Closed)
            {
                DBHelper.conn.Open();
            }
            SqlCommand command = new SqlCommand(sql1, DBHelper.conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Status.sql = (string)reader["depID"];

            }
            DBHelper.conn.Close();
            string sql = string.Format("update tbclass set classname='{0}',studentnum='{1}',depID='{2}' where classID='{3}' ", classname, studentnum, Status.sql, classno);//执行更新的sql语句

            SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);//构建commamd对象

            try
            {
                cmd.CommandText = sql;//重新给cnd对象赋值
                DBHelper.conn.Open();//打开数据库连接
                int result = cmd.ExecuteNonQuery();//执行命令

                if (result < 1)//返回的值小于1，说明没有记录被影响，操作失败
                {
                    MessageBox.Show("修改失败", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改成功", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);//出现异常，打开异常消息
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();//关闭数据库连接
            }
            listView1.Clear();
            validateput1();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string classid = TxtCId.Text;
            ////确保用户选择了一条记录才执行删除命令
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("您没有选选择任何用户", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //为防止误删除，要先查询
                DialogResult choice = MessageBox.Show("确定要删除该记录吗？", "操作警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //如果确定删除，则执行删除操作
                if (choice == DialogResult.Yes)
                {
                    //删除sql语句
                    string sql = string.Format("delete from tbclass where classID='" + this.listView1.SelectedItems[0].SubItems[0].Text + "' ");
                    SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);//创建cmd对象
                    int result = 0;
                    try
                    {
                        DBHelper.conn.Open(); //打开数据库连接
                        result = cmd.ExecuteNonQuery();//执行命令
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);////出现异常，打开异常消息
                    }
                    finally
                    {
                        DBHelper.conn.Close();//关闭数据库连接
                    }
                    if (result < 1)//操作失败
                    {
                        MessageBox.Show("删除失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else//操作成功
                    {
                        MessageBox.Show("删除成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listView1.Clear();
                        validateput1();
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //点击listview后填充到txt和cbo中
            TxtCId.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
            TxtCName.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
            TxtNum.Text = this.listView1.SelectedItems[0].SubItems[4].Text;
            CboDepName.Text = this.listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            string sql = "select depname from tbdepartment";          //构建插入的sql语句
            cmd = new SqlCommand(sql, DBHelper.conn);   //创建command对象

            try
            {
                if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();     //数据库连接 
                SqlDataReader sdr0 = cmd.ExecuteReader();      //执行查询

                string Depname = "";

                //循环读出所有的系部名，并添加到院系名称列表框中
                while (sdr0.Read())
                {
                    Depname = (string)sdr0["depname"];
                    CboDepName.Items.Add(Depname);
                }
                sdr0.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作出错！");
                Console.WriteLine(ex.Message);    //出现异常，打开异常消息
            }
            finally
            {
                DBHelper.conn.Close();    //关闭数据库连接
            }
            validateput1();
        }
    }
}
