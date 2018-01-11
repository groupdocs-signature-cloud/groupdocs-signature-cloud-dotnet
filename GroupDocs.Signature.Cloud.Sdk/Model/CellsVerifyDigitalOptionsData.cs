// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CellsVerifyDigitalOptionsData.cs">
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
  /// Cells Verify Digital Options - keeps options to verify Digital Signature of Cells Documents
  /// </summary>  
  public class CellsVerifyDigitalOptionsData : VerifyDigitalOptionsData 
  {                       
        /// <summary>
        /// Comments of Digital Signature to validate
        /// </summary>  
        public string Comments { get; set; }

        /// <summary>
        /// Date and time range of Digital Signature to validate. Nullable value will be ignored.
        /// </summary>  
        public DateTime? SignDateTimeFrom { get; set; }

        /// <summary>
        /// Date and time range of Digital Signature to validate. Nullable value will be ignored.
        /// </summary>  
        public DateTime? SignDateTimeTo { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsVerifyDigitalOptionsData {\n");
          sb.Append("  Comments: ").Append(this.Comments).Append("\n");
          sb.Append("  SignDateTimeFrom: ").Append(this.SignDateTimeFrom).Append("\n");
          sb.Append("  SignDateTimeTo: ").Append(this.SignDateTimeTo).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
