using Data.Models.Base;

namespace Data.Models.Devices;

public class DeviceStatus : AType
{
    public virtual ICollection<Device> Devices { get; set; }
}