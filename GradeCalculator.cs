using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();

            // Parse the input to an integer
            if (int.TryParse(input, out int grade))
            {
                // Check if the grade is within the valid range
                if (grade >= 0 && grade <= 100)
                {
                    // Determine the letter grade based on the numerical grade
                    string letterGrade;
                    if (grade >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = "B";
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = "C";
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }

                    // Display the corresponding letter grade
                    Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("The grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }
        }
    }
}
