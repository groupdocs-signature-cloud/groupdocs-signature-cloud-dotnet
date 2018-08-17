using System.Collections.Generic;
using System.Linq;
namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Search_QRCode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Search QRCode - Cells
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new CellsSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                Text = CommonQrCodeText,
                SearchAllPages = true
            };
            var request = new PostSearchQRCodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode from Url - Cells
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Cells_URL()
        {
            var searchOptionsData = new CellsSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostSearchQRCodeFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Search Post QRCode - Cells Collection
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Cells_Collection()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));

            SearchOptionsCollectionData collection = new SearchOptionsCollectionData();
            collection.Items = new List<SearchOptionsData>();
            var searchOptionsData = new CellsSearchQRCodeOptionsData()
            {
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Exact,
                Text = "John Smith",
                DocumentPageNumber = 1,
                SearchAllPages = false
            };

            collection.Items.Add(searchOptionsData);

            searchOptionsData = new CellsSearchQRCodeOptionsData()
            {
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                Text = "John",
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
        /// Test Post Search QRCode - Images
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Images()
        {
            var file = TestFiles.SignedImagesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new ImagesSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostSearchQRCodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode from Url - Images
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Images_URL()
        {
            var searchOptionsData = new ImagesSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostSearchQRCodeFromUrlRequest
            {
                Url = TestFiles.ImagesSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode - Pdf
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new PdfSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostSearchQRCodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode from Url - Pdf
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Pdf_URL()
        {
            var searchOptionsData = new PdfSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostSearchQRCodeFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode - Slides
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Slides()
        {
            var file = TestFiles.SignedSlidesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new SlidesSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostSearchQRCodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode from Url - Slides
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Slides_URL()
        {
            var searchOptionsData = new SlidesSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostSearchQRCodeFromUrlRequest
            {
                Url = TestFiles.SlidesSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode - Words
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var searchOptionsData = new WordsSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                Text = CommonQrCodeText,
                SearchAllPages = false
            };
            var request = new PostSearchQRCodeRequest
            {
                Name = file.FileName,
                SearchOptionsData = searchOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostSearchQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Search QRCode from Url - Words
        /// </summary>
        [Test]
        public void PostSearchQRCodeTest_Words_URL()
        {
            var searchOptionsData = new WordsSearchQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = SearchQRCodeOptionsData.MatchTypeEnum.Contains,
                SearchAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostSearchQRCodeFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                SearchOptionsData = searchOptionsData
            };

            var response = SignatureApi.PostSearchQRCodeFromUrl(request);
            AssertResponse(response);
        }

    }
}