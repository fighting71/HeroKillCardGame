using Card.HeroKill.Core.Extension;
using Card.HeroKill.Core.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card.HeroKill.Data.Model
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/16/2021 5:30:07 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public class CardInfo
    {

        public CardInfo() { }

        public CardInfo(byte num, FlowerColor color, CardType type, string style)
        {
            Num = num;
            Color = color;
            Type = type;
            SetStyle(style);
        }

        public CardInfo(byte num, FlowerColor color, CardType type, byte subType, string style)
        {
            Num = num;
            Color = color;
            Type = type;
            SubType = subType;
            SetStyle(style);
        }

        /// <summary>
        /// 点数
        /// </summary>
        public byte Num { get; set; }

        public FlowerColor Color { get; set; }

        public CardType Type { get;}

        public byte SubType { get; }

        public string Style { get; set; }


        private void SetStyle(string style)
        {
            if(style.IsEmpty())
            {
                this.Style = GetType().Name;
            }
            else
            {
                this.Style = style;
            }
        }

    }
}
