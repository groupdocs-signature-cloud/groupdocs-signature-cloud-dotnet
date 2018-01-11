// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="VerifyQRCodeOptionsData.cs">
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
  /// Verify QRCode Options - keeps options to verify QRCode Signature of Document
  /// </summary>  
  public class VerifyQRCodeOptionsData : VerifyTextOptionsData 
  {                       
        /// <summary>
        /// Get or set Text Match Type verification.
        /// </summary>
        /// <value>Get or set Text Match Type verification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchTypeEnum
        { 
            /// <summary>
            /// Enum Exact for "Exact"
            /// </summary>            
            Exact,
            
            /// <summary>
            /// Enum StartsWith for "StartsWith"
            /// </summary>            
            StartsWith,
            
            /// <summary>
            /// Enum EndsWith for "EndsWith"
            /// </summary>            
            EndsWith,
            
            /// <summary>
            /// Enum Contains for "Contains"
            /// </summary>            
            Contains            
        }

        /// <summary>
        /// Get or set Text Match Type verification.
        /// </summary>
        public MatchTypeEnum? MatchType { get; set; }

        /// <summary>
        /// Get or set QRCode Type Name verification.
        /// </summary>  
        public string QRCodeTypeName { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class VerifyQRCodeOptionsData {\n");
          sb.Append("  QRCodeTypeName: ").Append(this.QRCodeTypeName).Append("\n");
          sb.Append("  MatchType: ").Append(this.MatchType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
