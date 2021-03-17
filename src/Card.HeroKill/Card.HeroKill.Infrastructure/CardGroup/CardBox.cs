using Card.HeroKill.Core.Menu;
using Card.HeroKill.Data.Model;
using Card.HeroKill.Infrastructure.ArmorModule;
using Card.HeroKill.Infrastructure.BasicModule;
using Card.HeroKill.Infrastructure.SupplyModule;
using Card.HeroKill.Infrastructure.WeaponModule;
using System;
using System.Collections.Generic;

namespace Card.HeroKill.Infrastructure.CardGroup
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 10:14:59 AM
    /// @source : 
    /// @des : 
    /// </summary>
    public class CardBox
    {

        private List<CardInfo> _freeList { get; set; }
        private List<CardInfo> _usedList { get; set; }

        private Random _random;

        private void Init()
        {
            _freeList = new List<CardInfo>();
            _usedList = new List<CardInfo>();

            CardInfo[] arr;
            FlowerColor color;

            #region Diamond
            color = FlowerColor.Diamond;

            arr = new CardInfo[] {
                new KillAllSupply(),
                new EludeCard(),
                new SugarCard(),
                new GivenAllSupply(),
                new DefenseHorseCard(),
                new FreezeSupply(),
                new MoreSupply(),
                new MoreSupply(),
                new SugarCard(),
                new KillCard(),
                new MoreSupply(),
                new PullDownSupply(),
                new EludeCard(),
            };

            Add();

            arr = new CardInfo[] {
                new RecoverAllSupply(),
                new EludeCard(),
                new GivenAllSupply(),
                new SugarCard(),
                new BaWangGongWeapon(),
                new SugarCard(),
                new SugarCard(),
                new SugarCard(),
                new MoreSupply(),
                new KillCard(),
                new KillCard(),
                new BombSupply(),
            };

            Add();
            #endregion

            #region Heart
            color = FlowerColor.Heart;
            arr = new CardInfo[] {
                new DuelSupply(),
                new EludeCard(),
                new EludeCard(),
                new TakeSupply(),
                new PoLangChuiWeapon(),
                new EludeCard(),
                new EludeCard(),
                new KillCard(),
                new EludeCard(),
                new KillCard(),
                new EludeCard(),
                new LangYaBangWeapon(),
                new AttackTheHorseCard(),
            };

            Add();

            arr = new CardInfo[] {
                new HuFuWeapon(),
                new EludeCard(),
                new TakeSupply(),
                new EludeCard(),
                new EludeCard(),
                new KillCard(),
                new KillCard(),
                new EludeCard(),
                new KillCard(),
                new EludeCard(),
                new EludeCard(),
                new DisableSupply(),
                new KillCard(),
            };

            Add();
            #endregion

            #region Club
            color = FlowerColor.Club;
            arr = new CardInfo[] {
                new BombSupply(),
                new YuRuYiArmor(),
                new TakeSupply(),
                new PullDownSupply(),
                new DefenseHorseCard(),
                new YuchangJianWeapon(),
                new SummonWolvesSupply(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new DisableSupply(),
                new LuYeQiangWeapon(),
                new SummonWolvesSupply(),
            };

            Add();

            arr = new CardInfo[] {
                new DuelSupply(),
                new LongLingDaoWeapon(),
                new PullDownSupply(),
                new TakeSupply(),
                new PanLongGuenWeapon(),
                new FreezeSupply(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new TakeSupply(),
                new DuelSupply(),
                new AttackTheHorseCard(),
            };

            Add();
            #endregion

            #region Spade
            color = FlowerColor.Spade;
            arr = new CardInfo[] {
                new HuFuWeapon(),
                new KillCard(),
                new PullDownSupply(),
                new PullDownSupply(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new DisableSupply(),
                new ColldinedOnringSupply(),
            };

            Add();

            arr = new CardInfo[] {
                new DuelSupply(),
                new YuRuYiArmor(),
                new KillCard(),
                new KillCard(),
                new DefenseHorseCard(),
                new FreezeSupply(),
                new SummonWolvesSupply(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new KillCard(),
                new ColldinedOnringSupply(),
                new DisableSupply(),
            };

            Add();
            #endregion

            #region reply
            _freeList.Add(new AttackTheHorseCard(5, FlowerColor.Diamond));
            _freeList.Add(new SugarCard(12, FlowerColor.Diamond));
            _freeList.Add(new SugarCard(12, FlowerColor.Heart));
            #endregion

            void Add()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    var item = arr[i];
                    item.Num = (byte)(i + 1);
                    item.Color = color;
                    _freeList.Add(item);
                }

            }

        }

        public CardBox()
        {
            Init();
            _random = new Random();
        }

        public CardInfo TakeOne()
        {
            if (_freeList.Count == 0)
            {
                if (_freeList.Count == 0) return null;
                _freeList.AddRange(_usedList);
                _usedList.Clear();
            }
            var rand = _random.Next(_freeList.Count);
            var card = _freeList[rand];
            _freeList.RemoveAt(rand);
            return card;
        }

        /// <summary>
        /// 回收
        /// </summary>
        /// <param name="card"></param>
        public void Recycle(CardInfo card)
        {
            _usedList.Add(card);
        }

    }
}
