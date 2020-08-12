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
                else if (userGrade >= 90 && userGrade < 97) // Thanks Aaron
                {
                    letterGrade = "A";
                }
                else if (userGrade >= 85 && userGrade < 90)
                {
                    letterGrade = "A-";
                }
                else if (userGrade >= 80 && userGrade < 85)
                {
                    letterGrade = "B+";
                }
                else if (userGrade >= 75 && userGrade < 80)
                {
                    letterGrade = "B";
                }
                else if (userGrade >= 70 && userGrade < 75)
                {
                    letterGrade = "B-";
                }
                else if (userGrade >= 65 && userGrade < 70)
                {
                    letterGrade = "C+";
                }
                else if (userGrade >= 60 && userGrade < 65)
                {
                    letterGrade = "C";
                }
                else if (userGrade >= 55 && userGrade < 60)
                {
                    letterGrade = "C-";
                }
                else if (userGrade >= 50 && userGrade < 55)
                {
                    letterGrade = "D";
                }
                else if (userGrade >= 0 && userGrade < 50)
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
