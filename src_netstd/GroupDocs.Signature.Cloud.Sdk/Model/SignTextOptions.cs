// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignTextOptions.cs">
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
    /// Base container class for signature options data
    /// </summary>
    [DataContract]
    public partial class SignTextOptions : SignOptions
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
        /// Stretch mode on document page
        /// </summary>
        /// <value>Stretch mode on document page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StretchEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum PageWidth for "PageWidth"
            /// </summary>
            [EnumMember(Value = "PageWidth")]
            PageWidth,
            
            /// <summary>
            /// Enum PageHeight for "PageHeight"
            /// </summary>
            [EnumMember(Value = "PageHeight")]
            PageHeight,
            
            /// <summary>
            /// Enum PageArea for "PageArea"
            /// </summary>
            [EnumMember(Value = "PageArea")]
            PageArea
        }

        /// <summary>
        /// Stretch mode on document page
        /// </summary>
        /// <value>Stretch mode on document page</value>
        [DataMember(Name="Stretch", EmitDefaultValue=false)]
        public StretchEnum Stretch { get; set; }
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
        /// Gets or sets the signature border style It is not suitable for PDF
        /// </summary>
        /// <value>Gets or sets the signature border style It is not suitable for PDF</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderDashStyleEnum
        {
            
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>
            [EnumMember(Value = "Dash")]
            Dash,
            
            /// <summary>
            /// Enum DashDot for "DashDot"
            /// </summary>
            [EnumMember(Value = "DashDot")]
            DashDot,
            
            /// <summary>
            /// Enum DashDotDot for "DashDotDot"
            /// </summary>
            [EnumMember(Value = "DashDotDot")]
            DashDotDot,
            
            /// <summary>
            /// Enum DashLongDash for "DashLongDash"
            /// </summary>
            [EnumMember(Value = "DashLongDash")]
            DashLongDash,
            
            /// <summary>
            /// Enum DashLongDashDot for "DashLongDashDot"
            /// </summary>
            [EnumMember(Value = "DashLongDashDot")]
            DashLongDashDot,
            
            /// <summary>
            /// Enum RoundDot for "RoundDot"
            /// </summary>
            [EnumMember(Value = "RoundDot")]
            RoundDot,
            
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>
            [EnumMember(Value = "Solid")]
            Solid,
            
            /// <summary>
            /// Enum SquareDot for "SquareDot"
            /// </summary>
            [EnumMember(Value = "SquareDot")]
            SquareDot
        }

        /// <summary>
        /// Gets or sets the signature border style It is not suitable for PDF
        /// </summary>
        /// <value>Gets or sets the signature border style It is not suitable for PDF</value>
        [DataMember(Name="BorderDashStyle", EmitDefaultValue=false)]
        public BorderDashStyleEnum BorderDashStyle { get; set; }
        /// <summary>
        /// Horizontal alignment of text inside a signature
        /// </summary>
        /// <value>Horizontal alignment of text inside a signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextHorizontalAlignmentEnum
        {
            
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
        /// Horizontal alignment of text inside a signature
        /// </summary>
        /// <value>Horizontal alignment of text inside a signature</value>
        [DataMember(Name="TextHorizontalAlignment", EmitDefaultValue=false)]
        public TextHorizontalAlignmentEnum TextHorizontalAlignment { get; set; }
        /// <summary>
        /// Vertical alignment of text inside a signature
        /// </summary>
        /// <value>Vertical alignment of text inside a signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextVerticalAlignmentEnum
        {
            
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
        /// Vertical alignment of text inside a signature
        /// </summary>
        /// <value>Vertical alignment of text inside a signature</value>
        [DataMember(Name="TextVerticalAlignment", EmitDefaultValue=false)]
        public TextVerticalAlignmentEnum TextVerticalAlignment { get; set; }
        /// <summary>
        /// Left X position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType property)
        /// </summary>
        /// <value>Left X position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType property)</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public int? Left { get; set; }

        /// <summary>
        /// Top Y Position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType property)
        /// </summary>
        /// <value>Top Y Position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType property)</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public int? Top { get; set; }

        /// <summary>
        /// Width of Signature area on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType property)
        /// </summary>
        /// <value>Width of Signature area on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType property)</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Height of Signature are on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType property)
        /// </summary>
        /// <value>Height of Signature are on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType property)</value>
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
        /// Text of signature
        /// </summary>
        /// <value>Text of signature</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the font of signature
        /// </summary>
        /// <value>Gets or sets the font of signature</value>
        [DataMember(Name="Font", EmitDefaultValue=false)]
        public SignatureFont Font { get; set; }

        /// <summary>
        /// Gets or sets the fore color of signature
        /// </summary>
        /// <value>Gets or sets the fore color of signature</value>
        [DataMember(Name="ForeColor", EmitDefaultValue=false)]
        public Color ForeColor { get; set; }

        /// <summary>
        /// Gets or sets the border color of signature
        /// </summary>
        /// <value>Gets or sets the border color of signature</value>
        [DataMember(Name="BorderColor", EmitDefaultValue=false)]
        public Color BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature
        /// </summary>
        /// <value>Gets or sets the background color of signature</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the signature background brush. Value by default is null.  If this property has a value it will be used instead BackgroundBrush property. For Spreadsheet documents TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. Spreadsheets, Images, Presentations It is not used for Watermark implementation. PDF For Stamp implementation LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used as SolidBrush. PDF It is not used for Annotation, Sticker, TextToFormField and Watermark implementations. Presentations For TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. Word Processing For TextStamp implementation LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used as SolidBrush. Word Processing It is not used for TextToFormField and Watermark implementations
        /// </summary>
        /// <value>Gets or sets the signature background brush. Value by default is null.  If this property has a value it will be used instead BackgroundBrush property. For Spreadsheet documents TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. Spreadsheets, Images, Presentations It is not used for Watermark implementation. PDF For Stamp implementation LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used as SolidBrush. PDF It is not used for Annotation, Sticker, TextToFormField and Watermark implementations. Presentations For TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. Word Processing For TextStamp implementation LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used as SolidBrush. Word Processing It is not used for TextToFormField and Watermark implementations</value>
        [DataMember(Name="BackgroundBrush", EmitDefaultValue=false)]
        public Brush BackgroundBrush { get; set; }

        /// <summary>
        /// Gets or sets the signature border visibility It is not suitable for PDF
        /// </summary>
        /// <value>Gets or sets the signature border visibility It is not suitable for PDF</value>
        [DataMember(Name="BorderVisiblity", EmitDefaultValue=false)]
        public bool? BorderVisiblity { get; set; }


        /// <summary>
        /// Gets or sets the signature border transparency (value from 0.0 (opaque) through 1.0 (clear)) It is not suitable for PDF
        /// </summary>
        /// <value>Gets or sets the signature border transparency (value from 0.0 (opaque) through 1.0 (clear)) It is not suitable for PDF</value>
        [DataMember(Name="BorderTransparency", EmitDefaultValue=false)]
        public double? BorderTransparency { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignTextOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  LocationMeasureType: ").Append(LocationMeasureType).Append("\n");
            sb.Append("  SizeMeasureType: ").Append(SizeMeasureType).Append("\n");
            sb.Append("  Stretch: ").Append(Stretch).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  MarginMeasureType: ").Append(MarginMeasureType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  ForeColor: ").Append(ForeColor).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  BackgroundBrush: ").Append(BackgroundBrush).Append("\n");
            sb.Append("  BorderVisiblity: ").Append(BorderVisiblity).Append("\n");
            sb.Append("  BorderDashStyle: ").Append(BorderDashStyle).Append("\n");
            sb.Append("  BorderTransparency: ").Append(BorderTransparency).Append("\n");
            sb.Append("  TextHorizontalAlignment: ").Append(TextHorizontalAlignment).Append("\n");
            sb.Append("  TextVerticalAlignment: ").Append(TextVerticalAlignment).Append("\n");
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
