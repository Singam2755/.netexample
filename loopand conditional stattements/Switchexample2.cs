using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopand_conditional_stattements
{
    class Switchexample2

    {  
        static void Main()
        {
            Console.WriteLine("enter the value of input1 and input2");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("enter the operation");
            string operation = Console.ReadLine();
            switch(operation)
            {
                case "+":
                    {
                        result = input1 + input2;
                        Console.WriteLine("addition:{0}", result);
                        break;
                    }
                case "-":
                    {
                        result = input1 - input2;
                        Console.WriteLine("subtraction:{0}", result);
                        break;
                    }
                case "*":
                    {
                        result = input1 * input2;
                        Console.WriteLine("multiplication:{0}", result);
                        break;
                    }
                default :
                    {
                        Console.WriteLine("invalid operation");
                        break;
                    }
                  

            }
            Console.Read();
        }
       
    }
}
