using System;

class Program
{
    static void Main()
    {
        // Example using TryParse to convert a string to an integer
        Console.WriteLine("Enter an integer value:");
        string intInput = Console.ReadLine();

        if (int.TryParse(intInput, out int intValue))
        {
            Console.WriteLine("Successfully converted to an integer: " + intValue);
        }
        else
        {
            Console.WriteLine("Error: Invalid input for integer conversion.");
        }

        // Example using Convert to convert a string to a double
        Console.WriteLine("\nEnter a double value:");
        string doubleInput = Console.ReadLine();

        try
        {
            double doubleValue = Convert.ToDouble(doubleInput);
            Console.WriteLine("Successfully converted to a double: " + doubleValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format for double conversion.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Input value is too large or too small for a double.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Example using Parse to convert a string to a decimal
        Console.WriteLine("\nEnter a decimal value:");
        string decimalInput = Console.ReadLine();

        try
        {
            decimal decimalValue = decimal.Parse(decimalInput);
            Console.WriteLine("Successfully converted to a decimal: " + decimalValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format for decimal conversion.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Input value is too large or too small for a decimal.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
