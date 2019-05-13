// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="OptionsBase.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using SwaggerDateConverter = GroupDocs.Signature.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Signature.Cloud.Sdk.Model
{
    /// <summary>
    /// Base container class for all possible options data
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SignQRCodeOptions), "SignQRCodeOptions")]
    [JsonSubtypes.KnownSubType(typeof(SignImageOptions), "SignImageOptions")]
    [JsonSubtypes.KnownSubType(typeof(VerifyTextOptions), "VerifyTextOptions")]
    [JsonSubtypes.KnownSubType(typeof(SignTextOptions), "SignTextOptions")]
    [JsonSubtypes.KnownSubType(typeof(SignStampOptions), "SignStampOptions")]
    [JsonSubtypes.KnownSubType(typeof(SearchOptions), "SearchOptions")]
    [JsonSubtypes.KnownSubType(typeof(VerifyDigitalOptions), "VerifyDigitalOptions")]
    [JsonSubtypes.KnownSubType(typeof(SearchQRCodeOptions), "SearchQRCodeOptions")]
    [JsonSubtypes.KnownSubType(typeof(SignBarcodeOptions), "SignBarcodeOptions")]
    [JsonSubtypes.KnownSubType(typeof(SearchDigitalOptions), "SearchDigitalOptions")]
    [JsonSubtypes.KnownSubType(typeof(VerifyOptions), "VerifyOptions")]
    [JsonSubtypes.KnownSubType(typeof(SignOptions), "SignOptions")]
    [JsonSubtypes.KnownSubType(typeof(SearchBarcodeOptions), "SearchBarcodeOptions")]
    [JsonSubtypes.KnownSubType(typeof(VerifyBarcodeOptions), "VerifyBarcodeOptions")]
    [JsonSubtypes.KnownSubType(typeof(SignDigitalOptions), "SignDigitalOptions")]
    [JsonSubtypes.KnownSubType(typeof(VerifyQRCodeOptions), "VerifyQRCodeOptions")]
    public partial class OptionsBase
    {
        /// <summary>
        /// Specifies the type of document to process
        /// </summary>
        /// <value>Specifies the type of document to process</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        {
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>
            [EnumMember(Value = "Image")]
            Image,
            
            /// <summary>
            /// Enum Pdf for "Pdf"
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf,
            
            /// <summary>
            /// Enum Presentation for "Presentation"
            /// </summary>
            [EnumMember(Value = "Presentation")]
            Presentation,
            
            /// <summary>
            /// Enum Spreadsheet for "Spreadsheet"
            /// </summary>
            [EnumMember(Value = "Spreadsheet")]
            Spreadsheet,
            
            /// <summary>
            /// Enum WordProcessing for "WordProcessing"
            /// </summary>
            [EnumMember(Value = "WordProcessing")]
            WordProcessing
        }

        /// <summary>
        /// Specifies the type of document to process
        /// </summary>
        /// <value>Specifies the type of document to process</value>
        [DataMember(Name="DocumentType", EmitDefaultValue=false)]
        public DocumentTypeEnum DocumentType { get; set; }
        /// <summary>
        /// Specifies the signature type of processing
        /// </summary>
        /// <value>Specifies the signature type of processing</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>
            [EnumMember(Value = "Image")]
            Image,
            
            /// <summary>
            /// Enum Digital for "Digital"
            /// </summary>
            [EnumMember(Value = "Digital")]
            Digital,
            
            /// <summary>
            /// Enum Barcode for "Barcode"
            /// </summary>
            [EnumMember(Value = "Barcode")]
            Barcode,
            
            /// <summary>
            /// Enum QRCode for "QRCode"
            /// </summary>
            [EnumMember(Value = "QRCode")]
            QRCode,
            
            /// <summary>
            /// Enum Stamp for "Stamp"
            /// </summary>
            [EnumMember(Value = "Stamp")]
            Stamp
        }

        /// <summary>
        /// Specifies the signature type of processing
        /// </summary>
        /// <value>Specifies the signature type of processing</value>
        [DataMember(Name="SignatureType", EmitDefaultValue=false)]
        public SignatureTypeEnum SignatureType { get; set; }


        /// <summary>
        /// Gets or sets a document page number for processing. Value is optional
        /// </summary>
        /// <value>Gets or sets a document page number for processing. Value is optional</value>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Process all document pages. Type of processing depends on SignatureType For Images Document Type it can be used only for multi-frames images like .tiff
        /// </summary>
        /// <value>Process all document pages. Type of processing depends on SignatureType For Images Document Type it can be used only for multi-frames images like .tiff</value>
        [DataMember(Name="AllPages", EmitDefaultValue=false)]
        public bool? AllPages { get; set; }

        /// <summary>
        /// Options to specify pages for processing
        /// </summary>
        /// <value>Options to specify pages for processing</value>
        [DataMember(Name="PagesSetup", EmitDefaultValue=false)]
        public PagesSetup PagesSetup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsBase {\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  AllPages: ").Append(AllPages).Append("\n");
            sb.Append("  PagesSetup: ").Append(PagesSetup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
