using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    abstract class Content//抽象类
    {
        #region 构造函数
        public Content(string kind)
        {
            _kind = kind;
            _createtime = DateTime.Now;
            _publishtime = DateTime.Now;   //这两个时间有点分不清区别
        }

        #endregion

        #region 数据
        //确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串，而且如果标题前后有空格，也予以删除
        public string _title;  
        public string Title 
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { Console.WriteLine("不可以为null或空字符"); }
                else
                { _title = value.Trim() ; }
            }
            get { return _title; }
        }
        public string Body;
        public string Author;

        private DateTime _createtime;
        private DateTime _publishtime;
        public DateTime CreateTime
        { get { return _createtime; } } 
        public DateTime PublishTime
        { get { return _publishtime; } }

        protected string _kind;  //只能被子类使用

        #endregion



        #region 抽象方法       

        [HelpMoneyChanged(3,Message ="韩佳宝")]
        public abstract void Publish();
        public abstract void Agree();
        public abstract void Disagree();

        #endregion

    }
}
