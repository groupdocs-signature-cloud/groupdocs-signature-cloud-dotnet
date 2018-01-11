using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Image_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Signature Post Image
        /// </summary>
        [Test]
        public void PostImageTest()
        {
            var file = TestFiles.Pdf02;
            var signOptionsData = new PdfSignImageOptionsData()
            {   
                DocumentPageNumber = 1,
                Height = 80,
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                ImageGuid = "images/signature_01.jpg",
                Top = 100,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostImageRequest
            {
                Name = TestFiles.Pdf02.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = TestFiles.Pdf02.Folder,
                Image = "storage/01_pages.png"
            };

            var response = SignatureApi.PostImage(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }

        /// <summary>
        /// Test Signature Post Image from Url
        /// </summary>
        [Test]
        public void PostImageUrlTest()
        {
            var signOptionsData = new WordsSignImageOptionsData()
            {
                DocumentPageNumber = 1,
                Height = 80,
                HorizontalAlignment = SignImageOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignImageOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignImageOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                ImageGuid = "storage/01_pages.png",
                Top = 100,
                VerticalAlignment = SignImageOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostImageFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostImageFromUrl(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }


}