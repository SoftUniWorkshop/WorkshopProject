namespace TemporaryStartUp.DatabaseFillers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WorkShop.Data;
    using WorkShop.Models;

    public class AddArmors
    {
        private Dictionary<string, int> Armors = new Dictionary<string, int>()
        { 
            { "Bronze Plate", 100},
            { "Gold Plate", 150},
            { "Iron Plate", 200},
            { "Chainmail Plate", 250},
            { "Titanium Plate", 300}
        };

        public void CreateArmors(WorkShopContext context)
        {
            foreach (var Armor in Armors)
            {
                var armor = new Armor()
                {
                    Name = Armor.Key,
                    Defence = Armor.Value,
                    Durability = 3
                };

                context.Armors.Add(armor);
                context.SaveChanges();

                Console.WriteLine($"Succesfully added armor {armor.Name}");
            }
        }
    }
}
