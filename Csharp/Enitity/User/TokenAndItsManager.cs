using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    // 声明一个令牌管理（TokenManager）类：
    //1.使用私有的Token枚举_tokens存储所具有的权限
    //2.暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限

    //枚举  Token
    public enum Token { none = 0, SuperAdmin = 1, Admin = 2, Blogge = 4, Newbie = 8, Registered = 16 }

    //
    public class TokenManager
    {
        #region 数据
        private Token _tokens;
        #endregion

        #region  功能
        public void Add(Token t)
        { _tokens = _tokens | t; }
        public void Remove(Token t)
        { _tokens = _tokens ^ t; }
        public bool Has(Token t)
        {
            if ((_tokens & t) == t)
            { return true; }    /*已经存在这个身份*/
            else
            { return false; }
        }

        #endregion



    }
}
