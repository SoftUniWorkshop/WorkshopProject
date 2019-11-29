namespace WorkShop.Models
{
    public class Potion
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Price { get; set; }

        public int HealthRestore { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
