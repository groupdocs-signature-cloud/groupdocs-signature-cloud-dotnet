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

using System.Linq;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Info
{
    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;

    public class TestSignatureGetFileInfo : BaseApiTest
    {
        [Test]
        public void GetDocumentInfo()
        {
            // Set request
            var testFile = TestFiles.PdfStorage.FirstOrDefault(x => x.Name.Equals("01_pages.pdf"));
            var fileInfo = testFile.GetFileInfo();
            var InfoSettings = new InfoSettings() { FileInfo = fileInfo };
            var request = new GetInfoRequest(InfoSettings);

            // Get and check result 
            var response = InfoApi.GetInfo(request);

            Assert.AreEqual(response.Size, testFile.Size, "Size");
            Assert.AreEqual(response.Extension, testFile.Extension, "Extension");
            Assert.AreEqual(response.FileFormat, testFile.FileFormat, "FileFormat");
            Assert.AreEqual(response.MaxPageHeight, testFile.MaxPageHeight, "MaxPageHeight");
            Assert.AreEqual(response.WidthForMaxHeight, testFile.MaxPageWidth, "MaxPageWidth");
            Assert.AreEqual(response.PagesCount, testFile.PagesCount, "PagesCount");
            Assert.AreEqual(response.FileInfo.FilePath, testFile.Path, "Path");
        }
    }
}
