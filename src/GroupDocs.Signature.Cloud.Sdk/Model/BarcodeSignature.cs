// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="BarcodeSignature.cs">
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
    /// Contains Barcode signature properties
    /// </summary>  
    public class BarcodeSignature : Signature 
    {                       
        /// <summary>
        /// Specifies the Barcode type
        /// </summary>  
        public string BarcodeType { get; set; }

        /// <summary>
        /// Specifies text of Bar-code
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Specifies the format of Barcode signature image.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BarcodeSignature {\n");
          sb.Append("  BarcodeType: ").Append(this.BarcodeType).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
