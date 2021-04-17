using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    // 声明一个令牌管理（TokenManager）类：
    //1.使用私有的Token枚举_tokens存储所具有的权限
    //2.暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限

    class TokenManager
    {
        //1.0数据
        //私有
        private Token _tokens;
      
        //2.1功能
        public void Add(Token t)
        {
             _tokens = _tokens | t;
        }
        //2.2功能
        public void Remove(Token t)
        {
            _tokens = _tokens ^ t;

        }
        //2.3功能---检验
        public bool Has(Token t)
        {
            if ((_tokens&t)==t)
            {
                return true;/*已经存在这个身份*/
            }
            else
            {
                return false;
            }
        }

      
    }
}
