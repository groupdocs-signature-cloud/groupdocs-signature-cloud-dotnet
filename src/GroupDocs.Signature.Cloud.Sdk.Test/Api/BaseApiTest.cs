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
using System.IO;
using System.Reflection;
using System.Text;
using GroupDocs.Signature.Cloud.Sdk.Api;
using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using NUnit.Framework;
using Configuration = GroupDocs.Signature.Cloud.Sdk.Client.Configuration;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    public class BaseApiTest
    {
        private readonly string _appSid = Config.AppSid;
        private readonly string _appKey = Config.AppKey;
        private readonly string _apiBaseUrl = Config.ApiBaseUrl;

        protected SignApi SignatureApi;
        protected InfoApi InfoApi;
        protected FileApi FileApi;
        protected FolderApi FolderApi;
        protected StorageApi StorageApi;

        public string DownloadFolder = "Downloaded";

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            var config = new Configuration(_appSid, _appKey)
            {
                ApiBaseUrl = _apiBaseUrl
            };

            SignatureApi = new SignApi(config);
            InfoApi = new InfoApi(config);
            FileApi = new FileApi(config);
            FolderApi = new FolderApi(config);
            StorageApi = new StorageApi(config);

            //Prepare folder for signed files
            DownloadFolder = Path.Combine(GetTestDataPath(), "Downloaded");
            if (Directory.Exists(DownloadFolder))
            {
                ClearFolder(DownloadFolder);
            }
            else
            {
                Directory.CreateDirectory(DownloadFolder);
            }

            UploadTestFiles();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Cleanup();
        }

        private void UploadTestFiles()
        {
            foreach (var testFile in TestFiles.AllFiles)
            {
                var existRequest = new ObjectExistsRequest(testFile.Path);
                var existResponse = StorageApi.ObjectExists(existRequest);
                if (existResponse.Exists == true) continue;
                var request = new UploadFileRequest(testFile.Path, GetTestFileStream(testFile));
                FileApi.UploadFile(request);
            }
        }

        private void Cleanup()
        {
            DeleteFolderFromStorage("signature");
        }

        private void DeleteFolderFromStorage(string folderName)
        {
            var request = new DeleteFolderRequest(folderName, null, true);
            FolderApi.DeleteFolder(request);
        }

        private byte[] GetTestFileBytes(TestFile file)
        {
            var filePath = Path.Combine(GetTestDataPathBin(), file.Path);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found: " + filePath);
            }

            return File.ReadAllBytes(filePath);
        }

        protected Stream GetTestFileStream(TestFile file)
        {
            var bytes = GetTestFileBytes(file);

            return new MemoryStream(bytes);
        }

        // ReSharper disable once UnusedMember.Global
        protected Stream SerializeObject(object obj)
        {
            var options = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            var json = JsonConvert.SerializeObject(obj, options);

            var bytes = Encoding.UTF8.GetBytes(json);

            return new MemoryStream(bytes);
        }

        private static string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath) ?? Directory.GetCurrentDirectory();
            var dir = new DirectoryInfo(workingDir).Parent.Parent;

            var baseDir = Path.Combine(dir.FullName, "TestData");

            return Path.GetFullPath(baseDir);
        }

        private static string GetTestDataPathBin()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath) ?? Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "TestData");

            return Path.GetFullPath(baseDir);
        }

        private static void ClearFolder(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (FileInfo file in folder.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo directory in folder.GetDirectories())
            {
                directory.Delete(true);
            }
        }

        internal void DownloadFile(string path)
        {
            var requestDownload = new DownloadFileRequest { path = path };
            var responseDownload = FileApi.DownloadFile(requestDownload);
            string fileName = Path.GetFileName(path);
            string newFilePath = Path.Combine(DownloadFolder, fileName);
            using (FileStream file = new FileStream(newFilePath, FileMode.Create))
            {
                responseDownload.CopyTo(file);
            }
        }
    }
}