using Card.HeroKill.Core.Menu;
using Card.HeroKill.Data.Model;
using Card.HeroKill.Infrastructure.CardGroup;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Use(Gamer gamer)
        {

            gamer.Health++;

            gamer.Cards.Remove(gamer.ChoiceCards.First());

        }
    }
}
