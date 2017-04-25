using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPracticeProblems
{
    public class MainMenu
    {
        //Member variables
        public List<string> listOfStrings = new List<string>() { "one", "two", "two", "three", "four", "three", "five", "six" };
        public List<string> listOfStringsWithOutDuplicates;
        public List<string> listOfGrades = new List<string>() { "90,100,82,89,55", "90,100,45,89,55", "90,88,82,89,55" };
        public double classAverageGrade;


        public MainMenu()
        {
            //constructor.
        }
        public void Start()
        {
            PrintListToBeProcessed(listOfStrings);
            listOfStringsWithOutDuplicates = RemoveDuplicatesFromStringList(listOfStrings);
            PrintListToBeProcessed(listOfGrades);
            classAverageGrade = GetClassAverageGrade(listOfGrades);
        }
        public void PrintListToBeProcessed(List<string> list)
        {
            string delimiter = ", ";
            Console.WriteLine("Here is the old list: " + list.Aggregate((i, j) => i + delimiter + j) + ".\n");
        }
        public List<string> RemoveDuplicatesFromStringList(List<string> list)
        {
            var listOfStringsWithOutDuplicates = listOfStrings.Distinct().ToList();
            string delimiter = ", ";
            Console.WriteLine("Here is the new list: " + listOfStringsWithOutDuplicates.Aggregate((i, j) => i + delimiter + j) + ".\n");
            return listOfStringsWithOutDuplicates;
        }
        public double GetClassAverageGrade(List<string> listOfGrades)
        {
            var temporaryListOfGrades = listOfGrades.OrderBy(g => g);
            //var temporaryListOfGrades2 = listOfGrades1.OrderBy().Select.Min;


            //Average in string?




            return 100;
        }
        static double AverageClassScores(List<string> studentsScores)
        {
            List<int> studentScores = new List<int>();
            double classAverage = 0;
            int numberInClass = 0;
            foreach (var student in studentsScores)
            {
                studentScores = student.Split(',')
                                    .Select(m => { return (int.Parse(m)); })
                                    .ToList();
                var studentAvg = studentScores.Where(x => x != studentScores.Min()).Average();
                classAverage += studentAvg;
                numberInClass += 1;
            }
            return classAverage / numberInClass;
        }
    }
}
