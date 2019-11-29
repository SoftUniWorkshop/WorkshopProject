namespace WorkShop.Models
{
    using System.Collections.Generic;

    public class User
    {
        public User()
        {
            UserWeapons = new List<UserWeapon>();
            UserArmors = new List<UserArmor>();
            UserPotions = new List<UserPotion>();
            UserStatues = new HashSet<UserStatue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Gold { get; set; }

        public int Health { get; set; }

        public ICollection<UserWeapon> UserWeapons { get; set; }

        public ICollection<UserArmor> UserArmors { get; set; }

        public ICollection<UserPotion> UserPotions { get; set; }

        public ICollection<UserStatue> UserStatues { get; set; }
    }
}
