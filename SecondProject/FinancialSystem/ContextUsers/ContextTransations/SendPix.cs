using System.Runtime.CompilerServices;

namespace ContextUsers.ContextTransations
{
  public class SendPix : Category
  {
    private string SourceUser;
    private string TargetUser; 
    private const string NameCategory = "SendPix";
    private decimal AmountSent;
    private decimal PreviousBalance;
    private decimal CurrentBalance;
    private const ECategory TypeCategory = ECategory.Despesa; 

  }
}