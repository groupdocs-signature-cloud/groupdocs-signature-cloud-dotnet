// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfVerifyTextOptionsData.cs">
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
  /// Pdf Verify Text Options - keeps options to verify Text Signature of Pdf Document
  /// </summary>  
  public class PdfVerifyTextOptionsData : VerifyTextOptionsData 
  {                       
        /// <summary>
        /// Type of Signature to be verified
        /// </summary>
        /// <value>Type of Signature to be verified</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureImplementationEnum
        { 
            /// <summary>
            /// Enum Stamp for "Stamp"
            /// </summary>            
            Stamp,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image,
            
            /// <summary>
            /// Enum Annotation for "Annotation"
            /// </summary>            
            Annotation,
            
            /// <summary>
            /// Enum Sticker for "Sticker"
            /// </summary>            
            Sticker,
            
            /// <summary>
            /// Enum TextToFormField for "TextToFormField"
            /// </summary>            
            TextToFormField,
            
            /// <summary>
            /// Enum Watermark for "Watermark"
            /// </summary>            
            Watermark            
        }

        /// <summary>
        /// Type of Signature to be verified
        /// </summary>
        public SignatureImplementationEnum? SignatureImplementation { get; set; }

        /// <summary>
        /// Specify Text Signature ID more than zero if it should be verified
        /// </summary>  
        public int? SignatureID { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfVerifyTextOptionsData {\n");
          sb.Append("  SignatureID: ").Append(this.SignatureID).Append("\n");
          sb.Append("  SignatureImplementation: ").Append(this.SignatureImplementation).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
