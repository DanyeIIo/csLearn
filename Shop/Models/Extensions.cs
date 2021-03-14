using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that query if '@this'.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static bool IsSpace(this string @this)
        {
            return @this.Contains("");
            //maybe change realisation!
        }
    }

}
