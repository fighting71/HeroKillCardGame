using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.WeaponModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : WeaponGenerate
    /// @des : 
    /// </summary>
    public class HuFuWeapon : WeaponCardInfo
    {
        public HuFuWeapon(byte num = default, FlowerColor color = default, string style = default) : base(1, num, color, WeaponType.HuFu, style)
        {
        }
    }
}
