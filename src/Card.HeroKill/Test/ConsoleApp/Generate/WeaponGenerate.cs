using Card.HeroKill.Core.CusAttr;
using Card.HeroKill.Core.Menu.Sub;
using Card.HeroKill.Core.Extension;
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
    /// @since : 3/17/2021 12:14:29 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class WeaponGenerate
    {
        public static void Run()
        {

            string[] files = Directory.GetFiles(@"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\WeaponModule");

            foreach (var file in files)
            {
                if (file.Contains("WeaponCardInfo")) continue;
                File.Delete(file);
            }

            foreach (WeaponType item in Enum.GetValues<WeaponType>())
            {
                DistanceAttribute distanceAttribute = item.GetAttribute<DistanceAttribute>();
                var code = Template.Replace("{name}", item.ToString()).Replace("{distance}", distanceAttribute.Distance.ToString());

                File.WriteAllText(@$"F:\Davis\Github\HeroKillCardGame\src\Card.HeroKill\Card.HeroKill.Infrastructure\WeaponModule\{item}Weapon.cs", code);

            }
        }

        private const string Template = @"using Card.HeroKill.Core.Menu;
using Card.HeroKill.Core.Menu.Sub;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Infrastructure.WeaponModule
{
    /// <summary>
    /// @auth : monster
    /// @since : 
    /// @source : WeaponGenerate
    /// @des : 
    /// </summary>
    public class {name}Weapon : WeaponCardInfo
    {
        public {name}Weapon(byte num = default, FlowerColor color = default, string style = default) : base({distance}, num, color, WeaponType.{name}, style)
        {
        }
    }
}
";
    }
}
