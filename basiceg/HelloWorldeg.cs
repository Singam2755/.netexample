using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiceg
{
    class HelloWorldeg
    {
        static void Main()
        {
            Console.Write("Hello World");
            Console.WriteLine("............");

            string myname = "ganesh", fathername = "ramana";
            Console.WriteLine(myname);

            Console.WriteLine("myname:" + myname);
            Console.WriteLine("fathername:"+ fathername) ;

            Console.WriteLine("myname:{1} {0}",myname,fathername);


           
            Console.Read();
          
        }

    }
}
