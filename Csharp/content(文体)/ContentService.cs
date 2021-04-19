using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class ContentService
    {

        public Content Option;
        public void Publish(string type) //参数枚举更好
        {
           
            Option = new Problem("poblem");
            Option.Publish();
        }
    }
}
