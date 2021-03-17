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
    public class LongLingDaoWeapon : WeaponCardInfo
    {
        public LongLingDaoWeapon(byte num = default, FlowerColor color = default, string style = default) : base(2, num, color, WeaponType.LongLingDao, style)
        {
        }
    }
}
