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
            if (s1.Length != s2.Length)
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
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            Console.WriteLine(HammingDistance(s1, s2));
        }
    }
}
