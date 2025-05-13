namespace GOCore;

public class AuctionHouse
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public int ZipCode { get; set; }
    public List<Auction> Auctions { get; set; }
    
    public List<Item> Items { get; set; }
    public List<Admin> AdminUsers { get; set; }
    
    public AuctionHouse(string name, string address, string city, int zipCode)
    {
        Name = name;
        Address = address;
        City = city;
        ZipCode = zipCode;
        Auctions = new List<Auction>();
        Items = new List<Item>();
        AdminUsers = new List<Admin>();
    }
    
    public AuctionHouse() {}
}