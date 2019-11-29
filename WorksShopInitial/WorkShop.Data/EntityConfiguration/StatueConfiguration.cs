using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class StatueConfiguration : IEntityTypeConfiguration<Statue>
    {
        public void Configure(EntityTypeBuilder<Statue> statue)
        {
            statue.HasKey(x => x.Id);

            statue.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            statue.Property(x => x.StatusIncrease)
                .IsRequired();

            statue.Property(x => x.Amount)
                .IsRequired();
        }
    }
}
