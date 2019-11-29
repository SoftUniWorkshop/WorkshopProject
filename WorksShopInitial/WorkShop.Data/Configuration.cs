using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Data
{
    internal class Configuration
    {
        internal static string ConnectionString
            => $"Server={Console.ReadLine()};Database=Gladiators;Integrated Securuty=true";
    }
}
