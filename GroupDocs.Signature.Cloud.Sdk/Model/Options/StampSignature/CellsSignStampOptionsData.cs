// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CellsSignStampOptionsData.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  /// Represents the Stamp Signature Options for Cells Documents.
  /// </summary>  
  public class CellsSignStampOptionsData : SignStampOptionsData 
  {                       
        /// <summary>
        /// Measure type (pixels or percent) for Left and Top properties. This property is obsolete.
        /// </summary>
        /// <value>Measure type (pixels or percent) for Left and Top properties. This property is obsolete.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocationMeasureTypeEnum
        { 
            /// <summary>
            /// Enum Pixels for "Pixels"
            /// </summary>            
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>            
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>            
            Millimeters            
        }

        /// <summary>
        /// Measure type (pixels or percent) for Width and Height properties. This property is obsolete.
        /// </summary>
        /// <value>Measure type (pixels or percent) for Width and Height properties. This property is obsolete.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeMeasureTypeEnum
        { 
            /// <summary>
            /// Enum Pixels for "Pixels"
            /// </summary>            
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>            
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>            
            Millimeters            
        }

        /// <summary>
        /// Gets or sets the measure type (pixels or percent) for Margin. This property is obsolete.
        /// </summary>
        /// <value>Gets or sets the measure type (pixels or percent) for Margin. This property is obsolete.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarginMeasureTypeEnum
        { 
            /// <summary>
            /// Enum Pixels for "Pixels"
            /// </summary>            
            Pixels,
            
            /// <summary>
            /// Enum Percents for "Percents"
            /// </summary>            
            Percents,
            
            /// <summary>
            /// Enum Millimeters for "Millimeters"
            /// </summary>            
            Millimeters            
        }

        /// <summary>
        /// Measure type (pixels or percent) for Left and Top properties. This property is obsolete.
        /// </summary>
        public LocationMeasureTypeEnum? LocationMeasureType { get; set; }

        /// <summary>
        /// Measure type (pixels or percent) for Width and Height properties. This property is obsolete.
        /// </summary>
        public SizeMeasureTypeEnum? SizeMeasureType { get; set; }

        /// <summary>
        /// Gets or sets the measure type (pixels or percent) for Margin. This property is obsolete.
        /// </summary>
        public MarginMeasureTypeEnum? MarginMeasureType { get; set; }

        /// <summary>
        /// Gets or sets worksheet number for signing. DocumentPageNumber parameter contains the same value.
        /// </summary>  
        public int? SheetNumber { get; set; }

        /// <summary>
        /// Gets or sets the top row number of signature (min value is 0). Top parameter contains the same value.
        /// </summary>  
        public int? RowNumber { get; set; }

        /// <summary>
        /// Gets or sets the left column number of signature (min value is 0). Left parameter contains the same value.
        /// </summary>  
        public int? ColumnNumber { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsSignStampOptionsData {\n");
          sb.Append("  SheetNumber: ").Append(this.SheetNumber).Append("\n");
          sb.Append("  RowNumber: ").Append(this.RowNumber).Append("\n");
          sb.Append("  ColumnNumber: ").Append(this.ColumnNumber).Append("\n");
          sb.Append("  LocationMeasureType: ").Append(this.LocationMeasureType).Append("\n");
          sb.Append("  SizeMeasureType: ").Append(this.SizeMeasureType).Append("\n");
          sb.Append("  MarginMeasureType: ").Append(this.MarginMeasureType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
