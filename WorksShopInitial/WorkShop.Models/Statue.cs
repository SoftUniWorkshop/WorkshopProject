namespace WorkShop.Models
{
    using Enums;
    using System.Collections.Generic;

    public class Statue
    {
        public Statue()
        {
            this.StatueUsers = new HashSet<UserStatue>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public StatueStatusIncrese StatusIncrease { get; set; }

        public int Amount { get; set; }

        public ICollection<UserStatue> StatueUsers { get; set; }
    }
}
