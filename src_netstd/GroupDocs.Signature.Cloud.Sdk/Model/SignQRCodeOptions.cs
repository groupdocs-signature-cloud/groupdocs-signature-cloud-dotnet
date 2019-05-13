// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignQRCodeOptions.cs">
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
    /// Represents the QR-code signature options
    /// </summary>
    [DataContract]
    public partial class SignQRCodeOptions : SignTextOptions
    {
        /// <summary>
        /// Gets or sets the alignment of text in the result QR-code Default value is None
        /// </summary>
        /// <value>Gets or sets the alignment of text in the result QR-code Default value is None</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeTextAlignmentEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Above for "Above"
            /// </summary>
            [EnumMember(Value = "Above")]
            Above,
            
            /// <summary>
            /// Enum Below for "Below"
            /// </summary>
            [EnumMember(Value = "Below")]
            Below,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            [EnumMember(Value = "Right")]
            Right
        }

        /// <summary>
        /// Gets or sets the alignment of text in the result QR-code Default value is None
        /// </summary>
        /// <value>Gets or sets the alignment of text in the result QR-code Default value is None</value>
        [DataMember(Name="CodeTextAlignment", EmitDefaultValue=false)]
        public CodeTextAlignmentEnum CodeTextAlignment { get; set; }
        /// <summary>
        /// Get or set QRCode type. Value should be one from supported QRCode types list
        /// </summary>
        /// <value>Get or set QRCode type. Value should be one from supported QRCode types list</value>
        [DataMember(Name="QRCodeType", EmitDefaultValue=false)]
        public string QRCodeType { get; set; }

        /// <summary>
        /// Gets or sets the weight of the signature border
        /// </summary>
        /// <value>Gets or sets the weight of the signature border</value>
        [DataMember(Name="BorderWeight", EmitDefaultValue=false)]
        public double? BorderWeight { get; set; }

        /// <summary>
        /// Gets or sets the signature opacity (value from 0.0 (clear) through 1.0 (opaque)) By default the value is 1.0
        /// </summary>
        /// <value>Gets or sets the signature opacity (value from 0.0 (clear) through 1.0 (opaque)) By default the value is 1.0</value>
        [DataMember(Name="Opacity", EmitDefaultValue=false)]
        public double? Opacity { get; set; }


        /// <summary>
        /// Gets or sets the space between QRCode elements and result image borders
        /// </summary>
        /// <value>Gets or sets the space between QRCode elements and result image borders</value>
        [DataMember(Name="InnerMargins", EmitDefaultValue=false)]
        public Padding InnerMargins { get; set; }

        /// <summary>
        /// Gets or sets the QR-code logo image file name. This property in use only if LogoStream is not specified. Using of this property could cause problems with verification. Use it carefully
        /// </summary>
        /// <value>Gets or sets the QR-code logo image file name. This property in use only if LogoStream is not specified. Using of this property could cause problems with verification. Use it carefully</value>
        [DataMember(Name="LogoGuid", EmitDefaultValue=false)]
        public string LogoGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignQRCodeOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  QRCodeType: ").Append(QRCodeType).Append("\n");
            sb.Append("  BorderWeight: ").Append(BorderWeight).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
            sb.Append("  CodeTextAlignment: ").Append(CodeTextAlignment).Append("\n");
            sb.Append("  InnerMargins: ").Append(InnerMargins).Append("\n");
            sb.Append("  LogoGuid: ").Append(LogoGuid).Append("\n");
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
