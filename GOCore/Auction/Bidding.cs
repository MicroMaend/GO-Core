namespace GOCore;

public class Bidding
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid CustomerId { get; set; }
    
    public Bidding(int amount, Guid customerId)
    {
        Id = Guid.NewGuid();
        Amount = amount;
        Date = DateTime.Now;
        CustomerId = customerId;
    }
}