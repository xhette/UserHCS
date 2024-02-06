using Data.Models.Base;

namespace Data.Models.Addresses;

public class RegionType : BaseAddressType
{
    public virtual ICollection<Address> Addresses { get; set; }
}