using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class UserWeaponConfiguration : IEntityTypeConfiguration<UserWeapon>
    {
        public void Configure(EntityTypeBuilder<UserWeapon> userWeapon)
        {
            userWeapon.HasKey(x => new { x.UserId, x.WeaponId });

            userWeapon.HasOne(w => w.Weapon)
                .WithMany(u => u.WeaponUsers)
                .HasForeignKey(w => w.WeaponId)
                .OnDelete(DeleteBehavior.Restrict);

            userWeapon.HasOne(u => u.User)
                .WithMany(w => w.UserWeapons)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
