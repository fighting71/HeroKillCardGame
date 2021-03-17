using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Card.HeroKill.Core.Extension
{
    /// <summary>
    /// @auth : monster
    /// @since : 3/17/2021 12:28:41 PM
    /// @source : 
    /// @des : 
    /// </summary>
    public static class EnumExt
    {
        public static T GetAttribute<T>(this Enum enumObj) where T : Attribute
        {
            var fieldInfo = enumObj.GetType().GetField(enumObj.ToString());
            if (fieldInfo?.IsDefined(typeof(T), true) ?? false)
            {
                return (fieldInfo.GetCustomAttribute(typeof(T), true) as T);
            }
            return default;
        }
    }
}
