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
    public class DefenseHorseCard : CardInfo
    {
        public DefenseHorseCard(byte num = default, FlowerColor color = default, string style = default) : base(num, color, CardType.DefenseHorse, style)
        {
        }

        public void Use(Gamer gamer)
        {

            if (gamer.DefenseHorseCard != null)
            {
                gamer.Box.Recycle(gamer.DefenseHorseCard);
            }

            gamer.DefenseHorseCard = this;

            gamer.Cards.RemoveAt(gamer.ChoiceCards.First());

        }
    }
}
