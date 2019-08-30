using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ChartJs.Blazor.ChartJS.Common
{
    internal class IndexableOptionConverter : JsonConverter
    {
        public override bool CanRead => false;
        public override bool CanWrite => true;

        public override bool CanConvert(Type objectType)
        {
            if (!objectType.IsGenericType) return false;

            return objectType.GetGenericTypeDefinition() == typeof(IndexableOption<>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // this doesn't work because it will apparently use the converter also in here resulting in an endless loop -> StackOverflowException
            // JObject o = JObject.FromObject(value, serializer);
            // JProperty prop = o.Property(IndexableOption<object>.PropertyName);
            // prop.Value.WriteTo(writer);

            // get the value using reflection and write it to the writer
            object toWrite = value.GetType().GetProperty(IndexableOption<object>.PropertyName, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(value);
            JToken.FromObject(toWrite).WriteTo(writer);
        }
    }
}
