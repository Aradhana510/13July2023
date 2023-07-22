using System;

class Program
{
    static void Main()
    {
        // Example 1: Convert string to integer using TryParse method
        Console.Write("Enter a number: ");
        string inputNumber = Console.ReadLine();

        if (int.TryParse(inputNumber, out int result))
        {
            int multipliedValue = result * 5;
            Console.WriteLine($"Result of the conversion: {multipliedValue}");
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
        }

        // Example 2: Convert string to DateTime object using Convert method
        Console.Write("Enter a date (yyyy-MM-dd format): ");
        string inputDate = Console.ReadLine();

        try
        {
            DateTime dateObject = Convert.ToDateTime(inputDate);
            DateTime oneMonthEarlier = dateObject.AddMonths(-1);
            Console.WriteLine($"One month earlier: {oneMonthEarlier:yyyy-MM-dd}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid date format. Please enter a date in yyyy-MM-dd format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Example 3: Convert string to TimeSpan object using Parse method
        Console.Write("Enter a time (hh:mm:ss format): ");
        string inputTime = Console.ReadLine();

        try
        {
            TimeSpan timeSpanObject = TimeSpan.Parse(inputTime);
            TimeSpan newTimeSpan = timeSpanObject.Add(new TimeSpan(2, 0, 0));
            Console.WriteLine($"Time after adding 2 hours: {newTimeSpan}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid time format. Please enter a time in hh:mm:ss format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
