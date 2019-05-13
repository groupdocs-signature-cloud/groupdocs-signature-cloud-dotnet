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
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Verify
{
    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using static GroupDocs.Signature.Cloud.Sdk.Model.OptionsBase;

    public class TestsVerifyBarcode : BaseApiTest
    {
        [Test]
        public void VerifyBarcodeImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new VerifyBarcodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Image;
            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { options };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        [Test]
        public void VerifyBarcodePdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new VerifyBarcodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Pdf;
            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { options };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        [Test]
        public void VerifyBarcodePresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new VerifyBarcodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Presentation;
            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { options };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        [Test]
        public void VerifyBarcodeSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new VerifyBarcodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Spreadsheet;
            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { options };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        [Test]
        public void VerifyBarcodeWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new VerifyBarcodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.WordProcessing;
            var verifySettings = new VerifySettings();
            verifySettings.FileInfo = fileInfo;
            verifySettings.Options = new List<VerifyOptions>() { options };
            var request = new VerifySignaturesRequest(verifySettings);

            // Get and check result 
            var response = SignApi.VerifySignatures(request);
            CheckResponse(response, testFile);
        }

        public static void PopulateOptions(VerifyBarcodeOptions options)
        {
            options.Page = 1;
            options.AllPages = true;
            options.PagesSetup = new PagesSetup()
            {
                EvenPages = false,
                FirstPage = true,
                LastPage = false,
                OddPages = false,
                PageNumbers = new List<int?>() { 1 }
            };
            options.SignatureType = SignatureTypeEnum.Barcode;
            options.BarcodeType = "Code39Standard";
            options.Text = "123456789012";
            options.MatchType = VerifyBarcodeOptions.MatchTypeEnum.Contains;
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
