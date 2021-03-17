using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Core.Extension
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 2:20:40 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public static class StringExt
    {

        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

    }
}
