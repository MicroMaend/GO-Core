namespace GOCore;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Images { get; set; }
    public int Value { get; set; }
    public Guid SellerId { get; set; }
    public string Status { get; set; }
    public string Condition { get; set; }
    public string Category { get; set; }
    public Guid AuctionHouseId { get; set; }

    
    public Item(string name, string description, List<string> images, int value, Guid sellerId, string status, string condition, string category, Guid auctionHouseId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Images = images;
        Value = value;
        SellerId = sellerId;
        Status = status;
        Condition = condition;
        Category = category;
        AuctionHouseId = auctionHouseId;
    }
    
    public Item() {}
}