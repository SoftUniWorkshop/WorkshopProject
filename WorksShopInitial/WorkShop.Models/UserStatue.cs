namespace WorkShop.Models
{
    public class UserStatue
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int StatueId { get; set; }
        public Statue Statue { get; set; }
    }
}
