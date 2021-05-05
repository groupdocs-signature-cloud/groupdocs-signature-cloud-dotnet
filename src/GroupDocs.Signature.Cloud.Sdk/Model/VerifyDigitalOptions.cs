// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="VerifyDigitalOptions.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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
    /// Defines options to verify Digital signature within a document
    /// </summary>  
    public class VerifyDigitalOptions : VerifyOptions 
    {                       
        /// <summary>
        /// Password of Digital Certificate if required
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// File Guid of Digital Certificate
        /// </summary>  
        public string CertificateFilePath { get; set; }

        /// <summary>
        /// Comments of Digital Signature to validate Suitable for Spreadsheet and Words Processing document types
        /// </summary>  
        public string Comments { get; set; }

        /// <summary>
        /// Date and time range of Digital Signature to validate. Null value will be ignored. Suitable for Spreadsheet and Words Processing document types
        /// </summary>  
        public DateTime? SignDateTimeFrom { get; set; }

        /// <summary>
        /// Date and time range of Digital Signature to validate. Null value will be ignored Suitable for Spreadsheet and Words Processing document types
        /// </summary>  
        public DateTime? SignDateTimeTo { get; set; }

        /// <summary>
        /// Reason of Digital Signature to validate Suitable for Pdf document type
        /// </summary>  
        public string Reason { get; set; }

        /// <summary>
        /// Signature Contact to validate Suitable for Pdf document type
        /// </summary>  
        public string Contact { get; set; }

        /// <summary>
        /// Signature Location to validate Suitable for Pdf document type
        /// </summary>  
        public string Location { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class VerifyDigitalOptions {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  CertificateFilePath: ").Append(this.CertificateFilePath).Append("\n");
          sb.Append("  Comments: ").Append(this.Comments).Append("\n");
          sb.Append("  SignDateTimeFrom: ").Append(this.SignDateTimeFrom).Append("\n");
          sb.Append("  SignDateTimeTo: ").Append(this.SignDateTimeTo).Append("\n");
          sb.Append("  Reason: ").Append(this.Reason).Append("\n");
          sb.Append("  Contact: ").Append(this.Contact).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
