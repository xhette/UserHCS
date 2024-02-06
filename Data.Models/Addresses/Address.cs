using Data.Models.Users;

namespace Data.Models.Addresses;

public class Address
{
    public int Id { get; set; }
    public int RegionTypeId { get; set; }
    public string RegionName { get; set; }
    public int SettlementTypeId { get; set; }
    public string SettlementName { get; set; }
    public int StreetTypeId { get; set; }
    public string StreetName { get; set; }
    public virtual RegionType RegionType { get; set; }
    public virtual SettlementType SettlementType { get; set; }
    public virtual StreetType StreetType { get; set; }
    
    public virtual ICollection<UserAccount> UserAccounts { get; set; }
}