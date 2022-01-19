using System;
using System.Collections.Generic;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var sockCount = 0;
        var set = new HashSet<int>();
        foreach (var i in ar)
        {
            if (!set.Contains(i))
            {
                set.Add(i);
            }
            else
            {
                sockCount++;
                set.Remove(i);
            }
        }

        return sockCount;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Kaç Çorap var :");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Çorap tiplerini giriniz Örn: 10, 10, 20, 30, 50, 20, 10, 20, 10");
        List<int> ar = new List<int>();
        for (int i = 0; i < n; i++)
        {
            ar.Add(Convert.ToInt32(Console.ReadLine()));
        }

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine("Çift çorap sayısı : " + result);
    }
}
