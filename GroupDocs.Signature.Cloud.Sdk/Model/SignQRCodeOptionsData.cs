// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignQRCodeOptionsData.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
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
  /// Represents the QRCode Signature Options.
  /// </summary>  
  public class SignQRCodeOptionsData : SignTextOptionsData 
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
        /// Gets or sets the signature border style.
        /// </summary>
        public BorderDashStyleEnum? BorderDashStyle { get; set; }

        /// <summary>
        /// Get or set QRCode type. Pick one from supported QRCode Types list
        /// </summary>  
        public string QRCodeTypeName { get; set; }

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
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SignQRCodeOptionsData {\n");
          sb.Append("  QRCodeTypeName: ").Append(this.QRCodeTypeName).Append("\n");
          sb.Append("  BorderVisiblity: ").Append(this.BorderVisiblity).Append("\n");
          sb.Append("  BorderDashStyle: ").Append(this.BorderDashStyle).Append("\n");
          sb.Append("  BorderWeight: ").Append(this.BorderWeight).Append("\n");
          sb.Append("  Opacity: ").Append(this.Opacity).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
