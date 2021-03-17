using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.SupplyModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : SupplyGenerate
    /// @des : 
    /// </summary>
    public class RecoverAllSupply : SupplyCardInfo
    {
        public RecoverAllSupply(byte num = default, FlowerColor color = default, string style = default) : base(num, color, SupplyType.RecoverAll, style)
        {
        }
    }
}
