using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Items
{
    public interface IShowcaseItem
    {
        int Identifier { get; set; }
        string Name { get; set; }
        int Volume { get; set; }
    }
}
