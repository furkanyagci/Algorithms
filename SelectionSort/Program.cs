using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp;
            //n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = { 1, 2, 3, 10, 6, 4, 7 };//new int[n];
            //Console.WriteLine($"{n} adet rakam giriniz : ");
            //for (int i = 0; i < n; i++)
            //{
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = i + 1; j < sayilar.Length; j++)
                {
                    if (sayilar[i] > sayilar[j])
                    {
                        temp = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = temp;
                    }
                }
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

        }
    }
}
