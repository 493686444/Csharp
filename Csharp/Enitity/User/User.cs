using System;
using System.Collections.Generic;
using System.Text;

//user.Password在类的外部只能改不能读
//如果user.Name为“admin”，输入时修改为“系统管理员”
//problem.Reward不能为负数

namespace Csharp
{
     sealed class User 
        : Entity,ISendMessage,IChat
    {
        //0.0构造函数
        public User()
        {

        }
        public User(string name, string password, string authcore)
        {
            this.Name = name;
            Password = password;
            Authcore = authcore;
        }
        //1.数据
        //公有
        public TokenManager Tokens;
                        //公有(假私有)
                        private string _name;
                        public string Name
                        {

                            get { return Name; }
                            set
                            {
                                if (value == "admin")
                                {
                                    _name = "系统管理员";
                                }
                                else
                                {
                                    _name = value;
                                }
                            }
                        }
                public string Password { private get; set; }
                public string Authcore { get; set; }

                public string Invitedby;

        //2.1功能---注册
        public bool Register(
            string readname, string readpassword, string readpasswordcopy,
            string readinvitedby, string readauthcore)
        {
            if (readname is null || readpassword is null)
            {
                return false;
            }
            else
            {
                if (Invitedby == readinvitedby &&
                    readpassword == readpasswordcopy &&
                    readauthcore == Authcore
                    )
                {
                    Password = readpassword;
                    Name = readname;
                    Invitedby = readinvitedby;

                    return true;
                }
            }
            return false;
        }


       //2.2功能---登录
        public bool Login(string readName, string readPassword, string readAuthcore)
        {
            if (readName is null)
            {
                throw new ArgumentNullException(nameof(readName));
            }

            if (readName == Name)
            {
                if (readPassword == Password && readAuthcore == Authcore)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        // 实现 2.3
        void ISendMessage.Send() 
        { 
        
        }
        void IChat.Send()
        {

        }
    }
}









