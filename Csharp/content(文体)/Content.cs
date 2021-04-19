using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
     abstract class  Content
    {
        #region 构造函数
        public Content(string kind)
        {
            _kind = kind;
        }

        #endregion

        #region 数据

        public string Title;
        public string Body;
        public string Author;

        private DateTime _createTime=DateTime.Now; 
        public DateTime PublishTime { get { return _createTime; } }

        protected string _kind;  //只能被子类使用
        #endregion

        //2.0功能---抽象
        public abstract void Publish();


       }
}
