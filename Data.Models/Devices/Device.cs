namespace Data.Models.Devices;

public class Device
{
    public int Id { get; set; }
    public string DeviceNumber { get; set; }
    public int IndicationTypeId { get; set; }
    public int StatusId { get; set; }
    public virtual IndicationType IndicationType { get; set; }
    public virtual DeviceStatus Status { get; set; }
}