using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class StringExtension
    {
        public static string ChangeChars(this string word)
        {
            return word.ToLower()
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ğ", "g")
                .Replace("ş", "s")
                .Replace("ç", "c")
                .Replace(" ", "");
        }
    }
}
