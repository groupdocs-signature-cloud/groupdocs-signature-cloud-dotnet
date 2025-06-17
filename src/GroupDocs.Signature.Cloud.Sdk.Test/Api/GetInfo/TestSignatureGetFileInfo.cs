// --------------------------------------------------------------------------------------------------------------------
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

using System.Linq;
using GroupDocs.Signature.Cloud.Sdk.Client;
using GroupDocs.Signature.Cloud.Sdk.Model;
using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api.GetInfo
{
    public class TestSignatureGetFileInfo : BaseApiTest
    {
        [Test]
        public void GetDocumentInfo()
        {
            // Set request
            var testFile = TestFiles.PdfStorage.FirstOrDefault(x => x.Name.Equals("01_pages.pdf"));
            var fileInfo = testFile.GetFileInfo();
            var infoSettings = new InfoSettings() { FileInfo = fileInfo };
            var request = new GetInfoRequest(infoSettings);

            // Get and check result 
            var response = InfoApi.GetInfo(request);

            Assert.AreEqual(testFile.Size, response.Size, "Size");
            Assert.AreEqual(testFile.Extension, response.Extension, "Extension");
            Assert.AreEqual(testFile.FileFormat, response.FileFormat, "FileFormat");
            Assert.AreEqual(testFile.MaxPageHeight, response.MaxPageHeight, "MaxPageHeight");
            Assert.AreEqual(testFile.MaxPageWidth, response.WidthForMaxHeight, "MaxPageWidth");
            Assert.AreEqual(testFile.PagesCount, response.PagesCount, "PagesCount");
            Assert.AreEqual(testFile.Path, response.FileInfo.FilePath, "Path");
        }

        [Test]
        public void TestGetInfoReturnsFileNotFound()
        {
            // Arrange
            var infoSettings = new InfoSettings { FileInfo = TestFiles.NotExist.GetFileInfo() };
            var request = new GetInfoRequest(infoSettings);

            // Act & Assert
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });
            Assert.AreEqual("Can't find file located at 'some-folder\\NotExist.docx'.", ex.Message);
        }
    }
}
