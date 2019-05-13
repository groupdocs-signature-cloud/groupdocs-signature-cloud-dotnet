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

namespace GroupDocs.Signature.Cloud.Sdk.Test.Search
{
    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using static GroupDocs.Signature.Cloud.Sdk.Model.OptionsBase;

    public class TestsSearchQRCode : BaseApiTest
    {
        [Test]
        public void SearchQRCodeImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchQRCodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Image;
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignApi.SearchSignatures(request);
            CheckResponse(new List<SearchQRCodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchQRCodePdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchQRCodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Pdf;
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignApi.SearchSignatures(request);
            CheckResponse(new List<SearchQRCodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchQRCodePresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchQRCodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Presentation;
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignApi.SearchSignatures(request);
            CheckResponse(new List<SearchQRCodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchQRCodeSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchQRCodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.Spreadsheet;
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignApi.SearchSignatures(request);
            CheckResponse(new List<SearchQRCodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchQRCodeWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchQRCodeOptions();
            PopulateOptions(options);
            options.DocumentType = DocumentTypeEnum.WordProcessing;
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignApi.SearchSignatures(request);
            CheckResponse(new List<SearchQRCodeOptions>() { options }, response, testFile);
        }

        public static void PopulateOptions(SearchQRCodeOptions options)
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
            options.SignatureType = SignatureTypeEnum.QRCode;
            options.QRCodeType = "Aztec";
            options.Text = "John Smith";
            options.MatchType = SearchQRCodeOptions.MatchTypeEnum.Contains;
        }

        public void CheckResponse(List<SearchQRCodeOptions> searchOptions, SearchResult result, TestFile testFile)
        {
            Assert.NotNull(result, "Result is empty.");
            Assert.AreEqual(result.Size, testFile.Size, "Wrong size.");
            Assert.NotNull(result.FileInfo, "FileInfo is null.");
            Assert.NotNull(String.IsNullOrEmpty(result.FileInfo?.FilePath), "FileInfo FilePath is empty.");
            Assert.AreEqual(testFile.Path, result.FileInfo?.FilePath, "FileInfo FilePath is wrong.");
            Assert.NotNull(result.Signatures, "Signatures null");
            Assert.IsNotEmpty(result.Signatures, "Signatures empty");
            foreach (var option in searchOptions)
            {
                bool exists = false;
                foreach (var signature in result.Signatures)
                {
                    QRCodeSignature QRCodeSignature = signature as QRCodeSignature;

                    if (QRCodeSignature != null &&
                        QRCodeSignature.SignatureType.ToString() == option.SignatureType.ToString() &&
                        QRCodeSignature.QRCodeType == option.QRCodeType &&
                        QRCodeSignature.Text == option.Text)
                    {
                        exists = true;
                        break;
                    }
                }
                Assert.IsTrue(exists, $"Signature type {option.SignatureType} is not found");
            }
        }
    }
}
