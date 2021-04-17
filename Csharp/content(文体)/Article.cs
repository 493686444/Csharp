using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Article
        : Content, IAgreeOrNot
    {
        //0.0构造函数
        public Article(string kind)
        : base(kind)
        {
        }
        //1.数据
                //和求助共有()
                    //公有(假私有)
                    private string[] _keyword = new string[10];
                    public string this[int index]
                    {
                        get { return _keyword[index]; }
                        set { _keyword[index] = value; }
                    }
                //和建议共有
                public string comment;
                public int Agree;
                public int Disagree;
        //三者共有(写在父类)

        //2.1接口的实现
        public void Change()
        {

        }
        //2.2抽象成员的实现
        public override void Publish() 
        {
        
        }


    }
}
