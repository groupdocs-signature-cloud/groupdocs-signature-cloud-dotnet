// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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

using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api.Storage
{
    public class TestStorageWorkWithFolders : BaseApiTest
    {
        [Test]
        public void StorageGetFilesList()
        {
            // Arrange
            var request = new GetFilesListRequest("Signed");

            // Act & Assert 
            var response = FolderApi.GetFilesList(request);
            Assert.Greater(response.Value.Count, 0);
        }

        [Test]
        public void StorageCopyMoveFolder()
        {
            // Create temp folder
            var cRequest = new CreateFolderRequest("temp");
            FolderApi.CreateFolder(cRequest);

            // Copy folder
            var copyRequest = new CopyFolderRequest("temp", "temp1");
            FolderApi.CopyFolder(copyRequest);

            // Check copied folder
            var eRequest = new ObjectExistsRequest("temp1");
            var eResponse = StorageApi.ObjectExists(eRequest);
            Assert.IsTrue(eResponse.Exists);
            Assert.IsTrue(eResponse.IsFolder);

            // Copy folder
            var moveRequest = new MoveFolderRequest("temp1", "temp2");
            FolderApi.MoveFolder(moveRequest);

            // Check moved folder
            eRequest = new ObjectExistsRequest("temp1");
            eResponse = StorageApi.ObjectExists(eRequest);
            Assert.IsFalse(eResponse.Exists);
            eRequest = new ObjectExistsRequest("temp2");
            eResponse = StorageApi.ObjectExists(eRequest);
            Assert.IsTrue(eResponse.Exists);

            // Delete temp and temp2 folders
            var delRequest = new DeleteFolderRequest("temp", null, true);
            FolderApi.DeleteFolder(delRequest);
            delRequest = new DeleteFolderRequest("temp2", null, true);
            FolderApi.DeleteFolder(delRequest);
        }
    }
}
