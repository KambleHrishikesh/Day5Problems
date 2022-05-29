using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Harmonic
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Harmonic Number");

            Console.WriteLine("Enter number : ");

            int num = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (double count = 1; count <= num; count++)
            {
                Console.Write("1/{0} + ", count);
                sum = sum + 1 / count;
            }


            Console.WriteLine("\nThe sum of {0}  series is {1}  ", num, sum);
            Console.ReadLine();
        }
    }
}
