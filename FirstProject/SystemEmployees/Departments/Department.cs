using SystemEmployees.Employees;

namespace SystemEmployees.Departments{
  public class Department
  {
    
    public string Name { get; set; }
    public IList<Employee> Employees { get; } = new List<Employee>();

    public Department(string name)
    {
        Name = name;
    }

    public void AddEmployee(Employee employee)
    {
      if (!Employees.Contains(employee))
      {
        Employees.Add(employee);
      }  
    }

    public void ListEmployees()
    {
      if (Employees.Count == 0)
      {
        Console.WriteLine($"Nenhum funcionário no departamento {Name}.");
        return;
      }

      Console.WriteLine($"Funcionários do departamento {Name}:");
      foreach (var employee in Employees)
      {
        Console.WriteLine(employee.ToString());
      }
    }
  }
}