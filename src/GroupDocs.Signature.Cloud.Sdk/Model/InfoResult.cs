// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoResult.cs">
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
    /// Document info result
    /// </summary>  
    public class InfoResult 
    {                       
        /// <summary>
        /// Input File info
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Document extension
        /// </summary>  
        public string Extension { get; set; }

        /// <summary>
        /// Document file format
        /// </summary>  
        public string FileFormat { get; set; }

        /// <summary>
        /// Document size in bytes
        /// </summary>  
        public long? Size { get; set; }

        /// <summary>
        /// Count of pages in document
        /// </summary>  
        public int? PagesCount { get; set; }

        /// <summary>
        /// Document created date
        /// </summary>  
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Document modification date
        /// </summary>  
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Specifies width for max height of document page
        /// </summary>  
        public int? WidthForMaxHeight { get; set; }

        /// <summary>
        /// Specifies max page height
        /// </summary>  
        public int? MaxPageHeight { get; set; }

        /// <summary>
        /// List of document pages descriptions
        /// </summary>  
        public List<PageInfo> Pages { get; set; }

        /// <summary>
        /// Collection of document signatures
        /// </summary>  
        public List<Signature> Signatures { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class InfoResult {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  Extension: ").Append(this.Extension).Append("\n");
          sb.Append("  FileFormat: ").Append(this.FileFormat).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  PagesCount: ").Append(this.PagesCount).Append("\n");
          sb.Append("  DateCreated: ").Append(this.DateCreated).Append("\n");
          sb.Append("  DateModified: ").Append(this.DateModified).Append("\n");
          sb.Append("  WidthForMaxHeight: ").Append(this.WidthForMaxHeight).Append("\n");
          sb.Append("  MaxPageHeight: ").Append(this.MaxPageHeight).Append("\n");
          sb.Append("  Pages: ").Append(this.Pages).Append("\n");
          sb.Append("  Signatures: ").Append(this.Signatures).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
