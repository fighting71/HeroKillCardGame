using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using Card.HeroKill.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.ArmorModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 2:04:42 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class ArmorCardInfo : CardInfo
    {
        public ArmorCardInfo(byte num, FlowerColor color, ArmorType subType, string style) : base(num, color, CardType.Armor, (byte)subType, style)
        {
        }
    }
}
