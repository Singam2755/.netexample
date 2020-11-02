using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopand_conditional_stattements
{
    class Switch
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.Read();
        }
    }
}
