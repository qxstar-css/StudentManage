using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage
{
    /// <summary>
    /// sql数据库连接字符串
    /// </summary>
    class DBHelper
    {
        private static string str = "Data Source=.;Initial Catalog=studb;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(str);
    }
}
