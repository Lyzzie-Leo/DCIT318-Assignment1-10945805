using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides of the triangle
            Console.WriteLine("Enter the length of the first side:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the length of the second side:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the length of the third side:");
            string input3 = Console.ReadLine();

            // Try to parse the inputs to integers
            if (int.TryParse(input1, out int side1) &&
                int.TryParse(input2, out int side2) &&
                int.TryParse(input3, out int side3))
            {
                // Check for the type of triangle based on the lengths of the sides
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numerical lengths for the sides of the triangle.");
            }
        }
    }
}
