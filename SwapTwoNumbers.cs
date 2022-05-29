using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public static void SwappingNumbers()
        {
            int a=5,b=10;
            Console.WriteLine("Before Swap a=" + a + "b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swap a="+a+"b="+b);
        }
    }
}
