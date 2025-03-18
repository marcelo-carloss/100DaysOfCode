namespace ContextUsers
{
  public class BankAccount
  {
    public BankAccount(User user, string bankAccountNumber, DateTime dateOfBirth)
    {
        User = user;
        BankAccountNumber = bankAccountNumber;
        DateOfBirth = dateOfBirth;
    }

    public User User { get; set; }
    public string BankAccountNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    private decimal balance;
    public decimal Balance {
      get { 
        if(balance <= 0)
        {
          Console.WriteLine("Você está sem saldo!");
        }
        return balance;}
      private set {
        
      }
    }
  }
}