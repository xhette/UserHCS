using Data.Models.Base;

namespace Data.Models.Addresses;

public class SettlementType : BaseAddressType
{
    public virtual ICollection<Address> Addresses { get; set; }
}