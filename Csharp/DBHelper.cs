﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Csharp
{
    class DBHelper
    {
        public  SqlConnection Conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = 17bang;Integrated Security = True;");
        private DbCommand _cmd = new SqlCommand();
        public DbCommand Cmd
        {
            set { _cmd = value; } 
            get { _cmd.Connection = Conn; return _cmd; } 
        }
    
        public void NonQueryProcess(string text) 
        {
            using (Conn)
            {
                Conn.Open();
                this.NonQueryCmdProcess(text);
            }
        }
        public void NonQueryCmdProcess(string text) 
        {
            Cmd.CommandText = text;
            Cmd.ExecuteNonQuery();
        }


        //
    }
}
