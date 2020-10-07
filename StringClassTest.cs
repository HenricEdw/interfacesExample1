using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample1
{
    class StringClassTest : IMyInterface
    {
        public string GetAString()
        {
            return "This is from StringClassTest";
        }

        public double GetSum(double one, double two)
        {
            return one + two;
        }
    }
}
