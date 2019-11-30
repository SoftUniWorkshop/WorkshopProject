
using TemporaryStartUp.DatabaseFillers;

namespace TemporaryStartUp
{
   
    public class Startup
    {
        static void Main(string[] args)
        {

            using var context = new WorkShop.Data.WorkShopContext();

            context.Database.EnsureCreated();

            var armors = new AddArmors();
            armors.CreateArmors(context);

            var weapons = new AddWeapons();
            weapons.CreateWeapons(context);

            var users = new AddUsers();
            users.CreateUsers(context);
        }
    }
}
