
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackExchange.Redis
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(string value)
        {
#if NET35
            if (value == null) return true;
            return string.IsNullOrEmpty(value.Trim());
#else
            return string.IsNullOrWhiteSpace(value);
#endif


        }
    }
}
