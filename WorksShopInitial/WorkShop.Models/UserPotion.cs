using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Models
{
    public class UserPotion
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int PotionId { get; set; }
        public Potion Potion { get; set; }
    }
}
