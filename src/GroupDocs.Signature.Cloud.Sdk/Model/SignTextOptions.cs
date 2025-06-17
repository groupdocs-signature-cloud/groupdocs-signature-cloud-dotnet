// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignTextOptions.cs">
//  Copyright (c) Aspose Pty Ltd
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

namespace GroupDocs.Signature.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Base container class for signature options data
    /// </summary>  
    public class SignTextOptions : SignOptions 
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
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>            
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>            
            Millimeters            
        }

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
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>            
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>            
            Millimeters            
        }

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
            None,
            
            /// <summary>
            /// Enum PageWidth for "PageWidth"
            /// </summary>            
            PageWidth,
            
            /// <summary>
            /// Enum PageHeight for "PageHeight"
            /// </summary>            
            PageHeight,
            
            /// <summary>
            /// Enum PageArea for "PageArea"
            /// </summary>            
            PageArea            
        }

        /// <summary>
        /// Horizontal alignment of signature on document page
        /// </summary>
        /// <value>Horizontal alignment of signature on document page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalAlignmentEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>            
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right            
        }

        /// <summary>
        /// Vertical alignment of signature on document page
        /// </summary>
        /// <value>Vertical alignment of signature on document page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom            
        }

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
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>            
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>            
            Millimeters            
        }

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
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right            
        }

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
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom            
        }

        /// <summary>
        /// Measure type (pixels or percent) for Left and Top properties
        /// </summary>
        public LocationMeasureTypeEnum? LocationMeasureType { get; set; }

        /// <summary>
        /// Measure type (pixels or percent) for Width and Height properties
        /// </summary>
        public SizeMeasureTypeEnum? SizeMeasureType { get; set; }

        /// <summary>
        /// Stretch mode on document page
        /// </summary>
        public StretchEnum? Stretch { get; set; }

        /// <summary>
        /// Horizontal alignment of signature on document page
        /// </summary>
        public HorizontalAlignmentEnum? HorizontalAlignment { get; set; }

        /// <summary>
        /// Vertical alignment of signature on document page
        /// </summary>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the measure type (pixels or percent) for Margin
        /// </summary>
        public MarginMeasureTypeEnum? MarginMeasureType { get; set; }

        /// <summary>
        /// Horizontal alignment of text inside a signature
        /// </summary>
        public TextHorizontalAlignmentEnum? TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Vertical alignment of text inside a signature
        /// </summary>
        public TextVerticalAlignmentEnum? TextVerticalAlignment { get; set; }

        /// <summary>
        /// Left X position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType property)
        /// </summary>  
        public int? Left { get; set; }

        /// <summary>
        /// Top Y Position of Signature on Document Page in Measure values (pixels or percent see MeasureType LocationMeasureType property)
        /// </summary>  
        public int? Top { get; set; }

        /// <summary>
        /// Width of Signature area on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType property)
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Height of Signature are on Document Page in Measure values (pixels or percent see MeasureType SizeMeasureType property)
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Rotation angle of signature on document page (clockwise)
        /// </summary>  
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets the space between Sign and Document edges (works ONLY if horizontal or vertical alignment are specified)
        /// </summary>  
        public Padding Margin { get; set; }

        /// <summary>
        /// Text of signature
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the font of signature
        /// </summary>  
        public SignatureFont Font { get; set; }

        /// <summary>
        /// Gets or sets the fore color of signature
        /// </summary>  
        public Color ForeColor { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature
        /// </summary>  
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the signature background brush. Value by default is null.  If this property has a value it will be used instead BackgroundBrush property. For Spreadsheet documents TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. Spreadsheets, Images, Presentations It is not used for Watermark implementation. PDF For Stamp implementation LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used as SolidBrush. PDF It is not used for Annotation, Sticker, TextToFormField and Watermark implementations. Presentations For TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. Word Processing For TextStamp implementation LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used as SolidBrush. Word Processing It is not used for TextToFormField and Watermark implementations
        /// </summary>  
        public Brush BackgroundBrush { get; set; }

        /// <summary>
        /// Gets or sets the signature border properties
        /// </summary>  
        public BorderLine Border { get; set; }

        /// <summary>
        /// Gets or sets the Z-order position of text signature. Determines the display order of overlapping signatures.             
        /// </summary>  
        public int? ZOrder { get; set; }

        /// <summary>
        /// Gets or sets the native attribute. If it is set document specific signatures could be used. Native text watermark for WordProcessing documents is different than regular, for example.             
        /// </summary>  
        public bool? Native { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SignTextOptions {\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  LocationMeasureType: ").Append(this.LocationMeasureType).Append("\n");
          sb.Append("  SizeMeasureType: ").Append(this.SizeMeasureType).Append("\n");
          sb.Append("  Stretch: ").Append(this.Stretch).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("  HorizontalAlignment: ").Append(this.HorizontalAlignment).Append("\n");
          sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
          sb.Append("  Margin: ").Append(this.Margin).Append("\n");
          sb.Append("  MarginMeasureType: ").Append(this.MarginMeasureType).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Font: ").Append(this.Font).Append("\n");
          sb.Append("  ForeColor: ").Append(this.ForeColor).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  BackgroundBrush: ").Append(this.BackgroundBrush).Append("\n");
          sb.Append("  Border: ").Append(this.Border).Append("\n");
          sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
          sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
          sb.Append("  ZOrder: ").Append(this.ZOrder).Append("\n");
          sb.Append("  Native: ").Append(this.Native).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
