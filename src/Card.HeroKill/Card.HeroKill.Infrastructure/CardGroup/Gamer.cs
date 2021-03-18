using Card.HeroKill.Data.Model;
using Card.HeroKill.Infrastructure.ArmorModule;
using Card.HeroKill.Infrastructure.BasicModule;
using Card.HeroKill.Infrastructure.WeaponModule;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card.HeroKill.Infrastructure.CardGroup
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 3:26:13 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class Gamer
    {
        public CardBox Box { get; set; }

        public List<CardInfo> Cards { get; set; }

        public WeaponCardInfo WeaponCardInfo { get; set; }

        public AttackTheHorseCard AttackTheHorseCard { get; set; }

        public DefenseHorseCard DefenseHorseCard { get; set; }

        public ArmorCardInfo ArmorCardInfo { get; set; }

        public int Health { get; set; }

        public string Name { get; }
        public int Camp { get; }
        public int MaxHealth { get; }

        public ISet<CardInfo> ChoiceCards { get; set; }

        public Gamer(CardBox box, int health, string name, int camp)
        {
            this.Health = health;
            MaxHealth = health;
            Name = name;
            Camp = camp;
            this.Box = box;
            Cards = new List<CardInfo>();
        }

        public void Take(int len)
        {
            for (int i = 0; i < len; i++)
            {
                CardInfo card = Box.TakeOne();
                if (card == null) break;
                Cards.Add(card);
            }
        }

        public virtual void Run(GroupCore group)
        {

            Console.WriteLine("curr game : " + this.Name);

            Console.WriteLine("cards:");

            foreach (var item in Cards)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }

            Console.WriteLine("other gamer:");

            var len = group.Gamers.Length;
            for (int i = 1; i < len; i++)
            {
                var game = group.Gamers[(group.CurrIndex + i) % len];
                Console.WriteLine($@"
    {game.Name}
    isFriend:{game.Camp == this.Camp}
    health:{game.Health}
    isAlive:{game.Health > 0}
    cardLen:{game.Cards.Count}
");
            }

            while (true)
            {

            }

            Console.ReadKey();

        }

        public void Discard()
        {
            var maxHave = this.Health;

            if (Cards.Count < maxHave) return;

            Console.WriteLine("discard stage>>>>>>>>>");

            Console.WriteLine("cards:");

            foreach (var item in Cards)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }

            var need = Cards.Count - maxHave;
            while (true)
            {

                Console.WriteLine($"you need discard len: {need} ");

                string discards = Console.ReadLine();

                HashSet<int> hashSet = discards.Split(" ").Where(u => int.TryParse(u, out _)).Select(u => int.Parse(u)).Where(u => u >= 0 && u < Cards.Count).ToHashSet();

                if (hashSet.Count == need)
                {
                    foreach (var item in hashSet.OrderByDescending(u => u))
                    {
                        var card = Cards[item];
                        Box.Recycle(card);
                        Cards.RemoveAt(item);
                    }
                    break;
                }
            }


        }

    }
}
