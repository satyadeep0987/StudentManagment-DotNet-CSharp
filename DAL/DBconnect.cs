using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL
{
    class DBconnect
    {
        public static SqlConnection GetConnection()
        {
            /*
             be carefull here add your on database source 
             if you are using visual studio 
             then navigate to 
             SQL sever objectExplorer -> <To your data base directoty> ->
             <right click and click on properties> ->
             search for "connecting string"
             and make that string to like like belo string.
             */
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;");
            return con;
        }
    }
}
