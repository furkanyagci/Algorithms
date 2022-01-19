using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 1;
            int temp;
            int n;

            Console.WriteLine("Sayı giriniz : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(sayi1);
                temp = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = temp;
            }

        }
    }
}
