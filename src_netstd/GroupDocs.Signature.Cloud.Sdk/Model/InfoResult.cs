// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoResult.cs">
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
    /// Document info result
    /// </summary>
    [DataContract]
    public partial class InfoResult
    {
        /// <summary>
        /// File info
        /// </summary>
        /// <value>File info</value>
        [DataMember(Name="FileInfo", EmitDefaultValue=false)]
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Document extension
        /// </summary>
        /// <value>Document extension</value>
        [DataMember(Name="Extension", EmitDefaultValue=false)]
        public string Extension { get; set; }

        /// <summary>
        /// Document file format
        /// </summary>
        /// <value>Document file format</value>
        [DataMember(Name="FileFormat", EmitDefaultValue=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// Document size in bytes
        /// </summary>
        /// <value>Document size in bytes</value>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Count of pages in document
        /// </summary>
        /// <value>Count of pages in document</value>
        [DataMember(Name="PagesCount", EmitDefaultValue=false)]
        public int? PagesCount { get; set; }

        /// <summary>
        /// Document created date
        /// </summary>
        /// <value>Document created date</value>
        [DataMember(Name="DateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Document modification date
        /// </summary>
        /// <value>Document modification date</value>
        [DataMember(Name="DateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Specifies width for max height of document page
        /// </summary>
        /// <value>Specifies width for max height of document page</value>
        [DataMember(Name="WidthForMaxHeight", EmitDefaultValue=false)]
        public int? WidthForMaxHeight { get; set; }

        /// <summary>
        /// Specifies max page height
        /// </summary>
        /// <value>Specifies max page height</value>
        [DataMember(Name="MaxPageHeight", EmitDefaultValue=false)]
        public int? MaxPageHeight { get; set; }

        /// <summary>
        /// List of document pages descriptions
        /// </summary>
        /// <value>List of document pages descriptions</value>
        [DataMember(Name="Pages", EmitDefaultValue=false)]
        public List<PageInfo> Pages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoResult {\n");
            sb.Append("  FileInfo: ").Append(FileInfo).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  PagesCount: ").Append(PagesCount).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  WidthForMaxHeight: ").Append(WidthForMaxHeight).Append("\n");
            sb.Append("  MaxPageHeight: ").Append(MaxPageHeight).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
