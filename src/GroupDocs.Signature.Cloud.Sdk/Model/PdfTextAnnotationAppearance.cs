// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfTextAnnotationAppearance.cs">
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
    /// Describes appearance of PDF text annotation object (Title, Subject, Content).
    /// </summary>  
    public class PdfTextAnnotationAppearance : SignatureAppearance 
    {                       
        /// <summary>
        /// Gets or sets border effect.
        /// </summary>
        /// <value>Gets or sets border effect.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderEffectEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Cloudy for "Cloudy"
            /// </summary>            
            Cloudy            
        }

        /// <summary>
        /// Gets or sets border effect.
        /// </summary>
        public BorderEffectEnum? BorderEffect { get; set; }

        /// <summary>
        /// Represents border appearance
        /// </summary>  
        public BorderLine Border { get; set; }

        /// <summary>
        /// Gets or sets border effect intensity. Valid range of value is [0..2].
        /// </summary>  
        public int? BorderEffectIntensity { get; set; }

        /// <summary>
        /// Gets or sets content of annotation object.
        /// </summary>  
        public string Contents { get; set; }

        /// <summary>
        /// Gets or sets horizontal corner radius.
        /// </summary>  
        public int? HCornerRadius { get; set; }

        /// <summary>
        /// Gets or sets Subject representing description of the object.
        /// </summary>  
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets a Title that will be displayed in title bar of annotation object.
        /// </summary>  
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets vertical corner radius.
        /// </summary>  
        public int? VCornerRadius { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfTextAnnotationAppearance {\n");
          sb.Append("  Border: ").Append(this.Border).Append("\n");
          sb.Append("  BorderEffect: ").Append(this.BorderEffect).Append("\n");
          sb.Append("  BorderEffectIntensity: ").Append(this.BorderEffectIntensity).Append("\n");
          sb.Append("  Contents: ").Append(this.Contents).Append("\n");
          sb.Append("  HCornerRadius: ").Append(this.HCornerRadius).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("  VCornerRadius: ").Append(this.VCornerRadius).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
