using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
     abstract class  Content
    {
        //0.0构造函数(_kind都有值)
        public Content(string kind)
        {
            _kind = kind;
        }
        //1.数据
                //公有
                public string Title;
                public string Body;
                public string Author;   
                    
                //私有
                private DateTime _createTime;
                        //可继承
                        protected string _kind;
        //2.0功能---抽象
        public abstract void Publish();


       }
}
