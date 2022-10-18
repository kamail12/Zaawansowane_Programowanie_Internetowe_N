using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Model.Models;

namespace WebStore.DAL.Configuration;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasMany(x => x.Orders)
            .WithOne(y => y.Customer)
            .HasForeignKey(y => y.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        // builder.HasMany(x => x.Adresses)
        //     .WithOne(y => y.Customer)
        //     .HasForeignKey(y => y.CustomerId)
        //     .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.BillingAddress)
            .WithOne(y => y.Customer)
            .HasForeignKey<Customer>(x => x.BillingAddressId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.ShippingAddress)
            .WithOne(y => y.Customer)
            .HasForeignKey<Customer>(x => x.ShippingAddressId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}