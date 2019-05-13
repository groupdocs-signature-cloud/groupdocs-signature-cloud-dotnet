// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignatureFont.cs">
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
    /// Create instance of SignatureFont class to specify Font properties
    /// </summary>
    [DataContract]
    public partial class SignatureFont
    {
        /// <summary>
        /// Font Family Name
        /// </summary>
        /// <value>Font Family Name</value>
        [DataMember(Name="FontFamily", EmitDefaultValue=false)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Font Size 
        /// </summary>
        /// <value>Font Size </value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Apply Font Bold Style
        /// </summary>
        /// <value>Apply Font Bold Style</value>
        [DataMember(Name="Bold", EmitDefaultValue=false)]
        public bool? Bold { get; set; }

        /// <summary>
        /// Apply Font Italic Style
        /// </summary>
        /// <value>Apply Font Italic Style</value>
        [DataMember(Name="Italic", EmitDefaultValue=false)]
        public bool? Italic { get; set; }

        /// <summary>
        /// Apply Underline Style
        /// </summary>
        /// <value>Apply Underline Style</value>
        [DataMember(Name="Underline", EmitDefaultValue=false)]
        public bool? Underline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureFont {\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  Underline: ").Append(Underline).Append("\n");
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
