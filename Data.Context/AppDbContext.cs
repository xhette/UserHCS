using Data.Models.Addresses;
using Data.Models.Devices;
using Data.Models.Payments;
using Data.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data;

public partial class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureUserAccount(modelBuilder.Entity<UserAccount>());
        ConfigureAccrual(modelBuilder.Entity<Accrual>());
        ConfigurateAddress(modelBuilder.Entity<Address>());
        ConfigureDevice(modelBuilder.Entity<Device>());
        ConfigureFincard(modelBuilder.Entity<Fincard>());
        ConfigurePayment(modelBuilder.Entity<Payment>());
        ConfigureService(modelBuilder.Entity<Service>());
        ConfigureUserProfile(modelBuilder.Entity<UserProfile>());
    }
}