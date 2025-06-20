// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="LinearGradientBrush.cs">
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
    /// Represents linear gradient brush
    /// </summary>  
    public class LinearGradientBrush : Brush 
    {                       
        /// <summary>
        /// Gets or sets start gradient color
        /// </summary>  
        public Color StartColor { get; set; }

        /// <summary>
        /// Gets or sets finish gradient color
        /// </summary>  
        public Color EndColor { get; set; }

        /// <summary>
        /// Gets or sets gradient angle
        /// </summary>  
        public double? Angle { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LinearGradientBrush {\n");
          sb.Append("  StartColor: ").Append(this.StartColor).Append("\n");
          sb.Append("  EndColor: ").Append(this.EndColor).Append("\n");
          sb.Append("  Angle: ").Append(this.Angle).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
