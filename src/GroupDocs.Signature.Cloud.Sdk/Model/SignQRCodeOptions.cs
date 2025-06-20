// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignQRCodeOptions.cs">
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
    /// Represents the QR-code signature options
    /// </summary>  
    public class SignQRCodeOptions : SignTextOptions 
    {                       
        /// <summary>
        /// Gets or sets the alignment of text in the result QR-code Default value is None
        /// </summary>
        /// <value>Gets or sets the alignment of text in the result QR-code Default value is None</value>
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
        /// Gets or sets the alignment of text in the result QR-code Default value is None
        /// </summary>
        public CodeTextAlignmentEnum? CodeTextAlignment { get; set; }

        /// <summary>
        /// Get or set QRCode type. Value should be one from supported QRCode types list
        /// </summary>  
        public string QRCodeType { get; set; }

        /// <summary>
        /// Gets or sets the signature transparency (value from 0.0 (opaque) through 1.0 (clear)). Default value is 0 (opaque).             
        /// </summary>  
        public double? Transparency { get; set; }

        /// <summary>
        /// Gets or sets the space between QRCode elements and result image borders
        /// </summary>  
        public Padding InnerMargins { get; set; }

        /// <summary>
        /// Gets or sets the QR-code logo image file name. This property in use only if LogoStream is not specified. Using of this property could cause problems with verification. Use it carefully
        /// </summary>  
        public string LogoFilePath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SignQRCodeOptions {\n");
          sb.Append("  QRCodeType: ").Append(this.QRCodeType).Append("\n");
          sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
          sb.Append("  CodeTextAlignment: ").Append(this.CodeTextAlignment).Append("\n");
          sb.Append("  InnerMargins: ").Append(this.InnerMargins).Append("\n");
          sb.Append("  LogoFilePath: ").Append(this.LogoFilePath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
