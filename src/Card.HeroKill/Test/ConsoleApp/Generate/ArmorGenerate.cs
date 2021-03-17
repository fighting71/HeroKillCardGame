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
    /// @since : 3/17/2021 2:13:29 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class ArmorGenerate
    {
        public static void Run()
        {

            string[] files = Directory.GetFiles(@"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\ArmorModule");

            foreach (var file in files)
            {
                if (file.Contains("ArmorCardInfo")) continue;
                File.Delete(file);
            }

            foreach (ArmorType item in Enum.GetValues<ArmorType>())
            {
                var code = Template.Replace("{name}", item.ToString());

                File.WriteAllText(@$"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\ArmorModule\{item}Armor.cs", code);

            }
        }

        private const string Template = @"using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.ArmorModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : ArmorGenerate
    /// @des : 
    /// </summary>
    public class {name}Armor : ArmorCardInfo
    {
        public {name}Armor(byte num = default, FlowerColor color = default, string style = default) : base(num, color, ArmorType.{name}, style)
        {
        }
    }
}
";
    }
}
