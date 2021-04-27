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

        public Comment comment;
        public IList<Appraise<Suggest>> Appraise;


        #region 实现---Publish
        public override void Publish()
        {

        }
        #endregion

    }
}

