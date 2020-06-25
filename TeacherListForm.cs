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
    public partial class TeacherListForm : Form
    {
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataSet ds;
        public TeacherListForm()
        {
            InitializeComponent();
        }

        public void updateGridView() {
            string sql = string.Format("select teacherID,teacherName,coursename,depname from tbteacher");
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = DBHelper.conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            if (ds.Tables.Count > 0)
                ds.Tables[0].Clear();
            sda.Fill(ds, "teacher");
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();

            string stradd = string.Format("insert into tbteacher(teacherID,loginpwd,teacherName,coursename,depname) values ('{0}','{1}','{2}','{3}','{4}')", TxtNo.Text, TxtPwd.Text, TxtName.Text, CboCName.Text, CboDep.Text);
            cmd = new SqlCommand();
            cmd.Connection = DBHelper.conn;
            cmd.CommandText = stradd;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            MessageBox.Show("记录已成功添加！");
            TxtNo.Text = "";
            TxtName.Text = "";
            TxtPwd.Text = "";

            updateGridView();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要保存修改吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(ds, "teacher");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            string teaID = DataGridViewTeacher.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            if (teaID == "")
                MessageBox.Show("请选择要删除的学生！");
            else
            {
                string sql = "delete from tbteacher where teacherID='" + teaID + "'";
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

        }

        private void TeacherListForm_Load(object sender, EventArgs e)
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
            string sql = string.Format("SELECT coursename FROM tbteacher WHERE depname='{0}'", CboDep.Text);

            cmd = new SqlCommand(sql, DBHelper.conn);

            try
            {
                DBHelper.conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                string coursename = "";
                CboCName.Items.Clear();

                while (sdr.Read())
                {
                    coursename = (string)sdr["coursename"];
                    CboCName.Items.Add(coursename);
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

        private void CboCName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
