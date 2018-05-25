using System.Collections.Generic;
using System.Linq;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Text_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature Text - Cells
        /// </summary>
        [Test]
        public void PostSignTextTest_Cells()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();
            var signOptionsData = new CellsSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = CellsSignTextOptionsData.SignatureImplementationEnum.TextStamp,
                DocumentPageNumber = 1,
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
                Height = 100,
                SizeMeasureType = CellsSignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                RowNumber = 2,
                Left = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = CellsSignTextOptionsData.BorderDashStyleEnum.Dash,
                BorderTransparency = 0.55,
                BorderWeight = 12,
                BackgroundTransparency = 0.8,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None
            };

            var request = new PostTextRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text - Images
        /// </summary>
        [Test]
        public void PostSignTextTest_Images()
        {
            var file = TestFiles.ImagesDocs.FirstOrDefault();
            var signOptionsData = new ImagesSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = ImagesSignTextOptionsData.SignatureImplementationEnum.TextAsImage,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                RotationAngle = 45,
                Opacity = 0.9,
                Stretch = SignTextOptionsData.StretchEnum.None,
                BorderDashStyle = ImagesSignTextOptionsData.BorderDashStyleEnum.Solid,
                BorderTransparency = 0,
                BorderWeight = 1,
                BackgroundTransparency = 0
            };

            var request = new PostTextRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text - PDF
        /// </summary>
        [Test]
        public void PostSignTextTest_Pdf()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();
            var signOptionsData = new PdfSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = PdfSignTextOptionsData.SignatureImplementationEnum.Stamp,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                SignatureID = 12,
                FormTextFieldTitle = CommonText,
                FormTextFieldType = PdfSignTextOptionsData.FormTextFieldTypeEnum.PlainText
            };

            var request = new PostTextRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text - Slides
        /// </summary>
        [Test]
        public void PostSignTextTest_Slides()
        {
            var file = TestFiles.SlidesDocs.FirstOrDefault();
            var signOptionsData = new SlidesSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = SlidesSignTextOptionsData.SignatureImplementationEnum.TextStamp,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderTransparency = 0.55,
                BorderWeight = 12,
                BackgroundTransparency = 0.8,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
            };

            var request = new PostTextRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text - Words
        /// </summary>
        [Test]
        public void PostSignTextTest_Words()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();
            var signOptionsData = new WordsSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = WordsSignTextOptionsData.SignatureImplementationEnum.TextStamp,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderDashStyle = WordsSignTextOptionsData.BorderDashStyleEnum.Dot,
                BorderTransparency = 0.55,
                BorderWeight = 12,
                BackgroundTransparency = 0.8,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
            };

            var request = new PostTextRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostText(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text from Url - Cells
        /// </summary>
        [Test]
        public void PostSignTextTest_Cells_URL()
        {
            var signOptionsData = new CellsSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = CellsSignTextOptionsData.SignatureImplementationEnum.TextStamp,
                DocumentPageNumber = 1,
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
                Height = 100,
                SizeMeasureType = CellsSignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                RowNumber = 2,
                Left = 2,
                ColumnNumber = 2,
                LocationMeasureType = CellsSignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = CellsSignTextOptionsData.BorderDashStyleEnum.Dash,
                BorderTransparency = 0.55,
                BorderWeight = 12,
                BackgroundTransparency = 0.8,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None
            };

            var request = new PostTextFromUrlRequest
            {
                Url = TestFiles.CellsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostTextFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text from Url - Images
        /// </summary>
        [Test]
        public void PostSignTextTest_Images_URL()
        {
            var signOptionsData = new ImagesSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = ImagesSignTextOptionsData.SignatureImplementationEnum.TextAsImage,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                RotationAngle = 45,
                Opacity = 0.9,
                Stretch = SignTextOptionsData.StretchEnum.None,
                BorderDashStyle = ImagesSignTextOptionsData.BorderDashStyleEnum.Solid,
                BorderTransparency = 0,
                BorderWeight = 1,
                BackgroundTransparency = 0
            };

            var request = new PostTextFromUrlRequest
            {
                Url = TestFiles.ImagesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostTextFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text from Url - PDF
        /// </summary>
        [Test]
        public void PostSignTextTest_Pdf_URL()
        {
            var signOptionsData = new PdfSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = PdfSignTextOptionsData.SignatureImplementationEnum.Stamp,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                SignatureID = 12,
                FormTextFieldTitle = CommonText,
                FormTextFieldType = PdfSignTextOptionsData.FormTextFieldTypeEnum.PlainText
            };

            var request = new PostTextFromUrlRequest
            {
                Url = TestFiles.PdfUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostTextFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text from Url - Slides
        /// </summary>
        [Test]
        public void PostSignTextTest_Slides_URL()
        {
            var signOptionsData = new SlidesSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = SlidesSignTextOptionsData.SignatureImplementationEnum.TextStamp,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderTransparency = 0.55,
                BorderWeight = 12,
                BackgroundTransparency = 0.8,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
            };

            var request = new PostTextFromUrlRequest
            {
                Url = TestFiles.SlidesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostTextFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature Text from Url - Words
        /// </summary>
        [Test]
        public void PostSignTextTest_Words_URL()
        {
            var signOptionsData = new WordsSignTextOptionsData()
            {
                Text = CommonText,
                SignatureImplementation = WordsSignTextOptionsData.SignatureImplementationEnum.TextStamp,
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
                Height = 100,
                SizeMeasureType = SignTextOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignTextOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignTextOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignTextOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignTextOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderDashStyle = WordsSignTextOptionsData.BorderDashStyleEnum.Dot,
                BorderTransparency = 0.55,
                BorderWeight = 12,
                BackgroundTransparency = 0.8,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
            };

            var request = new PostTextFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostTextFromUrl(request);
            AssertResponse(response);
        }
    }
}