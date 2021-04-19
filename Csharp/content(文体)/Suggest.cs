using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Suggest
        : Content
    {
        #region 构造函数
        public Suggest(string kind)
        : base(kind)
        {

        }
        #endregion
        //1.数据
        //和文章公有
        public string comment;



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
