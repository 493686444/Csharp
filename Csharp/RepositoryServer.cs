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

            DBHelper helper = new DBHelper();
            helper.NonQueryProcess($"INSERT INTO[dbo].[User]([id], [username], [password], [inviredby], [profileid], [bmoney]) " +
                $"VALUES (5, N'{user.Name}', N'{user.Password}', {user.Invitedby}, 5, 1000)");             //作者id不能自动生成identity,这是历史遗留问题

        }
        public string GetPassWord(User user)//Input---登录--取到密码
        {
            DBHelper helper = new DBHelper();
            return (string)helper.ScalarProcess($"SELECT [password] FROM [User] WHERE [username]=N'{user.Name}'");
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
                content.Published = true;
            }
        }
        public static List<Content> GetPage(int id, string sth)
        {
            List<Content> contents = new List<Content>();
            DBHelper helper = new DBHelper();
            using (helper.Conn)
            {
                helper.Conn.Open();
                if (sth.ToLower() == "problem")
                {
                    DbDataReader reader=helper.ReaderCmdProcess($"select * from problem where id = {id};");
                    while (reader.Read())
                    {
                        contents.Add(new Problem() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
                else if (sth.ToLower() == "article")
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from Article where id = {id};");
                    while (reader.Read())
                    {
                        contents.Add(new Article() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
                else
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from Suggest where id = {id};");
                    while (reader.Read())
                    {
                        contents.Add(new Suggest() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
            }
            return contents;
        }
        #endregion



    }
}


