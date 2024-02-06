using Data.Models.Payments;
using Microsoft.AspNetCore.Identity;

namespace Data.Models.Users;

public class User  : IdentityUser
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public virtual UserProfile UserProfile { get; set; }
    public virtual ICollection<UserAccount> UserAccounts { get; set; }
    public virtual ICollection<Fincard> Fincards { get; set; }
}