using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Result : IResult
    {
        public bool Check { get; set; }
        public string Message { get; set; }
        public Result(bool check = true) => Check = check; // ctor
        public Result(string message) => Message = message;// ctor
    }
}
