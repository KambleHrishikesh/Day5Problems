using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("Enter number of times Flip the coin");

            int noFlip = Convert.ToInt32(Console.ReadLine());                   //User input

            int head = 0,
                tail = 0;

            Random random = new Random();                               //Random is class

            for (int i = 1; i <= noFlip; i++)                            //Using For Loop because we know end
            {
                int Flip = random.Next(0, 2);                            //(0-initial,1-final)
                {
                    if (Flip == 0) //for tail
                    {
                        tail++;
                    }
                    else           //for head
                    {
                        head++;
                    }

                }
            }


            Console.WriteLine("Number of times Head occurs : " + head);

            Console.WriteLine("Number of times Tail occurs : " + tail);

            double percentageHead = (double)head / noFlip * 100;            //Head Percentage 
                                                                            //use of double data type for storing decimal values
            Console.WriteLine("Head percentage is : " + percentageHead);

            double percentageTail = (double)tail / noFlip * 100;            //Tail Percentage 
                                                                            //use of double data type for storing decimal values
            Console.WriteLine("Tail percentage is : " + percentageTail);

        }
    }
}
