using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IResult
    {
        bool Check { get; set; }
        string Message { get; set; }
    }
}
