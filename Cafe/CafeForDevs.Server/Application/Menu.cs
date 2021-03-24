using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CafeForDevs.Server.Application
{
    internal static class Menu
    {
        static Menu()
        {
            Items = new[]
            {
                new MenuItem
                {
                    Id = 1,
                    Name = "Breakfast",
                    Price = 1000
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Lanch",
                    Price = 500
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Dinner",
                    Price = 100
                }
            };
        }

        internal static MenuItem[] Items { get; private set; }
        internal static MenuItem Get(int menuItemId)
        {
            return Items.SingleOrDefault(x => x.Id.Equals(menuItemId));
        }
    }
}
