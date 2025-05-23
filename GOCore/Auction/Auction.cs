namespace GOCore;

public class Auction
{
    public Guid Id { get; set; }
    public Guid ItemId { get; set; }
    public bool IsOnline { get; set; }
    public DateTime AuctionStart { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }
    public Guid HighestBidId { get; set; }
    public Auction(Guid itemId, bool isOnline, DateTime auctionStart, DateTime auctionEnd, Guid highestBidId)
    {
        Id = Guid.NewGuid();
        ItemId = itemId;
        IsOnline = isOnline;
        AuctionStart = auctionStart;
        AuctionEnd = auctionEnd;
        Status = "Upcoming";
        HighestBidId = highestBidId;
    }
    
    public Auction() {}
}