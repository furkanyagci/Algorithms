using System;

namespace HammingDistance
{
    class Program
    {
        /// <summary>
        /// Aynı uzunluktaki 2 dizenin aynı indis no daki elemanların kaç tanesinin farklı old. gösterir. String veya rakam olabilir.
        /// </summary>
     
        static int HammingDistance(string s1, string s2)
        {
            if (s1.Length != s2.Length)//HammingDistance algoritmasında 2 string aynı uzunlukta olmalı
            {
                throw new Exception("Strings must be of the same length");
            }

            var diffCount = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    diffCount++;
                }
            }

            return diffCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
