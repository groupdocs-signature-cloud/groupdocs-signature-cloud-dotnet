using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Internal;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class BaseApiTest
    {
        protected const string FromUrlFolder = "tests\\from_url";
        protected const string FromContentFolder = "tests\\from_content";

        private readonly string _appSid = ConfigurationManager.AppSettings["AppSID"];
        private readonly string _appKey = ConfigurationManager.AppSettings["AppKey"];
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        public const string CommonText = "John Smith";
        public const string CommonBarcodeTypeName = "Code39Standard";
        public const string CommonBarCodeText = "123456789012";
        public const string CommonQrCodeTypeName = "Aztec";
        public const string CommonQrCodeText = "John Smith";
        public const string CommonPassword = "1234567890";
        public const string CommonImageGuid = @"images\JohnSmithSign.png";
        public const string CommonCertificateGuid = @"certificates\SherlockHolmes.pfx";
        public const string UriFileServer = @"http://localhost:52579/";
        public const string CellsDigitalComments = @"CellsDigitalComment";
        public static DateTime CellsDigitalSignDateTimeFrom = DateTime.MinValue;
        public static DateTime CellsDigitalSignDateTimeTo = DateTime.MaxValue;
        public const string PdfDigitalContact = @"PdfDigitalContact";
        public const string PdfDigitalLocation = @"PdfDigitalLocation";
        public const string PdfDigitalReason = @"PdfDigitalReason";

        protected SignatureApi SignatureApi;
        protected StorageApi StorageApi;

        [SetUp]
        public void BeforeEachTest()
        {
            var signaturConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            SignatureApi = new SignatureApi(signaturConfig);

            var storageConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            StorageApi = new StorageApi(storageConfig);
        }

        [TearDown]
        public void AfterEachTest()
        {
            RemoveTempFiles();
        }

        private void RemoveTempFiles()
        {
            //if (Directory.Exists(Path.Combine(GetTestDataPath(), "cache")))
            //    Directory.Delete(Path.Combine(GetTestDataPath(), "cache"), true);

            //if (Directory.Exists(Path.Combine(GetTestDataPath(), "tests")))
            //    Directory.Delete(Path.Combine(GetTestDataPath(), "tests"), true);

            //StorageApi.DeleteFolder("cache");
            //StorageApi.DeleteFolder("tests");
        }

        private byte[] GetTestFileBytes(TestFile file)
        {
            var filePath = Path.Combine(GetTestDataPath(), file.Folder, file.FileName);
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

        protected Stream SerializeObject(object obj)
        {
            var json = SerializationHelper.Serialize(obj);
            var bytes = Encoding.UTF8.GetBytes(json);

            return new MemoryStream(bytes);
        }

        private string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath);
            if (workingDir == null)
                workingDir = Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "..\\..\\..\\..\\..", "TestData");

            return Path.GetFullPath(baseDir);
        }

        protected void AssertResponse(SignatureDocumentResponse response)
        {
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
            if(response.Code.HasValue)
            {
                bool ready = (response.Code.GetValueOrDefault(DocumentResponse.CodeEnum.InternalServerError) == DocumentResponse.CodeEnum.OK);
                if(!ready)
                {
                    ready = (((int)response.Code.GetValueOrDefault(DocumentResponse.CodeEnum.InternalServerError)) == 200);
                }
                Assert.IsTrue(ready);
            }
            Assert.IsTrue(response.Status.Contains("OK"));
            //Assert.IsTrue(string.IsNullOrEmpty(response.Folder));
        }
        protected void AssertResponse(VerifiedDocumentResponse response)
        {
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
            if(response.Code.HasValue)
            {
                bool ready = (response.Code.GetValueOrDefault(DocumentResponse.CodeEnum.InternalServerError) == DocumentResponse.CodeEnum.OK);
                if(!ready)
                {
                    ready = (((int)response.Code.GetValueOrDefault(DocumentResponse.CodeEnum.InternalServerError)) == 200);
                }
                Assert.IsTrue(ready);
            }
            Assert.IsTrue(response.Status.Contains("OK"));
            Assert.IsTrue(response.Result.GetValueOrDefault());
        }

        protected void AssertResponse(SearchDocumentResponse response)
        {
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
            bool ready = (response.Code.GetValueOrDefault(DocumentResponse.CodeEnum.InternalServerError) == DocumentResponse.CodeEnum.OK);
            if (!ready)
            {
                ready = (((int)response.Code.GetValueOrDefault(DocumentResponse.CodeEnum.InternalServerError)) == 200);
            }
            Assert.IsTrue(ready);
            Assert.IsTrue(response.Status.Contains("OK"));
            Assert.IsTrue(response.Signatures.Count > 0);
        }
    }
}