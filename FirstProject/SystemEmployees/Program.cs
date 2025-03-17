using System;
using SystemEmployees.Departments;
using SystemEmployees.Employees;

namespace SystemEmployees
{
 class Program
 {
  static void Main(string[] args)
  {
   Department ti = new Department("TI");
   Department manager = new Department("Manager");
   Employee employeeMarcelo =  new Developer("300.386.656-00", "Marcelo", 5000m, ti);
   ti.ListEmployees();
   Employee employeeBrisa = new Manager("000.111.222-33", "Brisa", 10000, manager);
   manager.ListEmployees();
  }
 }
}