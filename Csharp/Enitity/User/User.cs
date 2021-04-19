using System;
using System.Collections.Generic;
using System.Text;

//user.Password在类的外部只能改不能读
//如果user.Name为“admin”，输入时修改为“系统管理员”
//problem.Reward不能为负数

namespace Csharp
{
    sealed class User  //不被继承
       : Entity, ISendMessage, IChat
    {
        #region 构造函数
        public User(string name, string password, string authcore)
        {
            this.Name = name;
            Password = password;//2.每一个User对象一定有Name和Password赋值
        }
        #endregion

        #region 数据
        //公有
        public TokenManager Tokens;
        //公有(假私有)
        private string _name;
        public string Name
        { 
            get { return _name; }
            set
            {
                if (value == "admin")
                {  _name = "系统管理员"; }//2.如果user.Name为“admin”，输入时修改为“系统管理员”
                else
                { _name = value; }
            }
        }
        public string Password { private get; set; }//1.user.Password在类的外部只能改不能读
        public string Authcore { get; set; }

        public string Invitedby;

        #endregion

        #region 函数方法(功能)

        #region 功能---注册
        public bool Register(string readpasswordcopy,User readuser
           )
        {
            if (readuser.Password is null || readuser.Name is null)
            { return false; }
            else//(上一个命题的  反命题 )
            {
                if (readuser.Invitedby == Invitedby &&
                    readuser.Password == readpasswordcopy &&
                   readuser.Authcore == Authcore)
                {
                    Password = readuser.Password;
                    Name = readuser.Name;
                    Invitedby = readuser.Invitedby;
                    Authcore = readuser.Authcore;
                    return true;
                }
                else
                { return false; }
            }
        }
        #endregion

        #region 功能---登录
        //封装验证过程
        static private bool Login_test(string sample, string tester, string _display_type)
        {
            if (sample is null)
            { Console.WriteLine($"The {_display_type} can't be empty");  return false;  }
            else if (sample != tester)
            { Console.WriteLine($"The {_display_type} is inexistenced"); return false; }
            else
            { return true; }
        }
        //利用检验过程  验证登录
        public bool Login()
        {
            //Verify user Name
            string _display_type = "Name";
            Console.WriteLine("Write your name");
            string readname = Console.ReadLine();
            if (Login_test(readname, Name, _display_type))
            {
                //Verify user Password
                _display_type = "Password";
                Console.WriteLine("Write your password");
                string readpassword = Console.ReadLine();
                if (Login_test(readpassword, Password, _display_type))
                {
                    //Verify user Authcode
                    _display_type = "Authcode";
                    Console.WriteLine("Write the authcode");
                    string readauthcord = Console.ReadLine();
                    if (Login_test(readauthcord, Authcore, _display_type))
                    {
                        Console.WriteLine("Login successfully");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
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









