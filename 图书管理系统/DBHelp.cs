using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace 古籍管理系统
{
    class DBHelp
    {

        public static SqlDataReader OleReader(string sql)
        {
            string connString = @"Data Source=SUNHAO-PC;Initial Catalog=古籍管理系统;Integrated Security=True;Pooling=False";
            SqlConnection cn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, cn);
            cn.Open();  
            SqlDataReader dr = command.ExecuteReader();
            //cn.Close();
            //cn.Dispose();
            return dr;

        }
        public static DataTable ExeOleCommand(string sql) 
        {
            string connString = @"Data Source=SUNHAO-PC;Initial Catalog=古籍管理系统;Integrated Security=True;Pooling=False";
            SqlConnection cn = new SqlConnection(connString);
            cn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
