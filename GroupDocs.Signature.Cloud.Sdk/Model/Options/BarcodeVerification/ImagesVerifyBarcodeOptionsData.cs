// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImagesVerifyBarcodeOptionsData.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  /// Represents the Barcode Verify Options for Images Documents.
  /// </summary>  
  public class ImagesVerifyBarcodeOptionsData : VerifyBarcodeOptionsData 
  {                       
        /// <summary>
        /// Gets or sets document page number for verifying. This property can only be used for multi-frames image formats (Tiff). Minimal value is 1.
        /// </summary>  
        public int? DocumentPageNumber { get; set; }

        /// <summary>
        /// Options to specify pages to be verified. This property can only be used for multi-frames image formats (Tiff).
        /// </summary>  
        public PagesSetupData PagesSetup { get; set; }

        /// <summary>
        /// Verify all document pages. This property can only be used for multi-frames image formats (Tiff).
        /// </summary>  
        public bool? VerifyAllPages { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImagesVerifyBarcodeOptionsData {\n");
          sb.Append("  DocumentPageNumber: ").Append(this.DocumentPageNumber).Append("\n");
          sb.Append("  PagesSetup: ").Append(this.PagesSetup).Append("\n");
          sb.Append("  VerifyAllPages: ").Append(this.VerifyAllPages).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}