using System;
using System.Globalization;
using System.Collections.Generic;

namespace RegisterEmployees {
    class Employees {
        public int Id {get; set;}
        public string Name {get; set;}
        public double Salary {get; private set;}

        public Employees (int id, string name, double salary){
            Id = id; Name = name; Salary = salary;
        }

        public void IncreaseSalary (double percentage){
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return "Employee ID: "+ Id
            + ", Name: "+Name
            + ", Salary: "+Salary
            + "\n";
        }
    }
}