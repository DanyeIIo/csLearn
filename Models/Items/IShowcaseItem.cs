using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Items
{
    interface IShowcaseItem : IShowcaseItem
    {
        int Cost { get; set; }
    }
}
