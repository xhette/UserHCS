namespace Data.Models.Devices;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ServiceProviderId { get; set; }
    public virtual ServiceProvider ServiceProvider { get; set; }
}