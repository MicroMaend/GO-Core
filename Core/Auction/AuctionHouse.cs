namespace Core;

public class AuctionHouse
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public int ZipCode { get; set; }
    public List<Auction> Auctions { get; set; }
    public List<Admin> AdminUsers { get; set; }
}