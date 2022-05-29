using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOrOdd
    {
        public static void CheckEvenOrOdd()
        {
            int num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());

            if (num%2 ==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
