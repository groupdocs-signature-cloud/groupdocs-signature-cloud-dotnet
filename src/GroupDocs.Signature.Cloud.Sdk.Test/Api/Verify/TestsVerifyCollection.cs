// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Signature.Cloud.Sdk.Model;
using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api.Verify
{
    public class TestsVerifyCollection : BaseApiTest
    {
        [Test]
        public void VerifyCollectionImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\ImageCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new VerifyBarcodeOptions();
            TestsVerifyBarcode.PopulateOptions(optionsBarcode);

            //Digital verification is not supported for images

            var optionsQrCode = new VerifyQRCodeOptions();
            TestsVerifyQrCode.PopulateOptions(optionsQrCode);

            //Text verification is not supported for images

            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { optionsBarcode, optionsQrCode };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignatureApi.VerifySignatures(request);
            CheckResponse(response, testFile);

        }

        [Test]
        public void VerifyCollectionPdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PdfCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new VerifyBarcodeOptions();
            TestsVerifyBarcode.PopulateOptions(optionsBarcode);

            var optionsQrCode = new VerifyQRCodeOptions();
            TestsVerifyQrCode.PopulateOptions(optionsQrCode);

            var optionsDigital = new VerifyDigitalOptions();
            TestsVerifyDigital.PopulateOptions(optionsDigital);

            var optionsText = new VerifyTextOptions();
            TestsVerifyText.PopulateOptions(optionsText);

            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { optionsBarcode, optionsQrCode, optionsDigital, optionsText };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignatureApi.VerifySignatures(request);
            CheckResponse(response, testFile);

        }

        [Test]
        public void VerifyCollectionPresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PresentationCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new VerifyBarcodeOptions();
            TestsVerifyBarcode.PopulateOptions(optionsBarcode);

            //Digital verification is not supported for presentations

            var optionsQrCode = new VerifyQRCodeOptions();
            TestsVerifyQrCode.PopulateOptions(optionsQrCode);

            var optionsText = new VerifyTextOptions();
            TestsVerifyText.PopulateOptions(optionsText);

            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { optionsBarcode, optionsQrCode, optionsText };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignatureApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        [Test]
        public void VerifyCollectionSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\SpreadsheetCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new VerifyBarcodeOptions();
            TestsVerifyBarcode.PopulateOptions(optionsBarcode);

            var optionsQrCode = new VerifyQRCodeOptions();
            TestsVerifyQrCode.PopulateOptions(optionsQrCode);

            var optionsDigital = new VerifyDigitalOptions();
            TestsVerifyDigital.PopulateOptions(optionsDigital);

            var optionsText = new VerifyTextOptions();
            TestsVerifyText.PopulateOptions(optionsText);

            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { optionsBarcode, optionsQrCode, optionsDigital, optionsText };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignatureApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        [Test]
        public void VerifyCollectionWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\WordProcessingStorageCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new VerifyBarcodeOptions();
            TestsVerifyBarcode.PopulateOptions(optionsBarcode);

            var optionsQrCode = new VerifyQRCodeOptions();
            TestsVerifyQrCode.PopulateOptions(optionsQrCode);

            var optionsDigital = new VerifyDigitalOptions();
            TestsVerifyDigital.PopulateOptions(optionsDigital);

            var optionsText = new VerifyTextOptions();
            TestsVerifyText.PopulateOptions(optionsText);

            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { optionsBarcode, optionsQrCode, optionsDigital, optionsText };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignatureApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        protected void CheckResponse(VerifyResult result, TestFile testFile)
        {
            Assert.NotNull(result, "Result is empty.");
            Assert.AreEqual(true, result.IsSuccess, "Result is not true.");
            Assert.AreEqual(result.Size, testFile.Size, "Wrong size.");
            Assert.NotNull(result.FileInfo, "FileInfo is null.");
            Assert.NotNull(String.IsNullOrEmpty(result.FileInfo?.FilePath), "FileInfo FilePath is empty.");
            Assert.AreEqual(testFile.Path, result.FileInfo?.FilePath, "FileInfo FilePath is wrong.");
        }
    }
}
