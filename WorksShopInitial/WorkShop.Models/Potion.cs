using System.Collections.Generic;

namespace WorkShop.Models
{
    public class Potion
    {
        public Potion()
        {
            this.PotionUsers = new HashSet<UserPotion>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Price { get; set; }

        public int HealthRestore { get; set; }

        public ICollection<UserPotion> PotionUsers { get; set; }

    }
}
