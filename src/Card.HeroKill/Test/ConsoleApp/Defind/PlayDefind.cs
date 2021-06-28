using Card.HeroKill.Core.Menu;
using Card.HeroKill.Data.Model;
using Card.HeroKill.Infrastructure.CardGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Defind
{
    /// <summary>
    /// @auth : monster
    /// @since : 6/28/2021 11:07:25 AM
    /// @source : 
    /// @des : 
    /// </summary>
    public abstract class PlayDefind
    {

        public void Run()
        {

            while (true)
            {

                Choice choice = GetBestChoice();

                if (choice == null) return;

                Use(choice.Card);

            }

        }

        public abstract bool HaveChoice();

        public abstract Choice GetBestChoice();

        public abstract bool Use(CardInfo card);

    }

    public class Choice
    {
        public CardInfo Card { get; set; }
        public Gamer Target { get; set; }
    }

}
