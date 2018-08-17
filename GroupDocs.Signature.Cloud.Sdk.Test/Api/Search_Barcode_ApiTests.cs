using System.Collections.Generic;
using System.Linq;
namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Search_Barcode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Search Post Barcode - Cells
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new CellsSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                Text = CommonBarCodeText,
                SearchAllPages = true
            };
            var request = new PostSearchBarcodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode from Url - Cells
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Cells_URL()
        {
            var searchOptionsData = new CellsSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostSearchBarcodeFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Search Post Barcode - Cells Collection
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Cells_Collection()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));

            SearchOptionsCollectionData collection = new SearchOptionsCollectionData();
            collection.Items = new List<SearchOptionsData>();
            var searchOptionsData = new CellsSearchBarcodeOptionsData()
            {
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Exact,
                Text = "12345678",
                DocumentPageNumber = 1,
                SearchAllPages = false
            };

            collection.Items.Add(searchOptionsData);

            searchOptionsData = new CellsSearchBarcodeOptionsData()
            {
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                Text = "1234",
                DocumentPageNumber = 2,
                SearchAllPages = false
            };

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
        /// Test Post Search Barcode - Images
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Images()
        {
            var file = TestFiles.SignedImagesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new ImagesSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };
            var request = new PostSearchBarcodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode - Pdf
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("Signed_BarCode"));
            var searchOptionsData = new PdfSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                //BarcodeTypeName = CommonBarcodeTypeName,
                //MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                //SearchAllPages = true,
                //Text = CommonBarCodeText
            };
            var request = new PostSearchBarcodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode - Slides
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Slides()
        {
            var file = TestFiles.SignedSlidesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new SlidesSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };
            var request = new PostSearchBarcodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode - Words
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new WordsSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                Text = CommonBarCodeText,
                SearchAllPages = false
            };
            var request = new PostSearchBarcodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode from Url - Images
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Images_URL()
        {
            var searchOptionsData = new ImagesSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostSearchBarcodeFromUrlRequest
            {
                Url = TestFiles.ImagesSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode from Url - Pdf
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Pdf_URL()
        {
            var searchOptionsData = new PdfSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostSearchBarcodeFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode from Url - Slides
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Slides_URL()
        {
            var searchOptionsData = new SlidesSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostSearchBarcodeFromUrlRequest
            {
                Url = TestFiles.SlidesSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search Barcode from Url - Words
        /// </summary>
        [Test]
        public void PostSearchBarcodeTest_Words_URL()
        {
            var searchOptionsData = new WordsSearchBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = SearchBarcodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostSearchBarcodeFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchBarcodeFromUrl(request);
            AssertResponse(response);
        }
    }
}