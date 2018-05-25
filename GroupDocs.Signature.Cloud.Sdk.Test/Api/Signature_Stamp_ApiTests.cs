using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Stamp_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature Stamp - Cells
        /// </summary>
        [Test]
        public void PostSignStampTest_Cells()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();

            var signOptionsData = new CellsSignStampOptionsData
            {
                ImageGuid = CommonImageGuid,
                SheetNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = CellsSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                RowNumber = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostStamp(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp - Images
        /// </summary>
        [Test]
        public void PostSignStampTest_Images()
        {
            var file = TestFiles.ImagesDocs.FirstOrDefault();
            var signOptionsData = new ImagesSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostStamp(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp - PDF
        /// </summary>
        [Test]
        public void PostSignStampTest_Pdf()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();
            var signOptionsData = new PdfSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostStamp(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp - Slides
        /// </summary>
        [Test]
        public void PostSignStampTest_Slides()
        {
            var file = TestFiles.SlidesDocs.FirstOrDefault();
            var signOptionsData = new SlidesSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostStamp(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp - Words
        /// </summary>
        [Test]
        public void PostSignStampTest_Words()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();
            var signOptionsData = new WordsSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostStamp(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp from Url - Cells
        /// </summary>
        [Test]
        public void PostSignStampTest_Cells_URL()
        {
            var signOptionsData = new CellsSignStampOptionsData
            {
                ImageGuid = CommonImageGuid,
                SheetNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = CellsSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                RowNumber = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampFromUrlRequest
            {
                Url = TestFiles.CellsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostStampFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp from Url - Images
        /// </summary>
        [Test]
        public void PostSignStampTest_Images_URL()
        {
            var signOptionsData = new ImagesSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampFromUrlRequest
            {
                Url = TestFiles.ImagesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostStampFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp from Url - PDF
        /// </summary>
        [Test]
        public void PostSignStampTest_Pdf_URL()
        {
            var signOptionsData = new PdfSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampFromUrlRequest
            {
                Url = TestFiles.PdfUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostStampFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp from Url - Slides
        /// </summary>
        [Test]
        public void PostSignStampTest_Slides_URL()
        {
            var signOptionsData = new SlidesSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampFromUrlRequest
            {
                Url = TestFiles.SlidesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostStampFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Stamp from Url - Words
        /// </summary>
        [Test]
        public void PostSignStampTest_Words_URL()
        {
            var signOptionsData = new WordsSignStampOptionsData()
            {
                ImageGuid = CommonImageGuid,
                DocumentPageNumber = 1,
                SignAllPages = false,
                PagesSetup = new PagesSetupData()
                {
                    EvenPages = false,
                    FirstPage = true,
                    LastPage = false,
                    OddPages = false,
                    PageNumbers = new List<int?>() { 1 }
                },
                // Size properties
                Width = 200,
                Height = 150,
                SizeMeasureType = ImagesSignStampOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = ImagesSignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = ImagesSignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                RotationAngle = 45,
                Opacity = 0.9,
                BackgroundColor = new Color(Color.CornflowerBlue.Web),
                BackgroundColorCropType = SignStampOptionsData.BackgroundColorCropTypeEnum.InnerArea,
                BackgroundImageCropType = SignStampOptionsData.BackgroundImageCropTypeEnum.MiddleArea
            };
            signOptionsData.OuterLines = new List<StampLineData>();
            signOptionsData.OuterLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Arial", FontSize = 12, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 5,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.FullTextRepeat,
                     BackgroundColor = new Color(Color.BlueViolet.Web),
                     Height = 20,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.DarkOrange.Web), Style = BorderLineData.StyleEnum.LongDashDot, Transparency = 0.7, Weight = 1.4 },
                     Visible = true
                 });
            signOptionsData.InnerLines = new List<StampLineData>();
            signOptionsData.InnerLines.Add(
                 new StampLineData()
                 {
                     Text = CommonText,
                     Font = new SignatureFontData() { FontFamily = "Times New Roman", FontSize = 20, Bold = true, Italic = true, Underline = true },
                     TextBottomIntent = 3,
                     TextColor = new Color(Color.Gold.Web),
                     TextRepeatType = StampLineData.TextRepeatTypeEnum.None,
                     BackgroundColor = new Color(Color.CornflowerBlue.Web),
                     Height = 30,
                     InnerBorder = new BorderLineData() { Color = new Color(Color.OliveDrab.Web), Style = BorderLineData.StyleEnum.LongDash, Transparency = 0.5, Weight = 1.2 },
                     OuterBorder = new BorderLineData() { Color = new Color(Color.GhostWhite.Web), Style = BorderLineData.StyleEnum.Dot, Transparency = 0.4, Weight = 1.4 },
                     Visible = true
                 });

            var request = new PostStampFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostStampFromUrl(request);
            AssertResponse(response);
        }
    }
}