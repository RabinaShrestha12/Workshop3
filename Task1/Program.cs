public class Operators
{
    //  add two numbers
    public static void Main()
    {
        int a = 6;
        int b = 4;

        //addition
        int add = a + b;
        Console.WriteLine("sum of a and b: " + add);
        
        // subraction
        int sub = a - b;
        Console.WriteLine("Difference of a and b: " + sub);

        // Multiplication
        int mul = a * b;
        Console.WriteLine("Product of a and b: " + mul);

        // Division
        if (b != 0)
        {
            double div = (double)a / b;
            Console.WriteLine("Quotient of a and b: " + div);
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }

        // Odd or Even Finder using Ternary Operator
        int number = 7;
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine("The number " + number + " is an " + result);
    }
        
    }
