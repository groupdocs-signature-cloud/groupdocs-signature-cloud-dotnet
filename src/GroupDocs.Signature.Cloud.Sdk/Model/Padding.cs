// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Padding.cs">
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
    /// Represents padding or margin information associated with element
    /// </summary>  
    public class Padding 
    {                       
        /// <summary>
        /// Gets or sets the padding value for all the edges
        /// </summary>  
        public int? All { get; set; }

        /// <summary>
        /// Gets or sets the padding value for the left edge
        /// </summary>  
        public int? Left { get; set; }

        /// <summary>
        /// Gets or sets the padding value for the top edge
        /// </summary>  
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets the padding value for the right edge
        /// </summary>  
        public int? Right { get; set; }

        /// <summary>
        /// Gets or sets the padding value for the bottom edge
        /// </summary>  
        public int? Bottom { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Padding {\n");
          sb.Append("  All: ").Append(this.All).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Right: ").Append(this.Right).Append("\n");
          sb.Append("  Bottom: ").Append(this.Bottom).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
