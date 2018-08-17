using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using GroupDocs.Signature.Cloud.Sdk.Api;
using NUnit.Framework;
using Configuration = GroupDocs.Signature.Cloud.Sdk.Api.Configuration;

namespace GroupDocs.Signature.Cloud.Sdk.Test
{
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;
    [SetUpFixture]
    public class TestsSetup
    {
        private readonly string _appSid = ConfigurationManager.AppSettings["AppSID"];
        private readonly string _appKey = ConfigurationManager.AppSettings["AppKey"];
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        private readonly StorageApi _storageApi;

        public TestsSetup()
        {
            var storageConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            _storageApi = new StorageApi(storageConfig);
        }

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            var path = GetTestDataPath();
            TestFiles.Initialize(path);
            UploadTestFiles(path);
        }

        private void UploadTestFiles(string path)
        {
            var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = _storageApi.IsExist(relativeDirPath);
                if (!response.FileExist.IsExist)
                    _storageApi.CreateFolder(relativeDirPath);
            }

            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = _storageApi.IsExist(relativeFilePath);
                if (!response.FileExist.IsExist)
                {
                    var fileName = Path.GetFileName(file);
                    var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
                    var bytes = File.ReadAllBytes(file);

                    _storageApi.CreateFile(fileName, relativeDirPath, bytes);
                }
            }
        }

        private string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath);
            if (workingDir == null)
                workingDir = Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "Resources", "TestData");

            return Path.GetFullPath(baseDir);
        }
    }
}