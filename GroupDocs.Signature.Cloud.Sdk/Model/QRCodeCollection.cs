// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="QRCodeCollection.cs">
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
    /// Describes collection of supported QRCode types.
    /// </summary>  
    public class QRCodeCollection
    {
        #region Static properties

        static QRCodeCollection()
        {
            Aztec = "Aztec";
            DataMatrix = "DataMatrix";
            GS1DataMatrix = "GS1DataMatrix";
            GS1QR = "GS1QR";
            QR = "QR";
        }

        /// <summary>
        /// Gets a predefined QRCode name for Aztec QRCode Type object.
        /// </summary>
        public static string Aztec { get; private set; }

        /// <summary>
        /// Gets a predefined QRCode name for DataMatrix QRCode Type object.
        /// </summary>
        public static string DataMatrix { get; private set; }

        /// <summary>
        /// Gets a predefined QRCode name for GS1DataMatrix QRCode Type object.
        /// </summary>
        public static string GS1DataMatrix { get; private set; }

        /// <summary>
        /// Gets a predefined QRCode name for GS1QR QRCode Type object.
        /// </summary>
        public static string GS1QR { get; private set; }

        /// <summary>
        /// Gets a predefined QRCode name for QR QRCode Type object.
        /// </summary>
        public static string QR { get; private set; }
        
        #endregion

        /// <summary>
        /// List of QRCode Types.
        /// </summary>  
        public List<QRCodeType> QRCodeTypes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QRCodeCollection {\n");
            sb.Append("  QRCodeTypes: ").Append(this.QRCodeTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}