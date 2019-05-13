// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignStampOptions.cs">
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
    /// Represents the Stamp signature options
    /// </summary>
    [DataContract]
    public partial class SignStampOptions : SignImageOptions
    {
        /// <summary>
        /// Gets or sets the background color crop type of signature
        /// </summary>
        /// <value>Gets or sets the background color crop type of signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackgroundColorCropTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum OuterArea for "OuterArea"
            /// </summary>
            [EnumMember(Value = "OuterArea")]
            OuterArea,
            
            /// <summary>
            /// Enum MiddleArea for "MiddleArea"
            /// </summary>
            [EnumMember(Value = "MiddleArea")]
            MiddleArea,
            
            /// <summary>
            /// Enum InnerArea for "InnerArea"
            /// </summary>
            [EnumMember(Value = "InnerArea")]
            InnerArea
        }

        /// <summary>
        /// Gets or sets the background color crop type of signature
        /// </summary>
        /// <value>Gets or sets the background color crop type of signature</value>
        [DataMember(Name="BackgroundColorCropType", EmitDefaultValue=false)]
        public BackgroundColorCropTypeEnum BackgroundColorCropType { get; set; }
        /// <summary>
        /// Gets or sets the background image crop type of signature
        /// </summary>
        /// <value>Gets or sets the background image crop type of signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackgroundImageCropTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum OuterArea for "OuterArea"
            /// </summary>
            [EnumMember(Value = "OuterArea")]
            OuterArea,
            
            /// <summary>
            /// Enum MiddleArea for "MiddleArea"
            /// </summary>
            [EnumMember(Value = "MiddleArea")]
            MiddleArea,
            
            /// <summary>
            /// Enum InnerArea for "InnerArea"
            /// </summary>
            [EnumMember(Value = "InnerArea")]
            InnerArea
        }

        /// <summary>
        /// Gets or sets the background image crop type of signature
        /// </summary>
        /// <value>Gets or sets the background image crop type of signature</value>
        [DataMember(Name="BackgroundImageCropType", EmitDefaultValue=false)]
        public BackgroundImageCropTypeEnum BackgroundImageCropType { get; set; }
        /// <summary>
        /// List of Outer Lines rendered as concentric circles
        /// </summary>
        /// <value>List of Outer Lines rendered as concentric circles</value>
        [DataMember(Name="OuterLines", EmitDefaultValue=false)]
        public List<StampLine> OuterLines { get; set; }

        /// <summary>
        /// List of Inner Lines rendered as set of rectangles
        /// </summary>
        /// <value>List of Inner Lines rendered as set of rectangles</value>
        [DataMember(Name="InnerLines", EmitDefaultValue=false)]
        public List<StampLine> InnerLines { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature
        /// </summary>
        /// <value>Gets or sets the background color of signature</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the signature background brush. Value by default is null.  When property has a value it is used instead BackgroundBrush property
        /// </summary>
        /// <value>Gets or sets the signature background brush. Value by default is null.  When property has a value it is used instead BackgroundBrush property</value>
        [DataMember(Name="BackgroundBrush", EmitDefaultValue=false)]
        public Brush BackgroundBrush { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignStampOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  OuterLines: ").Append(OuterLines).Append("\n");
            sb.Append("  InnerLines: ").Append(InnerLines).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  BackgroundBrush: ").Append(BackgroundBrush).Append("\n");
            sb.Append("  BackgroundColorCropType: ").Append(BackgroundColorCropType).Append("\n");
            sb.Append("  BackgroundImageCropType: ").Append(BackgroundImageCropType).Append("\n");
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
