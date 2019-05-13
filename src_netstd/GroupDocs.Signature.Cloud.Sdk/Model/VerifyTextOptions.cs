// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="VerifyTextOptions.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Signature.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Signature.Cloud.Sdk.Model
{
    /// <summary>
    /// Keeps options to verify Text signature of document
    /// </summary>
    [DataContract]
    public partial class VerifyTextOptions : VerifyOptions
    {
        /// <summary>
        /// Get or set text match type verification. It is used only when Text property is set
        /// </summary>
        /// <value>Get or set text match type verification. It is used only when Text property is set</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchTypeEnum
        {
            
            /// <summary>
            /// Enum Exact for "Exact"
            /// </summary>
            [EnumMember(Value = "Exact")]
            Exact,
            
            /// <summary>
            /// Enum StartsWith for "StartsWith"
            /// </summary>
            [EnumMember(Value = "StartsWith")]
            StartsWith,
            
            /// <summary>
            /// Enum EndsWith for "EndsWith"
            /// </summary>
            [EnumMember(Value = "EndsWith")]
            EndsWith,
            
            /// <summary>
            /// Enum Contains for "Contains"
            /// </summary>
            [EnumMember(Value = "Contains")]
            Contains
        }

        /// <summary>
        /// Get or set text match type verification. It is used only when Text property is set
        /// </summary>
        /// <value>Get or set text match type verification. It is used only when Text property is set</value>
        [DataMember(Name="MatchType", EmitDefaultValue=false)]
        public MatchTypeEnum MatchType { get; set; }
        /// <summary>
        /// Specify text of signature if it should be verified
        /// </summary>
        /// <value>Specify text of signature if it should be verified</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyTextOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
