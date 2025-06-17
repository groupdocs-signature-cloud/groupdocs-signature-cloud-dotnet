// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfDigitalSignature.cs">
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
    /// Contains pdf digital Signature properties
    /// </summary>  
    public class PdfDigitalSignature 
    {                       
        /// <summary>
        /// Type of Pdf digital signature.
        /// </summary>
        /// <value>Type of Pdf digital signature.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum Signature for "Signature"
            /// </summary>            
            Signature,
            
            /// <summary>
            /// Enum Certificate for "Certificate"
            /// </summary>            
            Certificate            
        }

        /// <summary>
        /// Type of Pdf digital signature.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Information provided by the signer to enable a recipient to contact the signer
        /// </summary>  
        public string ContactInfo { get; set; }

        /// <summary>
        /// The CPU host name or physical location of the signing.
        /// </summary>  
        public string Location { get; set; }

        /// <summary>
        /// The reason for the signing, such as (I agreeРІР‚В¦).
        /// </summary>  
        public string Reason { get; set; }

        /// <summary>
        /// Time stamp for Pdf digital signature. Default value is null.
        /// </summary>  
        public TimeStamp TimeStamp { get; set; }

        /// <summary>
        /// Force to show/hide signature properties
        /// </summary>  
        public bool? ShowProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfDigitalSignature {\n");
          sb.Append("  ContactInfo: ").Append(this.ContactInfo).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  Reason: ").Append(this.Reason).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  TimeStamp: ").Append(this.TimeStamp).Append("\n");
          sb.Append("  ShowProperties: ").Append(this.ShowProperties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
