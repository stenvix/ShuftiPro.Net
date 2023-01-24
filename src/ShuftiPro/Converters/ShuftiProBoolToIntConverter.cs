using System;
using Newtonsoft.Json;

namespace ShuftiPro.Converters
{
    internal class ShuftiProBoolToIntConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null && value is bool isChecked)
            {
                writer.WriteValue(isChecked ? "1" : "0");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value != null)
            {
                return reader.Value.ToString() == "1";
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool) || objectType == typeof(bool?);
        }
    }
}
