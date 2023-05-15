using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter your choice (1-4): ");
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (choice)
        {
            case '1':
                result = Add(num1, num2);
                break;
            case '2':
                result = Subtract(num1, num2);
                break;
            case '3':
                result = Multiply(num1, num2);
                break;
            case '4':
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }

    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return double.NaN;
        }
    }
}
