using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class WeaponConfiguration : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> weapon)
        {
            weapon.HasKey(x => x.Id);

            weapon.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            weapon.Property(x => x.Damage)
                .IsRequired();

            weapon.Property(x => x.Duratbility)
                .IsRequired();
        }
    }
}
