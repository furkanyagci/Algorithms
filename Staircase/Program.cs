using System;
using System.Text;

class Result
{
    /// <summary>
    /// 
    /// </summary>

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            StringBuilder step = new StringBuilder(String.Empty);
            step.Append(' ', n - i);
            step.Append('#', i);
            Console.WriteLine(step);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}