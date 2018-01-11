// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordsSignTextOptionsData.cs">
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
  /// Represents the Text Sign Options for Words Documents.
  /// </summary>  
  public class WordsSignTextOptionsData : SignTextOptionsData 
  {                       
        /// <summary>
        /// Gets or sets the signature border style.
        /// </summary>
        /// <value>Gets or sets the signature border style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderDashStyleEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>            
            Solid,
            
            /// <summary>
            /// Enum ShortDash for "ShortDash"
            /// </summary>            
            ShortDash,
            
            /// <summary>
            /// Enum ShortDot for "ShortDot"
            /// </summary>            
            ShortDot,
            
            /// <summary>
            /// Enum ShortDashDot for "ShortDashDot"
            /// </summary>            
            ShortDashDot,
            
            /// <summary>
            /// Enum ShortDashDotDot for "ShortDashDotDot"
            /// </summary>            
            ShortDashDotDot,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>            
            Dot,
            
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>            
            Dash,
            
            /// <summary>
            /// Enum LongDash for "LongDash"
            /// </summary>            
            LongDash,
            
            /// <summary>
            /// Enum DashDot for "DashDot"
            /// </summary>            
            DashDot,
            
            /// <summary>
            /// Enum LongDashDot for "LongDashDot"
            /// </summary>            
            LongDashDot,
            
            /// <summary>
            /// Enum LongDashDotDot for "LongDashDotDot"
            /// </summary>            
            LongDashDotDot            
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
        /// Gets or sets the signature border style.
        /// </summary>
        public BorderDashStyleEnum? BorderDashStyle { get; set; }

        /// <summary>
        /// Gets or sets the type of text signature implementation.
        /// </summary>
        public SignatureImplementationEnum? SignatureImplementation { get; set; }

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
          sb.Append("class WordsSignTextOptionsData {\n");
          sb.Append("  BorderDashStyle: ").Append(this.BorderDashStyle).Append("\n");
          sb.Append("  BorderTransparency: ").Append(this.BorderTransparency).Append("\n");
          sb.Append("  BorderWeight: ").Append(this.BorderWeight).Append("\n");
          sb.Append("  BackgroundTransparency: ").Append(this.BackgroundTransparency).Append("\n");
          sb.Append("  SignatureImplementation: ").Append(this.SignatureImplementation).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
