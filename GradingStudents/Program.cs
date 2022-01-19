using System;
using System.Collections.Generic;

class Result
{

    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                var currDiff = 5 - (grades[i] % 5);

                if (currDiff < 3)
                {
                    grades[i] += currDiff;
                }

            }
        }

        return grades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kaç adet not girilecek : ");
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            Console.WriteLine("Not giriniz : ");
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine("Notların yuvarlanmış halleri");
        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
