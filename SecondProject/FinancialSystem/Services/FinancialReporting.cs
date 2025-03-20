using FinancialSystem.Interfaces;
using FinancialSystem.Models;

namespace FinancialSystem.Services
{
  public class FinancialReporting : IFinancialReporting
  {
    private User _user;
    public FinancialReporting(User user)
    {
      _user = user;
    }

    public void GenerateReport()
    {
      decimal totalRevenue = _user.Transactions
        .Where(t => t.Type == TypeTransaction.Revenue)
        .Sum(t => t.Value);

      decimal totalExpenses = _user.Transactions
        .Where(t => t.Type == TypeTransaction.Extense)
        .Sum(t => t.Value);

      decimal amount = totalRevenue - totalExpenses;

      Console.WriteLine("\n=== Relatório Financeiro ===");
      Console.WriteLine($"Total of Revenue: R$ {totalRevenue}");
      Console.WriteLine($"Total of Expenses: R$ {totalExpenses}");
      Console.WriteLine($"Current Balance: R$ {amount}");
    }
  }
}