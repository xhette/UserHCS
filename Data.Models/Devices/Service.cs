namespace Data.Models.Devices;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string UnitsName { get; set; }
    public int ServiceProviderId { get; set; }
    public int IndicationTypeId { get; set; }
    public virtual ServiceProvider ServiceProvider { get; set; }
    public virtual IndicationType IndicationType { get; set; }
}