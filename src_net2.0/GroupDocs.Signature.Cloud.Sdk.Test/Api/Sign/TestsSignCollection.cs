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

namespace GroupDocs.Signature.Cloud.Sdk.Test.Sign
{
    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using static GroupDocs.Signature.Cloud.Sdk.Model.OptionsBase;

    public class TestsSignCollection : BaseApiTest
    {
        [Test]
        public void SignCollectionImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\ImageCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new SignBarcodeOptions();
            TestsSignBarcode.PopulateOptions(optionsBarcode);
            optionsBarcode.DocumentType = DocumentTypeEnum.Image;
            optionsBarcode.Top = 0;

            var optionsQRCode = new SignQRCodeOptions();
            TestsSignQRCode.PopulateOptions(optionsQRCode);
            optionsQRCode.DocumentType = DocumentTypeEnum.Image;
            optionsQRCode.Top = optionsBarcode.Height + 20;

            //Digital signature is not supported for Images.

            var optionsText = new SignTextOptions();
            TestsSignText.PopulateOptions(optionsText);
            optionsText.DocumentType = DocumentTypeEnum.Image;
            optionsText.Top = optionsQRCode.Top + optionsQRCode.Height + 20;

            var optionsImage = new SignImageOptions();
            TestsSignImage.PopulateOptions(optionsImage);
            optionsImage.DocumentType = DocumentTypeEnum.Image;
            optionsImage.Top = optionsText.Top + optionsText.Height + 20;

