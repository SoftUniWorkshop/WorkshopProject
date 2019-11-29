using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class UserPotionConfiguration : IEntityTypeConfiguration<UserPotion>
    {
        public void Configure(EntityTypeBuilder<UserPotion> userPotion)
        {
            userPotion.HasKey(x => new { x.PotionId, x.UserId });

            userPotion.HasOne(p => p.Potion)
                .WithMany(u => u.PotionUsers)
                .HasForeignKey(p => p.PotionId)
                .OnDelete(DeleteBehavior.Restrict);

            userPotion.HasOne(u => u.User)
              .WithMany(p => p.UserPotions)
              .HasForeignKey(u => u.UserId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}