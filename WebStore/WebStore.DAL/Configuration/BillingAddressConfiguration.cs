using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Model.Models;

namespace WebStore.DAL.Configuration;
public class BillingAddressConfiguration : IEntityTypeConfiguration<BillingAddress>
{
    public void Configure(EntityTypeBuilder<BillingAddress> builder)
    {
        builder.ToTable("BillingAddress");

        builder.HasOne(x => x.Customer)
            .WithOne(y => y.BillingAddress)
            .HasForeignKey<BillingAddress>(x => x.Id);
    }
}
