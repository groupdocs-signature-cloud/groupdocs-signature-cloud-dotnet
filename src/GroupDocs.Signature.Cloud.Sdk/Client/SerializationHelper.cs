// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SerializationHelper.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Signature.Cloud.Sdk.Client
{
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                           ? JsonConvert.SerializeObject(
                               obj,
                               new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
                           : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject(json, type);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }

                return null;
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jse)
            {
                throw new ApiException(500, jse.Message);
            }
            catch (System.Xml.XmlException xmle)
            {
                throw new ApiException(500, xmle.Message);
            }
        }

        internal abstract class JsonCreationConverter<T> : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return typeof(T).IsAssignableFrom(objectType);
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                var jsonObject = JObject.Load(reader);
                T target = this.Create(objectType, jsonObject);
                serializer.Populate(jsonObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            /// <summary>
            /// Create an instance of objectType, based properties in the JSON object.
            /// </summary>
            /// <param name="objectType">type of object expected.</param>
            /// <param name="jsonObject">
            /// Contents of JSON object that will be deserialized.
            /// </param>
            /// <returns>An instance of objectType.</returns>
            protected abstract T Create(Type objectType, JObject jsonObject);
        }
    }
}