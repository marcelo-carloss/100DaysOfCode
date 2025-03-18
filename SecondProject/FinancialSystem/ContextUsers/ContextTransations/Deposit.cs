using System.Runtime.CompilerServices;

namespace ContextUsers.ContextTransations
{
  public class Deposit : Category
  {
    private string Username;
    private const string Name = "Deposit";
    private decimal DepositAmount;
    private decimal PreviousBalance;
    private decimal CurrentBalance;
    private const ECategory TypeCategory = ECategory.Receita; 

  }
}