using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge218
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Palindromic(71));

            Console.ReadKey();
        }

        static string Palindromic(decimal num)
        {
            decimal originalNum = num;
            int count = 0;

            if (IsPalindrome(num.ToString()))
                return string.Format("{0} gets palindromic after 0 steps: {0}", num);

            while (true) {
                count++;
                num += GetReverse(num);
                Console.WriteLine(num);
                if (IsPalindrome(num.ToString()))
                    return string.Format("{0} gets palindromic after {1} steps: {2}", originalNum, count, num);                
            }
        }

        static bool IsPalindrome(string str)
        {
            return str == string.Concat( str.Reverse() );
        }

        static decimal GetReverse(decimal num)
        {
            return Convert.ToDecimal(string.Concat(num.ToString().Reverse()));
        }
    }
}
