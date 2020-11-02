using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopand_conditional_stattements
{
    class Studentdetails
    {
        static void Main()
        {
        string studentname, city;
            int studentid;

            Console.WriteLine("enter your studentname:");
            studentname = Console.ReadLine();
            Console.WriteLine("enter your city");
            city = Console.ReadLine();
            Console.WriteLine("enter your studentid:");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("studentname:{0} || city:{1} || studentid:{2}", studentname, city, studentid);
            Console.Read();


        }

    }
}
