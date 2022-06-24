// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PreviewSettings.cs">
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
    /// Defines preview request settings
    /// </summary>  
    public class PreviewSettings : BaseSettings 
    {                       
        /// <summary>
        /// Preview format
        /// </summary>
        /// <value>Preview format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PreviewFormatEnum
        { 
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>            
            PNG,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>            
            JPEG,
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>            
            BMP            
        }

        /// <summary>
        /// Preview format
        /// </summary>
        public PreviewFormatEnum? PreviewFormat { get; set; }

        /// <summary>
        /// Preview images width
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Preview images height
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Preview page numbers
        /// </summary>  
        public List<int?> PageNumbers { get; set; }

        /// <summary>
        /// Flag to hide signatures from page preview image. Only signatures are marked as IsSignature will be hidden from generated document page image
        /// </summary>  
        public bool? HideSignatures { get; set; }

        /// <summary>
        /// Set path for output pages. If not set then default path used.
        /// </summary>  
        public string OutputPath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PreviewSettings {\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  PageNumbers: ").Append(this.PageNumbers).Append("\n");
          sb.Append("  PreviewFormat: ").Append(this.PreviewFormat).Append("\n");
          sb.Append("  HideSignatures: ").Append(this.HideSignatures).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
