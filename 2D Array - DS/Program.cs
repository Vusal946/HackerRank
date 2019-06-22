using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace _2D_Array___DS
{
    class Program
    {
        static int hourglassSum(int[][] arr)
        {
            int maxSum = 0;
            int temp = 0;
            int iterator = 0;
            int length = 3;

            for (int i = 0; i < 16; i++)
            {
                for (int j = iterator; j < length; j++)
                {
                    for (int k = iterator; k < length; k++)
                    {
                        if (j % 2 == 0 || k % 2 != 0)
                        {
                            temp += arr[j][k];
                        }
                    }
                }
                Console.Write(temp + "  ");
                maxSum = temp > maxSum ? temp : maxSum;

                if (iterator != 6)
                    iterator += 1;
                else
                    iterator = 0;

                if (length != 6)
                    length += 1;
                else
                    length = 3;

                temp = 0;
            }
            return maxSum;
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            Console.WriteLine();           
            int result = hourglassSum(arr);            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

}
