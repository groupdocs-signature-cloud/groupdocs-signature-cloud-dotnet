using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace GroupDocs.Signature.Cloud.Sdk
{
    internal abstract class JsonCreationConverter<T> : JsonConverter
    {
        public override bool CanWrite => false;

        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            T target = this.Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        protected bool HasProperty(JObject jObject, params string[] values)
        {
            var result = false;
            foreach (var value in values)
            {
                if (!string.IsNullOrEmpty(jObject[value]?.ToString()))
                {
                    result = true;
                    break;
                }
                if (!string.IsNullOrEmpty(jObject[value.ToLower()]?.ToString()))
                {
                    result = true;
                    break;
                }
                var temp = char.ToLower(value[0]) + value.Substring(1);
                if (!string.IsNullOrEmpty(jObject[temp]?.ToString()))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        protected bool HasProperty(JToken item, params string[] values)
        {
            var result = false;
            foreach (var value in values)
            {
                if (!string.IsNullOrEmpty(item[value]?.ToString()))
                {
                    result = true;
                    break;
                }
                if (!string.IsNullOrEmpty(item[value.ToLower()]?.ToString()))
                {
                    result = true;
                    break;
                }
                var temp = char.ToLower(value[0]) + value.Substring(1);
                if (!string.IsNullOrEmpty(item[temp]?.ToString()))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        //protected SignatureType GetSignatureType(JObject jObject)
        //{
        //    SignatureType result = SignatureType.None;
        //    string type = jObject["SignatureType"]?.ToString();
        //    if (String.IsNullOrEmpty(type))
        //    {
        //        type = jObject["signatureType"]?.ToString();
        //    }
        //    if (!string.IsNullOrEmpty(type))
        //    {
        //        if (!Enum.TryParse<SignatureType>(type, out result))
        //        {
        //            result = SignatureType.None;
        //        }
        //    }
        //    return result;
        //}

        protected void VerifyRequest(JObject jObject)
        {
            if (jObject == null)
            {
                throw new ArgumentNullException(nameof(jObject));
            }

            var fileInfo = jObject.SelectToken("FileInfo");
            if (fileInfo == null)
            {
                throw new ArgumentNullException(nameof(fileInfo));
            }
            var requiredAttr = "FilePath";
            if (!HasProperty(fileInfo, requiredAttr))
            {
                throw new ArgumentNullException(requiredAttr);
            }
        }
    }
}
