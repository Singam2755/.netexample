using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopand_conditional_stattements
{
    class Evenorodd
    {
        static void Main()
        {
            int num1;
            Console.WriteLine("enter your number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%2==0)
            {
                Console.WriteLine("entered number is even nummber");
                Console.Read();
            }
            else
            {
                Console.WriteLine("entered number is an odd number");
                Console.Read();
            }

        }

    }
}
