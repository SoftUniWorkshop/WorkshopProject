
namespace TemporaryStartUp
{
   
    public class Startup
    {
        static void Main(string[] args)
        {

            using var context = new WorkShop.Data.WorkShopContext();

            context.Database.EnsureCreated();
           
        }
    }
}
