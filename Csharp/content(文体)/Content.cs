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

        public string Title;  
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
