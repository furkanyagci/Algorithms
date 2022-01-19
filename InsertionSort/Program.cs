using System;
using System.Diagnostics;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch(); // Bir Kod Bloğunun Toplam İşlem Süresini Bulmak
            watch.Start();

            int n, temp;
            int[] sayilar = { 1, 2, 3, 10, 6, 4, 7 };//new int[n];  

            //1.Yöntem
            for (int i = 1; i < sayilar.Length; i++)
            {
                for (int j = (i - 1); j >= 0; j--)
                {
                    if (sayilar[i] < sayilar[j])
                    {
                        temp = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = temp;
                        i--;
                    }
                    else
                    {
                        j = 0;
                    }
                }
            }

            //2.Yöntem
            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    int value = sayilar[i];
            //    int j = i - 1;
            //    while (j >= 0 && sayilar[j] > value)
            //    {
            //        sayilar[j + 1] = sayilar[j];
            //        j = j - 1;
            //    }
            //    sayilar[j + 1] = value;
            //}


            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed.Milliseconds + " ms");
        }
    }
}
