namespace HELLOWORLD;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to enter the first number
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        // Convert the first input to a double
        if (double.TryParse(input1, out double number1))
        {
            // Prompt user to enter the second number
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            // Convert the second input to a double
            if (double.TryParse(input2, out double number2))
            {
                // Add the two numbers
                double sum = number1 + number2;

                // Display the result
                Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
        }

        // Wait for user input before closing the console window
        Console.ReadLine();

    }
}

