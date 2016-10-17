using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade_Calculator gradeCalculator = new Grade_Calculator();
            List<string> classGrades = new List<string>();
            classGrades.Add("90,100,82,89,55");
            classGrades.Add("90,100,82,89,55");
            classGrades.Add("74,81,7,39,115");
            foreach (string grade in classGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("\n" + gradeCalculator.CalculateClassAverage(classGrades));
            Console.ReadKey();
        }
    }
}
