using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopand_conditional_stattements
{
    class Ifeg
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is the greatest");
                }
                else
                {
                    Console.WriteLine("num3 is the greatest");
                }

            }
            else if (num2 > num3)
                Console.WriteLine("num2 is the greatest");
            else
                Console.WriteLine("num3 is the greatest");

                Console.Read();
            
        }
    }
    
    
    
}
