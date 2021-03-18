using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using Card.HeroKill.Infrastructure.CardGroup;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Use(Gamer gamer)
        {

            if (gamer.ArmorCardInfo != null)
            {
                gamer.Box.Recycle(gamer.ArmorCardInfo);
            }

            gamer.ArmorCardInfo = this;

            gamer.Cards.Remove(gamer.ChoiceCards.First());
            gamer.ChoiceCards.Clear();

        }

    }
}
