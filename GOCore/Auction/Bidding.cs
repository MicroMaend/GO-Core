namespace GOCore;

public class Bidding
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    
    public Bidding(int amount, Guid userId)
    {
        Id = Guid.NewGuid();
        Amount = amount;
        Date = DateTime.Now;
        UserId = userId;
    }
}