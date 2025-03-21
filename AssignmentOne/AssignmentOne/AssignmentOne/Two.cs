﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public static class Two
    {
      
        public static void DivisibleByThree()
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void AddAllNumbers()
        {
            Console.WriteLine("Enter a number and press ok to add it all");

            int Total = 0;

            string input = "";

            while (input != "ok")
            {
                Console.WriteLine("Enter a number");
                input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }

                Total = Total + Convert.ToInt32(input);

            }

            Console.WriteLine("The total is: " + Total);
        }

        public static void CalculateFactorial()
        {
            Console.WriteLine("Enter a number");

            int Num = int.Parse(Console.ReadLine());

            int Factorial = 1;

            for (int i = 1; i <= Num; i++)
            {
                Factorial = Factorial * i;
            }

            Console.WriteLine("The factorial is " + Factorial);

        }

     
        public static void GuessNumber()
        {
            Random rand = new Random();

            int randomNumber = rand.Next(1, 11);
            int totalAttempts = 4;

            for (int i = 0; i < totalAttempts; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                int number = int.Parse(Console.ReadLine());

                if (randomNumber == number)
                {
                    Console.WriteLine("You won"!);
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again!");
                }
            }
            Console.WriteLine($"You lost! The correct number was {randomNumber}");
        }

      
        public static void MaxNumber()
        {
            Console.WriteLine("Enter numbers");

            string[] num = Console.ReadLine().Split(',').ToArray();

            int max = 0;

            foreach (string i in num)
            {
                int number = int.Parse(i.Trim()); 
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The max number is " + max);
        }
    }
}
