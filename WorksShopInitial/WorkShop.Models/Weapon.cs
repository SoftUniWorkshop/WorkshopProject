using System.Collections.Generic;

namespace WorkShop.Models
{
    public class Weapon
    {
        public Weapon()
        {
            this.WeaponUsers = new HashSet<UserWeapon>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Duratbility { get; set; }

        public ICollection<UserWeapon> WeaponUsers { get; set; }
    }
}
