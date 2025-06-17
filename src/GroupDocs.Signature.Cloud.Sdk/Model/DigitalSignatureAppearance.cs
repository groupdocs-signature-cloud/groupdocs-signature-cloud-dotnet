// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DigitalSignatureAppearance.cs">
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
    /// Describes appearance of Signature Line for Digital Signature. One Signature Line could be applied for only one Digital Signature. Signature Line always is on the first page. This feature may be useful for .docx, .doc, .odt and .xlsx file formats.
    /// </summary>  
    public class DigitalSignatureAppearance : SignatureAppearance 
    {                       
        /// <summary>
        /// Gets or sets a email that will be displayed in signature line.
        /// </summary>  
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets signer name for signature line.
        /// </summary>  
        public string Signer { get; set; }

        /// <summary>
        /// Gets or sets a title for signature line.
        /// </summary>  
        public string Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DigitalSignatureAppearance {\n");
          sb.Append("  Email: ").Append(this.Email).Append("\n");
          sb.Append("  Signer: ").Append(this.Signer).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