            var optionsStamp = new SignStampOptions();
            TestsSignStamp.PopulateOptions(optionsStamp);
            optionsStamp.DocumentType = DocumentTypeEnum.Image;
            optionsStamp.Top = optionsImage.Top + optionsImage.Height + 20;

            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { optionsBarcode, optionsQRCode, optionsText, optionsImage, optionsStamp };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);

        }

        [Test]
        public void SignCollectionPdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PdfCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new SignBarcodeOptions();
            TestsSignBarcode.PopulateOptions(optionsBarcode);
            optionsBarcode.DocumentType = DocumentTypeEnum.Pdf;
            optionsBarcode.Top = 0;

            var optionsQRCode = new SignQRCodeOptions();
            TestsSignQRCode.PopulateOptions(optionsQRCode);
            optionsQRCode.DocumentType = DocumentTypeEnum.Pdf;
            optionsQRCode.Top = optionsBarcode.Height + 20;

            var optionsDigital = new SignDigitalOptions();
            TestsSignDigital.PopulateOptions(optionsDigital);
            optionsDigital.DocumentType = DocumentTypeEnum.Pdf;
            optionsDigital.Top = optionsQRCode.Top + optionsQRCode.Height + 20;

            var optionsText = new SignTextOptions();
            TestsSignText.PopulateOptions(optionsText);
            optionsText.DocumentType = DocumentTypeEnum.Pdf;
            optionsText.Top = optionsDigital.Top + optionsDigital.Height + 20;

            var optionsImage = new SignImageOptions();
            TestsSignImage.PopulateOptions(optionsImage);
            optionsImage.DocumentType = DocumentTypeEnum.Pdf;
            optionsImage.Top = optionsText.Top + optionsText.Height + 20;

            var optionsStamp = new SignStampOptions();
            TestsSignStamp.PopulateOptions(optionsStamp);
            optionsStamp.DocumentType = DocumentTypeEnum.Pdf;
            optionsStamp.Top = optionsImage.Top + optionsImage.Height + 20;

            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { optionsBarcode, optionsQRCode, optionsDigital, optionsText, optionsImage, optionsStamp };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignCollectionPresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PresentationCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new SignBarcodeOptions();
            TestsSignBarcode.PopulateOptions(optionsBarcode);
            optionsBarcode.DocumentType = DocumentTypeEnum.Presentation;
            optionsBarcode.Top = 0;

            var optionsQRCode = new SignQRCodeOptions();
            TestsSignQRCode.PopulateOptions(optionsQRCode);
            optionsQRCode.DocumentType = DocumentTypeEnum.Presentation;
            optionsQRCode.Top = optionsBarcode.Height + 20;

            //Digital signature is not supported for Presentations.

            var optionsText = new SignTextOptions();
            TestsSignText.PopulateOptions(optionsText);
            optionsText.DocumentType = DocumentTypeEnum.Presentation;
            optionsText.Top = optionsQRCode.Top + optionsQRCode.Height + 20;

            var optionsImage = new SignImageOptions();
            TestsSignImage.PopulateOptions(optionsImage);
            optionsImage.DocumentType = DocumentTypeEnum.Presentation;
            optionsImage.Top = optionsText.Top + optionsText.Height + 20;

            var optionsStamp = new SignStampOptions();
            TestsSignStamp.PopulateOptions(optionsStamp);
            optionsStamp.DocumentType = DocumentTypeEnum.Presentation;
            optionsStamp.Top = optionsImage.Top + optionsImage.Height + 20;

            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { optionsBarcode, optionsQRCode, optionsText, optionsImage, optionsStamp };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignCollectionSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\SpreadsheetCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new SignBarcodeOptions();
            TestsSignBarcode.PopulateOptions(optionsBarcode);
            optionsBarcode.DocumentType = DocumentTypeEnum.Spreadsheet;
            optionsBarcode.Top = 0;

            var optionsQRCode = new SignQRCodeOptions();
            TestsSignQRCode.PopulateOptions(optionsQRCode);
            optionsQRCode.DocumentType = DocumentTypeEnum.Spreadsheet;
            optionsQRCode.Top = optionsBarcode.Height + 20;

            var optionsDigital = new SignDigitalOptions();
            TestsSignDigital.PopulateOptions(optionsDigital);
            optionsDigital.DocumentType = DocumentTypeEnum.Spreadsheet;
            optionsDigital.Top = optionsQRCode.Top + optionsQRCode.Height + 20;

            var optionsText = new SignTextOptions();
            TestsSignText.PopulateOptions(optionsText);
            optionsText.DocumentType = DocumentTypeEnum.Spreadsheet;
            optionsText.Top = optionsDigital.Top + optionsDigital.Height + 20;

            var optionsImage = new SignImageOptions();
            TestsSignImage.PopulateOptions(optionsImage);
            optionsImage.DocumentType = DocumentTypeEnum.Spreadsheet;
            optionsImage.Top = optionsText.Top + optionsText.Height + 20;

            var optionsStamp = new SignStampOptions();
            TestsSignStamp.PopulateOptions(optionsStamp);
            optionsStamp.DocumentType = DocumentTypeEnum.Spreadsheet;
            optionsStamp.Top = optionsImage.Top + optionsImage.Height + 20;

            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { optionsBarcode, optionsQRCode, optionsDigital, optionsText, optionsImage, optionsStamp };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
        }

        [Test]
        public void SignCollectionWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\WordProcessingStorageCollectionSigned.{testFile.Extension}";

            var optionsBarcode = new SignBarcodeOptions();
            TestsSignBarcode.PopulateOptions(optionsBarcode);
            optionsBarcode.DocumentType = DocumentTypeEnum.WordProcessing;
            optionsBarcode.Top = 0;

            var optionsQRCode = new SignQRCodeOptions();
            TestsSignQRCode.PopulateOptions(optionsQRCode);
            optionsQRCode.DocumentType = DocumentTypeEnum.WordProcessing;
            optionsQRCode.Top = optionsBarcode.Height + 20;

            var optionsDigital = new SignDigitalOptions();
            TestsSignDigital.PopulateOptions(optionsDigital);
            optionsDigital.DocumentType = DocumentTypeEnum.WordProcessing;
            optionsDigital.Top = optionsQRCode.Top + optionsQRCode.Height + 20;

            var optionsText = new SignTextOptions();
            TestsSignText.PopulateOptions(optionsText);
            optionsText.DocumentType = DocumentTypeEnum.WordProcessing;
            optionsText.Top = optionsDigital.Top + optionsDigital.Height + 20;

            var optionsImage = new SignImageOptions();
            TestsSignImage.PopulateOptions(optionsImage);
            optionsImage.DocumentType = DocumentTypeEnum.WordProcessing;
            optionsImage.Top = optionsText.Top + optionsText.Height + 20;

            var optionsStamp = new SignStampOptions();
            TestsSignStamp.PopulateOptions(optionsStamp);
            optionsStamp.DocumentType = DocumentTypeEnum.WordProcessing;
            optionsStamp.Top = optionsImage.Top + optionsImage.Height + 20;

            var signSettings = new SignSettings();
            signSettings.FileInfo = fileInfo;
            signSettings.SaveOptions = new SaveOptions() { OutputFilePath = signedFileName };
            signSettings.Options = new List<SignOptions>() { optionsBarcode, optionsQRCode, optionsDigital, optionsText, optionsImage, optionsStamp };
            var request = new CreateSignaturesRequest(signSettings);

            // Get and check result 
            var response = SignatureApi.CreateSignatures(request);
            CheckResponse(response, testFile);

            //Download the signed file
            this.DownloadFile(signedFileName);
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
