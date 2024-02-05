namespace Data.Models.Devices;

public class Indications
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Value { get; set; }
    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }
}