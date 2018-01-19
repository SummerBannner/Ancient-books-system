using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SLMS
{
    class DataOper
    {
        private static String StrConn;
        private static SqlConnection conn;// SQL Server 数据库的一个打开的连接
        private static DataSet ds;//数据在内存中的缓存
        private static SqlDataAdapter sda;
        //用于填充 DataSet 和更新 SQL Server 数据库的一组数据命令和一个数据库连接
        private static SqlCommand sc;//执行数据库查询语句

        public void goToConnect()
        {
            StrConn = "Data Source=localhost;Initial Catalog=SLSM;Integrated Security=True";
            try
            {
                conn = new SqlConnection(StrConn);//新建数据库连接
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new Exception(ex.Message);//抛出异常
            }
        }

        public DataSet query(String StrSql)
        {
            ds = new DataSet();
            conn.Open();//打开数据库连接
            sda = new SqlDataAdapter(StrSql, conn);
            sda.Fill(ds, "ds");
            conn.Close();//关闭数据库连接
            return ds;
        }

        public int DataProcessor(String StrSql)
        {
            int Row = 0;//影响行数
            conn.Open();//打开数据库连接
            sc = conn.CreateCommand();
            sc.CommandText = StrSql;
            Row = sc.ExecuteNonQuery();
            conn.Close();//关闭数据库连接
            return Row;
        }
    }
}
