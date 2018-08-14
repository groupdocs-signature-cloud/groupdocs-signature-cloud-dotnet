// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignBarcodeOptionsData.cs">
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
  /// Represents the Barcode Signature Options.
  /// </summary>  
  public class SignBarcodeOptionsData : SignTextOptionsData 
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
        /// Gets or sets the alignment of text in the result Barcode. Default value is None.
        /// </summary>
        /// <value>Gets or sets the alignment of text in the result Barcode. Default value is None.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeTextAlignmentEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Above for "Above"
            /// </summary>            
            Above,
            
            /// <summary>
            /// Enum Below for "Below"
            /// </summary>            
            Below,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right            
        }

        /// <summary>
        /// Gets or sets the signature border style.
        /// </summary>
        public BorderDashStyleEnum? BorderDashStyle { get; set; }

        /// <summary>
        /// Gets or sets the alignment of text in the result Barcode. Default value is None.
        /// </summary>
        public CodeTextAlignmentEnum? CodeTextAlignment { get; set; }

        /// <summary>
        /// Get or set Barcode type. Pick one from supported Barcode Types list.
        /// </summary>  
        public string BarcodeTypeName { get; set; }

        /// <summary>
        /// Gets or sets the Fore color of Barcode bars Using of this property could cause problems with verification. Use it carefully with maximum contrast with background.
        /// </summary>  
        public Color ForeColor { get; set; }

        /// <summary>
        /// Gets or sets the border color of signature. Using of this property could cause problems with verification. Use it carefully with maximum contrast with background.
        /// </summary>  
        public Color BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature. Using of this property could cause problems with verification. Use it carefully with maximum contrast with background.
        /// </summary>  
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the signature background brush. Value by default is null.  When property has a value it is used instead BackgroundBrush property. BackgroundBrush has limited scope of application for Bar-codes. SolidBrush, LinearGradientBrush (ColorStart) and RadialGradientBrush (ColorInner) are used   instead BackgroundColor. TextureBrush is not used.
        /// </summary>  
        public BrushData BackgroundBrush { get; set; }

        /// <summary>
        /// Gets or sets the signature border visibility.
        /// </summary>  
        public bool? BorderVisiblity { get; set; }

        /// <summary>
        /// Gets or sets the weight of the signature border. 
        /// </summary>  
        public double? BorderWeight { get; set; }

        /// <summary>
        /// Gets or sets the signature opacity (value from 0.0 (clear) through 1.0 (opaque)). By default the value is 1.0.
        /// </summary>  
        public double? Opacity { get; set; }

        /// <summary>
        /// Gets or sets the space between Barcode elements and result image borders.
        /// </summary>  
        public PaddingData InnerMargins { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SignBarcodeOptionsData {\n");
          sb.Append("  BarcodeTypeName: ").Append(this.BarcodeTypeName).Append("\n");
          sb.Append("  ForeColor: ").Append(this.ForeColor).Append("\n");
          sb.Append("  BorderColor: ").Append(this.BorderColor).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  BackgroundBrush: ").Append(this.BackgroundBrush).Append("\n");
          sb.Append("  BorderVisiblity: ").Append(this.BorderVisiblity).Append("\n");
          sb.Append("  BorderDashStyle: ").Append(this.BorderDashStyle).Append("\n");
          sb.Append("  BorderWeight: ").Append(this.BorderWeight).Append("\n");
          sb.Append("  Opacity: ").Append(this.Opacity).Append("\n");
          sb.Append("  CodeTextAlignment: ").Append(this.CodeTextAlignment).Append("\n");
          sb.Append("  InnerMargins: ").Append(this.InnerMargins).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
