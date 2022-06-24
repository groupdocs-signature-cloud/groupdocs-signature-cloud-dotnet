// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SignStampOptions.cs">
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
    /// Represents the Stamp signature options
    /// </summary>  
    public class SignStampOptions : SignImageOptions 
    {                       
        /// <summary>
        /// Gets or sets the background color crop type of signature
        /// </summary>
        /// <value>Gets or sets the background color crop type of signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackgroundColorCropTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum OuterArea for "OuterArea"
            /// </summary>            
            OuterArea,
            
            /// <summary>
            /// Enum MiddleArea for "MiddleArea"
            /// </summary>            
            MiddleArea,
            
            /// <summary>
            /// Enum InnerArea for "InnerArea"
            /// </summary>            
            InnerArea            
        }

        /// <summary>
        /// Gets or sets the background image crop type of signature
        /// </summary>
        /// <value>Gets or sets the background image crop type of signature</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackgroundImageCropTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum OuterArea for "OuterArea"
            /// </summary>            
            OuterArea,
            
            /// <summary>
            /// Enum MiddleArea for "MiddleArea"
            /// </summary>            
            MiddleArea,
            
            /// <summary>
            /// Enum InnerArea for "InnerArea"
            /// </summary>            
            InnerArea            
        }

        /// <summary>
        /// Gets or sets the background color crop type of signature
        /// </summary>
        public BackgroundColorCropTypeEnum? BackgroundColorCropType { get; set; }

        /// <summary>
        /// Gets or sets the background image crop type of signature
        /// </summary>
        public BackgroundImageCropTypeEnum? BackgroundImageCropType { get; set; }

        /// <summary>
        /// List of Outer Lines rendered as concentric circles
        /// </summary>  
        public List<StampLine> OuterLines { get; set; }

        /// <summary>
        /// List of Inner Lines rendered as set of rectangles
        /// </summary>  
        public List<StampLine> InnerLines { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature
        /// </summary>  
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the signature background brush. Value by default is null.  When property has a value it is used instead BackgroundBrush property
        /// </summary>  
        public Brush BackgroundBrush { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SignStampOptions {\n");
          sb.Append("  OuterLines: ").Append(this.OuterLines).Append("\n");
          sb.Append("  InnerLines: ").Append(this.InnerLines).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  BackgroundBrush: ").Append(this.BackgroundBrush).Append("\n");
          sb.Append("  BackgroundColorCropType: ").Append(this.BackgroundColorCropType).Append("\n");
          sb.Append("  BackgroundImageCropType: ").Append(this.BackgroundImageCropType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
