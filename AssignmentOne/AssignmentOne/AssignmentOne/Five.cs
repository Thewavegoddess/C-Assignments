using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public static class Five
    {
       
        public static void ReadFromFile()
        {
            string path = "C:\\Users\\USER\\Desktop\\Assignments\\AssignmentOne\\AssignmentOne\\AssignmentOne\\file.txt";
            string words = File.ReadAllText(path);
            string[] word = words.Split(" ");

            Console.WriteLine(word.Length);
        }

     
        public static void LongestWordInFile()
        {
            string path = "C:\\Users\\USER\\Desktop\\Assignments\\AssignmentOne\\AssignmentOne\\AssignmentOne\\file.txt";
            string words = File.ReadAllText(path);
            string[] word = words.Split(" ");

            string longestWord = " ";

            foreach (string w in word)
            {
                if (w.Length > longestWord.Length)
                {
                    longestWord = w;
                }
            }

            Console.WriteLine($"The longest word is {longestWord}");
        }
    }
}
