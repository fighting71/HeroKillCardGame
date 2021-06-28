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
    public class AttackTheHorseCard : CardInfo
    {
        public AttackTheHorseCard(byte num = default, FlowerColor color = default, string style = default) : base(num, color, CardType.AttackTheHorse, style)
        {
        }

        public void Use(Gamer gamer)
        {

            if (gamer.AttackTheHorseCard != null)
            {
                gamer.Box.Recycle(gamer.AttackTheHorseCard);
            }

            gamer.AttackTheHorseCard = this;

            gamer.Cards.Remove(gamer.ChoiceCards.First());

        }

    }
}
