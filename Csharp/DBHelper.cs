using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Csharp
{
    public class DBHelper
    {
        public  SqlConnection Conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = 17bang;Integrated Security = True;");
        private DbCommand _cmd = new SqlCommand();
        public DbCommand Cmd
        {
            set { _cmd = value; } 
            get { _cmd.Connection = Conn; return _cmd; } 
        }

    

        //NonQuery
        public void NonQueryProcess(string text) 
        {
            using (Conn)
            {
                Conn.Open();
                NonQueryCmdProcess(text);
            }
        }
        public void NonQueryCmdProcess(string text)
        {
            Cmd.CommandText = text;
            Cmd.ExecuteNonQuery();
        }

        //Scalar
        public object ScalarProcess(string text) 
        {
            object sth;
            using (Conn)
            {
                Conn.Open();
                sth= ScalarCmdProcess(text);
            }
            return sth;
        }
        public object ScalarCmdProcess(string text) 
        {
            Cmd.CommandText = text;
            return Cmd.ExecuteScalar();
        }

        //Reader
   
        public DbDataReader ReaderCmdProcess(string text) 
        {
            Cmd.CommandText = text;
            DbDataReader reader=Cmd.ExecuteReader();
            return reader;
        }
    }
}
