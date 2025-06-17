// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfTextStickerAppearance.cs">
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
    /// Describes appearance of PDF text annotation sticker object and pop-up window of sticker.
    /// </summary>  
    public class PdfTextStickerAppearance : SignatureAppearance 
    {                       
        /// <summary>
        /// Gets or sets the icon of sticker.
        /// </summary>
        /// <value>Gets or sets the icon of sticker.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IconEnum
        { 
            /// <summary>
            /// Enum Note for "Note"
            /// </summary>            
            Note,
            
            /// <summary>
            /// Enum Comment for "Comment"
            /// </summary>            
            Comment,
            
            /// <summary>
            /// Enum Key for "Key"
            /// </summary>            
            Key,
            
            /// <summary>
            /// Enum Help for "Help"
            /// </summary>            
            Help,
            
            /// <summary>
            /// Enum NewParagraph for "NewParagraph"
            /// </summary>            
            NewParagraph,
            
            /// <summary>
            /// Enum Paragraph for "Paragraph"
            /// </summary>            
            Paragraph,
            
            /// <summary>
            /// Enum Insert for "Insert"
            /// </summary>            
            Insert,
            
            /// <summary>
            /// Enum Check for "Check"
            /// </summary>            
            Check,
            
            /// <summary>
            /// Enum Cross for "Cross"
            /// </summary>            
            Cross,
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>            
            Circle,
            
            /// <summary>
            /// Enum Star for "Star"
            /// </summary>            
            Star            
        }

        /// <summary>
        /// Gets or sets the icon of sticker.
        /// </summary>
        public IconEnum? Icon { get; set; }

        /// <summary>
        /// Gets or sets the contents of pop-up window.
        /// </summary>  
        public string Contents { get; set; }

        /// <summary>
        /// Setup if sticker pop-up window will be opened by default.
        /// </summary>  
        public bool? Opened { get; set; }

        /// <summary>
        /// Gets or sets subject.
        /// </summary>  
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets title of pop-up window.
        /// </summary>  
        public string Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfTextStickerAppearance {\n");
          sb.Append("  Contents: ").Append(this.Contents).Append("\n");
          sb.Append("  Icon: ").Append(this.Icon).Append("\n");
          sb.Append("  Opened: ").Append(this.Opened).Append("\n");
          sb.Append("  Subject: ").Append(this.Subject).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
