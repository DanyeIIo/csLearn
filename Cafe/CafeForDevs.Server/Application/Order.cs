using System;
using System.Collections.Generic;

namespace CafeForDevs.Server.Application
{
    internal class Order
    {
        private List<OrderPosition> _positions;

        internal void AddPosition(MenuItem menuItem, int quantity)
        {
            var position = new OrderPosition
            {
                Name = menuItem.Name,
                Price = menuItem.Price,
                Quantity = quantity
            };
            _positions.Add(position);
        }
        internal OrderPosition[] Positions { get => _positions.ToArray(); }
    }
}
