using Card.HeroKill.Core.CusAttr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Core.Menu.Sub
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 12:18:13 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public enum WeaponType : byte
    {
        [Distance(5)]
        BaWangGong,
        [Distance(1)]
        HuFu,
        [Distance(2)]
        LongLingDao,
        [Distance(3)]
        LangYaBang,
        [Distance(3)]
        LuYeQiang,
        [Distance(3)]
        PoLangChui,
        [Distance(3)]
        PanLongGuen,
        [Distance(2)]
        YuchangJian,
    }
}
