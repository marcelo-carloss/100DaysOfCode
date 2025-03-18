namespace ContextUsers
{
  public class User
  {
    public User(string name, string cpf, string bankAccountNumber, DateTime dateOfBirth)
    {
        Id = Guid.NewGuid();
        Name = name;
        CPF = cpf;
        BankAccount = new BankAccount (this,bankAccountNumber,dateOfBirth);
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CPF { get; set; }
    public BankAccount BankAccount { get; set; }
  }
}