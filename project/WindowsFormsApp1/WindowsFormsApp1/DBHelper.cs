using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class DBHelper
    {
        //创建连接字符串
        static string connString = "server=.;database=Car;uid=sa;pwd=123";
        //自定义方法，实现增、删、改数据库操作，返回bool值
        public static bool Excute(string sql)
        {
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //打开连接
            conn.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //使用cmd的ExecuteNonQuery方法返回受影响的行数
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        //自定义方法，实现查询数据库操作，返回DataTable
        public static DataTable Select(string sql)
        {
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //创建DataAdapter对象
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            //创建容器
            DataTable dt = new DataTable();
            //使用dap的Fill方法填充数据
            dap.Fill(dt);
            return dt;
        }

    }
}
