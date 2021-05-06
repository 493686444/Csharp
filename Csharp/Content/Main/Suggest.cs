using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Suggest
        : Content
    {


        public Comment comment;
        public IList<Appraise<Suggest>> Appraise;


        #region 实现---Publish
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

    }
}

