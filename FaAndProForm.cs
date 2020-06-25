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
    public partial class FaAndProForm : Form
    {
        class Status
        {
            public static string sql;
        }
        SqlCommand cmd;
        public FaAndProForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dep院系管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDepAdd_Click(object sender, EventArgs e)
        {
            if (TxtDepId.Text.Trim() == "")
            {
                MessageBox.Show("请输入系号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TxtDepName.Text.Trim() == "")
            {
                MessageBox.Show("请输入院系名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TxtDepCall.Text.Trim() == "")
            {
                MessageBox.Show("请输入院系电话", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string sql = string.Format("INSERT INTO tbdepartment VALUES ('{0}','{1}','{2}')", TxtDepId.Text, TxtCName.Text, TxtDepCall.Text);
                    DBHelper.conn.Open();
                    SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                    int result = command.ExecuteNonQuery();

                    if (result < 1)
                    {
                        MessageBox.Show("录入失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("录入成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtDepId.Text = "";
                        TxtDepName.Text = "";
                        TxtDepCall.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库操作错误:" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBHelper.conn.Close();
                    this.ViewInfo();
                }
            }
        }
        private void ViewInfo()
        {
            string sql = string.Format("select * from tbdepartment");
            DBHelper.conn.Open();
            SqlCommand command = new SqlCommand(sql, DBHelper.conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = command;
            sda.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            DGVDep.DataSource = dv;
            DBHelper.conn.Close();

        }
        private void BtnDepUpdate_Click(object sender, EventArgs e)
        {
            int rowNumber = DGVDep.CurrentCell.RowIndex;

            string dId = DGVDep.Rows[rowNumber].Cells[0].Value.ToString();
            string dName = DGVDep.Rows[rowNumber].Cells[1].Value.ToString();
            string dPhone = DGVDep.Rows[rowNumber].Cells[2].Value.ToString();
            try
            {
                string sql = string.Format("update tbdepartment set depname='{0}',depPhone='{1}' where depID='{2}'", dName, dPhone, dId);
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
                this.ViewInfo();
            }
        }

        private void BtnDepDelete_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            string depID = DGVDep.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            if (depID == "")
                MessageBox.Show("请选择要删除的系部！");
            else
            {
                string sql = "delete from tbdepartment where depID='" + depID + "'";
                cmd = new SqlCommand(sql, DBHelper.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("记录已成功删除");
                DBHelper.conn.Close();
                this.ViewInfo();
            }
        }

        private void BtnDepCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FaAndProForm_Load(object sender, EventArgs e)
        {
            this.ViewInfo();
            //this.ViewInfo1();
            string sql = "select depname from tbdepartment";
            //读取系部名
            DBHelper.conn.Open();
            SqlCommand command = new SqlCommand(sql, DBHelper.conn);
            SqlDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                string sno = (string)datareader["depname"];
                CboDep.Items.Add(sno);
            }
            DBHelper.conn.Close();
        }
        /// <summary>
        /// 专业管理部分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtCId.Text == "")
            {
                MessageBox.Show("请输入专业号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCId.Focus();
            }
            else if (TxtCName.Text == "")
            {
                MessageBox.Show("请输入专业名称！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCName.Focus();
            }
            else if (CboDep.Text == "")
            {
                MessageBox.Show("请选择所在院系！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboDep.Focus();
            }
            else
            {
                try
                {
                    string sql1 = string.Format("select depID from tbdepartment where depname='{0}'", CboDep.Text);
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

                    string sql = string.Format("insert into tbclass(classID,classname,depId) values('{0}','{1}','{2}')", TxtCId.Text, TxtCName.Text, Status.sql);
                    DBHelper.conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);
                    int result1 = cmd.ExecuteNonQuery();
                    if (result1 < 1)
                    {
                        MessageBox.Show("添加失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DBHelper.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DBHelper.conn.Close();
                        this.ViewInfo1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库操作出错：" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int rowNumber = DGVClass.CurrentCell.RowIndex;

            string cId = DGVClass.Rows[rowNumber].Cells[0].Value.ToString();
            string cName = DGVClass.Rows[rowNumber].Cells[1].Value.ToString();
            string depID = DGVClass.Rows[rowNumber].Cells[2].Value.ToString();
            try
            {
                string sql = string.Format("update tbclass set classname='{0}',depID='{1}' where classID='{2}'", cName, depID, cId);
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
                this.ViewInfo();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();
            string classID = DGVClass.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            if (classID == "")
                MessageBox.Show("请选择要删除的专业！");
            else
            {
                string sql = "delete from tbclass where classID='" + classID + "'";
                cmd = new SqlCommand(sql, DBHelper.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("记录已成功删除");
                DBHelper.conn.Close();
                this.ViewInfo1();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewInfo1()
        {
            string sql = string.Format("select classID,classname,depID from tbclass");
            DBHelper.conn.Open();
            SqlCommand command = new SqlCommand(sql, DBHelper.conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = command;
            sda.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            DGVClass.DataSource = dv;
            DBHelper.conn.Close();

        }
    }
}
