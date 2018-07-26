using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.model;

public enum prof { klerk, manager, boss, }

namespace ConsoleApplication2
{
  public  interface IEmployer
    {
         string Name { get; set; }
         int Age { get; set; }
         int Salary { get; set; }
         DateTime DateOfStart { get; set; }
         prof Prof { get; set; }
    }
}
