namespace WorkShop.Models
{
    using System.Collections.Generic;

    public class User
    {
        public User()
        {
            Weapons = new List<Weapon>();
            Armors = new List<Armor>();
            Potions = new List<Potion>();
            UserStatues = new HashSet<UserStatue>();
        }

        public string Name { get; set; }

        public int Gold { get; set; }

        public int Health { get; set; }

        public ICollection<Weapon> Weapons { get; set; }

        public ICollection<Armor> Armors { get; set; }

        public ICollection<Potion> Potions { get; set; }

        public ICollection<UserStatue> UserStatues { get; set; }
    }
}
