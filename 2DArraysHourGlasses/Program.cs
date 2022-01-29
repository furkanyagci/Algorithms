using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    /*Örnek : Giriş aşağıdaki gibi olursa sonuç 19'dur.
        1 1 1 0 0 0
        0 1 0 0 0 0
        1 1 1 0 0 0
        0 0 2 4 4 0
        0 0 0 2 0 0
        0 0 1 2 4 0
     */
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();
        Console.WriteLine("Aralarında boşluk bırakarak 6 adet sayı giriniz. (6 x 6)");
        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        MaxHourGlass(arr);
    }

    private static void MaxHourGlass(List<List<int>> arr)
    {
        var currentValue = 0;
        var max = int.MinValue;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                currentValue = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                          arr[i + 1][j + 1] +
                               arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                max = Math.Max(max, currentValue);
            }
        }

        Console.WriteLine(max);
    }
}