using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WorkShop.Models;

namespace WorkShop.Data
{
    public class WorkShopContext : DbContext
    {
        public WorkShopContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Potion> Potions { get; set; }
        public DbSet<Statue> Statues { get; set; }
        public DbSet<UserArmor> UsersArmors { get; set; }
        public DbSet<UserWeapon> UsersWepons { get; set; }
        public DbSet<UserPotion> UsersPotions { get; set; }
        public DbSet<UserStatue> UsersStatues { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
