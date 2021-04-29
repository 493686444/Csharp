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
        public int ID;
        private string[] _keyword = new string[10];
        public string this[int index]
        {
            get { return _keyword[index]; }
            set { _keyword[index] = value; }
        }
       
        public List<Comment> Comments;//评论
        public List<Keyword> Keywords;//关键字

        public IList<Appraise<Article>> Appraise;

        #endregion


        #region 实现---发布
        public override void Publish()
        {
            _publishTime = DateTime.Now;
            //2.内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
            if (Author is null)
            {  throw new ArgumentNullException("作者不能为空"); }  //else { } nothing
        }
        #endregion

        public void Change()
        {

        }



    }
}
