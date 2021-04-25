using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class Article
        : Content, IAgreeOrNot
    {
        #region 构造函数
        public Article(string kind)
        : base(kind)
        {
        }
        #endregion

        #region 数据
        private string[] _keyword = new string[10];
        public string this[int index]
        {
            get { return _keyword[index]; }
            set { _keyword[index] = value; }
        }
       
        public List<Comment> Comments;
        public List<Keyword> Keyword;

        public Appraise Appraise;

        #endregion


        #region 实现---发布
        public override void Publish()
        {

        }
        #endregion

        #region 实现---Agree&Disagree
        public override void Agree()
        {

        }
        public override void Disagree()
        {

        }
        #endregion


        public void Change()
        {

        }



    }
}
