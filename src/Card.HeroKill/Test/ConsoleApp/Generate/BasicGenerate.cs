using Card.HeroKill.Core.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Generate
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 2:27:16 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class BasicGenerate
    {
        public static void Run()
        {

            string[] files = Directory.GetFiles(@"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\BasicModule");

            foreach (var file in files)
            {
                File.Delete(file);
            }

            foreach (CardType item in new CardType[] { CardType.Kill, CardType.Elude, CardType.AttackTheHorse, CardType.DefenseHorse, CardType.Sugar })
            {
                var code = Template.Replace("{name}", item.ToString());

                File.WriteAllText(@$"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\BasicModule\{item}Card.cs", code);

            }
        }

        private const string Template = @"using Card.HeroKill.Core.Menu;
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
    public class {name}Card : CardInfo
    {
        public {name}Card(byte num = default, FlowerColor color = default, string style = default) : base(num, color, CardType.{name}, style)
        {
        }
    }
}
";
    }
}
