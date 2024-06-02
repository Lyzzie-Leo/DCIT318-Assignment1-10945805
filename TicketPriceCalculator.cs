using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int age))
            {
                // Determine the ticket price based on the age
                int ticketPrice = 10; // default price

                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7; // discounted price
                }

                // Display the ticket price
                Console.WriteLine($"The ticket price is GHC{ticketPrice}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
