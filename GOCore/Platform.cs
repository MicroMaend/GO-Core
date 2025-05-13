namespace GOCore;

public class Platform
{
    public List<AuctionHouse> AuctionHouses { get; set; }
    public List<User> Users { get; set; }

    public Platform(List<AuctionHouse> auctionHouses, List<User> users)
    {
        AuctionHouses = auctionHouses;
        Users = users;
    }
    
    public Platform() {}
}
