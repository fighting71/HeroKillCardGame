using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Core.Menu.Sub
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 10:02:58 AM
    /// @source : 
    /// @des : 
    /// </summary>
    public enum SupplyType : byte
    {

        More  = 0,
        Take = 1,
        PullDown = 2,
        ColldinedOnring = 3,
        Disable = 4,
        Bomb = 5,
        Freeze = 6,
        KillAll = 7,
        SummonWolves = 8,
        RecoverAll = 9,
        Duel = 10,
        GivenAll = 11

    }
}
