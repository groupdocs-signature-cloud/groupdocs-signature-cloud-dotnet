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

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api.Sign
{
    using static Model.OptionsBase;

    public class TestsSignBarcode : BaseApiTest
    {
        [Test]
        public void SignBarcodeImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\ImageBarcodeSigned.{testFile.Extension}";

            var options = new SignBarcodeOptions();
            PopulateOptions(options);
            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { options };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignBarcodePdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PdfBarcodeSigned.{testFile.Extension}";

            var options = new SignBarcodeOptions();
            PopulateOptions(options);
            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { options };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignBarcodePresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PresentationBarcodeSigned.{testFile.Extension}";

            var options = new SignBarcodeOptions();
            PopulateOptions(options);
            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { options };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignBarcodeSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\SpreadsheetBarcodeSigned.{testFile.Extension}";

            var options = new SignBarcodeOptions();
            PopulateOptions(options);
            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { options };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignBarcodeWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\WordProcessingBarcodeSigned.{testFile.Extension}";

            var options = new SignBarcodeOptions();
            PopulateOptions(options);
            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { options };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        public static void PopulateOptions(SignBarcodeOptions options)
        {
            options.SignatureType = SignatureTypeEnum.Barcode;

            // set signature properties
            options.Text = "123456789012";
            options.BarcodeType = "Code128";
            options.CodeTextAlignment = SignBarcodeOptions.CodeTextAlignmentEnum.None;

            // set signature position on a page
            options.Left = 100;
            options.Top = 100;
            options.Width = 300;
            options.Height = 100;
            options.LocationMeasureType = SignTextOptions.LocationMeasureTypeEnum.Pixels;
            options.SizeMeasureType = SignTextOptions.SizeMeasureTypeEnum.Pixels;
            options.Stretch = SignTextOptions.StretchEnum.None;
            options.RotationAngle = 0;
            options.HorizontalAlignment = SignTextOptions.HorizontalAlignmentEnum.None;
            options.VerticalAlignment = SignTextOptions.VerticalAlignmentEnum.None;
            options.Margin = new Padding() { All = 5 };
            options.MarginMeasureType = SignTextOptions.MarginMeasureTypeEnum.Pixels;

            // set signature appearance
            options.ForeColor = new Color() { Web = "BlueViolet" };
            options.Border = new BorderLine
            {
                Color = new Color() {Web = "DarkOrange"},
                Visible = true,
                Style = BorderLine.StyleEnum.Dash,
                Weight = 12
            };
            options.BackgroundColor = new Color() { Web = "DarkOrange" };
            options.Transparency = 0.8;
            options.InnerMargins = new Padding() { All = 2 };

            //set pages for signing (each of these page settings could be used singly)
            options.AllPages = false;
            options.Page = 1;
            options.PagesSetup = new PagesSetup()
            {
                EvenPages = false,
                FirstPage = true,
                LastPage = false,
                OddPages = false,
                PageNumbers = new List<int?>() { 1 }
            };
        }

        protected void CheckResponse(SignResult result, TestFile testFile)
        {
            Assert.NotNull(result, "Result is empty.");
            Assert.NotNull(result.FileInfo, "FileInfo is null.");
            Assert.NotNull(String.IsNullOrEmpty(result.FileInfo?.FilePath), "FileInfo FilePath is empty.");
            Assert.AreNotEqual(testFile.Path, result.FileInfo?.FilePath, "FileInfo FilePath is wrong.");
        }
    }
}
