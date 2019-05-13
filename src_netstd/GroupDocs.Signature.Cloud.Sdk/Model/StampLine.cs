// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StampLine.cs">
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
    /// Specify Stamp line properties
    /// </summary>
    [DataContract]
    public partial class StampLine
    {
        /// <summary>
        /// Gets or sets text repeat type
        /// </summary>
        /// <value>Gets or sets text repeat type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextRepeatTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum FullTextRepeat for "FullTextRepeat"
            /// </summary>
            [EnumMember(Value = "FullTextRepeat")]
            FullTextRepeat,
            
            /// <summary>
            /// Enum RepeatWithTruncation for "RepeatWithTruncation"
            /// </summary>
            [EnumMember(Value = "RepeatWithTruncation")]
            RepeatWithTruncation
        }

        /// <summary>
        /// Gets or sets text repeat type
        /// </summary>
        /// <value>Gets or sets text repeat type</value>
        [DataMember(Name="TextRepeatType", EmitDefaultValue=false)]
        public TextRepeatTypeEnum TextRepeatType { get; set; }
        /// <summary>
        /// Gets or sets the line height on Stamp
        /// </summary>
        /// <value>Gets or sets the line height on Stamp</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature
        /// </summary>
        /// <value>Gets or sets the background color of signature</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the text of stamp line
        /// </summary>
        /// <value>Gets or sets the text of stamp line</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Get or set Font of Stamp Line text
        /// </summary>
        /// <value>Get or set Font of Stamp Line text</value>
        [DataMember(Name="Font", EmitDefaultValue=false)]
        public SignatureFont Font { get; set; }

        /// <summary>
        /// Gets or sets the text color of signature
        /// </summary>
        /// <value>Gets or sets the text color of signature</value>
        [DataMember(Name="TextColor", EmitDefaultValue=false)]
        public Color TextColor { get; set; }

        /// <summary>
        /// Gets or sets the bottom intent of text
        /// </summary>
        /// <value>Gets or sets the bottom intent of text</value>
        [DataMember(Name="TextBottomIntent", EmitDefaultValue=false)]
        public int? TextBottomIntent { get; set; }


        /// <summary>
        /// Setup Outer Border
        /// </summary>
        /// <value>Setup Outer Border</value>
        [DataMember(Name="OuterBorder", EmitDefaultValue=false)]
        public BorderLine OuterBorder { get; set; }

        /// <summary>
        /// Setup Internal Border
        /// </summary>
        /// <value>Setup Internal Border</value>
        [DataMember(Name="InnerBorder", EmitDefaultValue=false)]
        public BorderLine InnerBorder { get; set; }

        /// <summary>
        /// Get and set visibility of Stamp Line
        /// </summary>
        /// <value>Get and set visibility of Stamp Line</value>
        [DataMember(Name="Visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StampLine {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  TextBottomIntent: ").Append(TextBottomIntent).Append("\n");
            sb.Append("  TextRepeatType: ").Append(TextRepeatType).Append("\n");
            sb.Append("  OuterBorder: ").Append(OuterBorder).Append("\n");
            sb.Append("  InnerBorder: ").Append(InnerBorder).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
