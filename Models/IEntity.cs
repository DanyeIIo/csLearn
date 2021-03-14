using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Showcase
{
    public interface IEntity
    {
        IResult Validate();
    }
}
