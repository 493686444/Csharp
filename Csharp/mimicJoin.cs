using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class stringer
    {
        public string score;
        public stringer mimicJoin(string parter, string adder)
        {
            if (score == null)
            { score = adder; }
            else
            { score = score + parter + adder; }
            return this;
        }
        public stringer mimicJoins(string parter, string adderone, string addertwo, string adderthree, string adderfour)
        {
            this.mimicJoin(parter, adderone).mimicJoin(parter, addertwo).mimicJoin(parter, adderthree).mimicJoin(parter, adderfour);
            return this;
        }

    }

}
