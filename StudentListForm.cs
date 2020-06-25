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
    public partial class StudentListForm : Form
    {
        class Status
        {
            public static string sql;
        }
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataSet ds;

        static string ClassName = "";
        static string ClassID = "";
        static string DepName = "";
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("select classID from tbclass where classname='{0}'", CboClass.Text);

            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = DBHelper.conn;
            cmd.CommandText = sql1;
            cmd.CommandType = CommandType.Text;

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ClassID = sdr["classID"].ToString().Trim();
            }
            sdr.Close();
            string sql = string.Format("select studentID,loginid,studentname,studentNO,Sex,classID from tbstudent where classID='{0}' ", ClassID);

            try
            {
                if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
                cmd = new SqlCommand(sql, DBHelper.conn);
                cmd.CommandType = CommandType.Text;

                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                ds = new DataSet();
                if (ds.Tables.Count > 0)
                    ds.Tables[0].Clear();

                sda.Fill(ds, "Student");
                DGVStudent.DataSource = ds.Tables["Student"];

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要保存修改吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                sda.Update(ds, "student");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            string StuID = DGVStudent.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            if (StuID == "")
                MessageBox.Show("请选择要删除的学生！");
            else
            {
                string sql = "delete from tbstudent where studentID='" + StuID + "'";
                cmd = new SqlCommand(sql, DBHelper.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("记录已成功删除");
                updateGridView();
                DBHelper.conn.Close();
            }
        }

        private void BtnRefersh_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        public void updateGridView()
        {
            string sql = string.Format("select studentID,loginid,studentname,studentNO,Sex,s.classID from tbstudent s,tbclass c where s.classID=c.classID and c.classname='{0}'", CboClass.Text);
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = DBHelper.conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            if (ds.Tables.Count > 0)
                ds.Tables[0].Clear();
            sda.Fill(ds, "Student");
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            if (CboClass.Text.Trim() == "")
                MessageBox.Show("请选择班级！");
            string sql1 = string.Format("select classID from tbclass where classname='{0}'", CboClass.Text);
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
                Status.sql = (string)reader["classID"];

            }
            DBHelper.conn.Close();
            //打开数据库
            DBHelper.conn.Open();
            //sql语句
            string stradd = string.Format("insert into tbstudent(studentNO,studentname,classID,Sex) values('{0}','{1}','{2}','{3}')", TxtStuNo.Text, TxtStuName.Text, Status.sql, CboSex.Text);
            //执行sql语句
            cmd = new SqlCommand();
            cmd.Connection = DBHelper.conn;
            cmd.CommandText = stradd;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            MessageBox.Show("记录已成功添加！");
            //情况text
            TxtStuNo.Text = "";
            TxtStuName.Text = "";
            CboSex.Text = "";

            updateGridView();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            string sql = "select depname from tbdepartment";

            cmd = new SqlCommand(sql, DBHelper.conn);

            try
            {
                DBHelper.conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                string depName = "";

                while (sdr.Read())
                {
                    depName = (string)sdr["depname"];
                    CboDep.Items.Add(depName);
                }
                sdr.Close();
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

        private void CboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepName = CboDep.SelectedItem.ToString().Trim();
            CboClass.Items.Clear();
            string sql = string.Format("SELECT c.classname FROM tbclass c,tbdepartment d WHERE d.depname='{0}' and c.depID=d.depID", DepName);
            cmd = new SqlCommand(sql, DBHelper.conn);

            try
            {
                if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();//执行查询

                string className = "";
                //循环读出所有的班级名
                while (dataReader.Read())
                {
                    className = (string)dataReader["ClassName"];
                    CboClass.Items.Add(className);

                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库出错");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            LblDep.Text = DepName;
        }

        private void CboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassName = CboClass.SelectedItem.ToString().Trim();
            LblClass.Text = ClassName;

            string sql = string.Format("select * from tbclass where classID='{0}'", ClassID);

            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = DBHelper.conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ClassID = sdr["classname"].ToString().Trim();
            }
            sdr.Close();
        }
    }
}
