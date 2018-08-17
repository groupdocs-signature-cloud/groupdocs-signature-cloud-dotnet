using System.Collections.Generic;
using System.Linq;


namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_Text_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Verification Text - Cells
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Cells()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new CellsVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };
            var request = new PostVerificationTextRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Text from Url - Cells
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Cells_URL()
        {
            var verifyOptionsData = new CellsVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };

            var request = new PostVerificationTextFromUrlRequest
            {
                Url = TestFiles.CellsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationTextFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Verify Post Text - Cells Collection
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Cells_Collection()
        {
            var file = TestFiles.SignedCellsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));

            VerifyOptionsCollectionData collection = new VerifyOptionsCollectionData();
            collection.Items = new List<VerifyOptionsData>();
            var verifyOptionsData = new CellsVerifyTextOptionsData()
            {
                Text = "John Smith",
                DocumentPageNumber = 1,
                VerifyAllPages = false
            };

            collection.Items.Add(verifyOptionsData);

            verifyOptionsData = new CellsVerifyTextOptionsData()
            {
                Text = "John Smith",
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
        /// Test Post Verification Text - Pdf
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Pdf()
        {
            var file = TestFiles.SignedPdfDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new PdfVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                SignatureImplementation = PdfVerifyTextOptionsData.SignatureImplementationEnum.Stamp,
                Text = CommonText
            };
            var request = new PostVerificationTextRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Text from Url - Pdf
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Pdf_URL()
        {
            var verifyOptionsData = new PdfVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };

            var request = new PostVerificationTextFromUrlRequest
            {
                Url = TestFiles.PdfSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationTextFromUrl(request);
            AssertResponse(response);
        }
        
        /// <summary>
        /// Test Post Verification Text - Slides
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Slides()
        {
            var file = TestFiles.SignedSlidesDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new SlidesVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };
            var request = new PostVerificationTextRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Text from Url - Slides
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Slides_URL()
        {
            var verifyOptionsData = new SlidesVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };

            var request = new PostVerificationTextFromUrlRequest
            {
                Url = TestFiles.SlidesSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationTextFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Text - Words
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Words()
        {
            var file = TestFiles.SignedWordsDocs.FirstOrDefault(p => p.FileName.Contains("SignedForVerificationAll"));
            var verifyOptionsData = new WordsVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };
            var request = new PostVerificationTextRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Verification Text from Url - Words
        /// </summary>
        [Test]
        public void PostVerifyTextTest_Words_URL()
        {
            var verifyOptionsData = new WordsVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                VerifyAllPages = true,
                Text = CommonText
            };

            var request = new PostVerificationTextFromUrlRequest
            {
                Url = TestFiles.WordsSignedAllUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationTextFromUrl(request);
            AssertResponse(response);
        }
    }
}