using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public static void ThePowerOfTwo()
        {
            Console.WriteLine("Enter number : "); //user input 


            int N = Convert.ToInt32(Console.ReadLine()); //converting from string to int


            for (int i = 1; i < N; i++)
            //using for loop because we know end condition
            {
                var power = Math.Pow(2, N); //Math.Pow() is Math Class Method,
                                            //is used for calculating number raise to power of other number 

                if (0 <= N && N < 31)
                {
                    Console.WriteLine(power);
                }
                else
                {
                    Console.WriteLine("Enter number from 1 to 30");
                }

                break;
            }

        }
    }
}
