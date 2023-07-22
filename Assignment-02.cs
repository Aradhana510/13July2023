using System;

namespace EmployeeDetailsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Employee Details:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Employee Gender (M/F): ");
            char gender = char.Parse(Console.ReadLine());

            Console.Write("Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Date of Joining (DD/MM/YYYY): ");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            
            double taxRate = salary > 90000 ? 0.3 : 0.15;
            double taxAmount = salary * taxRate;

            
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t {salary.ToString("C2")}\t\t{dateOfJoining.ToShortDateString()}");
            Console.WriteLine("\nYou have to pay: --------------");
            Console.WriteLine($"Tax Rate: {taxRate:P}");
            Console.WriteLine($"Tax Amount: {taxAmount.ToString("C2")}");

            Console.ReadLine(); 
        }
    }
}
