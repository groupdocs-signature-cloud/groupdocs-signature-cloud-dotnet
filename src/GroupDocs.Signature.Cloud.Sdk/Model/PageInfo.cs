// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PageInfo.cs">
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
    /// Page information
    /// </summary>  
    public class PageInfo 
    {                       
        /// <summary>
        /// Page number
        /// </summary>  
        public int? Number { get; set; }

        /// <summary>
        /// Page name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Page width
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Page height
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Page angle
        /// </summary>  
        public int? Angle { get; set; }

        /// <summary>
        /// Page visibility
        /// </summary>  
        public bool? Visible { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageInfo {\n");
          sb.Append("  Number: ").Append(this.Number).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Angle: ").Append(this.Angle).Append("\n");
          sb.Append("  Visible: ").Append(this.Visible).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
