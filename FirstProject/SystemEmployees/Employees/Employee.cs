using SystemEmployees.Departments;
using System.Collections.Generic;

namespace SystemEmployees.Employees
{
  public abstract class Employee
  {
    protected string CPF { get; set; }
    protected string Name { get; set; }
    protected decimal salary;
    protected decimal SalaryBonus;
    protected decimal BonusPercentage;
    protected double DailyWorkingHours;
    protected Department departmentEmployee;

    public Department DepartmentEmployee
    {
      get{ return departmentEmployee;}
      private set {
        departmentEmployee = value;
      }
    }

    public decimal Salary {
      get{return salary;}
      private set{
        salary = value;
      }
    }
    public Employee(string cpf, string name, decimal salary, Department department)
    {
      CPF = cpf;
      Name = name;
      Salary = salary;
      DepartmentEmployee = department;
      department.AddEmployee(this);
    }
    public override string ToString() 
    {
      return $"CPF: {CPF}, Name: {Name}, Salary: {Salary:F2}";
    }


    public void IncreaseSalary(decimal percentage)
    {
      Salary = Salary + ((percentage/100) * Salary);
    }

    public abstract void CalculateBonus();
  }
}