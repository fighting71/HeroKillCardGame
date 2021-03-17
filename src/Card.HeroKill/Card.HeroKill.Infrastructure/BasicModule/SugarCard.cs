using Card.HeroKill.Core.Menu;
using Card.HeroKill.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.BasicModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : BasicGenerate
    /// @des : 
    /// </summary>
    public class SugarCard : CardInfo
    {
        public SugarCard(byte num = default, FlowerColor color = default, string style = default) : base(num, color, CardType.Sugar, style)
        {
        }
    }
}
