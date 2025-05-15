namespace GOCore;

public class Auction
{
    public Guid Id { get; set; }
    public Item Item { get; set; }
    public bool IsOnline { get; set; }
    public DateTime AuctionStart { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }
    public Bidding? HighestBid { get; set; }
    
    public Auction(Item item, bool isOnline, DateTime auctionStart, DateTime auctionEnd)
    {
        Id = Guid.NewGuid();
        Item = item;
        IsOnline = isOnline;
        AuctionStart = auctionStart;
        AuctionEnd = auctionEnd;
        Status = "Upcoming";
    }
    
    public Auction() {}
}