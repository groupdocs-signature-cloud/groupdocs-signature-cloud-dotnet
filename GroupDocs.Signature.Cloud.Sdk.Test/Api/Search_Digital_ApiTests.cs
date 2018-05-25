using System.Linq;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Search_Digital_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Search Digital - Cells
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new CellsSearchDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                SearchAllPages = true
            };
            var request = new PostSearchDigitalRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Digital - Pdf
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new PdfSearchDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                SearchAllPages = true
            };
            var request = new PostSearchDigitalRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Digital - Words
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new WordsSearchDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                SearchAllPages = true
            };
            var request = new PostSearchDigitalRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchDigital(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Digital from Url - Cells
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Cells_URL()
        {
            var searchOptionsData = new CellsSearchDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                SearchAllPages = true
            };

            var request = new PostSearchDigitalFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchDigitalFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Digital from Url - Pdf
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Pdf_URL()
        {
            var searchOptionsData = new PdfSearchDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                SearchAllPages = true
            };

            var request = new PostSearchDigitalFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchDigitalFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Digital from Url - Words
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Words_URL()
        {
            var searchOptionsData = new WordsSearchDigitalOptionsData()
            {
                DocumentPageNumber = 1,
                SearchAllPages = true
            };

            var request = new PostSearchDigitalFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchDigitalFromUrl(request);
            AssertResponse(response);
        }
    }
}