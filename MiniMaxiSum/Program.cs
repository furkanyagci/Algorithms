using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        long min = long.MaxValue;
        long max = long.MinValue;

        for (int i = 0; i < 5; i++)
        {
            sum += arr[i];
            min = Math.Min(min, arr[i]);
            max = Math.Max(max, arr[i]);
        }

        Console.WriteLine($"{sum-max} {sum-min}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            arr.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Result.miniMaxSum(arr);
    }
}
