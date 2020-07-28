// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeleteOptions.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
    /// Base container class for delete signature options
    /// </summary>  
    public class DeleteOptions 
    {                       
        /// <summary>
        /// Specifies the type of signature
        /// </summary>
        /// <value>Specifies the type of signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image,
            
            /// <summary>
            /// Enum Digital for "Digital"
            /// </summary>            
            Digital,
            
            /// <summary>
            /// Enum Barcode for "Barcode"
            /// </summary>            
            Barcode,
            
            /// <summary>
            /// Enum QRCode for "QRCode"
            /// </summary>            
            QRCode,
            
            /// <summary>
            /// Enum Stamp for "Stamp"
            /// </summary>            
            Stamp            
        }

        /// <summary>
        /// Specifies the type of signature
        /// </summary>
        public SignatureTypeEnum? SignatureType { get; set; }

        /// <summary>
        /// Unique signature identifier to modify signature in the document over Update or Delete methods. This property will be set automatically after Sign or Search method being called. If this property was saved before it can be set manually to manipulate the signature.              
        /// </summary>  
        public string SignatureId { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DeleteOptions {\n");
          sb.Append("  SignatureType: ").Append(this.SignatureType).Append("\n");
          sb.Append("  SignatureId: ").Append(this.SignatureId).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
