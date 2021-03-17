using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Core.CusAttr
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 12:23:47 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class DistanceAttribute : Attribute
    {
        public DistanceAttribute(int distance)
        {
            Distance = distance;
        }

        public int Distance { get; set; }
    }
}
