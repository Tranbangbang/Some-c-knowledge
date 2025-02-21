using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate_AnonymousFunction
{
    internal class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Employee()
        {

        }

        public Employee(int code, string name, double baseSalary)
        {
            Code = code;
            Name = name;
            BaseSalary = baseSalary;
        }

        public override string ToString()
        {
            return $"Employee: {Code} - {Name} - {BaseSalary}";
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

        
    }

}
