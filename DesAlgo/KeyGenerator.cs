using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesAlgo
{
    class KeyGenerator
    {
        public int[] PC1 = new int[] { 56, 48, 40, 32, 24, 16, 8, 
                                        0, 57, 49, 41, 33, 25, 17,  
                                       9, 1, 58, 50, 42, 34, 26,
                                       18, 10, 2, 59, 51, 43, 35,
                                       62, 54, 46, 38, 30, 22, 14,
                                       6, 61, 53, 45, 37, 29, 21,
                                       13, 5, 60, 52, 44, 36, 28,
                                       20, 12, 4, 27, 19, 11, 3,
                                  };

        public int[,] key16 = new int[16, 56];

        public string leftCirculerShift(string key, int round)
        {
            object[] leftHalf = new object[28];
            object[] rightHalf = new object[28];

            for (int i = 0; i < 28; i++)
            {
                leftHalf[i] = key[i];
            }
            int j = 0;
            for (int i = 28; i < 56; i++)
            {
                rightHalf[j++] = key[i];
            }
            Console.WriteLine(key);
            Console.WriteLine("Left Half....");
            for (int i = 0; i < 28; i++)
            {
                Console.Write(leftHalf[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Right Half....");
            for (int i = 0; i < 28; i++)
            {
                Console.Write(rightHalf[i]);
            }

            // to be continue hare....
            Console.WriteLine();
            int x = 5;
            Console.Write(x >> 2);


            return "";
        }

        public string permutationChoice1(string key)
        {
            object[] keyvalue = new object[56];
            Console.WriteLine(key);
            for (int i = 0; i < 56; i++)
            {
                keyvalue[i] = key[PC1[i]];
            }
            Console.WriteLine("Apply PC1 on Key...");
            for (int i = 0; i < 56; i++)
            {
                Console.Write(keyvalue[i]);
            }
            return keyvalue.ToString();
        }

        public void keyGeneration(string key)
        {
            leftCirculerShift(key, 2);
        }

    }
}
