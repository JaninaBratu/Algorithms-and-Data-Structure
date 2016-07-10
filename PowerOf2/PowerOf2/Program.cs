using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf2
{

    /*
     * Program care returneaza true sau false daca un nr este putere a lui 2
     * Metoda recursiva
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOf2(8));
        }


        //metoda Andrei
        public static bool IsPower(int number)
        {
            if (number == 1)
            {
                return true;
            }
            if (number == 0 || (number % 2 != 0))
             {
                return false;
            }
            return IsPower(number / 2);
        } 

        //metoda Janina
        public static bool IsPowerOf2(int n, int tempResult = 1)
        {
            if (tempResult < n)
            {
                tempResult = tempResult * 2;
                return IsPowerOf2(n, tempResult);
            }
            else if (tempResult == n)
            {
                return true;
            }
            else {
                return false;
            }
        }

        //public static bool IsPowerOf2(int number)
        //{
        //    int tempResult = 1 * 2;
        //    bool isValid = false;

        //    while (tempResult <= number && !isValid)
        //    {
        //        if (tempResult == number)
        //        {
        //            isValid = true;
        //        }
        //        else
        //        {
        //            tempResult = tempResult * 2;
        //        }
        //    }
        //    return isValid;
        //}
    }
}
