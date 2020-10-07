using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMyInterface> ettAnnatNamn = new List<IMyInterface>();
            var stringClass = new StringClassTest();
            var anotherClass = new AnotherClass();

            ettAnnatNamn.Add(stringClass);
            ettAnnatNamn.Add(anotherClass);

            foreach(var item in ettAnnatNamn)
            {
                Console.WriteLine(item.GetAString());
                Console.WriteLine(item.GetSum(4.00, 6.00));

            }

            Console.Read();
        }
    }
}
