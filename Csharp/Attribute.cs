using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HelpMoneyChangedAttribute : Attribute
    {
        public HelpMoneyChangedAttribute(int amount)
        {
            this.amount = amount;
        }
        public int amount;
        public string Message;
    }
}
