using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    interface IAgreeOrNot
    {
        public void Change();
    }

    //send消息
    interface ISendMessage
    {
        public void Send();
    }
    interface IChat
    {
        public void Send();
    }
}
