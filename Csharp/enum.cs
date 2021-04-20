using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    //设一个枚举为 ContentSevice  提供服务
    enum Contenttype { Problem=0, Article=1, Suggest=2 };

    //枚举  Token
    public enum Token { none = 0, SuperAdmin = 1, Admin = 2, Blogge = 4, Newbie = 8, Registered = 16 }

}
