// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="OptionsBase.cs">
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
    /// Base container class for all possible options data
    /// </summary>  
    public class OptionsBase 
    {                       
        /// <summary>
        /// Specifies the type of document to process
        /// </summary>
        /// <value>Specifies the type of document to process</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        { 
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image,
            
            /// <summary>
            /// Enum Pdf for "Pdf"
            /// </summary>            
            Pdf,
            
            /// <summary>
            /// Enum Presentation for "Presentation"
            /// </summary>            
            Presentation,
            
            /// <summary>
            /// Enum Spreadsheet for "Spreadsheet"
            /// </summary>            
            Spreadsheet,
            
            /// <summary>
            /// Enum WordProcessing for "WordProcessing"
            /// </summary>            
            WordProcessing            
        }

        /// <summary>
        /// Specifies the signature type of processing
        /// </summary>
        /// <value>Specifies the signature type of processing</value>
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
        /// Specifies the type of document to process
        /// </summary>
        public DocumentTypeEnum? DocumentType { get; set; }

        /// <summary>
        /// Specifies the signature type of processing
        /// </summary>
        public SignatureTypeEnum? SignatureType { get; set; }

        /// <summary>
        /// Gets or sets a document page number for processing. Value is optional
        /// </summary>  
        public int? Page { get; set; }

        /// <summary>
        /// Process all document pages. Type of processing depends on SignatureType For Images Document Type it can be used only for multi-frames images like .tiff
        /// </summary>  
        public bool? AllPages { get; set; }

        /// <summary>
        /// Options to specify pages for processing
        /// </summary>  
        public PagesSetup PagesSetup { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OptionsBase {\n");
          sb.Append("  DocumentType: ").Append(this.DocumentType).Append("\n");
          sb.Append("  SignatureType: ").Append(this.SignatureType).Append("\n");
          sb.Append("  Page: ").Append(this.Page).Append("\n");
          sb.Append("  AllPages: ").Append(this.AllPages).Append("\n");
          sb.Append("  PagesSetup: ").Append(this.PagesSetup).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
