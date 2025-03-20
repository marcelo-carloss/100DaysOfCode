using System;
using FinancialSystem.Models;
using FinancialSystem.Services;


namespace FinancialSystem 
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter your name: ");
      string username = Console.ReadLine();
      User user = new User(username);

      Persistence.LoadTransactions(user);

      while(true)
      {
        Console.WriteLine("\n=== Menu ===");
        Console.WriteLine("1 - Add Transaction");
        Console.WriteLine("2 - List Transactions");
        Console.WriteLine("3 - Generate Financial Report");
        Console.WriteLine("4 - Save and Exit");
        Console.Write("Choose an option: ");

        string option = Console.ReadLine();

        switch (option)

        {
          case "1":
            AddTransaction(user);
            break;
          case "2":
            user.ListTransactions();
          case "3":
            FinancialReporting reporting = new FinancialReporting(user);
            reporting.GenerateReport();
            break;
          case "4":
            Persistence.SaveTransactions(user);
            Console.WriteLine("Save data. Exit...");
            return;
          default:
            Console.WriteLine("Invalid option");
            break;
        }
      }
    }

    static void AddTransaction(User user)
    {
      Console.Write("Description: ");
      string description = Console.ReadLine();
      Console.Write("Value: ");
      decimal value = decimal.Parse(Console.ReadLine());
      Console.Write("Date (dd/mm/yyyy): ");
      DateTime date = DateTime.Parse(Console.ReadLine());
      Console.Write("Type (1 - Revenue, 2 - Extense)");
      TypeTransaction type = (Console.ReadLine() == "1") ? TypeTransaction.Revenue : TypeTransaction.Extense;

      user.AddTransaction(new Transaction(description, value, date, new Category(category), type));
      Console.WriteLine("Transaction added!");
    } 
  }
}
