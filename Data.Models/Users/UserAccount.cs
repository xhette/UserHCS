using Data.Models.Addresses;

namespace Data.Models.Users;

public class UserAccount
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public string UserId { get; set; }
    public int AddressId { get; set; }
    public virtual User User { get; set; }
    public virtual Address Address { get; set; }
}