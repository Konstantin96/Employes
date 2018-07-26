using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.model
{
    public struct Employer : IEmployer
    {
        public Employer(string name, int age, DateTime dateofStart, int salary, prof P)
        {
            Name = name;
            Age = age;
            Salary = salary;
            DateOfStart = dateofStart;
            Salary = salary;
            Prof = P;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfStart { get; set; }
        public prof Prof { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1}) - {2} ({3})\t{4}KZT", Name, Age, Prof, DateOfStart, Salary);
        }

    }
}
