using System.Linq;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_Digital_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Verification Digital - Cells
        /// </summary>
        [Test]
        public void PostVerifyDigitalTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new CellsVerifyDigitalOptionsData()
            {
                Password = CommonPassword,
                CertificateGuid = CommonCertificateGuid
            };
            var request = new PostVerificationDigitalRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Digital - Pdf
        /// </summary>
        [Test]
        public void PostVerifyDigitalTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new PdfVerifyDigitalOptionsData()
            {
                Password = CommonPassword,
                CertificateGuid = CommonCertificateGuid
            };
            var request = new PostVerificationDigitalRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Digital - Words
        /// </summary>
        [Test]
        public void PostVerifyDigitalTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new WordsVerifyDigitalOptionsData()
            {
                Password = CommonPassword,
                CertificateGuid = CommonCertificateGuid
            };
            var request = new PostVerificationDigitalRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Digital from Url - Cells
        /// </summary>
        [Test]
        public void PostVerifyDigitalTest_Cells_URL()
        {
            var verifyOptionsData = new CellsVerifyDigitalOptionsData()
            {
                Password = CommonPassword,
                CertificateGuid = CommonCertificateGuid
            };

            var request = new PostVerificationDigitalFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationDigitalFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Digital from Url - Pdf
        /// </summary>
        [Test]
        public void PostVerifyDigitalTest_Pdf_URL()
        {
            var verifyOptionsData = new PdfVerifyDigitalOptionsData()
            {
                Password = CommonPassword,
                CertificateGuid = CommonCertificateGuid
            };

            var request = new PostVerificationDigitalFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationDigitalFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Digital from Url - Words
        /// </summary>
        [Test]
        public void PostVerifyDigitalTest_Words_URL()
        {
            var verifyOptionsData = new WordsVerifyDigitalOptionsData()
            {
                Password = CommonPassword,
                CertificateGuid = CommonCertificateGuid
            };

            var request = new PostVerificationDigitalFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationDigitalFromUrl(request);
            AssertResponse(response);
        }
    }
}