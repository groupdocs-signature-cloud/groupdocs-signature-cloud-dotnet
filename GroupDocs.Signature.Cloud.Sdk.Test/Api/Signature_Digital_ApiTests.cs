using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Digital_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Signature Post Digital
        /// </summary>
        [Test]
        public void PostDigitalTest()
        {
            var file = TestFiles.Pdf02;
            var signOptionsData = new PdfSignDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                Height = 80,
                HorizontalAlignment = SignDigitalOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignDigitalOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignDigitalOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                CertificateGuid = "certificates/test03_rsa_sha1_1024.pfx",
                ImageGuid = "images/signature_01.jpg",
                Top = 100,
                VerticalAlignment = SignDigitalOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostDigitalRequest
            {
                Name = TestFiles.Pdf02.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = TestFiles.Pdf02.Folder,
                CertificateFile = "certificates/test03_rsa_sha1_1024.pfx",
                ImageFile = "images/signature_01.jpg"
            };

            //var response = SignatureApi.PostDigital(request);
            //Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}