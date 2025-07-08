using System;

class CalculatorProgram
{
    //Add method
    static void Add()
    {
        try
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine($"Result is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    //Subtract method
    static void Subtract()
    {
        try
        {
            Console.Write("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 - num2;
            Console.WriteLine($"Result is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    //Multiply method
    static void Multiply()
    {
        try
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 * num2;
            Console.WriteLine($"Result is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    //Divide method
    static void Divide()
    {
        try
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 / num2;
            Console.WriteLine($"Result is {result}");

            if (num2 == 0) // Prevents division by zero
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("CALCULATOR VERSION 1.00");
            Console.WriteLine("------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Choose: 1-5");
            Console.WriteLine("------------------------");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) // Validate input
            {
                Console.WriteLine("Invalid input. Please enter a number between 1-5.");
                continue; // Restart the loop
            }

            switch (choice)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the calculator.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1-5.");
                    break;
            }
        }
    }
}
