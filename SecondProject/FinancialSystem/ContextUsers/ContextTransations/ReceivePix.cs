using System.Runtime.CompilerServices;

namespace ContextUsers.ContextTransations
{
  public class ReceivePix : Category
  {
    private string SourceUser;
    private string TargetUser; 
    private const string NameCategory = "ReceivePix";
    private decimal AmountReceived;
    private decimal PreviousBalance;
    private decimal CurrentBalance;
    private const ECategory TypeCategory = ECategory.Receita; 

  }
}