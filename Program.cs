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

                if (userGrade > 100 || userGrade < 0)
                {
                    letterGrade = "Invalid";
                }
                else if (userGrade >= 97)
                {
                    letterGrade = "A+";
                }
                else if (userGrade >= 90) // Thanks Aaron
                {
                    letterGrade = "A";
                }
                else if (userGrade >= 85)
                {
                    letterGrade = "A-";
                }
                else if (userGrade >= 80)
                {
                    letterGrade = "B+";
                }
                else if (userGrade >= 75)
                {
                    letterGrade = "B";
                }
                else if (userGrade >= 70)
                {
                    letterGrade = "B-";
                }
                else if (userGrade >= 65)
                {
                    letterGrade = "C+";
                }
                else if (userGrade >= 60)
                {
                    letterGrade = "C";
                }
                else if (userGrade >= 55)
                {
                    letterGrade = "C-";
                }
                else if (userGrade >= 50)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                Console.WriteLine($"{userName}, your grade is {letterGrade}, based on your score of {userGrade}.");
            
                Console.Write(gradePrompt);
                userInput = Console.ReadLine();
            }
            

            
        }
    }
}
