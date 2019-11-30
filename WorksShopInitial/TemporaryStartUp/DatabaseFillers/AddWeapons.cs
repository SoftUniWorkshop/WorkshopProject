namespace TemporaryStartUp.DatabaseFillers
{
    using System;
    using System.Collections.Generic;
    using WorkShop.Data;
    using WorkShop.Models;

    public class AddWeapons
    {
        private Dictionary<string, int> Weapons = new Dictionary<string, int>()
        {
            { "Dagger", 100},
            { "Iron Sword", 150},
            { "Flail", 200},
            { "Spear", 250},
            { "Poleaxe", 300}
        };

        public void CreateWeapons(WorkShopContext context)
        {
            foreach (var Weapon in Weapons)
            {
                var weapon = new Weapon()
                {
                    Name = Weapon.Key,
                    Damage = Weapon.Value,
                    Durability = 3,
                };

                context.Weapons.Add(weapon);
                context.SaveChanges();

                Console.WriteLine($"Succesfully added weapon {weapon.Name}");
            }
        }
    }
}
