// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignDigitalOptions.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Represents the Digital sign options
    /// </summary>  
    public class SignDigitalOptions : SignImageOptions 
    {                       
        /// <summary>
        /// XAdES type GroupDocs.Signature.Options.DigitalSignOptions.XAdESType. Default value is None (XAdES is off). At this moment XAdES signature type is supported only for Spreadsheet documents.             
        /// </summary>
        /// <value>XAdES type GroupDocs.Signature.Options.DigitalSignOptions.XAdESType. Default value is None (XAdES is off). At this moment XAdES signature type is supported only for Spreadsheet documents.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum XAdESTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum XAdES for "XAdES"
            /// </summary>            
            XAdES            
        }

        /// <summary>
        /// XAdES type GroupDocs.Signature.Options.DigitalSignOptions.XAdESType. Default value is None (XAdES is off). At this moment XAdES signature type is supported only for Spreadsheet documents.             
        /// </summary>
        public XAdESTypeEnum? XAdESType { get; set; }

        /// <summary>
        /// Gets or sets the reason of signature.
        /// </summary>  
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the signature contact.
        /// </summary>  
        public string Contact { get; set; }

        /// <summary>
        /// Gets or sets the signature location.
        /// </summary>  
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the visibility of signature.
        /// </summary>  
        public bool? Visible { get; set; }

        /// <summary>
        /// Gets or sets the password of digital certificate
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the digital certificate file GUID
        /// </summary>  
        public string CertificateFilePath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SignDigitalOptions {\n");
          sb.Append("  Reason: ").Append(this.Reason).Append("\n");
          sb.Append("  Contact: ").Append(this.Contact).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  Visible: ").Append(this.Visible).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  CertificateFilePath: ").Append(this.CertificateFilePath).Append("\n");
          sb.Append("  XAdESType: ").Append(this.XAdESType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
