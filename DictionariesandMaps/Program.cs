using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Console.Write("Rehbere kaç kişi eklenecek : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> Data = new Dictionary<string, string>();
        
        Console.WriteLine("Kişi bilgileri (isim telno) şeklinde giriniz : ");

        for (int i = 0; i < n; i++)
        {
            string[] s= Console.ReadLine().Split(' ');
            string name = s[0];
            string number = s[1];

            Data.Add(name, number);
        }

        Console.Write("Kişi ara :");
        string searchName = "";
        while ((searchName = Console.ReadLine()) !=null)
        {
            if (Data.ContainsKey(searchName))
            {
                Console.WriteLine(searchName + " = " + Data[searchName]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.Write("Kişi ara :");
        }

    }
}
