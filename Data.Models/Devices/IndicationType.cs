using Data.Models.Base;
using Data.Models.Payments;

namespace Data.Models.Devices;

public class IndicationType : AType
{
    public virtual ICollection<Device> Devices { get; set; }
    public virtual ICollection<Service> Services { get; set; }
    public virtual ICollection<Accrual> Accruals { get; set; }
}