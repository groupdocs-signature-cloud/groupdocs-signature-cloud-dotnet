// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchBarcodeOptions.cs">
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
    /// Defines options to Search barcode signature within a document
    /// </summary>
    [DataContract]
    public partial class SearchBarcodeOptions : SearchOptions
    {
        /// <summary>
        /// Get or set barcode text match type search. It is used only when Text property is set
        /// </summary>
        /// <value>Get or set barcode text match type search. It is used only when Text property is set</value>
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
        /// Get or set barcode text match type search. It is used only when Text property is set
        /// </summary>
        /// <value>Get or set barcode text match type search. It is used only when Text property is set</value>
        [DataMember(Name="MatchType", EmitDefaultValue=false)]
        public MatchTypeEnum MatchType { get; set; }
        /// <summary>
        /// Specifies encode type property to search barcodes. If this value is not set, search is processed for all supported barcode Types
        /// </summary>
        /// <value>Specifies encode type property to search barcodes. If this value is not set, search is processed for all supported barcode Types</value>
        [DataMember(Name="BarcodeType", EmitDefaultValue=false)]
        public string BarcodeType { get; set; }

        /// <summary>
        /// Specifies text for searching and matching in barcode signature
        /// </summary>
        /// <value>Specifies text for searching and matching in barcode signature</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchBarcodeOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BarcodeType: ").Append(BarcodeType).Append("\n");
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
