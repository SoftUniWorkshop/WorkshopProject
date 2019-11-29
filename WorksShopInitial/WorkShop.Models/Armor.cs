using System.Collections.Generic;

namespace WorkShop.Models
{
    public class Armor
    {
        public Armor()
        {
            this.ArmorUsers = new HashSet<UserArmor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int Defence { get; set; }

        public int Durability { get; set; }

        public  ICollection<UserArmor> ArmorUsers { get; set; }

    }
}
