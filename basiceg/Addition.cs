using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiceg
{
    class Addition
    {
        static void Main()
        {
            int num1 = 30, num2 = 20, result1,result2;
            result1= num1 + num2;
            result2 = num1 - num2;

             Console.WriteLine ("Addition : {0}", result1);
            Console.WriteLine("subtraction:{0}", result2);
            Console.ReadKey();
        }
    }
}
