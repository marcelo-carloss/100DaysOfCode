using SystemEmployees.Departments;

namespace SystemEmployees.Employees
{
  public class Manager : Employee
  {
    public Manager(string cpf, string name, decimal salary, Department department) : base(cpf, name, salary, department)
    {}

    public override void CalculateBonus()
    {
        BonusPercentage = 0.1m;
        SalaryBonus = BonusPercentage * Salary;
    }
  }
}