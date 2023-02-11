using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course {
    class Program {
        static void Main (){

            List<Employee> employees = new List<Employee>();

            System.Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i <= n; i++){
                System.Console.WriteLine($"Employee number {i} data:");

                System.Console.WriteLine("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());

                System.Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                System.Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Value Per Hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y'){
                    System.Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }else {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            System.Console.WriteLine();
            System.Console.WriteLine("Payments: ");
            foreach( Employee emp in employees){
                System.Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}