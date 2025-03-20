namespace FinancialSystem.Models
{
  public enum TypeTransaction
  {
    Revenue,
    Extense
  }

  public class Transaction
  {
    public Guid Id { get; private set; }
    public string Description { get; private set; }
    public decimal Value { get; private set; }
    public DateTime Date { get; private set; }
    public Category Category { get; private set; }
    public TypeTransaction Type { get; private set; }
    public Transaction(Guid id, string description, decimal value, DateTime date, Category category, TypeTransaction type)
    {
        if (string.IsNullOrWhiteSpace(description))
          throw new ArgumentException("Description can't be empty.");
        if (value <= 0)
          throw new ArgumentException("The value must be greater than zero.");

        Id = Guid.NewGuid();
        Description = description;
        Value = value;
        Date = date;
        Category = category;
        Type = type;
    }


    public override string ToString()
    {
        return $"{Id}: {Description} - {Type} of R$ {Value} in {Date.ToShortDateString()} (Category: {Category.Name})";
    }
  }
}