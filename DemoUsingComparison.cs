using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate_AnonymousFunction
{
    internal class DemoUsingComparison
    {
        List<Employee> employees;

        public DemoUsingComparison()
        {
            employees = new List<Employee>();
        }

        public void InitData()
        {
            employees.Add(new Employee(1, "A", 1000));
            employees.Add(new Employee(4, "G", 1700));
            employees.Add(new Employee(2, "H", 2000));
            employees.Add(new Employee(3, "C", 1200));
        }

        //ham tuan thu delegate type Comparison
        public static int CodeComparison(Employee e1, Employee e2)
        {
            return e1.Code.CompareTo(e2.Code);
        }

        //ham tuan thu delegate type Comparison
        public static int NameComparison(Employee e1, Employee e2)
        {
            return e1.Name.CompareTo(e2.Name);
        }

        public void Sort()
        {
            //employees.Sort();
            Comparison<Employee> c = CodeComparison;
            //employees.Sort(c);
            //employees.Sort(NameComparison);

            //employees.Sort(
            //    //noi dung cua ham muon thuc hien
            //    //cai nay dc goi la Anonymous function
            //        delegate (Employee e1, Employee e2)
            //        {
            //            return e1.BaseSalary.CompareTo(e2.BaseSalary);
            //        }
            //    );

            //tuong duong doan code sau (su dung Lambda expression)
            employees.Sort((e1, e2) => e1.BaseSalary.CompareTo(e2.BaseSalary));
        }

        public void Display()
        {
            Console.WriteLine("List of employee:");
            foreach (Employee e in employees)
                Console.WriteLine(e);
        }
    }
}
