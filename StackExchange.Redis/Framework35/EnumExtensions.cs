#if NET35
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace StackExchange.Redis
{
    public static class Enum
    {
        public static Array GetValues(Type enumerationType)
        {
            if (!enumerationType.IsEnum)
                throw new Exception("GetEnumValues(enumerationType)" + enumerationType);

            object valAux = Activator.CreateInstance(enumerationType);
            FieldInfo[] fieldInfoArray = enumerationType.GetFields(BindingFlags.Static | BindingFlags.Public);

            Array res = Array.CreateInstance(enumerationType, fieldInfoArray.Length);
            for (int i = 0; i < res.Length; i++)
                res.SetValue(fieldInfoArray[i].GetValue(valAux), i);
            return res;
        }

        public static bool TryParse<TEnum>(string value, out TEnum result)
            where TEnum : struct
        {
            result = default(TEnum);
            try
            {
                result = (TEnum)System.Enum.Parse(typeof(TEnum), value);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
        {
            result = default(TEnum);
            try
            {
                result = (TEnum)System.Enum.Parse(typeof(TEnum), value, ignoreCase);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
#endif