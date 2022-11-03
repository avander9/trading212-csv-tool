using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trading212Tools.Extensions
{
    public static class StringExtension
    {
        public static string Sanitize(this string value)
        {
            return Regex.Replace(value, @"[^\w\d]", "").Trim();
        }
    }
}
