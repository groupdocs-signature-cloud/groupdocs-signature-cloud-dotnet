using System.Linq;
namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Collection_BaseApiTests : BaseApiTest
    {

        public void PostQrCodeTest()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault(p => p.FileName.Contains("02"));
            var signOptionsData = new PdfSignQRCodeOptionsData()
            {
                QRCodeTypeName = QRCodeCollection.QR,
                BackgroundColor = new Color() { Web = "#fcfcfc" },
                BorderColor = new Color() { Web = "#364E6F" },
                DocumentPageNumber = 1,
                Font = new SignatureFontData() { Bold = true, FontFamily = "Arial", FontSize = 12, Italic = true, Underline = false },
                ForeColor = new Color() { Web = "#364E6F" },
                Height = 80,
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                Text = "1234567890",
                Top = 100,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostQRCodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostQRCode(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }

        /// <summary>
        /// Test Signature Post QRCode from Url
        /// </summary>
        [Test]
        public void PostQrCodeTestUrl()
        {
            var signOptionsData = new WordsSignQRCodeOptionsData()
            {
                QRCodeTypeName = QRCodeCollection.QR,
                BackgroundColor = new Color() { Web = "#fcfcfc" },
                BorderColor = new Color() { Web = "#364E6F" },
                DocumentPageNumber = 1,
                Font = new SignatureFontData() { Bold = true, FontFamily = "Arial", FontSize = 12, Italic = true, Underline = false },
                ForeColor = new Color() { Web = "#364E6F" },
                Height = 80,
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                Text = "1234567890",
                Top = 100,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };

            var request = new PostQRCodeFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostQRCodeFromUrl(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}