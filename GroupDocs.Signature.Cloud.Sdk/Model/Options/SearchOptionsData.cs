// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchOptionsData.cs">
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
  /// Search Options - keeps options to Search document
  /// </summary>  
  public class SearchOptionsData 
  {                       
        /// <summary>
        /// Gets or sets Document page number for searching. Value is optional.
        /// </summary>  
        public int? DocumentPageNumber { get; set; }

        /// <summary>
        /// Options to specify pages for Signature searching.
        /// </summary>  
        public PagesSetupData PagesSetup { get; set; }

        /// <summary>
        /// Flag to search on each Document page.
        /// </summary>  
        public bool? SearchAllPages { get; set; }

        /// <summary>
        /// Internal property that specify the name of Options.
        /// </summary>  
        public string OptionsType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchOptionsData {\n");
          sb.Append("  DocumentPageNumber: ").Append(this.DocumentPageNumber).Append("\n");
          sb.Append("  PagesSetup: ").Append(this.PagesSetup).Append("\n");
          sb.Append("  SearchAllPages: ").Append(this.SearchAllPages).Append("\n");
          sb.Append("  OptionsType: ").Append(this.OptionsType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
