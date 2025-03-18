using System.Runtime.CompilerServices;

namespace ContextUsers.ContextTransations
{
  public class Withdrawal : Category
  {
    private string Username;
    private const string Name = "Withdrawal";
    private decimal WithdrawalAmount;
    private decimal PreviousBalance;
    private decimal CurrentBalance;
    private const ECategory TypeCategory = ECategory.Despesa; 

  }
}