using System;
using System.Globalization;
using System.Collections.Generic;

namespace RegisterEmployees {
    class Program {
        static void Main (string[] args){
            List<Employees> employees = new List<Employees>();

            System.Console.WriteLine();
            System.Console.WriteLine("How many employees will be registered?");
            int toRegister = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i=0; i < toRegister; i++){
                System.Console.WriteLine();
                System.Console.Write("Type the ID of the employe:");
                int emId = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine();
                System.Console.Write("Type the name of the employe:");
                string emName = Console.ReadLine();

                System.Console.WriteLine();
                System.Console.Write("Type the Salary of the employe:");
                double emSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employees(emId, emName, emSalary));
                
            }

            System.Console.WriteLine();
            System.Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Employees emp = employees.Find (x => x.Id == id);
            if (emp != null){
                System.Console.WriteLine("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }else {
                System.Console.WriteLine("This id does not exist");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Employees list:");
            foreach (Employees obj in employees){
                Console.WriteLine(obj);
            }

            System.Console.ReadLine();
        }
    }
}