using System.Runtime.InteropServices.Marshalling;
using SystemEmployees.Departments;

namespace SystemEmployees.Employees
{
  public class Trainee : Employee
  {
    public Trainee(string cpf, string name, decimal salary, Department department) : base(cpf, name, salary, department)
    {}

    public override void CalculateBonus()
    {
        BonusPercentage = 0.05m;
        SalaryBonus = BonusPercentage * Salary;
    }
  }
}