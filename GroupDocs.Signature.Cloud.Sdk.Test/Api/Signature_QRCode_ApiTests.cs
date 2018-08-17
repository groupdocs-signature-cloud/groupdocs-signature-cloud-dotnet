using System.Collections.Generic;
using System.Linq;
namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_QRCode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Post Signature QRCode - Cells
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Cells()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault();
            var signOptionsData = new CellsSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = CellsSignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = CellsSignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode from Url - Cells
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Cells_URL()
        {
            var signOptionsData = new CellsSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = CellsSignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = CellsSignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = CellsSignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeFromUrlRequest
            {
                Url = TestFiles.CellsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Sign Post QRCode - Cells Collection
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Cells_Collection()
        {
            var file = TestFiles.CellsDocs.FirstOrDefault(p => p.FileName.Contains("02_pages"));

            SignOptionsCollectionData collection = new SignOptionsCollectionData();
            collection.Items = new List<SignOptionsData>();
            var signOptionsData = new CellsSignQRCodeOptionsData()
            {
                QRCodeTypeName = CommonQrCodeTypeName,
                Text = "12345678",
                SheetNumber = 1,
                SignAllPages = false
            };

            collection.Items.Add(signOptionsData);

            signOptionsData = new CellsSignQRCodeOptionsData()
            {
                QRCodeTypeName = CommonQrCodeTypeName,
                Text = "1234",
                SheetNumber = 2,
                SignAllPages = false
            };

            collection.Items.Add(signOptionsData);

            var request = new PostCollectionRequest()
            {
                Name = file.FileName,
                SignOptionsCollectionData = collection,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostCollection(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode - Images
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Images()
        {
            var file = TestFiles.ImagesDocs.FirstOrDefault();
            var signOptionsData = new ImagesSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode from Url - Images
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Images_URL()
        {
            var signOptionsData = new ImagesSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeFromUrlRequest
            {
                Url = TestFiles.ImagesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostQRCodeFromUrl(request);
            AssertResponse(response);
        }
        
        /// <summary>
        /// Test Post Signature QRCode - PDF
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Pdf()
        {
            var file = TestFiles.PdfDocs.FirstOrDefault();
            var signOptionsData = new PdfSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode from Url - PDF
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Pdf_URL()
        {
            var signOptionsData = new PdfSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeFromUrlRequest
            {
                Url = TestFiles.PdfUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode - Slides
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Slides()
        {
            var file = TestFiles.SlidesDocs.FirstOrDefault();
            var signOptionsData = new SlidesSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode from Url - Slides
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Slides_URL()
        {
            var signOptionsData = new SlidesSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeFromUrlRequest
            {
                Url = TestFiles.SlidesUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostQRCodeFromUrl(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode - Words
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Words()
        {
            var file = TestFiles.WordsDocs.FirstOrDefault();
            var signOptionsData = new WordsSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeRequest
            {
                Name = file.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostQRCode(request);
            AssertResponse(response);
        }

        /// <summary>
        /// Test Post Signature QRCode from Url - Words
        /// </summary>
        [Test]
        public void PostSignQRCodeTest_Words_URL()
        {
            var signOptionsData = new WordsSignQRCodeOptionsData()
            {
                Text = CommonQrCodeText,
                QRCodeTypeName = CommonQrCodeTypeName,
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
                SizeMeasureType = SignQRCodeOptionsData.SizeMeasureTypeEnum.Pixels,
                // Location properties
                Top = 2,
                Left = 2,
                LocationMeasureType = SignQRCodeOptionsData.LocationMeasureTypeEnum.Pixels,
                // Alignment properties
                HorizontalAlignment = SignQRCodeOptionsData.HorizontalAlignmentEnum.Left,
                VerticalAlignment = SignQRCodeOptionsData.VerticalAlignmentEnum.Center,
                Margin = new PaddingData { All = 5 },
                MarginMeasureType = SignQRCodeOptionsData.MarginMeasureTypeEnum.Pixels,
                //Appearance properties
                BackgroundColor = new Color(Color.BlueViolet.Web),
                BorderColor = new Color(Color.DarkOrange.Web),
                ForeColor = new Color(Color.DarkOrange.Web),
                Font = new SignatureFontData(),
                BorderVisiblity = true,
                BorderDashStyle = SignQRCodeOptionsData.BorderDashStyleEnum.Dash,
                BorderWeight = 12,
                RotationAngle = 45,
                Stretch = SignTextOptionsData.StretchEnum.None,
                Opacity = 0.8,
                CodeTextAlignment = SignQRCodeOptionsData.CodeTextAlignmentEnum.None,
                InnerMargins = new PaddingData { All = 2 }
            };

            var request = new PostQRCodeFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                SignOptionsData = signOptionsData
            };

            var response = SignatureApi.PostQRCodeFromUrl(request);
            AssertResponse(response);
        }
    }
}