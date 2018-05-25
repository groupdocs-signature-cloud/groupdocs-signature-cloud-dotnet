// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="BarcodeCollection.cs">
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
    /// Describes collection of supported Barcode types.
    /// </summary>  
    public class BarcodeCollection
    {
        #region Static properties
        static BarcodeCollection()
        {
            AustralianPosteParcel = "AustralianPosteParcel";
            AustralianPost = "AustralianPost";
            Codabar = "Codabar";
            CodablockF = "CodablockF";
            Code11 = "Code11";
            Code128 = "Code128";
            Code16K = "Code16K";
            Code32 = "Code32";
            Code39Standard = "Code39Standard";
            Code39Extended = "Code39Extended";
            Code93Extended = "Code93Extended";
            Code93Standard = "Code93Standard";
            DatabarExpanded = "DatabarExpanded";
            DatabarExpandedStacked = "DatabarExpandedStacked";
            DatabarLimited = "DatabarLimited";
            DatabarOmniDirectional = "DatabarOmniDirectional";
            DatabarStacked = "DatabarStacked";
            DatabarStackedOmniDirectional = "DatabarStackedOmniDirectional";
            DatabarTruncated = "DatabarTruncated";
            DataLogic2of5 = "DataLogic2of5";
            DeutschePostIdentcode = "DeutschePostIdentcode";
            DeutschePostLeitcode = "DeutschePostLeitcode";
            DotCode = "DotCode";
            DutchKIX = "DutchKIX";
            EAN8 = "EAN8";
            EAN13 = "EAN13";
            EAN14 = "EAN14";
            GS1CodablockF = "GS1CodablockF";
            GS1Code128 = "GS1Code128";
            IATA2of5 = "IATA2of5";
            Interleaved2of5 = "Interleaved2of5";
            ISBN = "ISBN";
            ISMN = "ISMN";
            ISSN = "ISSN";
            ItalianPost25 = "ItalianPost25";
            ITF14 = "ITF14";
            ITF6 = "ITF6";
            MacroPdf417 = "MacroPdf417";
            Matrix2of5 = "Matrix2of5";
            MaxiCode = "MaxiCode";
            MicroPdf417 = "MicroPdf417";
            MSI = "MSI";
            OneCode = "OneCode";
            OPC = "OPC";
            PatchCode = "PatchCode";
            Pdf417 = "Pdf417";
            Pharmacode = "Pharmacode";
            Planet = "Planet";
            Postnet = "Postnet";
            PZN = "PZN";
            RM4SCC = "RM4SCC";
            SCC14 = "SCC14";
            SingaporePost = "SingaporePost";
            SSCC18 = "SSCC18";
            Standard2of5 = "Standard2of5";
            SwissPostParcel = "SwissPostParcel";
            UPCA = "UPCA";
            UpcaGs1Code128Coupon = "UpcaGs1Code128Coupon";
            UpcaGs1DatabarCoupon = "UpcaGs1DatabarCoupon";
            UPCE = "UPCE";
            VIN = "VIN";
        }

        /// <summary>
        /// Gets a predefined Barcode name for AustralianPosteParcel Barcode Type object.
        /// </summary>
        public static string AustralianPosteParcel { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for AustralianPost Barcode Type object.
        /// </summary>
        public static string AustralianPost { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Codabar Barcode Type object.
        /// </summary>
        public static string Codabar { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for CodablockF Barcode Type object.
        /// </summary>
        public static string CodablockF { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code11 Barcode Type object.
        /// </summary>
        public static string Code11 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code128 Barcode Type object.
        /// </summary>
        public static string Code128 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code16K Barcode Type object.
        /// </summary>
        public static string Code16K { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code32 Barcode Type object.
        /// </summary>
        public static string Code32 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code39Standard Barcode Type object.
        /// </summary>
        public static string Code39Standard { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code39Extended Barcode Type object.
        /// </summary>
        public static string Code39Extended { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code93Extended Barcode Type object.
        /// </summary>
        public static string Code93Extended { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Code93Standard Barcode Type object.
        /// </summary>
        public static string Code93Standard { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarExpanded Barcode Type object.
        /// </summary>
        public static string DatabarExpanded { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarExpandedStacked Barcode Type object.
        /// </summary>
        public static string DatabarExpandedStacked { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarLimited Barcode Type object.
        /// </summary>
        public static string DatabarLimited { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarOmniDirectional Barcode Type object.
        /// </summary>
        public static string DatabarOmniDirectional { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarStacked Barcode Type object.
        /// </summary>
        public static string DatabarStacked { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarStackedOmniDirectional Barcode Type object.
        /// </summary>
        public static string DatabarStackedOmniDirectional { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DatabarTruncated Barcode Type object.
        /// </summary>
        public static string DatabarTruncated { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DataLogic2of5 Barcode Type object.
        /// </summary>
        public static string DataLogic2of5 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DeutschePostIdentcode Barcode Type object.
        /// </summary>
        public static string DeutschePostIdentcode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DeutschePostLeitcode Barcode Type object.
        /// </summary>
        public static string DeutschePostLeitcode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DotCode Barcode Type object.
        /// </summary>
        public static string DotCode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for DutchKIX Barcode Type object.
        /// </summary>
        public static string DutchKIX { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for EAN8 Barcode Type object.
        /// </summary>
        public static string EAN8 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for EAN13 Barcode Type object.
        /// </summary>
        public static string EAN13 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for EAN14 Barcode Type object.
        /// </summary>
        public static string EAN14 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for GS1CodablockF Barcode Type object.
        /// </summary>
        public static string GS1CodablockF { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for GS1Code128 Barcode Type object.
        /// </summary>
        public static string GS1Code128 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for IATA2of5 Barcode Type object.
        /// </summary>
        public static string IATA2of5 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Interleaved2of5 Barcode Type object.
        /// </summary>
        public static string Interleaved2of5 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for ISBN Barcode Type object.
        /// </summary>
        public static string ISBN { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for ISMN Barcode Type object.
        /// </summary>
        public static string ISMN { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for ISSN Barcode Type object.
        /// </summary>
        public static string ISSN { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for ItalianPost25 Barcode Type object.
        /// </summary>
        public static string ItalianPost25 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for ITF14 Barcode Type object.
        /// </summary>
        public static string ITF14 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for ITF6 Barcode Type object.
        /// </summary>
        public static string ITF6 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for MacroPdf417 Barcode Type object.
        /// </summary>
        public static string MacroPdf417 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Matrix2of5 Barcode Type object.
        /// </summary>
        public static string Matrix2of5 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for MaxiCode Barcode Type object.
        /// </summary>
        public static string MaxiCode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for MicroPdf417 Barcode Type object.
        /// </summary>
        public static string MicroPdf417 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for MSI Barcode Type object.
        /// </summary>
        public static string MSI { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for OneCode Barcode Type object.
        /// </summary>
        public static string OneCode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for OPC Barcode Type object.
        /// </summary>
        public static string OPC { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for PatchCode Barcode Type object.
        /// </summary>
        public static string PatchCode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Pdf417 Barcode Type object.
        /// </summary>
        public static string Pdf417 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Pharmacode Barcode Type object.
        /// </summary>
        public static string Pharmacode { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Planet Barcode Type object.
        /// </summary>
        public static string Planet { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Postnet Barcode Type object.
        /// </summary>
        public static string Postnet { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for PZN Barcode Type object.
        /// </summary>
        public static string PZN { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for RM4SCC Barcode Type object.
        /// </summary>
        public static string RM4SCC { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for SCC14 Barcode Type object.
        /// </summary>
        public static string SCC14 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for SingaporePost Barcode Type object.
        /// </summary>
        public static string SingaporePost { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for SSCC18 Barcode Type object.
        /// </summary>
        public static string SSCC18 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for Standard2of5 Barcode Type object.
        /// </summary>
        public static string Standard2of5 { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for SwissPostParcel Barcode Type object.
        /// </summary>
        public static string SwissPostParcel { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for UPCA Barcode Type object.
        /// </summary>
        public static string UPCA { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for UpcaGs1Code128Coupon Barcode Type object.
        /// </summary>
        public static string UpcaGs1Code128Coupon { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for UpcaGs1DatabarCoupon Barcode Type object.
        /// </summary>
        public static string UpcaGs1DatabarCoupon { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for UPCE Barcode Type object.
        /// </summary>
        public static string UPCE { get; private set; }

        /// <summary>
        /// Gets a predefined Barcode name for VIN Barcode Type object.
        /// </summary>
        public static string VIN { get; private set; }

        #endregion

        /// <summary>
        /// List of Barcode Types.
        /// </summary>  
        public List<BarcodeType> BarcodeTypes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeCollection {\n");
            sb.Append("  BarcodeTypes: ").Append(this.BarcodeTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}