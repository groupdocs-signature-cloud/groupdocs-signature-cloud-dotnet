﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Signature.Cloud.Sdk.Model;
using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api.Search
{
    using static Model.OptionsBase;

    public class TestsSearchBarcode : BaseApiTest
    {
        [Test]
        public void SearchBarcodeImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchBarcodeOptions();
            PopulateOptions(options);
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignatureApi.SearchSignatures(request);
            CheckResponse(new List<SearchBarcodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchBarcodePdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchBarcodeOptions();
            PopulateOptions(options);
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignatureApi.SearchSignatures(request);
            CheckResponse(new List<SearchBarcodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchBarcodePresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchBarcodeOptions();
            PopulateOptions(options);
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignatureApi.SearchSignatures(request);
            CheckResponse(new List<SearchBarcodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchBarcodeSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchBarcodeOptions();
            PopulateOptions(options);
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignatureApi.SearchSignatures(request);
            CheckResponse(new List<SearchBarcodeOptions>() { options }, response, testFile);
        }

        [Test]
        public void SearchBarcodeWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorageSigned.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var options = new SearchBarcodeOptions();
            PopulateOptions(options);
            var searchSettings = new SearchSettings();
            searchSettings.FileInfo = fileInfo;
            searchSettings.Options = new List<SearchOptions>() { options };
            var request = new SearchSignaturesRequest(searchSettings);

            // Get and check result 
            var response = SignatureApi.SearchSignatures(request);
            CheckResponse(new List<SearchBarcodeOptions>() { options }, response, testFile);
        }

        public static void PopulateOptions(SearchBarcodeOptions options)
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
            options.BarcodeType = "Code39";
            options.Text = "123456789012";
            options.MatchType = SearchBarcodeOptions.MatchTypeEnum.Contains;
        }

        protected void CheckResponse(List<SearchBarcodeOptions> searchOptions, SearchResult result, TestFile testFile)
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
                    BarcodeSignature barcodeSignature = signature as BarcodeSignature;

                    if (barcodeSignature != null &&
                        barcodeSignature.SignatureType.ToString() == option.SignatureType.ToString() &&
                        barcodeSignature.BarcodeType == option.BarcodeType &&
                        barcodeSignature.Text == option.Text)
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
