namespace WorkShop.Models
{
    public class Weapon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Duratbility { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
