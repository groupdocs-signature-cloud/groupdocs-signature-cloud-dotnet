// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TestFiles.cs">
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

using System.Collections.Generic;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    public static class TestFiles
    {
        public static string CommonPassword = "1234567890";

        //Images
        public static readonly List<TestFile> ImageStorage = new List<TestFile>
        {
            new TestFile(@"Images\01_pages.jpg"){ Extension = "jpg", FileFormat = "JPEG Image", MaxPageHeight = 1000, MaxPageWidth = 1000, PagesCount = 1, Size = 90269},
            new TestFile(@"Images\01_pages.png"){ Extension = "png", FileFormat = "Portable Network Graphic", MaxPageHeight = 1000, MaxPageWidth = 1000, PagesCount = 1, Size = 11011},
        };

        public static readonly List<TestFile> ImageStorageSigned = new List<TestFile>
        {
            new TestFile(@"Signed\SignedForVerificationAll.png"){ Extension = "png", FileFormat = "Portable Network Graphic", Size = 27533},
        };

        //Pdf
        public static readonly List<TestFile> PdfStorage = new List<TestFile>
        {
            new TestFile(@"Pdf\01_pages.pdf"){ Extension = "pdf", FileFormat = "Portable Document Format File", MaxPageHeight = 792, MaxPageWidth = 612, PagesCount = 1, Size = 55321},
            new TestFile(@"Pdf\01_pages_pwd.pdf"){ Extension = "pdf", FileFormat = "Portable Document Format File", MaxPageHeight = 792, MaxPageWidth = 612, PagesCount = 1, Size = 94273, Password = TestFiles.CommonPassword},
            new TestFile(@"Pdf\02_pages.pdf"){ Extension = "pdf", FileFormat = "Portable Document Format File", MaxPageHeight = 841, MaxPageWidth = 595, PagesCount = 2, Size = 396944},
        };

        public static readonly List<TestFile> PdfStorageSigned = new List<TestFile>
        {
            new TestFile(@"Signed\SignedForVerificationAll.pdf"){ Extension = "pdf", FileFormat = "Portable Document Format File", Size = 164060},
        };

        //Presentations
        public static readonly List<TestFile> PresentationStorage = new List<TestFile>
        {
            new TestFile(@"Presentations\01_pages.pptx"){ Extension = "pptx", FileFormat = "PowerPoint Open XML Presentation", MaxPageHeight = 540, MaxPageWidth = 720, PagesCount = 1, Size = 42146},
            new TestFile(@"Presentations\01_pages_pwd.pptx"){ Extension = "pptx", FileFormat = "PowerPoint Open XML Presentation", MaxPageHeight = 540, MaxPageWidth = 720, PagesCount = 1, Size = 38912, Password = TestFiles.CommonPassword},
            new TestFile(@"Presentations\02_pages.pptx"){ Extension = "pptx", FileFormat = "PowerPoint Open XML Presentation", MaxPageHeight = 540, MaxPageWidth = 720, PagesCount = 2, Size = 51673},
        };

        public static readonly List<TestFile> PresentationStorageSigned = new List<TestFile>
        {
            new TestFile(@"Signed\SignedForVerificationAll.pptx"){ Extension = "pptx", FileFormat = "PowerPoint Open XML Presentation", Size = 43205},
        };

        //SpreadSheets
        public static readonly List<TestFile> SpreadsheetStorage = new List<TestFile>
        {
            new TestFile(@"Spreadsheets\01_pages.xlsx"){ Extension = "xlsx", FileFormat = "Microsoft Excel Open XML Spreadsheet", MaxPageHeight = 637, MaxPageWidth = 765, PagesCount = 1, Size = 12260},
            new TestFile(@"Spreadsheets\01_pages_pwd.xlsx"){ Extension = "xlsx", FileFormat = "Microsoft Excel Open XML Spreadsheet", MaxPageHeight = 1424, MaxPageWidth = 1165, PagesCount = 1, Size = 1001472, Password = TestFiles.CommonPassword},
            new TestFile(@"Spreadsheets\02_pages.xlsx"){ Extension = "xlsx", FileFormat = "Microsoft Excel Open XML Spreadsheet", MaxPageHeight = 846, MaxPageWidth = 867, PagesCount = 2, Size = 22396},
        };

        public static readonly List<TestFile> SpreadsheetStorageSigned = new List<TestFile>
        {
            new TestFile(@"Signed\SignedForVerificationAll.xlsx"){ Extension = "xlsx", FileFormat = "Microsoft Excel Open XML Spreadsheet", Size = 318157},
        };

        //WordProcessing
        public static readonly List<TestFile> WordProcessingStorage = new List<TestFile>
        {
            new TestFile(@"WordProcessing\01_pages.docx"){ Extension = "docx", FileFormat = "Microsoft Word Open XML Document", MaxPageHeight = 792, MaxPageWidth = 612, PagesCount = 1, Size = 1359584},
            new TestFile(@"WordProcessing\01_pages_pwd.docx"){ Extension = "docx", FileFormat = "Microsoft Word Open XML Document", MaxPageHeight = 792, MaxPageWidth = 612, PagesCount = 1, Size = 1069568, Password = TestFiles.CommonPassword},
            new TestFile(@"WordProcessing\02_pages.docx"){ Extension = "docx", FileFormat = "Microsoft Word Open XML Document", MaxPageHeight = 792, MaxPageWidth = 612, PagesCount = 2, Size = 1356395},
        };

        public static readonly List<TestFile> WordProcessingStorageSigned = new List<TestFile>
        {
            new TestFile(@"Signed\SignedForVerificationAll.docx"){ Extension = "docx", FileFormat = "Microsoft Word Open XML Document", Size = 1358290},
        };

        //Additional
        public static readonly List<TestFile> AdditionalStorage = new List<TestFile>
        {
            new TestFile(@"Additional\JohnSmithSign.png"),
            new TestFile(@"Additional\SherlockHolmes.pfx"),
            new TestFile(@"Additional\signature_01.jpg"),
            new TestFile(@"Additional\signature_02.jpg"),
            new TestFile(@"Additional\signature_03.jpg")
        };

        public static readonly TestFile NotExist = new TestFile("some-folder\\NotExist.docx");

        private static List<TestFile> _allFiles;

        public static List<TestFile> AllFiles {
            get {
                if (_allFiles == null)
                {
                    _allFiles = new List<TestFile>();
                    _allFiles.AddRange(ImageStorage);
                    _allFiles.AddRange(ImageStorageSigned);
                    _allFiles.AddRange(PdfStorage);
                    _allFiles.AddRange(PdfStorageSigned);
                    _allFiles.AddRange(PresentationStorage);
                    _allFiles.AddRange(PresentationStorageSigned);
                    _allFiles.AddRange(SpreadsheetStorage);
                    _allFiles.AddRange(SpreadsheetStorageSigned);
                    _allFiles.AddRange(WordProcessingStorage);
                    _allFiles.AddRange(WordProcessingStorageSigned);
                    _allFiles.AddRange(AdditionalStorage);
                }
                return _allFiles;
            }
        } 

    }
}
