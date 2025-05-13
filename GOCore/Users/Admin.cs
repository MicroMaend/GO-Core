namespace GOCore;

public class Admin
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    
    public Admin(string userName, string password)
    {
        Id = Guid.NewGuid();
        UserName = userName;
        Password = password;
    }
    
    public Admin() {}
}