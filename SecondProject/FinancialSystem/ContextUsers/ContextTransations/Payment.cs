using System.Runtime.CompilerServices;

namespace ContextUsers.ContextTransations
{
  public class Payment : Category
  {
    private string Username;
    private const string Name = "Payment";
    private decimal PaymentAmount;
    private decimal PreviousBalance;
    private decimal CurrentBalance;
    private const ECategory TypeCategory = ECategory.Despesa; 

  }
}