using Card.HeroKill.Infrastructure.CardGroup;
using ConsoleApp.Generate;
using Newtonsoft.Json;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region generate
            //{
            //    SupplyGenerate.Run();
            //    WeaponGenerate.Run();
            //    ArmorGenerate.Run();
            //    BasicGenerate.Run();
            //}
            #endregion

            CardBox box = new CardBox();

            //while (true)
            //{
            //    var card = box.TakeOne();
            //    if (card == null) break;
            //    Console.WriteLine(JsonConvert.SerializeObject(card));
            //}

            Gamer game = new Gamer(box, 4, "Alice", 1);
            Gamer npc = new Gamer(box, 3, "Npc", 2);

            GroupCore core = new GroupCore(game, npc);

            core.Start();

            Console.WriteLine("Hello World!");

            Console.ReadKey(true);

        }
    }
}
