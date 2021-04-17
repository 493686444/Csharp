using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Suggest
        : Content
    {
        //0.0构造函数
        public Suggest(string kind)
        : base(kind) 
        {
        
        }

        //1.数据
                //和文章公有
                public string comment;
                public int Agree;
                public int Disagree;
                 //三者共有(写在父类)



        //2.1抽象成员的实现
        public override void Publish()
        {

        }
    }
}
