namespace ContextUsers.ContextTransations
{
  public class Transation
  {
    public User User { get; set; }
    public decimal PreviousBalance { get; set; }
    public decimal CurrentBalance { get; set; }
    public Category TypeTransation { get; set; }
  }
}