using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Text_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Signature Post Text
        /// </summary>
        [Test]
        public void PostTextTest()
        {
            var file = TestFiles.Pdf02;
            var signOptionsData = new PdfSignTextOptionsData()
            {
                BackgroundColor = new Color(){ Web = "#fcfcfc" },
                BorderColor = new Color(){ Web = "#364E6F"},
                DocumentPageNumber = 1,
                Font = new SignatureFontData() {  Bold = true, FontFamily = "Arial", FontSize = 12, Italic = true, Underline = false},
                ForeColor = new Color(){ Web = "#364E6F"},
                Height = 80,
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() {  Left = 10, Right = 10, Bottom = 10, Top = 10},
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                Text = "1234567890",
                Top = 100,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Width = 100                
            };
            var request = new PostTextRequest
            {
                Name = TestFiles.Pdf02.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = TestFiles.Pdf02.Folder
            };

            var response = SignatureApi.PostText(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }

        /// <summary>
        /// Test Signature Post Text from Url
        /// </summary>
        [Test]
        public void PostTextUrlTest()
        {
            var signOptionsData = new WordsSignTextOptionsData()
            {
                BackgroundColor = new Color() { Web = "#fcfcfc" },
                BorderColor = new Color() { Web = "#364E6F" },
                DocumentPageNumber = 1,
                Font = new SignatureFontData() { Bold = true, FontFamily = "Arial", FontSize = 12, Italic = true, Underline = false },
                ForeColor = new Color() { Web = "#364E6F" },
                Height = 80,
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                SignAllPages = false,
                Text = "1234567890",
                Top = 100,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostTextFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostTextFromUrl(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}