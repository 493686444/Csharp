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

        public string comment;


        #region 实现---Publish
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
    }
}
