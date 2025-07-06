using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            var attribute = field?.GetCustomAttribute<DisplayAttribute>();

            return attribute?.Name ?? enumValue.ToString();
        }

        public static TEnum GetEnumValueFromDisplayName<TEnum>(this string displayName) where TEnum : struct, Enum
        {
            foreach (var field in typeof(TEnum).GetFields())
            {
                var displayAttr = Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) as DisplayAttribute;
                if (displayAttr != null && displayAttr.Name == displayName)
                    return (TEnum)field.GetValue(null)!;

                if (field.Name == displayName)
                    return (TEnum)field.GetValue(null)!;
            }

            throw new ArgumentException($"'{displayName}' is not a valid display name for {typeof(TEnum)}");
        }
    }
}
