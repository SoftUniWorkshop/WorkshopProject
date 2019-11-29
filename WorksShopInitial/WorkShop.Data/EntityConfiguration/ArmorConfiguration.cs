
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class ArmorConfiguration : IEntityTypeConfiguration<Armor>
    {
        public void Configure(EntityTypeBuilder<Armor> armor)
        {
            armor.HasKey(x => x.Id);

            armor.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            armor.Property(x => x.Defence)
                .IsRequired();

            armor.Property(x => x.Durability)
                .IsRequired();
        }
    }
}