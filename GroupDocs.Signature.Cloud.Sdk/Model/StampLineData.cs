// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StampLineData.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
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
  /// Specify Stamp line properties.
  /// </summary>  
  public class StampLineData 
  {                       
        /// <summary>
        /// Gets or sets text repeat type.
        /// </summary>
        /// <value>Gets or sets text repeat type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextRepeatTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum FullTextRepeat for "FullTextRepeat"
            /// </summary>            
            FullTextRepeat,
            
            /// <summary>
            /// Enum RepeatWithTruncation for "RepeatWithTruncation"
            /// </summary>            
            RepeatWithTruncation            
        }

        /// <summary>
        /// Gets or sets text repeat type.
        /// </summary>
        public TextRepeatTypeEnum? TextRepeatType { get; set; }

        /// <summary>
        /// Gets or sets the line height on Stamp.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the background color of signature.
        /// </summary>  
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the text of stamp line.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Get or set Font of Stamp Line text.
        /// </summary>  
        public SignatureFontData Font { get; set; }

        /// <summary>
        /// Gets or sets the text color of signature.
        /// </summary>  
        public Color TextColor { get; set; }

        /// <summary>
        /// Gets or sets the bottom intent of text.
        /// </summary>  
        public int? TextBottomIntent { get; set; }

        /// <summary>
        /// Setup Outer Border.
        /// </summary>  
        public BorderLineData OuterBorder { get; set; }

        /// <summary>
        /// Setup Internal Border.
        /// </summary>  
        public BorderLineData InnerBorder { get; set; }

        /// <summary>
        /// Get and set visibility of Stamp Line.
        /// </summary>  
        public bool? Visible { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StampLineData {\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Font: ").Append(this.Font).Append("\n");
          sb.Append("  TextColor: ").Append(this.TextColor).Append("\n");
          sb.Append("  TextBottomIntent: ").Append(this.TextBottomIntent).Append("\n");
          sb.Append("  TextRepeatType: ").Append(this.TextRepeatType).Append("\n");
          sb.Append("  OuterBorder: ").Append(this.OuterBorder).Append("\n");
          sb.Append("  InnerBorder: ").Append(this.InnerBorder).Append("\n");
          sb.Append("  Visible: ").Append(this.Visible).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
