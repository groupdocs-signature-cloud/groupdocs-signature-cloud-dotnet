using System.Linq;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_Barcode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Verification Barcode - Cells
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new CellsVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };
            var request = new PostVerificationBarcodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode - Images
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Images()
        {
            var file = TestFiles.SignedImagesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new ImagesVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };
            var request = new PostVerificationBarcodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode - Pdf
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new PdfVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };
            var request = new PostVerificationBarcodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode - Slides
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Slides()
        {
            var file = TestFiles.SignedSlidesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new SlidesVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };
            var request = new PostVerificationBarcodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode - Words
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new WordsVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                Text = CommonBarCodeText,
                VerifyAllPages = false
            };
            var request = new PostVerificationBarcodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationBarcode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode from Url - Cells
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Cells_URL()
        {
            var verifyOptionsData = new CellsVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostVerificationBarcodeFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode from Url - Images
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Images_URL()
        {
            var verifyOptionsData = new ImagesVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostVerificationBarcodeFromUrlRequest
            {
                Url = TestFiles.ImagesSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode from Url - Pdf
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Pdf_URL()
        {
            var verifyOptionsData = new PdfVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostVerificationBarcodeFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode from Url - Slides
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Slides_URL()
        {
            var verifyOptionsData = new SlidesVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostVerificationBarcodeFromUrlRequest
            {
                Url = TestFiles.SlidesSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationBarcodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Barcode from Url - Words
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest_Words_URL()
        {
            var verifyOptionsData = new WordsVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = CommonBarcodeTypeName,
                MatchType = VerifyBarcodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonBarCodeText
            };

            var request = new PostVerificationBarcodeFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationBarcodeFromUrl(request);
            AssertResponse(response);
        }
    }
}