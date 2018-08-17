using System.Collections.Generic;
using System.Linq;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_QRCode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Verification QRCode - Cells
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new CellsVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostVerificationQRCodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationQRCode(request);

            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode from Url - Cells
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Cells_URL()
        {
            var verifyOptionsData = new CellsVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostVerificationQRCodeFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Verify Post QRCode - Cells Collection
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Cells_Collection()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));

            VerifyOptionsCollectionData collection = new VerifyOptionsCollectionData();
            collection.Items = new List<VerifyOptionsData>();
            var verifyOptionsData = new CellsVerifyQRCodeOptionsData()
            {
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Exact,
                Text = "John Smith",
                DocumentPageNumber = 1,
                VerifyAllPages = false
            };

            collection.Items.Add(verifyOptionsData);

            verifyOptionsData = new CellsVerifyQRCodeOptionsData()
            {
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                Text = "John",
                DocumentPageNumber = 2,
                VerifyAllPages = false
            };

            collection.Items.Add(verifyOptionsData);

            var request = new PostVerificationCollectionRequest()
            {
                Name = file.FileName,
                VerifyOptionsCollectionData = collection,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationCollection(request);
            AssertResponse(response);
        }
        
        /// <summary>
        /// Test Post Verification QRCode - Images
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Images()
        {
            var file = TestFiles.SignedImagesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new ImagesVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostVerificationQRCodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode from Url - Images
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Images_URL()
        {
            var verifyOptionsData = new ImagesVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostVerificationQRCodeFromUrlRequest
            {
                Url = TestFiles.ImagesSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode - Pdf
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new PdfVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostVerificationQRCodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode from Url - Pdf
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Pdf_URL()
        {
            var verifyOptionsData = new PdfVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostVerificationQRCodeFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode - Slides
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Slides()
        {
            var file = TestFiles.SignedSlidesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new SlidesVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostVerificationQRCodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode from Url - Slides
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Slides_URL()
        {
            var verifyOptionsData = new SlidesVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostVerificationQRCodeFromUrlRequest
            {
                Url = TestFiles.SlidesSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode - Words
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new WordsVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };
            var request = new PostVerificationQRCodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification QRCode from Url - Words
        /// </summary>
        [Test]
        public void PostVerifyQRCodeTest_Words_URL()
        {
            var verifyOptionsData = new WordsVerifyQRCodeOptionsData()
            {
                DocumentPageNumber = 1,
                QRCodeTypeName = CommonQrCodeTypeName,
                MatchType = VerifyQRCodeOptionsData.MatchTypeEnum.Contains,
                VerifyAllPages = true,
                Text = CommonQrCodeText
            };

            var request = new PostVerificationQRCodeFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationQRCodeFromUrl(request);
            AssertResponse(response);
        }

    }
}