namespace GOCore;

public class AuctionHouse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public int ZipCode { get; set; }
    public List<Admin> AdminUsers { get; set; }
    
    public AuctionHouse(string name, string address, string city, int zipCode)
    {
        Name = name;
        Address = address;
        City = city;
        ZipCode = zipCode;
        AdminUsers = new List<Admin>();
    }
    
    public AuctionHouse() {}
}