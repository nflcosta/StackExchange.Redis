
using System;

namespace StackExchange.Redis
{
    public static class VersionExtensions
    {
        public static bool TryParse(string input, out Version result)
        {
#if NET35
            result = default(Version);
            try
            {
                var version = new Version(input);

                result = version;
            }
            catch
            {
                return false;
            }

            return true;

#else
            return VersionExtensions.TryParse(input, out result);
#endif
        }
    }

}