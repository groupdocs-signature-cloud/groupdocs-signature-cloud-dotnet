// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PagesSetupData.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
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
  /// Describes special pages of Document to work with
  /// </summary>  
  public class PagesSetupData 
  {                       
        /// <summary>
        /// Get or set flag to use first document page
        /// </summary>  
        public bool? FirstPage { get; set; }

        /// <summary>
        /// Get or set flag to use last document page
        /// </summary>  
        public bool? LastPage { get; set; }

        /// <summary>
        /// Get or set flag to use odd pages of document
        /// </summary>  
        public bool? OddPages { get; set; }

        /// <summary>
        /// Get or set flag to use even pages of document
        /// </summary>  
        public bool? EvenPages { get; set; }

        /// <summary>
        /// Set arbitrary pages of document to use
        /// </summary>  
        public List<int?> PageNumbers { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PagesSetupData {\n");
          sb.Append("  FirstPage: ").Append(this.FirstPage).Append("\n");
          sb.Append("  LastPage: ").Append(this.LastPage).Append("\n");
          sb.Append("  OddPages: ").Append(this.OddPages).Append("\n");
          sb.Append("  EvenPages: ").Append(this.EvenPages).Append("\n");
          sb.Append("  PageNumbers: ").Append(this.PageNumbers).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
