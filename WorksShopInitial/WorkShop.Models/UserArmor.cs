using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Models
{
    public class UserArmor
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ArmorId { get; set; }
        public Armor Armor { get; set; }
    }
}
