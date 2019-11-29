using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Models
{
   public class UserWeapon
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
