using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public static void TheLeapYear()
        {
            Console.WriteLine("Enter year");

            int year = Convert.ToInt32(Console.ReadLine());   //user input


            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))     //checking for leap year or not
            {
                Console.WriteLine("{0} is a leap year  ", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year  ", year);
            }
        }
    }
}
