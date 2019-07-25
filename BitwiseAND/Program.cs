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
using System.Linq.Expressions;

class Solution
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        var list = new List<int>();

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int max = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    int temp = (i != j) ? i & j : 0;
                    max = max > temp ? max : temp;
                }
            }
            list.Add(max);
        }
        foreach (var item in list)
            Console.WriteLine(item);
    }
}
