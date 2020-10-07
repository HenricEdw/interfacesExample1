using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample1
{
    class AnotherClass : IMyInterface
    {
        public string GetAString()
        {
            return "From AnotherClass";
        }

        public double GetSum(double one, double two)
        {
            return one * two;
        }

        public int ThisIsNotAMemberOfTheInterface()
        {
            return 10;
        }
    }
}
