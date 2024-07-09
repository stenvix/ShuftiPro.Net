using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace ShuftiPro.Converters
{
    public class ShuftiProSafeStringEnumConverter<TEnum> : StringEnumConverter where TEnum : struct, Enum
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch
            {
                return default(TEnum);
            }
        }
    }
}
