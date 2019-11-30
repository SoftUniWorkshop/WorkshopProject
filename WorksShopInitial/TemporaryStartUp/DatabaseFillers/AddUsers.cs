namespace TemporaryStartUp.DatabaseFillers
{
    using System;
    using System.Collections.Generic;
    using WorkShop.Data;
    using WorkShop.Models;

    public class AddUsers
    {
        private List<string> Names = new List<string>() { "Pesho", "Ivan", "Sasho", "Kaloyan", "Dimitur"};

        public void CreateUsers(WorkShopContext context)
        {
            foreach (var Name in Names)
            {
                var user = new User
                {
                    Name = Name,
                    Health = 100,
                    Gold = new Random().Next(100, 201),
                };

                context.Users.Add(user);
                context.SaveChanges();

                Console.WriteLine($"Succesfully added user {user.Name}");
            }
        }
    }
}
