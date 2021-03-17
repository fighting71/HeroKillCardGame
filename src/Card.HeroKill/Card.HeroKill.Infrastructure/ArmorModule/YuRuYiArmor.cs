using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.ArmorModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : ArmorGenerate
    /// @des : 
    /// </summary>
    public class YuRuYiArmor : ArmorCardInfo
    {
        public YuRuYiArmor(byte num = default, FlowerColor color = default, string style = default) : base(num, color, ArmorType.YuRuYi, style)
        {
        }
    }
}
