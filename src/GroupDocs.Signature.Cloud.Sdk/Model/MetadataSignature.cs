// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="MetadataSignature.cs">
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
    /// Contains Metadata signature properties.
    /// </summary>  
    public class MetadataSignature : Signature 
    {                       
        /// <summary>
        /// Specifies metadata type.
        /// </summary>
        /// <value>Specifies metadata type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Certificate for "Certificate"
            /// </summary>            
            Certificate,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image,
            
            /// <summary>
            /// Enum Pdf for "Pdf"
            /// </summary>            
            Pdf,
            
            /// <summary>
            /// Enum Presentation for "Presentation"
            /// </summary>            
            Presentation,
            
            /// <summary>
            /// Enum Spreadsheet for "Spreadsheet"
            /// </summary>            
            Spreadsheet,
            
            /// <summary>
            /// Enum WordProcessing for "WordProcessing"
            /// </summary>            
            WordProcessing            
        }

        /// <summary>
        /// Specifies metadata value type.
        /// </summary>
        /// <value>Specifies metadata value type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataTypeEnum
        { 
            /// <summary>
            /// Enum Undefined for "Undefined"
            /// </summary>            
            Undefined,
            
            /// <summary>
            /// Enum Boolean for "Boolean"
            /// </summary>            
            Boolean,
            
            /// <summary>
            /// Enum Integer for "Integer"
            /// </summary>            
            Integer,
            
            /// <summary>
            /// Enum Double for "Double"
            /// </summary>            
            Double,
            
            /// <summary>
            /// Enum DateTime for "DateTime"
            /// </summary>            
            DateTime,
            
            /// <summary>
            /// Enum String for "String"
            /// </summary>            
            String            
        }

        /// <summary>
        /// Specifies metadata type.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Specifies metadata value type.
        /// </summary>
        public DataTypeEnum? DataType { get; set; }

        /// <summary>
        /// Specifies metadata object value
        /// </summary>  
        public string Value { get; set; }

        /// <summary>
        /// Specifies unique metadata name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The identifier of Image Metadata signature. See GroupDocs.Signature.Domain.ImageMetadataSignatures class that contains standard Signature with predefined Id value.
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Size of  Image Metadata value
        /// </summary>  
        public int? Size { get; set; }

        /// <summary>
        /// Description for standard Image Metadata signature
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// The prefix tag of Pdf Metadata signature name. By default this property is set to \"xmp\". Possible values are
        /// </summary>  
        public string TagPrefix { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MetadataSignature {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  DataType: ").Append(this.DataType).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  Description: ").Append(this.Description).Append("\n");
          sb.Append("  TagPrefix: ").Append(this.TagPrefix).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
