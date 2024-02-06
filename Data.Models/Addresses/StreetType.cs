using Data.Models.Base;

namespace Data.Models.Addresses;

public class StreetType : BaseAddressType
{
    public virtual ICollection<Address> Addresses { get; set; }
}