using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace ShuftiPro.Converters
{
    public class ShuftiProSafeStringEnumConverter<TEnum> : StringEnumConverter where TEnum : struct, Enum
    {
        private readonly TEnum _defaultValue;

        public ShuftiProSafeStringEnumConverter()
        {
            _defaultValue = (TEnum)Enum.GetValues(typeof(TEnum)).GetValue(0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                string enumText = reader.Value.ToString();

                if (Enum.TryParse<TEnum>(enumText, out var result))
                {
                    return result;
                }
                else
                {
                    return _defaultValue;
                }
            }

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}
