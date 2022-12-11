using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course {
    class Program{
        static void Main (){
            
            System.Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();

            System.Console.WriteLine("Enter worker data: ");
            Console.Write("Name :");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dpt = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, dpt);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i =0; i < n; i++){
                System.Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hour): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, valuePerHour, hours);
                worker.AddContract(contract);
            }

            System.Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            System.Console.WriteLine("Name: "+worker.Name);
            System.Console.WriteLine("Department: "+worker.Department.Name);
            System.Console.WriteLine("Iconome for "+monthAndYear + " : $" + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}