using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using Card.HeroKill.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.SupplyModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 11:52:54 AM
    /// @source : 
    /// @des : 
    /// </summary>
    public class SupplyCardInfo : CardInfo
    {
        public SupplyCardInfo(byte num, FlowerColor color, SupplyType subType, string style) : base(num, color, CardType.Supply, (byte)subType, style)
        {
        }
    }
}
