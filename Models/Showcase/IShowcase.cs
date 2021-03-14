using Models.Items;
using System;
using System.Collections.Generic;

namespace Models.Showcase
{
    public interface IShowcase
    {
        int Identifier { get; set; }
        int Volume { get; set; }
        string Name { get; set; }
        List<IItem> Items { get;}
        DateTime CreatedAt { get; }
        DateTime RemovedAt { get; }
    }

}
