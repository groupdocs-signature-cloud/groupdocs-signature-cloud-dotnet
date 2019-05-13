// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="BorderLine.cs">
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
    /// Instance to keep Border line properties
    /// </summary>
    [DataContract]
    public partial class BorderLine
    {
        /// <summary>
        /// Gets or sets the signature border style
        /// </summary>
        /// <value>Gets or sets the signature border style</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>
            [EnumMember(Value = "Solid")]
            Solid,
            
            /// <summary>
            /// Enum ShortDash for "ShortDash"
            /// </summary>
            [EnumMember(Value = "ShortDash")]
            ShortDash,
            
            /// <summary>
            /// Enum ShortDot for "ShortDot"
            /// </summary>
            [EnumMember(Value = "ShortDot")]
            ShortDot,
            
            /// <summary>
            /// Enum ShortDashDot for "ShortDashDot"
            /// </summary>
            [EnumMember(Value = "ShortDashDot")]
            ShortDashDot,
            
            /// <summary>
            /// Enum ShortDashDotDot for "ShortDashDotDot"
            /// </summary>
            [EnumMember(Value = "ShortDashDotDot")]
            ShortDashDotDot,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>
            [EnumMember(Value = "Dot")]
            Dot,
            
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>
            [EnumMember(Value = "Dash")]
            Dash,
            
            /// <summary>
            /// Enum LongDash for "LongDash"
            /// </summary>
            [EnumMember(Value = "LongDash")]
            LongDash,
            
            /// <summary>
            /// Enum DashDot for "DashDot"
            /// </summary>
            [EnumMember(Value = "DashDot")]
            DashDot,
            
            /// <summary>
            /// Enum LongDashDot for "LongDashDot"
            /// </summary>
            [EnumMember(Value = "LongDashDot")]
            LongDashDot,
            
            /// <summary>
            /// Enum LongDashDotDot for "LongDashDotDot"
            /// </summary>
            [EnumMember(Value = "LongDashDotDot")]
            LongDashDotDot
        }

        /// <summary>
        /// Gets or sets the signature border style
        /// </summary>
        /// <value>Gets or sets the signature border style</value>
        [DataMember(Name="Style", EmitDefaultValue=false)]
        public StyleEnum Style { get; set; }

        /// <summary>
        /// Gets or sets the signature border transparency (value from 0.0 (opaque) through 1.0 (clear))
        /// </summary>
        /// <value>Gets or sets the signature border transparency (value from 0.0 (opaque) through 1.0 (clear))</value>
        [DataMember(Name="Transparency", EmitDefaultValue=false)]
        public double? Transparency { get; set; }

        /// <summary>
        /// Gets or sets the weight of the signature border
        /// </summary>
        /// <value>Gets or sets the weight of the signature border</value>
        [DataMember(Name="Weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }

        /// <summary>
        /// Gets or sets the border color of signature
        /// </summary>
        /// <value>Gets or sets the border color of signature</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BorderLine {\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  Transparency: ").Append(Transparency).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
