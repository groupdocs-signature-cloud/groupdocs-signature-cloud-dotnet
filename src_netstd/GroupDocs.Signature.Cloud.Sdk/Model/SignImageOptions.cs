// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignImageOptions.cs">
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
    /// Represents the Image sign options
    /// </summary>
    [DataContract]
    public partial class SignImageOptions : SignOptions
    {
        /// <summary>
        /// Measure type (pixels or percent) for Left and Top properties
        /// </summary>
        /// <value>Measure type (pixels or percent) for Left and Top properties</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocationMeasureTypeEnum
        {
            
            /// <summary>
            /// Enum Pixels for "Pixels"
            /// </summary>
            [EnumMember(Value = "Pixels")]
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>
            [EnumMember(Value = "Percents")]
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>
            [EnumMember(Value = "Millimeters")]
            Millimeters
        }

        /// <summary>
        /// Measure type (pixels or percent) for Left and Top properties
        /// </summary>
        /// <value>Measure type (pixels or percent) for Left and Top properties</value>
        [DataMember(Name="LocationMeasureType", EmitDefaultValue=false)]
        public LocationMeasureTypeEnum LocationMeasureType { get; set; }
        /// <summary>
        /// Measure type (pixels or percent) for Width and Height properties
        /// </summary>
        /// <value>Measure type (pixels or percent) for Width and Height properties</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeMeasureTypeEnum
        {
            
            /// <summary>
            /// Enum Pixels for "Pixels"
            /// </summary>
            [EnumMember(Value = "Pixels")]
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>
            [EnumMember(Value = "Percents")]
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>
            [EnumMember(Value = "Millimeters")]
            Millimeters
        }

        /// <summary>
        /// Measure type (pixels or percent) for Width and Height properties
        /// </summary>
        /// <value>Measure type (pixels or percent) for Width and Height properties</value>
        [DataMember(Name="SizeMeasureType", EmitDefaultValue=false)]
        public SizeMeasureTypeEnum SizeMeasureType { get; set; }
        /// <summary>
        /// Horizontal alignment of signature on document page
        /// </summary>
        /// <value>Horizontal alignment of signature on document page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalAlignmentEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            [EnumMember(Value = "Left")]
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            [EnumMember(Value = "Center")]
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            [EnumMember(Value = "Right")]
            Right
        }

        /// <summary>
        /// Horizontal alignment of signature on document page
        /// </summary>
        /// <value>Horizontal alignment of signature on document page</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=false)]
        public HorizontalAlignmentEnum HorizontalAlignment { get; set; }
        /// <summary>
        /// Vertical alignment of signature on document page
        /// </summary>
        /// <value>Vertical alignment of signature on document page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            [EnumMember(Value = "Top")]
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            [EnumMember(Value = "Center")]
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom
        }

        /// <summary>
        /// Vertical alignment of signature on document page
        /// </summary>
        /// <value>Vertical alignment of signature on document page</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=false)]
        public VerticalAlignmentEnum VerticalAlignment { get; set; }
        /// <summary>
        /// Gets or sets the measure type (pixels or percent) for Margin
        /// </summary>
        /// <value>Gets or sets the measure type (pixels or percent) for Margin</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarginMeasureTypeEnum
        {
            
            /// <summary>
            /// Enum Pixels for "Pixels"
            /// </summary>
            [EnumMember(Value = "Pixels")]
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>
            [EnumMember(Value = "Percents")]
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>
            [EnumMember(Value = "Millimeters")]
            Millimeters
        }

        /// <summary>
        /// Gets or sets the measure type (pixels or percent) for Margin
        /// </summary>
        /// <value>Gets or sets the measure type (pixels or percent) for Margin</value>
        [DataMember(Name="MarginMeasureType", EmitDefaultValue=false)]
        public MarginMeasureTypeEnum MarginMeasureType { get; set; }
        /// <summary>
        /// Gets or sets the signature image file name. This property is used only if ImageStream is not specified
        /// </summary>
        /// <value>Gets or sets the signature image file name. This property is used only if ImageStream is not specified</value>
        [DataMember(Name="ImageGuid", EmitDefaultValue=false)]
        public string ImageGuid { get; set; }

        /// <summary>
        /// Left X position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType). (works if horizontal alignment is not specified). For Spreadsheet documents this property is mutually exclusive with Column property. If Left property is set ColumnNumber will be reset to 0
        /// </summary>
        /// <value>Left X position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType). (works if horizontal alignment is not specified). For Spreadsheet documents this property is mutually exclusive with Column property. If Left property is set ColumnNumber will be reset to 0</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public int? Left { get; set; }

        /// <summary>
        /// Top Y Position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType). (works if vertical alignment is not specified). For Spreadsheet documents this property is mutually exclusive with Row property. If Top property is set RowNumber will be reset to 0
        /// </summary>
        /// <value>Top Y Position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType). (works if vertical alignment is not specified). For Spreadsheet documents this property is mutually exclusive with Row property. If Top property is set RowNumber will be reset to 0</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public int? Top { get; set; }

        /// <summary>
        /// Width of Signature on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType)
        /// </summary>
        /// <value>Width of Signature on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType)</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Height of Signature on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType)
        /// </summary>
        /// <value>Height of Signature on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType)</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }



        /// <summary>
        /// Rotation angle of signature on document page (clockwise)
        /// </summary>
        /// <value>Rotation angle of signature on document page (clockwise)</value>
        [DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public int? RotationAngle { get; set; }



        /// <summary>
        /// Gets or sets the space between Sign and Document edges (works ONLY if horizontal or vertical alignment are specified)
        /// </summary>
        /// <value>Gets or sets the space between Sign and Document edges (works ONLY if horizontal or vertical alignment are specified)</value>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public Padding Margin { get; set; }


        /// <summary>
        /// Gets or sets the additional opacity for sign image (value from 0.0 (clear) through 1.0 (opaque)). By default the value is 1.0
        /// </summary>
        /// <value>Gets or sets the additional opacity for sign image (value from 0.0 (clear) through 1.0 (opaque)). By default the value is 1.0</value>
        [DataMember(Name="Opacity", EmitDefaultValue=false)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignImageOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ImageGuid: ").Append(ImageGuid).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  LocationMeasureType: ").Append(LocationMeasureType).Append("\n");
            sb.Append("  SizeMeasureType: ").Append(SizeMeasureType).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  MarginMeasureType: ").Append(MarginMeasureType).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
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
