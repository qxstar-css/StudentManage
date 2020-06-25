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
    public partial class ScoreAnalyseForm : Form
    {
        class Status
        {
            public static string sql;
        }
        SqlCommand cmd;//创建command对象
        public ScoreAnalyseForm()
        {
            InitializeComponent();
        }
        private void validateput()
        {
            //依次创建列名
            ColumnHeader col1 = new ColumnHeader();
            col1.Text = "学号";
            listView1.Columns.Add(col1);

            ColumnHeader col2 = new ColumnHeader();
            col2.Text = "课程名";
            listView1.Columns.Add(col2);

            ColumnHeader col3 = new ColumnHeader();
            col3.Text = "课程号";
            listView1.Columns.Add(col3);

            ColumnHeader col4 = new ColumnHeader();
            col4.Text = "分数";
            listView1.Columns.Add(col4);

            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();  //打开数据库
            string str = string.Format("select studentNO,coursename,tbscore.courseID,score from tbcourse,tbscore where tbcourse.courseID=tbscore.courseID");//构建插入的sql语句
            cmd = new SqlCommand(str, DBHelper.conn); //构建command对象


            listView1.View = View.Details;
            SqlDataReader sdr = cmd.ExecuteReader();  //执行查询

            //循环读出所有的列，并添加到listview中
            while (sdr.Read())
            {
                string[] st = new string[4];
                st[0] = sdr[0].ToString();
                st[1] = sdr[1].ToString();
                st[2] = sdr[2].ToString();
                st[3] = sdr[3].ToString();

                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Insert(0, lv);
            }
            DBHelper.conn.Close();//关闭数据库连接
        }
        private void BtnAnalysis_Click(object sender, EventArgs e)
        {
            //清空listview
            listView1.Items.Clear();

            if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();  //打开数据库
            string str = string.Format("select studentNO,coursename,tbscore.courseID,score from tbcourse,tbscore where tbcourse.courseID=tbscore.courseID and coursename='{0}'", CboCourseName.Text);//构建插入的sql语句
            cmd = new SqlCommand(str, DBHelper.conn); //构建command对象


            listView1.View = View.Details;
            SqlDataReader sdr = cmd.ExecuteReader();  //执行查询

            //循环读出所有的列，并添加到listview中
            while (sdr.Read())
            {
                string[] st = new string[4];
                st[0] = sdr[0].ToString();
                st[1] = sdr[1].ToString();
                st[2] = sdr[2].ToString();
                st[3] = sdr[3].ToString();

                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Insert(0, lv);
            }
            DBHelper.conn.Close();//关闭数据库连接
            try
            {
                //定义Status
                string str6 = string.Format("select courseID from tbcourse where coursename='{0}'", CboCourseName.Text);
                DBHelper.conn.Open();
                SqlCommand cmd1 = new SqlCommand(str6, DBHelper.conn);
                SqlDataReader datareader1 = cmd1.ExecuteReader();
                while (datareader1.Read())
                {
                    Status.sql = (string)datareader1["courseID"];
                }
                DBHelper.conn.Close();

                //求选择所选课程的总人数
                string str8 = string.Format("select count(*) from tbscore where courseID='{0}'", Status.sql);
                DBHelper.conn.Open();
                SqlCommand cmd3 = new SqlCommand(str8, DBHelper.conn);
                int num = (int)cmd3.ExecuteScalar();
                DBHelper.conn.Close();

                //分数大于等于60的人数
                string str9 = string.Format("select count(*) from tbscore where courseID='{0}' and score>=60", Status.sql);
                DBHelper.conn.Open();
                SqlCommand cmd4 = new SqlCommand(str9, DBHelper.conn);
                int passnum = (int)cmd4.ExecuteScalar();
                DBHelper.conn.Close();

                //求分数大于85的人数
                string str10 = string.Format("select count(*) from tbscore where courseID='{0}' and score>=80", Status.sql);
                DBHelper.conn.Open();
                SqlCommand cmd5 = new SqlCommand(str10, DBHelper.conn);
                int Greatnum = (int)cmd5.ExecuteScalar();
                DBHelper.conn.Close();

                //在求平均分
                string str11 = string.Format("select AVG(score) from tbscore where courseID='{0}'", Status.sql);
                DBHelper.conn.Open();
                SqlCommand cmd6 = new SqlCommand(str11, DBHelper.conn);
                int avg = (int)(cmd6.ExecuteScalar());
                DBHelper.conn.Close();

                //现实查询结果
                float passRate = 100 * (float)passnum / num;
                float greatrate = 100 * (float)Greatnum / num;
                TxtPassRate.Text = passRate.ToString("0.00");  //保留两位
                TxtExcellentRate.Text = greatrate.ToString("0.00");//保留两位
                TxtAVG.Text = avg.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作出错:" + ex.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DBHelper.conn.State == ConnectionState.Open) DBHelper.conn.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreAnalyseForm_Load(object sender, EventArgs e)
        {
            string sql = "select coursename from tbcourse";          //构建插入的sql语句
            cmd = new SqlCommand(sql, DBHelper.conn);   //创建command对象

            try
            {
                if (DBHelper.conn.State == ConnectionState.Closed) DBHelper.conn.Open();     //数据库连接 
                SqlDataReader sdr0 = cmd.ExecuteReader();      //执行查询

                string Depname = "";

                //循环读出所有的课程名
                while (sdr0.Read())
                {
                    Depname = (string)sdr0["coursename"];
                    CboCourseName.Items.Add(Depname);
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
            validateput();
        }
    }
}
