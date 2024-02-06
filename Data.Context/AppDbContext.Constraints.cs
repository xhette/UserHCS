using Data.Models.Addresses;
using Data.Models.Devices;
using Data.Models.Payments;
using Data.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data;

public partial class AppDbContext
{
    private void ConfigureUserAccount(EntityTypeBuilder<UserAccount> entity)
    {
        entity.HasOne(x => x.User)
            .WithMany(x => x.UserAccounts)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity.HasOne(x => x.Address)
            .WithMany(x => x.UserAccounts)
            .HasForeignKey(x => x.AddressId);
    }

    private void ConfigureUserProfile(EntityTypeBuilder<UserProfile> entity)
    {
        entity.HasOne(x => x.User)
            .WithOne(x => x.UserProfile)
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Cascade);
    }

    private void ConfigureDevice(EntityTypeBuilder<Device> entity)
    {
        entity.HasOne(x => x.IndicationType)
            .WithMany(x => x.Devices)
            .HasForeignKey(x => x.IndicationTypeId);
        
        entity.HasOne(x => x.Status)
            .WithMany(x => x.Devices)
            .HasForeignKey(x => x.StatusId);
    }

    private void ConfigurateAddress(EntityTypeBuilder<Address> entity)
    {
        entity.HasOne(x => x.RegionType)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.RegionTypeId);

        entity.HasOne(x => x.StreetType)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.SettlementTypeId);

        entity.HasOne(x => x.StreetType)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.StreetTypeId);
    }

    private void ConfigureService(EntityTypeBuilder<Service> entity)
    {
        entity.HasOne(x => x.ServiceProvider)
            .WithMany(x => x.Services)
            .HasForeignKey(x => x.ServiceProviderId);

        entity.HasOne(x => x.IndicationType)
            .WithMany(x => x.Services)
            .HasForeignKey(x => x.IndicationTypeId);
    }

    private void ConfigureAccrual(EntityTypeBuilder<Accrual> entity)
    {
        entity.HasOne(x => x.Fincard)
            .WithMany(x => x.Accruals)
            .HasForeignKey(x => x.FincardId);

        entity.HasOne(x => x.IndicationType)
            .WithMany(x => x.Accruals)
            .HasForeignKey(x => x.IndicationTypeId);
    }

    private void ConfigureFincard(EntityTypeBuilder<Fincard> entity)
    {
        entity.HasOne(x => x.User)
            .WithMany(x => x.Fincards)
            .HasForeignKey(x => x.UserId);
    }

    private void ConfigurePayment(EntityTypeBuilder<Payment> entity)
    {
        entity.HasOne(x => x.Fincard)
            .WithMany(x => x.Payments)
            .HasForeignKey(x => x.FincardId);
    }
}