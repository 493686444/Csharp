using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public  class Appraise<T>
    {
        #region 数据
       public T Target;
        public User Voter;
        public string Kind;
        #endregion


        #region 功能
        public  void Agree()
        {
            this.Kind = "Agree";
        }
        public void Disagree()
        {
            this.Kind = "Disagree";
        }
        #endregion

    }
}
