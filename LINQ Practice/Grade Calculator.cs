using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Grade_Calculator
    {
        public List<string> GetRidOfDuplicates(List<string> list)
        {
            return list = (list.Distinct()).ToList();
            
        }
        public decimal CalculateClassAverage(List<string> grades)
        {
            List<decimal> classAverages = new List<decimal>();
            try
            {
                foreach(string grade in grades)
                {
                    List<decimal> allGrades = ConvertToDecimalList(grade);
                    RemoveLowestScore(allGrades);
                    classAverages.Add(allGrades.Average());
                }
                decimal classAverage = classAverages.Average();
                return classAverage;
            }
            catch
            {
                throw new Exception("make sure to be using decimals");
            }
        }
        public List<decimal> ConvertToDecimalList(string grades)
        {
            char[] characterArray = grades.ToCharArray();
            List<char> charList = characterArray.ToList<char>();
            List<char> item = new List<char>();
            List<decimal> Result = new List<decimal>();
            foreach(char character in charList)
            {
                if(char.IsNumber(character))
                {
                    item.Add(character);
                }
                else
                {
                    char[] numberArray = item.ToArray<char>();
                    string numberString = new string(numberArray);
                    decimal number = Convert.ToDecimal(numberString);
                    item.RemoveRange(0, item.Count);
                    Result.Add(number);
                }
            }
            return Result;
        }
        private List<decimal> RemoveLowestScore(List<decimal> list)
        {
            list.Sort();
            list.RemoveAt(0);
            return list;
        }
        public bool CheckIfHasSubstring(List<string> list, string substring)
        {
            return list.Any(word => word.Contains(substring));
        }
        public bool HasOnlyOddNumbers(int[] numberArray)
        {
            return numberArray.Any(number => number % 2 != 0);
        }

    }
}
