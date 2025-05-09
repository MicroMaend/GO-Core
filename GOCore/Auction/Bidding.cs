namespace GOCore;

public class Bidding
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid CustomerId { get; set; }
}