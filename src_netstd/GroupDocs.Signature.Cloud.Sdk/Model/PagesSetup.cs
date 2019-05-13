// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PagesSetup.cs">
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
    /// Describes special pages of document to process
    /// </summary>
    [DataContract]
    public partial class PagesSetup
    {
        /// <summary>
        /// Get or set flag to use first document page
        /// </summary>
        /// <value>Get or set flag to use first document page</value>
        [DataMember(Name="FirstPage", EmitDefaultValue=false)]
        public bool? FirstPage { get; set; }

        /// <summary>
        /// Get or set flag to use last document page
        /// </summary>
        /// <value>Get or set flag to use last document page</value>
        [DataMember(Name="LastPage", EmitDefaultValue=false)]
        public bool? LastPage { get; set; }

        /// <summary>
        /// Get or set flag to use odd pages of document
        /// </summary>
        /// <value>Get or set flag to use odd pages of document</value>
        [DataMember(Name="OddPages", EmitDefaultValue=false)]
        public bool? OddPages { get; set; }

        /// <summary>
        /// Get or set flag to use even pages of document
        /// </summary>
        /// <value>Get or set flag to use even pages of document</value>
        [DataMember(Name="EvenPages", EmitDefaultValue=false)]
        public bool? EvenPages { get; set; }

        /// <summary>
        /// Set arbitrary pages of document to use
        /// </summary>
        /// <value>Set arbitrary pages of document to use</value>
        [DataMember(Name="PageNumbers", EmitDefaultValue=false)]
        public List<int?> PageNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagesSetup {\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
            sb.Append("  OddPages: ").Append(OddPages).Append("\n");
            sb.Append("  EvenPages: ").Append(EvenPages).Append("\n");
            sb.Append("  PageNumbers: ").Append(PageNumbers).Append("\n");
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
