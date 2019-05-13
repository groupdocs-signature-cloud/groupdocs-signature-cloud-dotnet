// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="VerifyDigitalOptions.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Signature.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Signature.Cloud.Sdk.Model
{
    /// <summary>
    /// Defines options to verify Digital signature within a document
    /// </summary>
    [DataContract]
    public partial class VerifyDigitalOptions : VerifyOptions
    {
        /// <summary>
        /// Password of Digital Certificate if required
        /// </summary>
        /// <value>Password of Digital Certificate if required</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// File Guid of Digital Certificate
        /// </summary>
        /// <value>File Guid of Digital Certificate</value>
        [DataMember(Name="CertificateGuid", EmitDefaultValue=false)]
        public string CertificateGuid { get; set; }

        /// <summary>
        /// Comments of Digital Signature to validate Suitable for Spreadsheet and Words Processing document types
        /// </summary>
        /// <value>Comments of Digital Signature to validate Suitable for Spreadsheet and Words Processing document types</value>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Date and time range of Digital Signature to validate. Null value will be ignored. Suitable for Spreadsheet and Words Processing document types
        /// </summary>
        /// <value>Date and time range of Digital Signature to validate. Null value will be ignored. Suitable for Spreadsheet and Words Processing document types</value>
        [DataMember(Name="SignDateTimeFrom", EmitDefaultValue=false)]
        public DateTime? SignDateTimeFrom { get; set; }

        /// <summary>
        /// Date and time range of Digital Signature to validate. Null value will be ignored Suitable for Spreadsheet and Words Processing document types
        /// </summary>
        /// <value>Date and time range of Digital Signature to validate. Null value will be ignored Suitable for Spreadsheet and Words Processing document types</value>
        [DataMember(Name="SignDateTimeTo", EmitDefaultValue=false)]
        public DateTime? SignDateTimeTo { get; set; }

        /// <summary>
        /// Reason of Digital Signature to validate Suitable for Pdf document type
        /// </summary>
        /// <value>Reason of Digital Signature to validate Suitable for Pdf document type</value>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Signature Contact to validate Suitable for Pdf document type
        /// </summary>
        /// <value>Signature Contact to validate Suitable for Pdf document type</value>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Signature Location to validate Suitable for Pdf document type
        /// </summary>
        /// <value>Signature Location to validate Suitable for Pdf document type</value>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyDigitalOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CertificateGuid: ").Append(CertificateGuid).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  SignDateTimeFrom: ").Append(SignDateTimeFrom).Append("\n");
            sb.Append("  SignDateTimeTo: ").Append(SignDateTimeTo).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
