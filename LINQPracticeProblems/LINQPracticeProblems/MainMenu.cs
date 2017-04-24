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
        List<string> listOfStrings = new List<string>() { "one", "two", "two", "three", "four", "three", "five", "six" };
        public MainMenu()
        {
            //constructor.
        }
        public void Start()
        {
            string delimiter = ", ";
            Console.WriteLine("Here is the old list: " + listOfStrings.Aggregate((i, j) => i + delimiter + j));
            RemoveDuplicatesFromStringList();
        }

        public void RemoveDuplicatesFromStringList()
        {
            var listOfStringsWithOutDuplicates = listOfStrings.Distinct().ToList();
            string delimiter = ", ";
            Console.WriteLine("Here is the new list: " + listOfStringsWithOutDuplicates.Aggregate((i, j) => i + delimiter + j) + "\n");
        }
    }
}
