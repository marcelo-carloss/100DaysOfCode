using FinancialSystem.Models;

namespace FinancialSystem.Services
{
  public static class Persistence
  {
    private const string PathFile = "transactions.csv";

    public static void SaveTransactions(User user)
    {
      using (StreamWriter writer = new StreamWriter(PathFile))
      {
        foreach (var transaction in user.Transactions)
        {
          writer.WriteLine($"{transaction.Id};{transaction.Description};{transaction.Value};{transaction.Date};{transaction.Category.Name};{transaction.Type}");
        }
      }
    }

    public static void LoadTransactions(User user)
    {
      if(!File.Exists(PathFile))
        return;

      using (StreamReader reader = new StreamReader(PathFile))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          var data = line.Split(';');

          string description = data[1];
          decimal value = decimal.Parse(data[2]);
          DateTime date = DateTime.Parse(data[3]);
          Category category = new Category(data[4]);
          TypeTransaction type = (TypeTransaction)Enum.Parse(typeof(TypeTransaction), data[5]);

          user.AddTransaction(new Transaction(description, value, category, type));
        }
      }
    }
  }
}