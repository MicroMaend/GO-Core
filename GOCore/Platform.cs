namespace GOCore;

public class Platform
{
    public List<AuctionHouse> AuctionHouses { get; set; }
    public List<User> Customers { get; set; }

    public Platform(List<AuctionHouse> auctionHouses, List<User> customers)
    {
        AuctionHouses = auctionHouses;
        Customers = customers;
    }
}
