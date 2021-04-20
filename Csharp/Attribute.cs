using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    [AttributeUsage(AttributeTargets.Method)]
    class HelpMoneyChangedAttribute : Attribute
    {

        public HelpMoneyChangedAttribute(int amount)
        {
            this.amount = amount;
        }
        int amount;
        string Message;
    }
}
