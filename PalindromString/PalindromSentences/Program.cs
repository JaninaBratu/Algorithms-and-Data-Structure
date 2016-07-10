using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isPalindrom("Noel sees Leon"));
            //Console.WriteLine(isPalindrom("Eve, mad Adam, Eve"));
            //Console.WriteLine(isPalindrom("Tenet C is a basis, a basic tenet."));
            /////-----##end first example##---//////

            ///----##start second example--////
            Console.WriteLine(isPalindrom2("Noel sees Leon"));

        }

        public static bool isPalindrom(string s)
        {
            s = new string(s.Where(c => !char.IsPunctuation(c)).ToArray()).Trim();
            s= s.Replace(" ", "").ToLower().Trim();
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);

            return s == backwards;
        }

        public static bool isPalindrom2(string s)
        {
            int length = s.Length;

            s = new string(s.Where(c=> char.IsLetter(c)).ToArray()).Trim();
            s = s.Replace(" ", "").ToLower().Trim();

            length = s.Length;

            int startPosition = 0;
            int endPosition = s.Length-1;

            bool continueChecking = true;
            bool isOk = false;

            while (continueChecking)
            {
                if (startPosition != 0)
                {
                    startPosition++;
                    endPosition--;
                }

                for (int i = startPosition; i < s.Length/2; i++)
                {
                    for (int j = endPosition; j >= (s.Length/2)+1; j--)
                    {
                        if (s[i].Equals(s[j]))
                        {
                            isOk = continueChecking;
                            break;
                        }
                    }
                    if (!isOk)
                    {
                        continueChecking = false;
                        break;
                    }
                }
            }

            return isOk;
        }
        
    }
}
