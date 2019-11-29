using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class UserArmorConfiguration : IEntityTypeConfiguration<UserArmor>
    {
        public void Configure(EntityTypeBuilder<UserArmor> userArmor)
        {
            userArmor.HasKey(x => new { x.UserId, x.ArmorId});

            userArmor.HasOne(a => a.Armor)
                .WithMany(u => u.ArmorUsers)
                .HasForeignKey(a => a.ArmorId)
                .OnDelete(DeleteBehavior.Restrict);

            userArmor.HasOne(u => u.User)
                .WithMany(a => a.UserArmors)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
