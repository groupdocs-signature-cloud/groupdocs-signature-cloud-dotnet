using System.Linq;
using NUnit.Framework;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;
    using System.Collections.Generic;

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
        /// Test Search Post Digital - Cells Collection
        /// </summary>
        [Test]
        public void PostSearchDigitalTest_Cells_Collection()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));

            SearchOptionsCollectionData collection = new SearchOptionsCollectionData();
            collection.Items = new List<SearchOptionsData>();
            var searchOptionsData = new CellsSearchDigitalOptionsData();

            collection.Items.Add(searchOptionsData);

            searchOptionsData = new CellsSearchDigitalOptionsData();

            collection.Items.Add(searchOptionsData);

            var request = new PostSearchCollectionRequest()
            {
                Name = file.FileName,
                SearchOptionsCollectionData = collection,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchCollection(request);
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