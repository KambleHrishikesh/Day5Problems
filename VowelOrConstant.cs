using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConstant
    {
        public static void CheckVowelOrConstant()
        {
            char ch;
            Console.WriteLine("enter any character to check vowel or constant");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch =='a'|| ch =='e'||ch =='i'||ch =='o'||ch =='u')
            {
                Console.WriteLine(ch + "is Vowel");

            }
            else
            {
                Console.WriteLine(ch + "is constant");
            }
        }
    }
}
