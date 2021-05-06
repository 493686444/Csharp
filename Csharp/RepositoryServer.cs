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

        #region 注册和登录
        public void Save(User user)
        {
            using (connection = new SqlConnection(connectionString))
            {
                string cmd = $"INSERT INTO[dbo].[User]([id], [username], [password], [inviredby], [profileid], [bmoney]) " +
                    $"VALUES (5, N'{user.Name}', N'{user.Password}', {user.Invitedby}, 5, 1000)";
                DBHelper helper = new DBHelper();
                helper.NonQueryProcess(cmd);             //作者id不能自动生成identity,这是历史遗留问题
            }
        }
        public string GetPassWord(User user)//Input---登录--取到密码
        {
            DBHelper helper = new DBHelper();
            return (string)helper.ScalarProcess($"SELECT [password] FROM [User]WHERE Name={user.Name}");
        }

        #endregion
        #region 发布修改
        public void Save(Problem content) 
        {
            DBHelper helper = new DBHelper();
            if (content.Published)
            {
                helper.NonQueryProcess($"update [Problem] set [Title]=N'{content.Title}',[Content]=N'{content.Body}',[Reward]={content.Reward}");//暂时只传这三个属性进行测试
            }
            else
            {
                helper.NonQueryProcess($"insert [Problem] ([Title],[Content],Reward) values (N'{content.Title}',N'{content.Body}',{content.Reward})");
            }
        }
    }   
        #endregion



    }
}


