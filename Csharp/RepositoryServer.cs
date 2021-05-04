using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
namespace Csharp
{

    public class RepositoryServer
    {

        #region 数据
        public int version;
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
        public DbConnection connection;
        public DbCommand cmd;
        #endregion
        ///数据持久化
        //1.注册/登录
        //2.内容：
        //a.发布/修改
        //b.单页呈现
        //c.列表页呈现（包括：过滤/分页）
        //3.批量标记Message为已读

        #region 功能---存
        public void Save(User user)//Output---注册--存入数据库
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    $"INSERT INTO [dbo].[User] ([id], [username], [password], [inviredby], [profileid], [bmoney]) VALUES (5, N'{user.Name}', N'{user.Password}', {user.Invitedby}, 5, 1000)"; //作者id不能自动生成identity,这是历史遗留问题
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 功能---取
        public string Get(User user)//Input---登录--取到密码
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = $"SELECT [password] FROM [User]WHERE Name={user.Name}";
                string reader = (string)cmd.ExecuteScalar();
                return reader;
            }
        }
        #endregion

    }
}


