using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
namespace Csharp
{
    public class User  
       : Entity, ISendMessage, IChat
    {
        #region 构造函数
        //public User(string name, string password)
        //{
        //    this.Name = name;
        //    Password = password;   //为了便于测试
        //}
        #endregion

        #region 数据

        public TokenManager Tokens;
        public string Authcore { get; set; }
        public User Invitedby;

        private string _name;
        public string Name 
        {
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("名字不可为空");
                }
                else
                {
                    _name = value;
                }
            }
            get { return _name; }
        }

        private string _password;
        public string Password
        {
            set
            {
                if (_inspector(value))
                {
                    _password = value;
                }
            }
            get { return _password; }
        }

        #region 检验密码
        public bool _inspector(string value)
        {
            _inspector_conditions = new string[] { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            bool yesornot = false;
            for (int i = 0; i < _inspector_conditions.Length; i++)
            {
                if (value.Contains(_inspector_conditions[i]))
                {
                    yesornot = true;
                    break;
                }
            }
            if (value.ToLower() == value)
            {
                Console.WriteLine("密码必须大小写都有");
                return false;
            }
            else
            {
                if (value.Length < 6)
                {
                    Console.WriteLine("不得少于6个");
                    return false;
                }
                else
                {
                    if (yesornot)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("密码必须含有数字和特殊符号（~!@#$%^&*()_+）");
                        return false;
                    }
                }
            }

        }
        #endregion



        private string[] _inspector_conditions;

        #endregion

        #region 函数方法(功能)

        ///数据持久化
        //1.注册/登录
        #region 功能---注册
        public void Register()
        {
            RepositoryServer repositoryServer = new RepositoryServer();
            repositoryServer.Save(this);
            Console.WriteLine("注册成功");
        }
        #endregion

        #region 功能---登录
        public void Login()
        {
            RepositoryServer repositoryServer = new RepositoryServer();
            string dbPassword = repositoryServer.GetPassWord(this);
            if (dbPassword is null)
            {
                Console.WriteLine("用户名不存在");
                return;
            }
            else
            {
                if (_password == dbPassword)
                {
                    Console.WriteLine("密码正确");
                }
                else
                {
                    Console.WriteLine("密码错误");
                }
            }
        }
        #endregion

        #region 实现

        void ISendMessage.Send()
        {

        }
        void IChat.Send()
        {

        }
        #endregion



        #endregion 函数结束
    }
}









