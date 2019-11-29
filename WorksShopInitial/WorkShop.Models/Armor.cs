namespace WorkShop.Models
{
    public class Armor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Defence { get; set; }

        public int Durability { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
