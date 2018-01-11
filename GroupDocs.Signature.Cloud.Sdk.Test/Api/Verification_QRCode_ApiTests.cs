using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_QRCode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Verification Post QRCode
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest()
        {
            var file = TestFiles.SignedTextStamp_Pdf01;
            var verifyOptionsData = new PdfVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = "QR",
                Text = "12345678",
                VerifyAllPages = false
            };
            var request = new PostVerificationQRCodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationQRCode(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }

        /// <summary>
        /// Test Signature Post QRCode from Url
        /// </summary>
        [Test]
        public void PostVerifyQRCodeUrlTest()
        {
            var verifyOptionsData = new WordsVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = "QR",
                VerifyAllPages = false,
                Text = "12345678"
            };
            var request = new PostVerificationQRCodeFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationQRCodeFromUrl(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}