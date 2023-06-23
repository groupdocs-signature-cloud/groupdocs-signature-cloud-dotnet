// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfDigitalSignatureAppearance.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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
    /// Describes appearance of Digital Signature are on PDF documents.
    /// </summary>  
    public class PdfDigitalSignatureAppearance : SignatureAppearance 
    {                       
        /// <summary>
        /// Get or set background color of signature appearance. By default the value is SystemColors.Windows
        /// </summary>  
        public Color Background { get; set; }

        /// <summary>
        /// Gets or sets contact info label. Default value: \"Contact\". if this value is empty then no contact label will appear on digital signature area.             
        /// </summary>  
        public string ContactInfoLabel { get; set; }

        /// <summary>
        /// Gets or sets date signed label. Default value: \"Date\".
        /// </summary>  
        public string DateSignedAtLabel { get; set; }

        /// <summary>
        /// Gets or sets digital signed label. Default value: \"Digitally signed by\".
        /// </summary>  
        public string DigitalSignedLabel { get; set; }

        /// <summary>
        /// Gets or sets the Font family name to display the labels. Default value is \"Arial\".
        /// </summary>  
        public string FontFamilyName { get; set; }

        /// <summary>
        /// Gets or sets the Font size to display the labels. Default value is 10.
        /// </summary>  
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets location label. Default value: \"Location\". if this value is empty then no location label will appear on digital signature area.
        /// </summary>  
        public string LocationLabel { get; set; }

        /// <summary>
        /// Gets or sets reason label. Default value: \"Reason\". if this value is empty then no reason label will appear on digital signature area.
        /// </summary>  
        public string ReasonLabel { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfDigitalSignatureAppearance {\n");
          sb.Append("  Background: ").Append(this.Background).Append("\n");
          sb.Append("  ContactInfoLabel: ").Append(this.ContactInfoLabel).Append("\n");
          sb.Append("  DateSignedAtLabel: ").Append(this.DateSignedAtLabel).Append("\n");
          sb.Append("  DigitalSignedLabel: ").Append(this.DigitalSignedLabel).Append("\n");
          sb.Append("  FontFamilyName: ").Append(this.FontFamilyName).Append("\n");
          sb.Append("  FontSize: ").Append(this.FontSize).Append("\n");
          sb.Append("  LocationLabel: ").Append(this.LocationLabel).Append("\n");
          sb.Append("  ReasonLabel: ").Append(this.ReasonLabel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
