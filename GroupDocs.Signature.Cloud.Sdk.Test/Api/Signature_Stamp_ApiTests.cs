
using System.Collections.Generic;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using GroupDocs.Signature.Cloud.Sdk.Api;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Stamp_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Signature Post Stamp
        /// </summary>
        [Test]
        public void PostStampTest()
        {
            var file = TestFiles.Pdf02;
            var signOptionsData = new PdfSignStampOptionsData()
            {
                BackgroundColor = new Color() { Web = "#fcfcfc" },
                BackgroundColorCropType = PdfSignStampOptionsData.BackgroundColorCropTypeEnum.MiddleArea,
                BackgroundImageCropType = PdfSignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea,
                DocumentPageNumber = 1,
                Height = 80,
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                Top = 100,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            //
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     BackgroundColor = new Color("#0f0f0f"),
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     Height = 10,
                     InnerBorder = new BorderLineData() { Color = new Color("#000000"), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color("#f0f0f0"), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Text = "1234567890",
                     TextBottomIntent = 2,
                     TextColor = new Color("#FF0C0C"),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat
                 });
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     BackgroundColor = new Color("#FF0C0C"),
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 14, Bold = true, Italic = true, Underline = true },
                     Height = 12,
                     InnerBorder = new BorderLineData() { Color = new Color("#FF0C0C"), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color("#FF0C0C"), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Text = "12121212",
                     TextBottomIntent = 3,
                     TextColor = new Color("#FF0C0C"),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            var request = new PostStampRequest
            {
                Name = TestFiles.Pdf02.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = TestFiles.Pdf02.Folder
            };

            //var response = SignatureApi.PostStamp(request);
            //Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}