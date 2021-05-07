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

        public int version;


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

        //发布修改
        public void Save(Problem problem)
        {
            DBHelper helper = new DBHelper();
            //DbParameter pTitle = new SqlParameter("@Title", problem.Title);
            //DbParameter pBody = new SqlParameter("@Body", problem.Body);
            //DbParameter pReward = new SqlParameter("@Reward", problem.Reward);
            //helper.Cmd.Parameters.Add(pTitle);
            //helper.Cmd.Parameters.Add(pBody);
            //helper.Cmd.Parameters.Add(pReward);
            if (problem.Published)
            {
                string command = 
                    $"update [Problem] set [Title]=N'{problem.Title}',[Content]=N'{problem.Body}',[Reward]={problem.Reward}";
                helper.NonQueryProcess(command);//暂时只传这三个属性进行测试
            }
            else
            {
                string command = 
                    $"insert [Problem] (" +
                        $"[id],[Title],[Content],Reward,[NeedRemoteHelp],[PublishDateTime]) values (" +
                        $"N'{problem.id}',N'{problem.Title}',N'{problem.Body}',{problem.Reward},{1},'{problem.PublishTime.ToString("yyyy/MM/dd HH:mm:ss")}')";
                helper.NonQueryProcess(command);
                problem.Published = true;
            }
        }
        //得到单页和多页
        public static List<Content> GetPage(int id, string sth)
        {
            List<Content> contents = new List<Content>();
            DBHelper helper = new DBHelper();
            DbParameter pId = new SqlParameter("@id", id);
            helper.Cmd.Parameters.Add(pId);
            using (helper.Conn)
            {
                helper.Conn.Open();
                if (sth.ToLower() == "problem")
                {
                  
                    DbDataReader reader=helper.ReaderCmdProcess($"select * from problem where id =@id;");
                 
                    while (reader.Read())
                    {
                        contents.Add(new Problem() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
                else if (sth.ToLower() == "article")
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from Article where id =@id;");
                    while (reader.Read())
                    {
                        contents.Add(new Article() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
                else
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from Suggest where id =@id;");
                    while (reader.Read())
                    {
                        contents.Add(new Suggest() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
            }
            return contents;
        }
        public static List<Content> GetPage(string sth) 
        {
            List<Content> contents = new List<Content>();
            DBHelper helper = new DBHelper();
            using (helper.Conn)
            {
                helper.Conn.Open();
                if (sth.ToLower() == "problem")
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from problem");
                    while (reader.Read())
                    {
                        contents.Add(new Problem() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
                else if (sth.ToLower() == "article")
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from Article");
                    while (reader.Read())
                    {
                        contents.Add(new Article() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
                else
                {
                    DbDataReader reader = helper.ReaderCmdProcess($"select * from Suggest");
                    while (reader.Read())
                    {
                        contents.Add(new Suggest() { id = (int)reader[0], Body = (string)reader[1] });
                    }
                }
            }
            return contents;
        }



    }
}


