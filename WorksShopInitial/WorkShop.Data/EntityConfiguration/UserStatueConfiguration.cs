using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class UserStatueConfiguration : IEntityTypeConfiguration<UserStatue>
    {
        public void Configure(EntityTypeBuilder<UserStatue> userStatue)
        {
            userStatue.HasKey(x => new { x.UserId, x.StatueId });

            userStatue.HasOne(u => u.User)
                .WithMany(s => s.UserStatues)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            userStatue.HasOne(s => s.Statue)
                .WithMany(u => u.StatueUsers)
                .HasForeignKey(s => s.StatueId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
