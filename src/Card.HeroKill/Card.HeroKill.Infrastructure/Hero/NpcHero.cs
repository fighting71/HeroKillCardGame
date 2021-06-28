using Card.HeroKill.Core.Menu;
using Card.HeroKill.Infrastructure.CardGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card.HeroKill.Infrastructure.Hero
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/18/2021 10:48:38 AM
    /// @source : 
    /// @des : 
    /// </summary>
    public class NpcHero : Gamer
    {
        public NpcHero(CardBox box, int health, string name, int camp) : base(box, health, name, camp)
        {
        }

        public override void Run(GroupCore group)
        {
            var cards = this.Cards;

            Dictionary<CardType, Data.Model.CardInfo[]> dic = cards.GroupBy(u => u.Type).ToDictionary(u => u.Key, u => u.ToArray());

            if (this.ArmorCardInfo == null && dic.ContainsKey(CardType.Armor))
            {
                Data.Model.CardInfo cardInfo = dic[CardType.Armor].First();

                this.ChoiceCards.Add(cardInfo);

            }

            if (dic.ContainsKey(CardType.Supply))
            {

            }

        }
    }
}
