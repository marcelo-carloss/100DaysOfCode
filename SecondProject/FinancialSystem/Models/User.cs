using System.Collections.Generic;
using System.Transactions;

namespace FinancialSystem.Models
{
  public class User
  {
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public List<Transaction> Transactions { get; private set; }
    
    public User(string name)
    {
      if (string.IsNullOrWhiteSpace(name))
        throw new ArgumentException("Name can't be empty.");
      
      Id = Guid.NewGuid();
      Name = name;
      Transactions = new List<Transaction>();
    }

    public void AddTransaction(Transaction transaction)
    {
      Transactions.Add(transaction);
    }

    public void ListTransactions()
    {
      if (Transactions.Count == 0)
      {
        Console.WriteLine("No transactions found.");
        return;
      }

      Console.WriteLine("\n=== Transactions ===");
      foreach (var transaction in Transactions)
      {
        Console.WriteLine(transaction);
      }
    }
  }
}