using Data.Models.Addresses;
using Data.Models.Devices;
using Data.Models.Payments;
using Data.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Data;

public partial class AppDbContext
{
    //Таблицы
    public DbSet<Address> Addresses { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<Indication> Indications { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceProvider> ServiceProviders { get; set; }
    public DbSet<Accrual> Accruals { get; set; }
    public DbSet<Fincard> Fincards { get; set; }
    public DbSet<Payment> Payments { get; set; }
    
    //Справочники
    public DbSet<RegionType> RegionTypes { get; set; }
    public DbSet<SettlementType> SettlementTypes { get; set; }
    public DbSet<StreetType> StreetTypes { get; set; }
    public DbSet<DeviceStatus> DeviceStatuses { get; set; }
    public DbSet<IndicationType> IndicationTypes { get; set; }
}