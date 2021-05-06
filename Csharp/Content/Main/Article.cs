using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class Article
        : Content, IAgreeOrNot
    {
   
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

            if (Author is null)
            {
                Console.WriteLine("作者参数不能为空");
                throw new ArgumentNullException();//2.内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
            }
            else { }
        }
        #endregion

        public void Change()
        {
        }

    }
}

