// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageAppearance.cs">
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
    /// Describes extended appearance features for Image Signature.
    /// </summary>  
    public class ImageAppearance : SignatureAppearance 
    {                       
        /// <summary>
        /// Gets or sets image brightness. Default value is 1 it corresponds to original brightness of image.
        /// </summary>  
        public double? Brightness { get; set; }

        /// <summary>
        /// Gets or sets image contrast. Default value is 1 it corresponds to original contrast of image.
        /// </summary>  
        public double? Contrast { get; set; }

        /// <summary>
        /// Gets or sets image gamma. Default value is 1 it corresponds to original gamma of image.
        /// </summary>  
        public double? GammaCorrection { get; set; }

        /// <summary>
        /// Setup this flag to true if gray-scale filter is required.
        /// </summary>  
        public bool? Grayscale { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImageAppearance {\n");
          sb.Append("  Brightness: ").Append(this.Brightness).Append("\n");
          sb.Append("  Contrast: ").Append(this.Contrast).Append("\n");
          sb.Append("  GammaCorrection: ").Append(this.GammaCorrection).Append("\n");
          sb.Append("  Grayscale: ").Append(this.Grayscale).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
