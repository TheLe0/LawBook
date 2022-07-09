using System;
using System.Collections.Generic;
using System.Text;

namespace LawBook.Extension
{
    internal static class StringExtended
    {
        public static bool IsNumeric(this string str)
        {
            if (str == string.Empty)
            {
                return false;
            }

            return str.All(c => c >= '0' && c <= '9');
        }
    }
}
