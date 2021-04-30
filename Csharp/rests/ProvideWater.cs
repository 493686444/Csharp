using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class Person
    {
        public  int GetWater(ProvideWater providewater)
        {
            return providewater(this);
        }
    };
    public delegate int ProvideWater(Person person);
  

}
