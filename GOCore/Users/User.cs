namespace GOCore;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int ZipCode { get; set; }
    public string City { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    
    public User(string userName, string password , string name, string address, int zipCode, string city, int phoneNumber, string email)
    {
        Id = Guid.NewGuid();
        UserName = userName;
        Password = password;
        Name = name;
        Address = address;
        ZipCode = zipCode;
        City = city;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    
    public User() {}
}