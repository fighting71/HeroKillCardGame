using Card.HeroKill.Core.Menu.Sub;
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
    /// @since : 3/17/2021 12:07:19 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class SupplyGenerate
    {

        public static void Run()
    {
            string[] files = Directory.GetFiles(@"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\SupplyModule");

            foreach (var file in files)
            {
                if (file.Contains("SupplyCardInfo")) continue;
                File.Delete(file);
            }

            foreach (SupplyType item in Enum.GetValues<SupplyType>())
            {
                var code = Template.Replace("{name}", item.ToString());

                File.WriteAllText(@$"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\SupplyModule\{item}Supply.cs", code);

            }
        }

        private const string Template = @"using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.SupplyModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : SupplyGenerate
    /// @des : 
    /// </summary>
    public class {name}Supply : SupplyCardInfo
    {
        public {name}Supply(byte num = default, FlowerColor color = default, string style = default) : base(num, color, SupplyType.{name}, style)
        {
        }
    }
}
";

    }
}
