using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class PotionConfiguration : IEntityTypeConfiguration<Potion>
    {
        public void Configure(EntityTypeBuilder<Potion> potion)
        {
            potion.HasKey(x => x.Id);

            potion.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            potion.Property(x => x.HealthRestore)
           .IsRequired();

        }
    }
}
