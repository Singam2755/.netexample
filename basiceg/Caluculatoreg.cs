using System;


namespace basiceg
{
    class Caluculatoreg
    {
        float num1 = 100, num2 = 40, result;
        void Add()
        {
            result = num1 + num2;
            Console.WriteLine("addition is :{0}", result);
            Console.WriteLine("addition is :{0}", num1 + num2);
        }

        float Sub()
        {
            return (num1 - num2);

        }
        static void Main()
        {
            Caluculatoreg objcalci = new Caluculatoreg();
            objcalci.Add();
            float res = objcalci.Sub();
            Console.WriteLine("sub:{0}", res);
            Console.WriteLine("sub:{0}", objcalci.Sub());
            Console.ReadKey();
        }
    }
}
