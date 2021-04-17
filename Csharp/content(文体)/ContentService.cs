using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class ContentService
    {
        //发布的时间
        public DateTime PublishTime { get; } = DateTime.Now;
        //2.1功能
        public bool Publish(Content CandSth) 
        {
            return true;

        }
    }
}
