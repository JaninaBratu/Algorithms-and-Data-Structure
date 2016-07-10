using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(""));
        }

        public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
