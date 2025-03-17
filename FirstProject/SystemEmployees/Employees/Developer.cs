using SystemEmployees.Departments;

namespace SystemEmployees.Employees
{
  public class Developer : Employee
  {
  
    public Developer(string cpf, string name, decimal salary, Department department) : base(cpf, name, salary, department){}
  

    public override void CalculateBonus()
    {
        BonusPercentage = 0.07m;
        SalaryBonus = BonusPercentage * Salary;
    }
  }
}