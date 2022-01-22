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

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        var n = arr.Count;
        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    sum += arr[i][j];
                }
                if (i + j == n - 1)
                {
                    sum -= arr[i][j];
                }
            }
        }

        return Math.Abs(sum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Matris boyutu nedir(Örn : 3) : ");//3 girince 3x3 matris oluşur.
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();
        Console.WriteLine($"{n} satırlı {n} sutunlu matris oluşturuldu. Aralarda boşluk bırakarak {n} tane eleman giriniz ve Enter tuşuna basınız.");
        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);
    }
}
