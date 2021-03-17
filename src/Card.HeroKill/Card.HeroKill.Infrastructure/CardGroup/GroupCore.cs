using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Card.HeroKill.Infrastructure.CardGroup
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 3:50:10 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class GroupCore
    {
        private Dictionary<int, int> _aliveDic = new Dictionary<int, int>();
        private Random _random = new Random();
        private int _aliveLen;

        public Gamer[] Gamers { get; }

        public int CurrIndex { get; set; }

        public GroupCore(params Gamer[] gamers)
        {

            Debug.Assert(gamers != null);
            Debug.Assert(gamers.Length > 1);

            this.Gamers = gamers;
        }

        public void Start()
        {
            foreach (var gamer in Gamers)
            {
                gamer.Take(4);
                if (_aliveDic.ContainsKey(gamer.Camp)) _aliveDic[gamer.Camp]++;
                else _aliveDic[gamer.Camp] = 1;
            }

            Debug.Assert(_aliveDic.Count > 1);

            _aliveLen = Gamers.Length;

            CurrIndex = _random.Next(_aliveLen);

            while (_aliveDic.Count > 1)
            {
                Gamer currGamer = Gamers[CurrIndex];
                if (currGamer.Health < 1)
                {
                    CurrIndex = (CurrIndex + 1) % Gamers.Length;
                    continue;
                }

                currGamer.Take(2);

                currGamer.Run(this);

                currGamer.Discard();

                CurrIndex = (CurrIndex + 1) % Gamers.Length;
            }

        }


    }
}
