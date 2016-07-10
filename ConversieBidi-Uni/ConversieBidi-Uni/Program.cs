
using System;
using System.Collections.Generic;

namespace ConversieBidi_Uni
{
    public class Program
    {
        protected static byte[,] mArray = null;
        protected static int[] mResultArray = null;


        public static void Main(string[] args)
        {
            mArray = InitializeBidimensionalArray();
            mResultArray = ConversionToUnidimensionalArray(mArray);
            for (int i = 0; i < mResultArray.Length; i++)
            {
                Console.WriteLine(mResultArray[i]);
            }
        }

        protected static byte[,] InitializeBidimensionalArray()
        {
            byte[,] myArray = new byte[2,2];
            myArray[0, 0] = 0;
            myArray[0, 1] = 10;
            myArray[1, 0] = 100;
            myArray[1, 1] = 255;

            return myArray;
        }
        protected static int[] ConversionToUnidimensionalArray(byte[,] arrayToConvert)
        {
            byte[] bytes = new byte[8];

            int[] resultArray = new int[1000];

            List<int> list = new List<int>();

                for (int rows = 0; rows < arrayToConvert.GetLength(0); rows++)
                {
                     for(int columns=0; columns < arrayToConvert.GetLength(1); columns++)
                     {
                        bytes = BitConverter.GetBytes(arrayToConvert[rows, columns]);
                        //int item = BitConverter.ToInt32(bytes, 0);
                        //list.Add(item);
                        //bytes = null;

                        int i = BitConverter.ToInt32(bytes, 0);
                        Console.WriteLine("int: {0}", i);
                        //item = 0;
                }
            }
            for(int i = 0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            return resultArray;
        }
    }
}
