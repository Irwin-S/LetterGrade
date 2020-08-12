using System;

namespace LetterGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            double userGrade;
            string letterGrade;

            Console.Write("Please enter your grade:");
            userGrade = double.Parse(Console.ReadLine());

            if (userGrade >= 97 && userGrade <= 100)
            {
                letterGrade = "A+";
            }
            else if (userGrade >= 90 && userGrade <= 96)
            {
                letterGrade = "A";
            }
            else if (userGrade >= 85 && userGrade <= 89)
            {
                letterGrade = "A-";
            }
            else if (userGrade >= 80 && userGrade <= 84)
            {
                letterGrade = "B+";
            }
            else if (userGrade >= 75 && userGrade <= 79)
            {
                letterGrade = "B";
            }
            else if (userGrade >= 70 && userGrade <= 74)
            {
                letterGrade = "B-";
            }
            else if (userGrade >= 65 && userGrade <= 69)
            {
                letterGrade = "C+";
            }
            else if (userGrade >= 60 && userGrade <= 64)
            {
                letterGrade = "C";
            }
            else if (userGrade >= 55 && userGrade <= 59)
            {
                letterGrade = "C-";
            }
            else if (userGrade >= 50 && userGrade <= 54)
            {
                letterGrade = "D";
            }
            else if (userGrade >= 0 && userGrade <= 49)
            {
                letterGrade = "F";
            }
            else
            {
                letterGrade = "Invalid";
            }

            Console.WriteLine($"Your grade is {letterGrade}, based on your score of {userGrade}.");
        }
    }
}
