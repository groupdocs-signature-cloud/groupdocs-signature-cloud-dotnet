// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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

    public class TestsSignStamp : BaseApiTest
    {
        [Test]
        public void SignStampImage()
        {
            // Set request
            var testFile = TestFiles.ImageStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\ImageStampSigned.{testFile.Extension}";

            var options = new SignStampOptions();
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
        public void SignStampPdf()
        {
            // Set request
            var testFile = TestFiles.PdfStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PdfStampSigned.{testFile.Extension}";

            var options = new SignStampOptions();
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
        public void SignStampPresentation()
        {
            // Set request
            var testFile = TestFiles.PresentationStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\PresentationStampSigned.{testFile.Extension}";

            var options = new SignStampOptions();
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
        public void SignStampSpreadsheet()
        {
            // Set request
            var testFile = TestFiles.SpreadsheetStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\SpreadsheetStampSigned.{testFile.Extension}";

            var options = new SignStampOptions();
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
        public void SignStampWordProcessing()
        {
            // Set request
            var testFile = TestFiles.WordProcessingStorage.FirstOrDefault();
            var fileInfo = testFile.GetFileInfo();
            var signedFileName = $@"Output\WordProcessingStampSigned.{testFile.Extension}";

            var options = new SignStampOptions();
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

        public static void PopulateOptions(SignStampOptions options)
        {
            options.SignatureType = SignatureTypeEnum.Stamp;

            // set signature properties
            options.ImageFilePath = @"Additional\JohnSmithSign.png";

            // set signature position on a page
            options.Left = 100;
            options.Top = 100;
            options.Width = 300;
            options.Height = 200;
            options.LocationMeasureType = SignImageOptions.LocationMeasureTypeEnum.Pixels;
            options.SizeMeasureType = SignImageOptions.SizeMeasureTypeEnum.Pixels;
            options.RotationAngle = 0;
            options.HorizontalAlignment = SignImageOptions.HorizontalAlignmentEnum.None;
            options.VerticalAlignment = SignImageOptions.VerticalAlignmentEnum.None;
            options.Margin = new Padding() { All = 5 };
            options.MarginMeasureType = SignImageOptions.MarginMeasureTypeEnum.Pixels;

            // set signature appearance
            options.BackgroundColor = new Color() { Web = "CornflowerBlue" };
            options.BackgroundColorCropType = SignStampOptions.BackgroundColorCropTypeEnum.InnerArea;
            options.BackgroundImageCropType = SignStampOptions.BackgroundImageCropTypeEnum.MiddleArea;
            options.Transparency = 0.8;

            options.OuterLines = new List<StampLine> {
                 new StampLine()
                 {
                     Text = "John Smith",
                     Font = new SignatureFont() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color() { Web = "Gold" },
                     TextRepeatType = StampLine.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color() { Web = "BlueViolet" },
                     Height = 20,
                     InnerBorder = new BorderLine() { Color = new Color() { Web = "DarkOrange" }, Style = BorderLine.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLine() { Color = new Color() { Web = "DarkOrange" }, Style = BorderLine.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 }
            };

            options.InnerLines = new List<StampLine> {
                 new StampLine()
                 {
                     Text = "John Smith",
                     Font = new SignatureFont() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color() { Web = "Gold" },
                     TextRepeatType = StampLine.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color() { Web = "CornflowerBlue" },
                     Height = 30,
                     InnerBorder = new BorderLine() { Color = new Color() { Web = "OliveDrab" }, Style = BorderLine.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLine() { Color = new Color() { Web = "GhostWhite" }, Style = BorderLine.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 }
            };

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
