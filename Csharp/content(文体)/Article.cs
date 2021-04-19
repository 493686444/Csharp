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

        //三者共有(写在父类)

   
        public void Change()
        {

        }
      
        public override void Publish() 
        {
        
        }
        #region 实现---Agree&Disagree
        public override void Agree()
        {

        }
        public override void Disagree()
        {

        }
        #endregion

    }
}
