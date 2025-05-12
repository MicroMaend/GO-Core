namespace GOCore;

public class Auction
{
    public Guid Id { get; set; }
    public Item Item { get; set; }
    public bool IsOnline { get; set; }
    public List<Bidding> Bids { get; set; }
    public DateTime AuctionStart { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }
    
    public Auction(Item item, bool isOnline, DateTime auctionStart, DateTime auctionEnd)
    {
        Id = Guid.NewGuid();
        Item = item;
        IsOnline = isOnline;
        Bids = new List<Bidding>();
        AuctionStart = auctionStart;
        AuctionEnd = auctionEnd;
        Status = "Upcoming";
    }
}