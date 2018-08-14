// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CellsSignTextOptionsData.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  /// Represents the Text Sign Options for Cells Documents.
  /// </summary>  
  public class CellsSignTextOptionsData : SignTextOptionsData 
  {                       
        /// <summary>
        /// Gets or sets the signature border style.
        /// </summary>
        /// <value>Gets or sets the signature border style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderDashStyleEnum
        { 
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>            
            Dash,
            
            /// <summary>
            /// Enum DashDot for "DashDot"
            /// </summary>            
            DashDot,
            
            /// <summary>
            /// Enum DashDotDot for "DashDotDot"
            /// </summary>            
            DashDotDot,
            
            /// <summary>
            /// Enum DashLongDash for "DashLongDash"
            /// </summary>            
            DashLongDash,
            
            /// <summary>
            /// Enum DashLongDashDot for "DashLongDashDot"
            /// </summary>            
            DashLongDashDot,
            
            /// <summary>
            /// Enum RoundDot for "RoundDot"
            /// </summary>            
            RoundDot,
            
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>            
            Solid,
            
            /// <summary>
            /// Enum SquareDot for "SquareDot"
            /// </summary>            
            SquareDot            
        }

        /// <summary>
        /// Gets or sets the type of text signature implementation.
        /// </summary>
        /// <value>Gets or sets the type of text signature implementation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureImplementationEnum
        { 
            /// <summary>
            /// Enum TextStamp for "TextStamp"
            /// </summary>            
            TextStamp,
            
            /// <summary>
            /// Enum TextAsImage for "TextAsImage"
            /// </summary>            
            TextAsImage            
        }

        /// <summary>
        /// Horizontal alignment of text inside a signature.
        /// </summary>
        /// <value>Horizontal alignment of text inside a signature.</value>
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
        /// Vertical alignment of text inside a signature.
        /// </summary>
        /// <value>Vertical alignment of text inside a signature.</value>
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
        /// Gets or sets the signature border style.
        /// </summary>
        public BorderDashStyleEnum? BorderDashStyle { get; set; }

        /// <summary>
        /// Gets or sets the type of text signature implementation.
        /// </summary>
        public SignatureImplementationEnum? SignatureImplementation { get; set; }

        /// <summary>
        /// Horizontal alignment of text inside a signature.
        /// </summary>
        public TextHorizontalAlignmentEnum? TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Vertical alignment of text inside a signature.
        /// </summary>
        public TextVerticalAlignmentEnum? TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets worksheet number for signing. Minimal value is 1.
        /// </summary>  
        public int? DocumentPageNumber { get; set; }

        /// <summary>
        /// Gets or sets the position of the top edge of the Signature area in pixels. This property is mutually exclusive with Row property. If Top property is set RowNumber will be reset to 0.
        /// </summary>  
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets the position of the left edge of the Signature area in pixels. This property is mutually exclusive with Column property. If Left property is set ColumnNumber will be reset to 0.
        /// </summary>  
        public int? Left { get; set; }

        /// <summary>
        /// Gets or sets the space between Sign and worksheet edges. (works ONLY if horizontal or vertical alignment are specified).
        /// </summary>  
        public PaddingData Margin { get; set; }

        /// <summary>
        /// Gets or sets the signature background brush. Value by default is null.  When property has a value it is used instead BackgroundBrush property. For TextStamp implementation RadialGradientBrush is not applicable, it is replaced by LinearGradientBrush. It is not used for Watermark implementation.
        /// </summary>  
        public BrushData BackgroundBrush { get; set; }

        /// <summary>
        /// Gets or sets worksheet number for signing. DocumentPageNumber parameter contains the same value.
        /// </summary>  
        public int? SheetNumber { get; set; }

        /// <summary>
        /// Gets or sets the top row number of signature (min value is 0). Top parameter contains the same value.
        /// </summary>  
        public int? RowNumber { get; set; }

        /// <summary>
        /// Gets or sets the left column number of signature (min value is 0). Left parameter contains the same value.
        /// </summary>  
        public int? ColumnNumber { get; set; }

        /// <summary>
        /// Gets or sets the signature border visibility.
        /// </summary>  
        public bool? BorderVisiblity { get; set; }

        /// <summary>
        /// Gets or sets the signature border transparency (value from 0.0 (opaque) through 1.0 (clear)).
        /// </summary>  
        public double? BorderTransparency { get; set; }

        /// <summary>
        /// Gets or sets the weight of the signature border. 
        /// </summary>  
        public double? BorderWeight { get; set; }

        /// <summary>
        /// Gets or sets the signature background transparency (value from 0.0 (opaque) through 1.0 (clear)).
        /// </summary>  
        public double? BackgroundTransparency { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsSignTextOptionsData {\n");
          sb.Append("  DocumentPageNumber: ").Append(this.DocumentPageNumber).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  Margin: ").Append(this.Margin).Append("\n");
          sb.Append("  BackgroundBrush: ").Append(this.BackgroundBrush).Append("\n");
          sb.Append("  SheetNumber: ").Append(this.SheetNumber).Append("\n");
          sb.Append("  RowNumber: ").Append(this.RowNumber).Append("\n");
          sb.Append("  ColumnNumber: ").Append(this.ColumnNumber).Append("\n");
          sb.Append("  BorderVisiblity: ").Append(this.BorderVisiblity).Append("\n");
          sb.Append("  BorderDashStyle: ").Append(this.BorderDashStyle).Append("\n");
          sb.Append("  BorderTransparency: ").Append(this.BorderTransparency).Append("\n");
          sb.Append("  BorderWeight: ").Append(this.BorderWeight).Append("\n");
          sb.Append("  BackgroundTransparency: ").Append(this.BackgroundTransparency).Append("\n");
          sb.Append("  SignatureImplementation: ").Append(this.SignatureImplementation).Append("\n");
          sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
          sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
