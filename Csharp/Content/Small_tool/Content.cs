using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public abstract class Content : Entity
    {

        #region 构造函数
        public Content(string kind)
        { _kind = kind; _createtime = DateTime.Now; }
        #endregion

        #region 数据
        public bool Published;

        protected string _kind;
        public string Body;
        public User _author;
        public User Author
        {
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("作者名字为空");
                }
                else
                {
                    _author = value;
                }
            }
            get { return _author; }
        }
        private string _title;
        public string Title
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("不可以为null或空字符");
                }
                else
                { _title = value.Trim(); }
            }
            get { return _title; }
        }
        private DateTime _createtime;
        public DateTime CreateTime { get { return _createtime; } }
        protected DateTime _publishTime;
        public DateTime PublishTime { get { return _publishTime; } }

        #endregion

        #region 抽象方法       

        [HelpMoneyChanged(3, Message = "韩佳宝")]
        public abstract void Publish();

        #endregion

    }
}
