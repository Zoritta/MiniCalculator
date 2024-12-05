namespace Lektion4B;

class Program
{
    static void Main()
    {
        while (true)
        {
            System.Console.WriteLine("Hi! I am a mini calculator, here's how I can help you: first, enter a number...");
            int userInput1 = GetValidNumber();
            System.Console.WriteLine("Enter the second number...");
            int userInput2 = GetValidNumber();
            System.Console.WriteLine("Which operator do you want to use (+, -, *, /)?");
            string operation = GetValidOperator();

            try
            {
                int result = operation switch
                {
                    "+" => userInput1 + userInput2,
                    "-" => userInput1 - userInput2,
                    "*" => userInput1 * userInput2,
                    "/" when userInput2 != 0 => userInput1 / userInput2,
                    "/" => throw new InvalidOperationException("Division by zero is not allowed."),
                    _ => throw new InvalidOperationException("Invalid operation.")
                };

                Console.WriteLine($"The result of {userInput1} {operation} {userInput2} is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string? choice = Console.ReadLine();
            if (choice?.ToLower() != "yes")
            {
                Console.WriteLine("Goodbye!");
                break; // Exit the loop and program
            }
        }
    }

    static string GetValidOperator()
    {
        while (true)
        {
            string? key = Console.ReadLine();
            if (key == "+" || key == "-" || key == "*" || key == "/")
            {
                return key;
            }
            Console.WriteLine("Invalid input! Please enter one of these operators: +, -, *, /.");
        }
    }

    static int GetValidNumber()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
