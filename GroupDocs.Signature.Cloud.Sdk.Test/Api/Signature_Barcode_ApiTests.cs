using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Barcode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Signature Post Barcode
        /// </summary>
        [Test]
        public void PostBarcodeTest()
        {
            var file = TestFiles.Pdf02;
            var signOptionsData = new PdfSignBarcodeOptionsData()
            {
                BarcodeTypeName = "Code128",
                BackgroundColor = new Color() { Web = "#fcfcfc" },
                BorderColor = new Color() { Web = "#364E6F" },
                DocumentPageNumber = 1,
                Font = new SignatureFontData() { Bold = true, FontFamily = "Arial", FontSize = 12, Italic = true, Underline = false },
                ForeColor = new Color() { Web = "#364E6F" },
                Height = 80,
                HorizontalAlignment = SignBarcodeOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignBarcodeOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignBarcodeOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                Text = "1234567890",
                Top = 100,
                VerticalAlignment = SignBarcodeOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostBarcodeRequest
            {
                Name = TestFiles.Pdf02.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = TestFiles.Pdf02.Folder
            };

            var response = SignatureApi.PostBarcode(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}