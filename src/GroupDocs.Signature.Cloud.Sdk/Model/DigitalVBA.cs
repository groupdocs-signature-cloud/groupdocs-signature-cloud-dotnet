// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DigitalVBA.cs">
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
    /// 
    /// </summary>  
    public class DigitalVBA 
    {                       
        /// <summary>
        /// Gets or sets the password of digital certificate
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the digital certificate file path
        /// </summary>  
        public string CertificateFilePath { get; set; }

        /// <summary>
        /// Gets or sets setting of only VBA project signing. If set to true, the SpreadSheet document will not be signed, but the VBA project will be signed.             
        /// </summary>  
        public bool? SignOnlyVBAProject { get; set; }

        /// <summary>
        /// Gets or sets the signature comments.
        /// </summary>  
        public string Comments { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DigitalVBA {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  CertificateFilePath: ").Append(this.CertificateFilePath).Append("\n");
          sb.Append("  SignOnlyVBAProject: ").Append(this.SignOnlyVBAProject).Append("\n");
          sb.Append("  Comments: ").Append(this.Comments).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
