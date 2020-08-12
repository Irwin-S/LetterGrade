using System;

namespace LetterGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Title: August 11th Practice
                Purpose: Convert a numeric grade to a letter grade.

                Author: James Grieve
                Last Modified: August 12, 2020

            */

            double userGrade = -1;
            string userInput, letterGrade, userName;
            // Constants are declared once and their value does not change.
            // This can allow you to change something in one location and have it automatically propogate.
            // It also saves some memory because you aren't saving space to add data later.
            const string gradePrompt = "Please enter your grade, or Q to exit: ";

            Console.WriteLine("This application will convert a numeric grade to a letter grade.");

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            Console.Write(gradePrompt);
            userInput = Console.ReadLine();
            while (userInput.ToLower() != "q")
            {
                bool valid = false;
                while (!valid)
                {
                    try 
                    {
                        userGrade = double.Parse(userInput);
                        valid = true;
                    }
                    catch
                    {
                        Console.WriteLine("That was not a numeric value, please try again.");
                        Console.Write("Please enter a numeric grade:");
                        userInput = Console.ReadLine();
                    }
                }

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

                Console.WriteLine($"{userName}, your grade is {letterGrade}, based on your score of {userGrade}.");
            
                Console.Write(gradePrompt);
                userInput = Console.ReadLine();
            }
            

            
        }
    }
}
