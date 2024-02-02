namespace Data.Models.Users;

public class User
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public virtual UserProfile UserProfile { get; set; }
}