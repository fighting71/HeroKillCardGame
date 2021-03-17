using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using Card.HeroKill.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.WeaponModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 10:10:22 AM
    /// @source : 
    /// @des : 
    /// </summary>
    public class WeaponCardInfo : CardInfo
    {
        public WeaponCardInfo(int distance, byte num, FlowerColor color, WeaponType subType, string style) : base(num, color, CardType.Weapon, (byte)subType, style)
        {
            this.Distance = distance;
        }

        public int Distance { get; }
    }
}
