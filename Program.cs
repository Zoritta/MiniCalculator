
namespace Lektion4B;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Hi! I am a mini calculator, it's how I can help you: first enter a number and enter...");
        int userInput1 = GetValidNumber();
        System.Console.WriteLine("Enter the second number...");
        int userInput2 = GetValidNumber();
        System.Console.WriteLine("Which operator do you want to do (+, -, * , /)");
        string operation = GetValidOperator();
        int result = operation switch
        {
            "+" => userInput1 + userInput2,
            "-" => userInput1 - userInput2,
            "*" => userInput1 * userInput2,
            "/" when userInput2 != 0 => userInput1 / userInput2,
            _ => throw new InvalidOperationException("Invalid operation or division by zero.")
        };

        Console.WriteLine($"The result of {userInput1} {operation} {userInput2} is: {result}");
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
